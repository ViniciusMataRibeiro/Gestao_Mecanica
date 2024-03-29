﻿using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.Components
{
    public partial class FormPesquisa : MetroFramework.Forms.MetroForm
    {
        public bool gravou = false;
        public FormPesquisa()
        {
            InitializeComponent();
        }

        public List<ProdutoDto> ListaProdutos { get; set; }

        public Produto_Servico Servico;
        public int QtdProduto = 0;
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Servico.IdProduto = (int)cbProduto.SelectedValue;
            Servico.QtdPecas = (int)ndpQuantidade.Value;
            Servico.ValorProduto = npdValorUn.Value;
            Servico.ValorTotal = npdTotal.Value;
            Servico.NomeProduto = ListaProdutos.Where(w=> w.Id == Servico.IdProduto).FirstOrDefault().Nome;

            if (!vereficar()) return;
            gravou = true;
            Close();
        }

        private bool vereficar()
        {
            var Verific = true;
            var QtdEstoque = ListaProdutos.Where(w => w.Id == (int)cbProduto.SelectedValue).FirstOrDefault().Quantidade;

            if (cbProduto.SelectedValue == null)
            {
                errorProvider1.SetError(cbProduto, "Campo obrigatório!");
                Verific = false;
            }
            if (ndpQuantidade.Value == 0)
            {
                errorProvider1.SetError(ndpQuantidade, "Campo obrigatório!");
                Verific = false;
            }
            else if ((float)ndpQuantidade.Value > QtdEstoque)
            {
                errorProvider1.SetError(ndpQuantidade, $"Quantidade informada maior que a quantidade em estoque!\nQuantidade restante: {QtdEstoque} Unidades.");
                Verific = false;
            }
            else
            {
                foreach (var item in ListaProdutos)
                {
                    if (item.Id == (int)cbProduto.SelectedValue)
                    {
                        item.Quantidade = item.Quantidade - QtdProduto;
                    }
                }
            }

            return Verific;
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            carregarCombo();

            if (Servico == null)
            {
                Servico = new Produto_Servico();
                this.Text = "Inclusao";
            }
            else
            {
                this.Text = "Alteração";

                cbProduto.SelectedIndex = Servico.IdProduto;
                ndpQuantidade.Value = Servico.QtdPecas;
                npdValorUn.Value = Servico.ValorProduto;
                npdTotal.Value = Servico.ValorTotal;
            }
        }

        private void carregarCombo()
        {
            cbProduto.ValueMember = "Id";
            cbProduto.DisplayMember = "Nome";
            cbProduto.DataSource = ListaProdutos;
        }

        private void ndpQuantidade_ValueChanged(object sender, EventArgs e)
        {
            npdTotal.Value = npdValorUn.Value * ndpQuantidade.Value;
            QtdProduto = (int)ndpQuantidade.Value;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var IdProduto = (int)cbProduto.SelectedValue;
            var Result = ListaProdutos.Where(w=> w.Id == IdProduto).ToList();
            npdValorUn.Value = Convert.ToDecimal(Result[0].ValorUn);
        }
    }
}

﻿using DataBase;
using ProjetoMTA.Base;
using ProjetoMTA.Components;
using ProjetoMTA.UI.Veiculo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.UI.Cliente
{
    public partial class FormClienteConsulta : FormBaseConsulta
    {

        ClienteDto clientedto;
        VeiculoDto veiculoDto;
        public FormClienteConsulta()
        {
            InitializeComponent();
            InitGridBaseConsulta<ClienteDto>(Grid);
            InitGridBaseConsulta<VeiculoDto>(GridVeiculo);
        }

        private  void FormClienteConsulta_Load(object sender, EventArgs e)
        {
            CarregarGridCliente();
        }

        private void CarregarGridCliente()
        {
            try
            {
                clientedto = new ClienteDto();
                var Result = clientedto.GetAll(GetConnectionString());
                if (Result != null)
                {
                    Grid.DataSource = Result;
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
            }
            
        }
        private void CarregarGridVeiculo()
        {
            try
            {
                veiculoDto = new VeiculoDto();
                var Result = veiculoDto.GetAll(GetConnectionString());
                if (Result != null)
                {
                    GridVeiculo.DataSource = Result;
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
            }
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            if (btOpcao.Text == "   Veiculos")
            {
                AdicionarDado();
            }
            else
            {
                AdicionarDadoVeiculo(0);
            }
        }


        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btOpcao.Text == "   Veiculos")
                {
                    var obj = (ClienteDto)Grid.CurrentRow?.DataBoundItem;
                    if (obj == null) return;

                    FormClienteCadastro frm = new FormClienteCadastro("Alterar", obj);
                    frm.ShowDialog();
                    if (frm.ErroAoGravar) CarregarGridCliente();
                    else
                    {
                        bindingSource.ResetBindings(false);
                    }
                    frm.Dispose();
                }
                else
                {
                    var obj = (VeiculoDto)GridVeiculo.CurrentRow?.DataBoundItem;
                    if (obj == null) return;

                    FormVeiculocadastro frm = new FormVeiculocadastro("Alterar", obj);
                    frm.ShowDialog();
                    if (frm.ErroAoGravar) CarregarGridVeiculo();
                    else
                    {
                        bindingSourceVeiculo.ResetBindings(false);
                    }
                    frm.Dispose();
                }
            }
            catch (Exception x)
            {
                DisplayMessage(x.Message, "Operação cancelada", OFIcon.Warning);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (btOpcao.Text == "   Veiculos")
            {
                var obj = (ClienteDto)Grid.CurrentRow?.DataBoundItem;
                if (obj == null) return;

                clientedto = new ClienteDto();

                try
                {
                    if (OficinaMessageBox.Show("Deseja realmente remover este Cliente?", "Delete", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                        return;
                    var deletou = clientedto.Delete(obj.Id, GetConnectionString());
                    if (deletou)
                    {
                        bindingSource.Remove(obj);
                        DisplayMessage("Cliente removido com sucesso", "Dado deletado");
                    }
                    else
                    {
                        throw new Exception("Não foi possível deletar equipamento");
                    }
                }
                catch (Exception x)
                {
                    DisplayMessage(x.Message, "Problema ao deletar registro", OFIcon.Warning);
                }
                finally
                {
                    CarregarGridCliente();
                }

            }
            else
            {
                var obj = (VeiculoDto)GridVeiculo.CurrentRow?.DataBoundItem;
                if (obj == null) return;

                veiculoDto = new VeiculoDto();

                try
                {
                    if (OficinaMessageBox.Show("Deseja realmente remover este Veiculo?", "Delete", OFButtons.YesNo, OFIcon.Question) == DialogResult.No)
                        return;
                    var deletou = veiculoDto.Delete(obj.Id, GetConnectionString());
                    if (deletou)
                    {
                        bindingSourceVeiculo.Remove(obj);
                        DisplayMessage("Veiculo removido com sucesso", "Dado deletado");
                    }
                    else
                    {
                        throw new Exception("Não foi possível deletar o Veiculo");
                    }
                }
                catch (Exception x)
                {
                    DisplayMessage(x.Message, "Problema ao deletar registro", OFIcon.Warning);
                }
                finally
                {
                    CarregarGridVeiculo();
                }
            }
        }

        private void AdicionarDado()
        {
            FormClienteCadastro frm = new FormClienteCadastro("incluir", new ClienteDto());
            frm.ShowDialog();
            if (frm.Gravou)
            {
                bindingSource.Add(frm.Dto);
                if (frm.CriarNovo) AdicionarDado();
                else bindingSource.ResetBindings(false);
                if (OficinaMessageBox.Show($"Deseja Cadastrar um veiculo ao cliente?", "Incluir", OFButtons.YesNo, OFIcon.Question) == DialogResult.Yes)
                    AdicionarDadoVeiculo(frm.Dto.Id);
            }
            frm.Dispose();
            CarregarGridCliente();
            
        }
        private void AdicionarDadoVeiculo(int id)
        {
            FormVeiculocadastro frm = new FormVeiculocadastro("incluir", new VeiculoDto());
            frm.IdCliente = id;
            frm.ShowDialog();
            if (frm.Gravou)
            {
                bindingSourceVeiculo.Add(frm.Dto);
                if (frm.CriarNovo) AdicionarDado();
                else bindingSourceVeiculo.ResetBindings(false);
            }
            frm.Dispose();
            CarregarGridVeiculo();
        }

        private void btOpcao_Click(object sender, EventArgs e)
        {
            if (btOpcao.Text == "   Veiculos")
            {
                btOpcao.Text = "   Clientes";
                btOpcao.Image = Properties.Resources.Pessoa_32;
                Grid.Visible = false;
                GridVeiculo.Visible = true;

                CarregarGridVeiculo();
            }
            else if (btOpcao.Text == "   Clientes")
            {
                btOpcao.Text = "   Veiculos";
                btOpcao.Image = Properties.Resources.Carro_32;
                Grid.Visible = true;
                GridVeiculo.Visible = false;
                CarregarGridCliente();
            }
            
        }
    }
}

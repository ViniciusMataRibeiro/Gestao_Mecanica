using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMTA.Components
{
    public partial class OficinaMessageBox : Form
    {
        private const string Abort = "Anular";
        private const string Retry = "Repetir";
        private const string Ignore = "Ignorar";
        private const string Cancel = "Cancelar";
        private const string Yes = "Sim";
        private const string No = "Não";
        private const string Ok = "Ok";

        private static Color Background = Color.FromArgb(51, 51, 51);
        private static Color Footer = Color.FromArgb(64, 64, 64);
        private static Color Text = Color.White;


        private const int CS_DROPSHADOW = 0x00020000;
        private static OficinaMessageBox _msgBox;
        private Panel _plHeader = new Panel();
        private Panel _plFooter = new Panel();
        private Panel _plIcon = new Panel();
        private PictureBox _picIcon = new PictureBox();
        private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();
        private Label _lblTitle;
        private Label _lblMessage;
        private List<Button> _buttonCollection = new List<Button>();
        private static DialogResult _buttonResult = new DialogResult();
        private static Timer _timer;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        private OficinaMessageBox()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //this.BackColor = System.Drawing.Color.Teal;
            this.KeyDown += MsgBox_KeyDown;
            this.BackColor = Background;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new Padding(3);
            this.Width = 400;

            _lblTitle = new Label()
            {
                ForeColor = Text,
                Font = new Font("Segoe UI", 18),
                Dock = DockStyle.Top,
                Height = 50
            };

            _lblMessage = new Label()
            {
                ForeColor = Text,
                Font = new Font("Segoe UI", 10),
                Dock = DockStyle.Fill
            };

            _flpButtons.FlowDirection = FlowDirection.RightToLeft;
            _flpButtons.Dock = DockStyle.Fill;

            _plHeader.Dock = DockStyle.Fill;
            _plHeader.Padding = new Padding(20);
            _plHeader.Controls.Add(_lblMessage);
            _plHeader.Controls.Add(_lblTitle);

            _plFooter.Dock = DockStyle.Bottom;
            _plFooter.Padding = new Padding(20);
            //_plFooter.BackColor = System.Drawing.Color.LightSeaGreen;
            _plFooter.BackColor = Footer;

            _plFooter.Height = 80;
            _plFooter.Controls.Add(_flpButtons);

            _picIcon.Width = 32;
            _picIcon.Height = 32;
            _picIcon.Location = new Point(30, 50);

            _plIcon.Dock = DockStyle.Left;
            _plIcon.Padding = new Padding(20);
            _plIcon.Width = 70;
            _plIcon.Controls.Add(_picIcon);

            this.KeyPreview = true;

            this.Controls.Add(_plHeader);
            this.Controls.Add(_plIcon);
            this.Controls.Add(_plFooter);
        }

        public static void Show(string message)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            OficinaMessageBox.InitIcon(OFIcon.Application);
            OficinaMessageBox.InitButtons(OFButtons.OK);
            _msgBox.Size = OficinaMessageBox.MessageSize(message, "");
            _msgBox.ShowDialog();
            MessageBeep(0);
        }

        public static void Show(string message, string title)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            OficinaMessageBox.InitIcon(OFIcon.Application);
            OficinaMessageBox.InitButtons(OFButtons.OK);
            _msgBox.Size = OficinaMessageBox.MessageSize(message, title);
            _msgBox.ShowDialog();
            MessageBeep(0);
        }

        public static void Show(string message, string title, OFIcon icon)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            OficinaMessageBox.InitIcon(icon);
            OficinaMessageBox.InitButtons(OFButtons.OK);
            _msgBox.Size = OficinaMessageBox.MessageSize(message, title);
            _msgBox.ShowDialog();
            MessageBeep(0);
        }

        public static DialogResult Show(string message, string title, OFButtons buttons)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox._plIcon.Hide();

            OficinaMessageBox.InitButtons(buttons);
            OficinaMessageBox.InitIcon(OFIcon.Application);

            _timer = new Timer();
            Size formSize = OficinaMessageBox.MessageSize(message, title);
            _msgBox.Size = formSize;
            _msgBox.Opacity = 0;
            _timer.Interval = 20;
            _timer.Tag = new OfAnimateMsgBox(formSize, OFAnimateStyle.FadeIn);
            _timer.Tick += Timer_Tick;
            _timer.Start();

            //_msgBox.Size = GAMessageBox.MessageSize(message, title);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        public static DialogResult Show(string message, string title, OFButtons buttons, OFIcon icon)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;

            OficinaMessageBox.InitButtons(buttons);
            OficinaMessageBox.InitIcon(icon);

            _timer = new Timer();
            Size formSize = OficinaMessageBox.MessageSize(message, title);
            _msgBox.Size = formSize;
            _msgBox.Opacity = 0;
            _timer.Interval = 20;
            _timer.Tag = new OfAnimateMsgBox(formSize, OFAnimateStyle.FadeIn);
            _timer.Tick += Timer_Tick;
            _timer.Start();

            //_msgBox.Size = GAMessageBox.MessageSize(message, title);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        public static DialogResult Show(string message, string title, OFButtons buttons, OFIcon icon, OFAnimateStyle style)
        {
            _msgBox = new OficinaMessageBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Height = 0;

            OficinaMessageBox.InitButtons(buttons);
            OficinaMessageBox.InitIcon(icon);

            _timer = new Timer();
            Size formSize = OficinaMessageBox.MessageSize(message, title);

            switch (style)
            {
                case OFAnimateStyle.SlideDown:
                    _msgBox.Size = new Size(formSize.Width, 0);
                    _timer.Interval = 1;
                    _timer.Tag = new OfAnimateMsgBox(formSize, style);
                    break;

                case OFAnimateStyle.FadeIn:
                    _msgBox.Size = formSize;
                    _msgBox.Opacity = 0;
                    _timer.Interval = 20;
                    _timer.Tag = new OfAnimateMsgBox(formSize, style);
                    break;

                case OFAnimateStyle.ZoomIn:
                    _msgBox.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                    _timer.Tag = new OfAnimateMsgBox(formSize, style);
                    _timer.Interval = 1;
                    break;
            }

            _timer.Tick += Timer_Tick;
            _timer.Start();

            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            OfAnimateMsgBox animate = (OfAnimateMsgBox)timer.Tag;

            switch (animate.Style)
            {
                case OFAnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case OFAnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case OFAnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width)
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }
                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }
                    break;
            }
        }

        private static void InitButtons(OFButtons buttons)
        {
            switch (buttons)
            {
                case OFButtons.AbortRetryIgnore:
                    _msgBox.InitAbortRetryIgnoreButtons();
                    break;

                case OFButtons.OK:
                    _msgBox.InitOKButton();
                    break;

                case OFButtons.OKCancel:
                    _msgBox.InitOKCancelButtons();
                    break;

                case OFButtons.RetryCancel:
                    _msgBox.InitRetryCancelButtons();
                    break;

                case OFButtons.YesNo:
                    _msgBox.InitYesNoButtons();
                    break;

                case OFButtons.YesNoCancel:
                    _msgBox.InitYesNoCancelButtons();
                    break;
            }

            foreach (Button btn in _msgBox._buttonCollection)
            {
                btn.ForeColor = Text;
                btn.Font = new System.Drawing.Font("Segoe UI", 8);
                btn.Padding = new Padding(3);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Height = 30;
                btn.FlatAppearance.BorderColor = Text;
                btn.GotFocus += OnGotFocus;
                btn.LostFocus += OnLostFocus;

                _msgBox._flpButtons.Controls.Add(btn);
            }
        }

        private static void OnLostFocus(object sender, EventArgs eventArgs)
        {
            var obj = sender as Button;
            obj.Padding = new Padding(3);
            obj.Font = new System.Drawing.Font("Segoe UI", 8, FontStyle.Regular);
        }

        private static void OnGotFocus(object sender, EventArgs eventArgs)
        {
            var obj = sender as Button;
            obj.Padding = new Padding(0);
            obj.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void InitAbortRetryIgnoreButtons()
        {
            Button btnAbort = new Button()
            {
                Text = Abort
            };
            btnAbort.Click += ButtonClick;

            Button btnRetry = new Button()
            {
                Text = Retry
            };
            btnRetry.Click += ButtonClick;

            Button btnIgnore = new Button()
            {
                Text = Ignore
            };
            btnIgnore.Click += ButtonClick;

            this._buttonCollection.Add(btnIgnore);
            this._buttonCollection.Add(btnRetry);
            this._buttonCollection.Add(btnAbort);
        }

        private void InitOKButton()
        {
            Button btnOK = new Button()
            {
                Text = Ok
            };
            btnOK.Click += ButtonClick;

            this._buttonCollection.Add(btnOK);
        }

        private void InitOKCancelButtons()
        {
            Button btnOK = new Button()
            {
                Text = Ok
            };
            btnOK.Click += ButtonClick;

            Button btnCancel = new Button()
            {
                Text = Cancel
            };
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnCancel);
            this._buttonCollection.Add(btnOK);

        }

        private void InitRetryCancelButtons()
        {
            Button btnRetry = new Button()
            {
                Text = Retry
            };
            btnRetry.Click += ButtonClick;

            Button btnCancel = new Button()
            {
                Text = Cancel
            };
            btnCancel.Click += ButtonClick;


            this._buttonCollection.Add(btnCancel);
            this._buttonCollection.Add(btnRetry);

        }

        private void InitYesNoButtons()
        {
            Button btnYes = new Button()
            {
                Text = Yes
            };
            //btnYes.BackColor = Color.SeaGreen;
            btnYes.Click += ButtonClick;

            Button btnNo = new Button()
            {
                Text = No
            };
            //btnNo.BackColor = Color.Crimson;
            btnNo.Click += ButtonClick;

            this._buttonCollection.Add(btnNo);
            this._buttonCollection.Add(btnYes);

        }

        private void InitYesNoCancelButtons()
        {
            Button btnYes = new Button()
            {
                Text = Yes
            };
            btnYes.Click += ButtonClick;

            Button btnNo = new Button()
            {
                Text = No
            };
            btnNo.Click += ButtonClick;

            Button btnCancel = new Button()
            {
                Text = Cancel
            };
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnCancel);
            this._buttonCollection.Add(btnNo);
            this._buttonCollection.Add(btnYes);
        }

        private static void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case Abort:
                    _buttonResult = DialogResult.Abort;
                    break;

                case Retry:
                    _buttonResult = DialogResult.Retry;
                    break;

                case Ignore:
                    _buttonResult = DialogResult.Ignore;
                    break;

                case Ok:
                    _buttonResult = DialogResult.OK;
                    break;

                case Cancel:
                    _buttonResult = DialogResult.Cancel;
                    break;

                case Yes:
                    _buttonResult = DialogResult.Yes;
                    break;

                case No:
                    _buttonResult = DialogResult.No;
                    break;
            }

            _msgBox.Dispose();
        }
        
        private static void InitIcon(OFIcon icon)
        {
            switch (icon)
            {
                case OFIcon.Application:
                    _msgBox._picIcon.Image = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location).ToBitmap();
                    break;

                case OFIcon.Info:
                    _msgBox._picIcon.Image = SystemIcons.Information.ToBitmap();
                    break;

                case OFIcon.Question:
                    _msgBox._picIcon.Image = SystemIcons.Question.ToBitmap();
                    break;

                case OFIcon.Shield:
                    _msgBox._picIcon.Image = SystemIcons.Shield.ToBitmap();
                    break;

                case OFIcon.Warning:
                    _msgBox._picIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
            }

        }

        private static Size MessageSize(string message, string title)
        {
            Graphics g = _msgBox.CreateGraphics();
            int width = 400;
            int height = 180;

            SizeF sizeMessage = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 10));
            SizeF sizeTitle = g.MeasureString(title, new System.Drawing.Font("Segoe UI", 10));

            if (sizeMessage.Width > width || sizeTitle.Width > width)
            {
                width = 700;
            }
            string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
            int lines = groups.Length;
            height += 35 * lines;
            
            return new Size(width, height);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Pen pen = new Pen(Color.FromArgb(0, 151, 251));

            g.DrawRectangle(pen, rect);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MsgBox
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "MsgBox";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgBox_KeyDown);
            this.ResumeLayout(false);
        }

        private void MsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    _buttonResult = DialogResult.No;
                    Close();
                    break;
            }
        }

        private void OficinaMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    _buttonResult = DialogResult.No;
                    Close();
                    break;
            }
        }
    }

    public enum OFIcon
    {
        Application = 1,
        Warning = 4,
        Info = 5,
        Question = 6,
        Shield = 7
    }
    public enum OFButtons
    {
        AbortRetryIgnore = 1,
        OK = 2,
        OKCancel = 3,
        RetryCancel = 4,
        YesNo = 5,
        YesNoCancel = 6
    }
    public enum OFAnimateStyle
    {
        SlideDown = 1,
        FadeIn = 2,
        ZoomIn = 3
    }
    class OfAnimateMsgBox
    {
        public Size FormSize;
        public OFAnimateStyle Style;

        public OfAnimateMsgBox(Size formSize, OFAnimateStyle style)
        {
            this.FormSize = formSize;
            this.Style = style;
        }
    }
}

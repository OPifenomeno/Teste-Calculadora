namespace Calc_Syneco
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            config = new MenuStrip();
            limparHistóricoToolStripMenuItem = new ToolStripMenuItem();
            desencaixarCalcToolStripMenuItem = new ToolStripMenuItem();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            btCalc = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            calculator1 = new calculator();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 113, 151);
            panel1.Controls.Add(config);
            panel1.Controls.Add(guna2Button2);
            panel1.Controls.Add(guna2CircleButton1);
            panel1.Controls.Add(btCalc);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 71);
            panel1.TabIndex = 0;
            // 
            // config
            // 
            config.Dock = DockStyle.None;
            config.Items.AddRange(new ToolStripItem[] { limparHistóricoToolStripMenuItem, desencaixarCalcToolStripMenuItem });
            config.LayoutStyle = ToolStripLayoutStyle.Table;
            config.Location = new Point(832, 3);
            config.Name = "config";
            config.RenderMode = ToolStripRenderMode.Professional;
            config.Size = new Size(115, 42);
            config.Stretch = false;
            config.TabIndex = 6;
            config.Visible = false;
            config.MouseLeave += menuStrip1_MouseLeave;
            // 
            // limparHistóricoToolStripMenuItem
            // 
            limparHistóricoToolStripMenuItem.Name = "limparHistóricoToolStripMenuItem";
            limparHistóricoToolStripMenuItem.Size = new Size(105, 19);
            limparHistóricoToolStripMenuItem.Text = "Limpar histórico";
            limparHistóricoToolStripMenuItem.Click += limparHistóricoToolStripMenuItem_Click;
            // 
            // desencaixarCalcToolStripMenuItem
            // 
            desencaixarCalcToolStripMenuItem.Name = "desencaixarCalcToolStripMenuItem";
            desencaixarCalcToolStripMenuItem.Size = new Size(109, 19);
            desencaixarCalcToolStripMenuItem.Text = "Desencaixar calc.";
            desencaixarCalcToolStripMenuItem.Click += desencaixarCalcToolStripMenuItem_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Right;
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = Properties.Resources.X;
            guna2Button2.ImageSize = new Size(40, 40);
            guna2Button2.ImeMode = ImeMode.Close;
            guna2Button2.Location = new Point(927, 10);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedDepth = 0;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(57, 54);
            guna2Button2.TabIndex = 5;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Anchor = AnchorStyles.Right;
            guna2CircleButton1.Animated = true;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.HoverState.FillColor = Color.FromArgb(8, 79, 106);
            guna2CircleButton1.Image = Properties.Resources.eng;
            guna2CircleButton1.ImageAlign = HorizontalAlignment.Right;
            guna2CircleButton1.ImageOffset = new Point(-1, 0);
            guna2CircleButton1.ImageSize = new Size(40, 40);
            guna2CircleButton1.ImeMode = ImeMode.On;
            guna2CircleButton1.Location = new Point(864, 9);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(58, 57);
            guna2CircleButton1.TabIndex = 4;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // btCalc
            // 
            btCalc.Anchor = AnchorStyles.Right;
            btCalc.Animated = true;
            btCalc.BorderRadius = 20;
            btCalc.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            btCalc.CausesValidation = false;
            btCalc.CustomizableEdges = customizableEdges4;
            btCalc.DisabledState.BorderColor = Color.DarkGray;
            btCalc.DisabledState.CustomBorderColor = Color.DarkGray;
            btCalc.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btCalc.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btCalc.FillColor = Color.Transparent;
            btCalc.Font = new Font("Segoe UI", 9F);
            btCalc.ForeColor = Color.White;
            btCalc.HoverState.FillColor = Color.FromArgb(8, 79, 106);
            btCalc.Image = Properties.Resources.calc;
            btCalc.ImageAlign = HorizontalAlignment.Left;
            btCalc.ImageOffset = new Point(2, 0);
            btCalc.ImageSize = new Size(33, 51);
            btCalc.ImeMode = ImeMode.Off;
            btCalc.Location = new Point(809, 9);
            btCalc.Name = "btCalc";
            btCalc.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btCalc.Size = new Size(55, 61);
            btCalc.TabIndex = 3;
            btCalc.TabStop = false;
            btCalc.TextAlign = HorizontalAlignment.Right;
            btCalc.Click += abrirCalculadora;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.syneco_logo;
            pictureBox1.Location = new Point(385, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = panel1;
            guna2DragControl1.TransparentWhileDrag = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(13, 127, 169);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 29);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_SKA_Azul;
            pictureBox2.Location = new Point(481, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(13, 127, 169);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 38);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.syneco_clients;
            pictureBox3.Location = new Point(0, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1000, 477);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(calculator1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 536);
            panel2.TabIndex = 3;
            // 
            // calculator1
            // 
            calculator1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            calculator1.BackColor = Color.FromArgb(0, 151, 204);
            calculator1.CausesValidation = false;
            calculator1.Dock = DockStyle.Right;
            calculator1.ImeMode = ImeMode.On;
            calculator1.Location = new Point(1000, 38);
            calculator1.MaximumSize = new Size(301, 468);
            calculator1.Name = "calculator1";
            calculator1.Size = new Size(0, 468);
            calculator1.TabIndex = 10;
            calculator1.Load += calculator1_Load;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 607);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MainMenuStrip = config;
            MinimumSize = new Size(1000, 454);
            Name = "MainWindow";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            config.ResumeLayout(false);
            config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btCalc;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private calculator calculator1;
        private MenuStrip config;
        private ToolStripMenuItem limparHistóricoToolStripMenuItem;
        private ToolStripMenuItem desencaixarCalcToolStripMenuItem;
    }
}

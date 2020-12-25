using System.IO.Ports;
namespace Apresentacao
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftInferior = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLeftSuperiorEsquerdo = new System.Windows.Forms.Panel();
            this.pnlLeftSuperior = new System.Windows.Forms.Panel();
            this.pnlLeftSuperiorSuperior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbUFSJ = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnBancoDados = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.btnMedicao = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbStatusPort = new System.Windows.Forms.TextBox();
            this.lblStatusPort = new System.Windows.Forms.Label();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.cbbComPort = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.pnlSuperiorEsquerdo = new System.Windows.Forms.Panel();
            this.pnlSuperiorSuperior = new System.Windows.Forms.Panel();
            this.lblTextoSuperior = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlInferiorBorda = new System.Windows.Forms.Panel();
            this.pnlInferiorEsquerdo = new System.Windows.Forms.Panel();
            this.lblDesenvolvidoPor = new System.Windows.Forms.Label();
            this.pnlCentralInicial = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeftInferior.SuspendLayout();
            this.pnlLeftSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUFSJ)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            this.pnlCentralInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftInferior
            // 
            this.pnlLeftInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLeftInferior.Controls.Add(this.panel3);
            this.pnlLeftInferior.Controls.Add(this.pnlLeftSuperiorEsquerdo);
            this.pnlLeftInferior.Controls.Add(this.pnlLeftSuperior);
            this.pnlLeftInferior.Controls.Add(this.btnInicio);
            this.pnlLeftInferior.Controls.Add(this.btnBancoDados);
            this.pnlLeftInferior.Controls.Add(this.btnControle);
            this.pnlLeftInferior.Controls.Add(this.btnMedicao);
            this.pnlLeftInferior.Controls.Add(this.btnDashboard);
            this.pnlLeftInferior.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftInferior.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftInferior.Name = "pnlLeftInferior";
            this.pnlLeftInferior.Size = new System.Drawing.Size(259, 720);
            this.pnlLeftInferior.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 719);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 1);
            this.panel3.TabIndex = 18;
            // 
            // pnlLeftSuperiorEsquerdo
            // 
            this.pnlLeftSuperiorEsquerdo.BackColor = System.Drawing.Color.White;
            this.pnlLeftSuperiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSuperiorEsquerdo.Location = new System.Drawing.Point(0, 222);
            this.pnlLeftSuperiorEsquerdo.Name = "pnlLeftSuperiorEsquerdo";
            this.pnlLeftSuperiorEsquerdo.Size = new System.Drawing.Size(1, 498);
            this.pnlLeftSuperiorEsquerdo.TabIndex = 9;
            // 
            // pnlLeftSuperior
            // 
            this.pnlLeftSuperior.Controls.Add(this.pnlLeftSuperiorSuperior);
            this.pnlLeftSuperior.Controls.Add(this.panel1);
            this.pnlLeftSuperior.Controls.Add(this.pcbUFSJ);
            this.pnlLeftSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSuperior.Name = "pnlLeftSuperior";
            this.pnlLeftSuperior.Size = new System.Drawing.Size(259, 222);
            this.pnlLeftSuperior.TabIndex = 8;
            // 
            // pnlLeftSuperiorSuperior
            // 
            this.pnlLeftSuperiorSuperior.BackColor = System.Drawing.Color.White;
            this.pnlLeftSuperiorSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftSuperiorSuperior.Location = new System.Drawing.Point(1, 0);
            this.pnlLeftSuperiorSuperior.Name = "pnlLeftSuperiorSuperior";
            this.pnlLeftSuperiorSuperior.Size = new System.Drawing.Size(258, 1);
            this.pnlLeftSuperiorSuperior.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 222);
            this.panel1.TabIndex = 8;
            // 
            // pcbUFSJ
            // 
            this.pcbUFSJ.Image = global::Apresentacao.Properties.Resources.ufsj;
            this.pcbUFSJ.Location = new System.Drawing.Point(45, 32);
            this.pcbUFSJ.Name = "pcbUFSJ";
            this.pcbUFSJ.Size = new System.Drawing.Size(164, 158);
            this.pcbUFSJ.TabIndex = 7;
            this.pcbUFSJ.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 234);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(231, 90);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click_1);
            this.btnInicio.MouseLeave += new System.EventHandler(this.Button5_MouseLeave);
            this.btnInicio.MouseHover += new System.EventHandler(this.Button5_MouseHover);
            // 
            // btnBancoDados
            // 
            this.btnBancoDados.BackColor = System.Drawing.Color.Black;
            this.btnBancoDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnBancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBancoDados.ForeColor = System.Drawing.Color.White;
            this.btnBancoDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBancoDados.Location = new System.Drawing.Point(12, 618);
            this.btnBancoDados.Name = "btnBancoDados";
            this.btnBancoDados.Size = new System.Drawing.Size(231, 90);
            this.btnBancoDados.TabIndex = 3;
            this.btnBancoDados.Text = "Banco de Dados";
            this.btnBancoDados.UseVisualStyleBackColor = false;
            this.btnBancoDados.Click += new System.EventHandler(this.BtnBancoDados_Click);
            this.btnBancoDados.MouseLeave += new System.EventHandler(this.BtnBancoDados_MouseLeave);
            this.btnBancoDados.MouseHover += new System.EventHandler(this.BtnBancoDados_MouseHover);
            // 
            // btnControle
            // 
            this.btnControle.BackColor = System.Drawing.Color.Black;
            this.btnControle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControle.ForeColor = System.Drawing.Color.White;
            this.btnControle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControle.Location = new System.Drawing.Point(12, 522);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(231, 90);
            this.btnControle.TabIndex = 2;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = false;
            this.btnControle.Click += new System.EventHandler(this.BtnControle_Click);
            this.btnControle.MouseLeave += new System.EventHandler(this.BtnControle_MouseLeave);
            this.btnControle.MouseHover += new System.EventHandler(this.BtnControle_MouseHover);
            // 
            // btnMedicao
            // 
            this.btnMedicao.BackColor = System.Drawing.Color.Black;
            this.btnMedicao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicao.ForeColor = System.Drawing.Color.White;
            this.btnMedicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicao.Location = new System.Drawing.Point(12, 426);
            this.btnMedicao.Name = "btnMedicao";
            this.btnMedicao.Size = new System.Drawing.Size(231, 90);
            this.btnMedicao.TabIndex = 1;
            this.btnMedicao.Text = "Medição";
            this.btnMedicao.UseVisualStyleBackColor = false;
            this.btnMedicao.Click += new System.EventHandler(this.Button2_Click);
            this.btnMedicao.MouseLeave += new System.EventHandler(this.BtnMedicao_MouseLeave);
            this.btnMedicao.MouseHover += new System.EventHandler(this.BtnMedicao_MouseHover);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 330);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(231, 90);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.BtnDashboard_MouseLeave);
            this.btnDashboard.MouseHover += new System.EventHandler(this.BtnDashboard_MouseHover);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.pnlSuperior.Controls.Add(this.panel4);
            this.pnlSuperior.Controls.Add(this.pnlSuperiorEsquerdo);
            this.pnlSuperior.Controls.Add(this.pnlSuperiorSuperior);
            this.pnlSuperior.Controls.Add(this.lblTextoSuperior);
            this.pnlSuperior.Controls.Add(this.btnSair);
            this.pnlSuperior.Controls.Add(this.btnMinimize);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(259, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(941, 104);
            this.pnlSuperior.TabIndex = 1;
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.txbStatusPort);
            this.panel4.Controls.Add(this.lblStatusPort);
            this.panel4.Controls.Add(this.btnClosePort);
            this.panel4.Controls.Add(this.btnOpenPort);
            this.panel4.Controls.Add(this.cbbBaudRate);
            this.panel4.Controls.Add(this.lblBaudRate);
            this.panel4.Controls.Add(this.cbbComPort);
            this.panel4.Controls.Add(this.lblComPort);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 44);
            this.panel4.TabIndex = 13;
            // 
            // txbStatusPort
            // 
            this.txbStatusPort.BackColor = System.Drawing.Color.White;
            this.txbStatusPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbStatusPort.Enabled = false;
            this.txbStatusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStatusPort.Location = new System.Drawing.Point(683, 11);
            this.txbStatusPort.Name = "txbStatusPort";
            this.txbStatusPort.Size = new System.Drawing.Size(246, 24);
            this.txbStatusPort.TabIndex = 7;
            // 
            // lblStatusPort
            // 
            this.lblStatusPort.AutoSize = true;
            this.lblStatusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusPort.ForeColor = System.Drawing.Color.Black;
            this.lblStatusPort.Location = new System.Drawing.Point(606, 9);
            this.lblStatusPort.Name = "lblStatusPort";
            this.lblStatusPort.Size = new System.Drawing.Size(87, 25);
            this.lblStatusPort.TabIndex = 6;
            this.lblStatusPort.Text = "Status: ";
            // 
            // btnClosePort
            // 
            this.btnClosePort.BackColor = System.Drawing.Color.LightGray;
            this.btnClosePort.Enabled = false;
            this.btnClosePort.ForeColor = System.Drawing.Color.Black;
            this.btnClosePort.Location = new System.Drawing.Point(496, 5);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(100, 32);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = false;
            this.btnClosePort.Click += new System.EventHandler(this.BtnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.BackColor = System.Drawing.Color.Lime;
            this.btnOpenPort.ForeColor = System.Drawing.Color.Black;
            this.btnOpenPort.Location = new System.Drawing.Point(390, 5);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(100, 32);
            this.btnOpenPort.TabIndex = 4;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = false;
            this.btnOpenPort.Click += new System.EventHandler(this.BtnOpenPort_Click);
            this.btnOpenPort.MouseHover += new System.EventHandler(this.BtnOpenPort_MouseHover);
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(304, 11);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(77, 24);
            this.cbbBaudRate.TabIndex = 3;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaudRate.ForeColor = System.Drawing.Color.Black;
            this.lblBaudRate.Location = new System.Drawing.Point(198, 9);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(119, 25);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // cbbComPort
            // 
            this.cbbComPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbComPort.FormattingEnabled = true;
            this.cbbComPort.Location = new System.Drawing.Point(115, 11);
            this.cbbComPort.Name = "cbbComPort";
            this.cbbComPort.Size = new System.Drawing.Size(77, 24);
            this.cbbComPort.TabIndex = 1;
            this.cbbComPort.Click += new System.EventHandler(this.CbbComPort_Click);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComPort.ForeColor = System.Drawing.Color.Black;
            this.lblComPort.Location = new System.Drawing.Point(18, 9);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(115, 25);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // pnlSuperiorEsquerdo
            // 
            this.pnlSuperiorEsquerdo.BackColor = System.Drawing.Color.White;
            this.pnlSuperiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSuperiorEsquerdo.Location = new System.Drawing.Point(940, 1);
            this.pnlSuperiorEsquerdo.Name = "pnlSuperiorEsquerdo";
            this.pnlSuperiorEsquerdo.Size = new System.Drawing.Size(1, 103);
            this.pnlSuperiorEsquerdo.TabIndex = 12;
            // 
            // pnlSuperiorSuperior
            // 
            this.pnlSuperiorSuperior.BackColor = System.Drawing.Color.White;
            this.pnlSuperiorSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorSuperior.Name = "pnlSuperiorSuperior";
            this.pnlSuperiorSuperior.Size = new System.Drawing.Size(941, 1);
            this.pnlSuperiorSuperior.TabIndex = 11;
            // 
            // lblTextoSuperior
            // 
            this.lblTextoSuperior.AutoSize = true;
            this.lblTextoSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSuperior.Location = new System.Drawing.Point(190, 11);
            this.lblTextoSuperior.Name = "lblTextoSuperior";
            this.lblTextoSuperior.Size = new System.Drawing.Size(518, 29);
            this.lblTextoSuperior.TabIndex = 3;
            this.lblTextoSuperior.Text = "Sistema supervisório de transmissão LoRaWan";
            this.lblTextoSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = global::Apresentacao.Properties.Resources.quit;
            this.btnSair.Location = new System.Drawing.Point(879, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 50);
            this.btnSair.TabIndex = 2;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnQuit_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Apresentacao.Properties.Resources.min;
            this.btnMinimize.Location = new System.Drawing.Point(823, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema supervisório utilizando LoraWan";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnMinimizar.Location = new System.Drawing.Point(826, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.btnQuit.Location = new System.Drawing.Point(882, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 50);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 54);
            this.panel2.TabIndex = 1;
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.Black;
            this.pnlInferior.Controls.Add(this.pnlInferiorBorda);
            this.pnlInferior.Controls.Add(this.pnlInferiorEsquerdo);
            this.pnlInferior.Controls.Add(this.lblDesenvolvidoPor);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 587);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(941, 29);
            this.pnlInferior.TabIndex = 0;
            // 
            // pnlInferiorBorda
            // 
            this.pnlInferiorBorda.BackColor = System.Drawing.Color.White;
            this.pnlInferiorBorda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferiorBorda.Location = new System.Drawing.Point(0, 28);
            this.pnlInferiorBorda.Name = "pnlInferiorBorda";
            this.pnlInferiorBorda.Size = new System.Drawing.Size(940, 1);
            this.pnlInferiorBorda.TabIndex = 7;
            // 
            // pnlInferiorEsquerdo
            // 
            this.pnlInferiorEsquerdo.BackColor = System.Drawing.Color.White;
            this.pnlInferiorEsquerdo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInferiorEsquerdo.Location = new System.Drawing.Point(940, 0);
            this.pnlInferiorEsquerdo.Name = "pnlInferiorEsquerdo";
            this.pnlInferiorEsquerdo.Size = new System.Drawing.Size(1, 29);
            this.pnlInferiorEsquerdo.TabIndex = 6;
            // 
            // lblDesenvolvidoPor
            // 
            this.lblDesenvolvidoPor.AutoSize = true;
            this.lblDesenvolvidoPor.Location = new System.Drawing.Point(699, 7);
            this.lblDesenvolvidoPor.Name = "lblDesenvolvidoPor";
            this.lblDesenvolvidoPor.Size = new System.Drawing.Size(230, 17);
            this.lblDesenvolvidoPor.TabIndex = 0;
            this.lblDesenvolvidoPor.Text = "Desenvolvido por Victor de Oliveira";
            // 
            // pnlCentralInicial
            // 
            this.pnlCentralInicial.BackColor = System.Drawing.Color.White;
            this.pnlCentralInicial.Controls.Add(this.pnlRight);
            this.pnlCentralInicial.Controls.Add(this.pnlInferior);
            this.pnlCentralInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralInicial.Location = new System.Drawing.Point(259, 104);
            this.pnlCentralInicial.Name = "pnlCentralInicial";
            this.pnlCentralInicial.Size = new System.Drawing.Size(941, 616);
            this.pnlCentralInicial.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Black;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(940, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1, 587);
            this.pnlRight.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlCentralInicial);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlLeftInferior);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de monitoramento utilizando LoRaWan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLeftInferior.ResumeLayout(false);
            this.pnlLeftSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUFSJ)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.pnlCentralInicial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftInferior;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnBancoDados;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnMedicao;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pcbUFSJ;
        private System.Windows.Forms.Panel pnlLeftSuperior;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTextoSuperior;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Label lblDesenvolvidoPor;
        private System.Windows.Forms.Panel pnlCentralInicial;
        private System.Windows.Forms.Panel pnlLeftSuperiorEsquerdo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLeftSuperiorSuperior;
        private System.Windows.Forms.Panel pnlSuperiorSuperior;
        private System.Windows.Forms.Panel pnlSuperiorEsquerdo;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlInferiorEsquerdo;
        private System.Windows.Forms.Panel pnlInferiorBorda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblComPort;
        public System.Windows.Forms.ComboBox cbbComPort;
        public System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Label lblStatusPort;
        private System.Windows.Forms.TextBox txbStatusPort;
    }
}


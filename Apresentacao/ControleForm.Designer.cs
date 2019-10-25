namespace Apresentacao
{
    partial class ControleForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLedVermelho = new System.Windows.Forms.Button();
            this.lblLedVermelho = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPlayPause = new System.Windows.Forms.Panel();
            this.btnEsteiraPlay = new System.Windows.Forms.Button();
            this.btnEsteiraPause = new System.Windows.Forms.Button();
            this.btnEsteiraVelocidade = new System.Windows.Forms.TextBox();
            this.btnEsteiraEsquerdaVelocidade = new System.Windows.Forms.Button();
            this.btnEsteiraDireitaVelocidade = new System.Windows.Forms.Button();
            this.btnEsteiraDireita = new System.Windows.Forms.Button();
            this.btnEsteiraEsquerda = new System.Windows.Forms.Button();
            this.gpbEnviarComando = new System.Windows.Forms.GroupBox();
            this.btnEnviarComando = new System.Windows.Forms.Button();
            this.txbEnviarComando = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBeepSound = new System.Windows.Forms.Button();
            this.btnBeepSoundStop = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlPlayPause.SuspendLayout();
            this.gpbEnviarComando.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLedVermelho);
            this.groupBox1.Controls.Add(this.lblLedVermelho);
            this.groupBox1.Font = new System.Drawing.Font("Oswald", 15F);
            this.groupBox1.Location = new System.Drawing.Point(38, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 383);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iluminação";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(35, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ligar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 13F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Led verde";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button2.Location = new System.Drawing.Point(35, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ligar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Oswald", 13F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Led Amarelo";
            // 
            // btnLedVermelho
            // 
            this.btnLedVermelho.BackColor = System.Drawing.Color.Lime;
            this.btnLedVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnLedVermelho.Location = new System.Drawing.Point(35, 92);
            this.btnLedVermelho.Name = "btnLedVermelho";
            this.btnLedVermelho.Size = new System.Drawing.Size(138, 33);
            this.btnLedVermelho.TabIndex = 7;
            this.btnLedVermelho.Text = "Ligar";
            this.btnLedVermelho.UseVisualStyleBackColor = false;
            this.btnLedVermelho.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // lblLedVermelho
            // 
            this.lblLedVermelho.AutoSize = true;
            this.lblLedVermelho.Font = new System.Drawing.Font("Oswald", 13F);
            this.lblLedVermelho.ForeColor = System.Drawing.Color.Black;
            this.lblLedVermelho.Location = new System.Drawing.Point(28, 58);
            this.lblLedVermelho.Name = "lblLedVermelho";
            this.lblLedVermelho.Size = new System.Drawing.Size(127, 32);
            this.lblLedVermelho.TabIndex = 6;
            this.lblLedVermelho.Text = "Led vermelho";
            this.lblLedVermelho.Click += new System.EventHandler(this.Label7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlPlayPause);
            this.groupBox2.Controls.Add(this.btnEsteiraVelocidade);
            this.groupBox2.Controls.Add(this.btnEsteiraEsquerdaVelocidade);
            this.groupBox2.Controls.Add(this.btnEsteiraDireitaVelocidade);
            this.groupBox2.Controls.Add(this.btnEsteiraDireita);
            this.groupBox2.Controls.Add(this.btnEsteiraEsquerda);
            this.groupBox2.Font = new System.Drawing.Font("Oswald", 15F);
            this.groupBox2.Location = new System.Drawing.Point(263, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Esteira rolante";
            // 
            // pnlPlayPause
            // 
            this.pnlPlayPause.Controls.Add(this.btnEsteiraPlay);
            this.pnlPlayPause.Controls.Add(this.btnEsteiraPause);
            this.pnlPlayPause.Location = new System.Drawing.Point(73, 44);
            this.pnlPlayPause.Name = "pnlPlayPause";
            this.pnlPlayPause.Size = new System.Drawing.Size(71, 73);
            this.pnlPlayPause.TabIndex = 9;
            // 
            // btnEsteiraPlay
            // 
            this.btnEsteiraPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraPlay.Image = global::Apresentacao.Properties.Resources.play;
            this.btnEsteiraPlay.Location = new System.Drawing.Point(13, 17);
            this.btnEsteiraPlay.Name = "btnEsteiraPlay";
            this.btnEsteiraPlay.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraPlay.TabIndex = 4;
            this.btnEsteiraPlay.UseVisualStyleBackColor = true;
            this.btnEsteiraPlay.Click += new System.EventHandler(this.BtnEsteiraPlayPause_Click);
            this.btnEsteiraPlay.MouseHover += new System.EventHandler(this.BtnEsteiraPlay_MouseHover);
            // 
            // btnEsteiraPause
            // 
            this.btnEsteiraPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraPause.Image = global::Apresentacao.Properties.Resources.pause;
            this.btnEsteiraPause.Location = new System.Drawing.Point(13, 17);
            this.btnEsteiraPause.Name = "btnEsteiraPause";
            this.btnEsteiraPause.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraPause.TabIndex = 5;
            this.btnEsteiraPause.UseVisualStyleBackColor = true;
            this.btnEsteiraPause.Click += new System.EventHandler(this.BtnEsteiraPause_Click);
            this.btnEsteiraPause.MouseHover += new System.EventHandler(this.BtnEsteiraPause_MouseHover);
            // 
            // btnEsteiraVelocidade
            // 
            this.btnEsteiraVelocidade.Location = new System.Drawing.Point(86, 123);
            this.btnEsteiraVelocidade.Name = "btnEsteiraVelocidade";
            this.btnEsteiraVelocidade.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraVelocidade.TabIndex = 7;
            this.btnEsteiraVelocidade.Text = "1x";
            this.btnEsteiraVelocidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEsteiraVelocidade.TextChanged += new System.EventHandler(this.BtnEsteiraVelocidade_TextChanged);
            // 
            // btnEsteiraEsquerdaVelocidade
            // 
            this.btnEsteiraEsquerdaVelocidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraEsquerdaVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEsteiraEsquerdaVelocidade.ForeColor = System.Drawing.Color.Black;
            this.btnEsteiraEsquerdaVelocidade.Location = new System.Drawing.Point(22, 123);
            this.btnEsteiraEsquerdaVelocidade.Name = "btnEsteiraEsquerdaVelocidade";
            this.btnEsteiraEsquerdaVelocidade.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraEsquerdaVelocidade.TabIndex = 6;
            this.btnEsteiraEsquerdaVelocidade.Text = "<<";
            this.btnEsteiraEsquerdaVelocidade.UseVisualStyleBackColor = true;
            this.btnEsteiraEsquerdaVelocidade.Click += new System.EventHandler(this.BtnEsteiraEsquerdaVelocidade_Click);
            // 
            // btnEsteiraDireitaVelocidade
            // 
            this.btnEsteiraDireitaVelocidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraDireitaVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEsteiraDireitaVelocidade.ForeColor = System.Drawing.Color.Black;
            this.btnEsteiraDireitaVelocidade.Location = new System.Drawing.Point(150, 123);
            this.btnEsteiraDireitaVelocidade.Name = "btnEsteiraDireitaVelocidade";
            this.btnEsteiraDireitaVelocidade.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraDireitaVelocidade.TabIndex = 5;
            this.btnEsteiraDireitaVelocidade.Text = ">>";
            this.btnEsteiraDireitaVelocidade.UseVisualStyleBackColor = true;
            this.btnEsteiraDireitaVelocidade.Click += new System.EventHandler(this.BtnEsteiraDireitaVelocidade_Click);
            // 
            // btnEsteiraDireita
            // 
            this.btnEsteiraDireita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEsteiraDireita.ForeColor = System.Drawing.Color.Black;
            this.btnEsteiraDireita.Location = new System.Drawing.Point(150, 61);
            this.btnEsteiraDireita.Name = "btnEsteiraDireita";
            this.btnEsteiraDireita.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraDireita.TabIndex = 3;
            this.btnEsteiraDireita.Text = ">";
            this.btnEsteiraDireita.UseVisualStyleBackColor = true;
            this.btnEsteiraDireita.Click += new System.EventHandler(this.BtnEsteiraDireita_Click);
            // 
            // btnEsteiraEsquerda
            // 
            this.btnEsteiraEsquerda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsteiraEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnEsteiraEsquerda.ForeColor = System.Drawing.Color.Black;
            this.btnEsteiraEsquerda.Location = new System.Drawing.Point(22, 61);
            this.btnEsteiraEsquerda.Name = "btnEsteiraEsquerda";
            this.btnEsteiraEsquerda.Size = new System.Drawing.Size(45, 45);
            this.btnEsteiraEsquerda.TabIndex = 2;
            this.btnEsteiraEsquerda.Text = "<";
            this.btnEsteiraEsquerda.UseVisualStyleBackColor = true;
            this.btnEsteiraEsquerda.Click += new System.EventHandler(this.BtnEsteiraEsquerda_Click);
            // 
            // gpbEnviarComando
            // 
            this.gpbEnviarComando.Controls.Add(this.btnEnviarComando);
            this.gpbEnviarComando.Controls.Add(this.txbEnviarComando);
            this.gpbEnviarComando.Font = new System.Drawing.Font("Oswald", 15F);
            this.gpbEnviarComando.Location = new System.Drawing.Point(38, 509);
            this.gpbEnviarComando.Name = "gpbEnviarComando";
            this.gpbEnviarComando.Size = new System.Drawing.Size(864, 91);
            this.gpbEnviarComando.TabIndex = 5;
            this.gpbEnviarComando.TabStop = false;
            this.gpbEnviarComando.Text = "Enviar Comando";
            // 
            // btnEnviarComando
            // 
            this.btnEnviarComando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarComando.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarComando.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarComando.Location = new System.Drawing.Point(799, 54);
            this.btnEnviarComando.Name = "btnEnviarComando";
            this.btnEnviarComando.Size = new System.Drawing.Size(40, 24);
            this.btnEnviarComando.TabIndex = 3;
            this.btnEnviarComando.Text = ">";
            this.btnEnviarComando.UseVisualStyleBackColor = true;
            this.btnEnviarComando.Click += new System.EventHandler(this.BtnEnviarComando_Click);
            // 
            // txbEnviarComando
            // 
            this.txbEnviarComando.BackColor = System.Drawing.Color.White;
            this.txbEnviarComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEnviarComando.Location = new System.Drawing.Point(26, 54);
            this.txbEnviarComando.Name = "txbEnviarComando";
            this.txbEnviarComando.Size = new System.Drawing.Size(754, 24);
            this.txbEnviarComando.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBeepSound);
            this.groupBox4.Controls.Add(this.btnBeepSoundStop);
            this.groupBox4.Font = new System.Drawing.Font("Oswald", 15F);
            this.groupBox4.Location = new System.Drawing.Point(263, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 168);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Beep";
            // 
            // btnBeepSound
            // 
            this.btnBeepSound.BackColor = System.Drawing.Color.White;
            this.btnBeepSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeepSound.Image = global::Apresentacao.Properties.Resources.sound;
            this.btnBeepSound.Location = new System.Drawing.Point(55, 57);
            this.btnBeepSound.Name = "btnBeepSound";
            this.btnBeepSound.Size = new System.Drawing.Size(89, 89);
            this.btnBeepSound.TabIndex = 1;
            this.btnBeepSound.UseVisualStyleBackColor = false;
            this.btnBeepSound.Click += new System.EventHandler(this.BtnBeepSound_Click);
            this.btnBeepSound.MouseLeave += new System.EventHandler(this.BtnBeepSound_MouseLeave);
            this.btnBeepSound.MouseHover += new System.EventHandler(this.BtnBeepSound_MouseHover);
            // 
            // btnBeepSoundStop
            // 
            this.btnBeepSoundStop.BackColor = System.Drawing.Color.White;
            this.btnBeepSoundStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeepSoundStop.Image = global::Apresentacao.Properties.Resources.soundStop;
            this.btnBeepSoundStop.Location = new System.Drawing.Point(55, 57);
            this.btnBeepSoundStop.Name = "btnBeepSoundStop";
            this.btnBeepSoundStop.Size = new System.Drawing.Size(89, 89);
            this.btnBeepSoundStop.TabIndex = 2;
            this.btnBeepSoundStop.UseVisualStyleBackColor = false;
            this.btnBeepSoundStop.Click += new System.EventHandler(this.BtnBeepSoundStop_Click);
            this.btnBeepSoundStop.MouseLeave += new System.EventHandler(this.BtnBeepSoundStop_MouseLeave);
            this.btnBeepSoundStop.MouseHover += new System.EventHandler(this.BtnBeepSoundStop_MouseHover);
            // 
            // ControleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gpbEnviarComando);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleForm";
            this.Text = "ControleForm";
            this.Load += new System.EventHandler(this.ControleForm_Load);
            this.MouseHover += new System.EventHandler(this.ControleForm_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPlayPause.ResumeLayout(false);
            this.gpbEnviarComando.ResumeLayout(false);
            this.gpbEnviarComando.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLedVermelho;
        private System.Windows.Forms.Label lblLedVermelho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox btnEsteiraVelocidade;
        private System.Windows.Forms.Button btnEsteiraEsquerdaVelocidade;
        private System.Windows.Forms.Button btnEsteiraDireitaVelocidade;
        private System.Windows.Forms.Button btnEsteiraPlay;
        private System.Windows.Forms.Button btnEsteiraDireita;
        private System.Windows.Forms.Button btnEsteiraEsquerda;
        private System.Windows.Forms.GroupBox gpbEnviarComando;
        private System.Windows.Forms.Button btnEnviarComando;
        private System.Windows.Forms.TextBox txbEnviarComando;
        private System.Windows.Forms.Panel pnlPlayPause;
        private System.Windows.Forms.Button btnEsteiraPause;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBeepSound;
        private System.Windows.Forms.Button btnBeepSoundStop;
    }
}
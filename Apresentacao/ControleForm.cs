using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao.Properties;

namespace Apresentacao
{
    public partial class ControleForm : Form
    {
        // MainForm mainForm = new MainForm();
        int clicks=1;

        public ControleForm()
        {
            InitializeComponent();
            
        }

        private void ControleForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnMensagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexaoSerial.Instancia.GetConexao().IsOpen == true)
                {
                   // conexao.Write(txbMensagem.Text);
                }
                else
                {
                    MessageBox.Show("Erro de comunicação com a porta !");
                }
            }
            catch
            {
                MessageBox.Show("Deu ruim !");
            }
         
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnLampadaLiga_Click(object sender, EventArgs e)
        {
            if(ConexaoSerial.Instancia.GetConexao().IsOpen == true)
            {
                //btnLedRed.Text = "Ligado";
               // btnLedRed.BackColor = Color.Green;
               // conexao.Write("LED1:1");
            }
            else
            {
                //btnLedRed.BackColor = Color.Gray;
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnEsteiraPlayPause_Click(object sender, EventArgs e)
        {
            btnEsteiraPlay.Visible = false;
            btnEsteiraPause.Visible = true;
            ConexaoSerial.Instancia.GetConexao().Write("ligaEsteira");
        }

        private void BtnEsteiraPause_Click(object sender, EventArgs e)
        {       
            btnEsteiraPlay.Visible = true;
            btnEsteiraPause.Visible = false;
        }

        private void ControleForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnEsteiraPlay_MouseHover(object sender, EventArgs e)
        {
            btnEsteiraPlay.BackColor = Color.White;
        }

        private void BtnEsteiraPause_MouseHover(object sender, EventArgs e)
        {
            btnEsteiraPause.BackColor = Color.White;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBeepSoundStop_Click(object sender, EventArgs e)
        {
            btnBeepSoundStop.Visible = false;
            btnBeepSoundStop.Enabled = false;
            btnBeepSound.Visible = true;
            btnBeepSound.Enabled = true;
            ConexaoSerial.Instancia.GetConexao().Write("desligaBuzzer");
        }

        private void BtnBeepSound_Click(object sender, EventArgs e)
        {
            btnBeepSound.Visible = false;
            btnBeepSound.Enabled = false;
            btnBeepSoundStop.Visible = true;
            btnBeepSoundStop.Enabled = true;
            ConexaoSerial.Instancia.GetConexao().Write("ligaBuzzer");
        }

        private void BtnBeepSoundStop_MouseHover(object sender, EventArgs e)
        {
            btnBeepSoundStop.BackColor = Color.White;
            btnBeepSoundStop.ForeColor = Color.White;
        }

        private void BtnBeepSound_MouseHover(object sender, EventArgs e)
        {
            btnBeepSound.BackColor = Color.White;
            btnBeepSound.ForeColor = Color.White;
        }

        private void BtnBeepSoundStop_MouseLeave(object sender, EventArgs e)
        {
            btnBeepSoundStop.BackColor = Color.White;
            btnBeepSoundStop.ForeColor = Color.White;
        }

        private void BtnBeepSound_MouseLeave(object sender, EventArgs e)
        {
            btnBeepSound.BackColor = Color.White;
            btnBeepSound.ForeColor = Color.White;
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            if(ConexaoSerial.Instancia.GetConexao().IsOpen == true)
            {
                if (btnLedVermelho.Text == "Desligar")
                {
                    btnLedVermelho.BackColor = Color.Lime;
                    btnLedVermelho.Text = "Ligar";
                    ConexaoSerial.Instancia.GetConexao().Write("desligaLED");
                    
                }
                else if(btnLedVermelho.Text == "Ligar")
                {
                    btnLedVermelho.BackColor = Color.Red;
                    btnLedVermelho.Text = "Desligar";
                    ConexaoSerial.Instancia.GetConexao().Write("ligaLED");
                }
               
            }
            else
            {
                MessageBox.Show("Conexão serial fechada !");

            }
        }

        private void BtnEnviarComando_Click(object sender, EventArgs e)
        {
            if(ConexaoSerial.Instancia.GetConexao().IsOpen == true)
            {
                ConexaoSerial.Instancia.GetConexao().Write(txbEnviarComando.Text);
                txbEnviarComando.Text = null;
            }
            else
            {

            }
        }

        private void BtnEsteiraDireita_Click(object sender, EventArgs e)
        {
            ConexaoSerial.Instancia.GetConexao().Write("rodaDireita");
        }

        private void BtnEsteiraEsquerda_Click(object sender, EventArgs e)
        {
            ConexaoSerial.Instancia.GetConexao().Write("rodaEsquerda");
        }

        private void BtnEsteiraDireitaVelocidade_Click(object sender, EventArgs e)
        {
            ConexaoSerial.Instancia.GetConexao().Write("velocidadeDireita");
        }

        private void BtnEsteiraEsquerdaVelocidade_Click(object sender, EventArgs e)
        {
            ConexaoSerial.Instancia.GetConexao().Write("velocidadeEsquerda");
        }

        private void BtnEsteiraVelocidade_TextChanged(object sender, EventArgs e)
        {

        }

        // Recepção strings serial
        string str = null, chtxt = null;
        public void RecepcaoSerial()
        {
            chtxt += ConexaoSerial.Instancia.GetConexao().ReadExisting();
            txbEnviarComando.Text += chtxt;
            str += chtxt;
            chtxt = null;

            // Texto [ligaLED] ou [desligaLED]
            // Substring seleciona a posição da string que começa com "["
            if(str.Substring(0,1).Equals("["))
            {

                // Se receber a string [ligarLED]
                if(str.Length >= 10)
                {
                    if(str.Substring(1,1).Equals("l") &&
                        str.Substring(2, 1).Equals("i") &&
                        str.Substring(3, 1).Equals("g") &&
                        str.Substring(4, 1).Equals("a") &&
                        str.Substring(5, 1).Equals("r") &&
                        str.Substring(6, 1).Equals("L") &&
                        str.Substring(7, 1).Equals("E") &&
                        str.Substring(8, 1).Equals("D") &&
                        str.Substring(9, 1).Equals("]") 
                        )
                    {
                        btnLedVermelho.BackColor = Color.Red;
                        btnLedVermelho.Text = "Desligar";
                    }
                }

                // Se receber a string [desligarLED]
                if (str.Length >= 13)
                {
                    if (str.Substring(1, 1).Equals("d") &&
                        str.Substring(2, 1).Equals("e") &&
                        str.Substring(3, 1).Equals("s") &&
                        str.Substring(4, 1).Equals("l") &&
                        str.Substring(5, 1).Equals("i") &&
                        str.Substring(6, 1).Equals("g") &&
                        str.Substring(7, 1).Equals("a") &&
                        str.Substring(8, 1).Equals("r") &&
                        str.Substring(9, 1).Equals("L") &&
                        str.Substring(10, 1).Equals("E") &&
                        str.Substring(11, 1).Equals("D") &&
                        str.Substring(12, 1).Equals("]")
                        )
                    {
                        btnLedVermelho.BackColor = Color.Lime;
                        btnLedVermelho.Text = "Ligar";
                    }
                }

                // Se receber a string [pausarEsteira]
                if (str.Length >= 15)
                {
                    if (str.Substring(1, 1).Equals("p") &&
                        str.Substring(2, 1).Equals("a") &&
                        str.Substring(3, 1).Equals("u") &&
                        str.Substring(4, 1).Equals("s") &&
                        str.Substring(5, 1).Equals("a") &&
                        str.Substring(6, 1).Equals("r") &&
                        str.Substring(7, 1).Equals("E") &&
                        str.Substring(8, 1).Equals("s") &&
                        str.Substring(9, 1).Equals("t") &&
                        str.Substring(10, 1).Equals("e") &&
                        str.Substring(11, 1).Equals("i") &&
                        str.Substring(12, 1).Equals("r") &&
                        str.Substring(13, 1).Equals("a") &&
                        str.Substring(14, 1).Equals("]")
                        )
                    {
                        btnEsteiraPause.Enabled = false;
                        btnEsteiraPlay.Enabled = true;
                    }
                }

                // Se receber a string [playEsteira]
                if (str.Length >= 13)
                {
                    if (str.Substring(1, 1).Equals("p") &&
                        str.Substring(2, 1).Equals("l") &&
                        str.Substring(3, 1).Equals("a") &&
                        str.Substring(4, 1).Equals("y") &&                     
                        str.Substring(5, 1).Equals("E") &&
                        str.Substring(6, 1).Equals("s") &&
                        str.Substring(7, 1).Equals("t") &&
                        str.Substring(8, 1).Equals("e") &&
                        str.Substring(9, 1).Equals("i") &&
                        str.Substring(10, 1).Equals("r") &&
                        str.Substring(11, 1).Equals("a") &&
                        str.Substring(12, 1).Equals("]")
                        )
                    {
                        btnEsteiraPause.Enabled = false;
                        btnEsteiraPlay.Enabled = true;
                    }
                }


            }
            
        }

    }
}

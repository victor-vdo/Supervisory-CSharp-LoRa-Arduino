using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace Apresentacao
{
    public partial class MainForm : Form
    {
        //public static ConexaoSerial _context;
      //  public static SerialPort conexao = new SerialPort();

        // Atributos e imports que permitem a movimentação do formulário principal na tela
        #region ImportsMoveForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
            public const int HT_CAPTION = 0x2;
            [DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
            [DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
        #endregion

        
        public MainForm()
        {
            InitializeComponent();
            
        }

        // Método que inicia logo após abrir o formulário principal
        private void Form1_Load(object sender, EventArgs e)
        {
            // Seleciona os nomes das portas disponíveis
            #region ConfiguraçãoPorta
                String[] arrayPortas = SerialPort.GetPortNames();
                for(int i =0; i < arrayPortas.Length; i++)
                {          
                    cbbComPort.Items.Add(arrayPortas[i]);
                }    
            #endregion

            // Seleciona os bauds das portas disponíveis
            #region ConfiguraçãoBaud
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
                for (int i = 0; i < valoresBaud.Length; i++)
                {
                    cbbBaudRate.Items.Add(valoresBaud[i].ToString());
                }
                cbbBaudRate.Text = "9600";
            #endregion

            // Setando botões iniciais desativados
            #region Setando botões iniciais desativados
                btnInicio.Enabled = true;
                btnInicio.Visible = true;

                btnDashboard.Enabled = false;
                btnDashboard.BackColor = Color.Gray;
                btnDashboard.Visible = true;

                btnMedicao.Enabled = false;
                btnMedicao.BackColor = Color.Gray;
                btnMedicao.Visible = true;

                btnControle.Enabled = false;
                btnControle.BackColor = Color.Gray;
                btnControle.Visible = true;

                btnBancoDados.Enabled = false;
                btnBancoDados.BackColor = Color.Gray;
                btnBancoDados.Visible = true;
            #endregion

            // Setando demais parâmetros 
            #region ParâmetrosSetados
            //txbStatusPort.Text = "Port is Closed";
            #endregion

        }



        // Método para formulários dentro do pnlCentralInicial
        private void AbrirFormFilho(object formFilho)
        {
            // Descobre se existe algum componente no interior do painel e remove caso exista
            if (pnlCentralInicial.Controls.Count > 0)
                this.pnlCentralInicial.Controls.RemoveAt(0);

            Form filho = formFilho as Form;
            filho.TopLevel = false; // Define que não é um formulário de nível superior
            filho.Dock = DockStyle.Fill; // Define que o form preencha todo o painel
            this.pnlCentralInicial.Controls.Add(filho); // Adiciona o form dentro do panelCentralInicial
            this.pnlCentralInicial.Tag = filho;
            filho.Show();
        }
        
        private void PnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new DashboardForm());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new MedicaoForm());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnQuit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ConexaoSerial.Instancia.GetConexao().Close();
        }

        private void BtnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Gray;
        }

        private void BtnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Black;
        }

        private void BtnMedicao_MouseHover(object sender, EventArgs e)
        {
            btnMedicao.BackColor = Color.Gray;
        }

        private void BtnMedicao_MouseLeave(object sender, EventArgs e)
        {
            btnMedicao.BackColor = Color.Black;
        }

        private void BtnControle_MouseHover(object sender, EventArgs e)
        {
            btnControle.BackColor = Color.Gray;
        }

        private void BtnControle_MouseLeave(object sender, EventArgs e)
        {
            btnControle.BackColor = Color.Black;
        }

        private void BtnBancoDados_MouseHover(object sender, EventArgs e)
        {
            btnBancoDados.BackColor = Color.Gray;
        }

        private void BtnBancoDados_MouseLeave(object sender, EventArgs e)
        {
            btnBancoDados.BackColor = Color.Black;
        }

        private void BtnControle_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new ControleForm());
        }

        private void Button5_MouseHover(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.Gray;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.Black;
        }

        private void BtnBancoDados_Click(object sender, EventArgs e)
        {
            AbrirFormFilho(new BancoDadosForm()); 
        }

        private void BtnInicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormFilho(new InicioForm());
       
            //conexao.Open();
            //conexao.Write("1");
            //conexao.Close();
        }

        private void BtnOpenPort_MouseHover(object sender, EventArgs e)
        {
            btnOpenPort.BackColor = Color.SpringGreen;
        }

        // Método que abre a conexão com a porta serial após clickar no botão OpenPort
        public void BtnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexaoSerial.Instancia.GetConexao().IsOpen == false )
                {
                    try
                    {
                        ConexaoSerial.Instancia.GetConexao().PortName = cbbComPort.Items[cbbComPort.SelectedIndex].ToString();
                        ConexaoSerial.Instancia.GetConexao().BaudRate = int.Parse(cbbBaudRate.Text);
                        ConexaoSerial.Instancia.GetConexao().Open();

                    }
                    catch
                    {
                        return;

                    }
                    if (ConexaoSerial.Instancia.GetConexao().IsOpen)
                    {
                        //  btnOpenPort.Text = "Desconectar";
                        cbbComPort.Enabled = false;
                        cbbBaudRate.Enabled = false;
                        GuiCaseConexaoOpen();
                    }
                }
                else
                {
                    MessageBox.Show("A conexão já está aberta em outro dispositivo !");
                    try
                    {
                        ConexaoSerial.Instancia.GetConexao().Close();
                        cbbComPort.Enabled = true;
                        cbbBaudRate.Enabled = true;
                        GuiCaseConexaoClosed();
                        //  btnOpenPort.Text = "Conectar";
                    }
                    catch
                    {
                        return;
                    }

                }
            }
            catch
            {
                GuiCaseConexaoClosed();
                MessageBox.Show("Ocorreu algum erro na conexão com o porta serial !");
            }

           
        }

        // GUI dos botões Open / Close Port e do textbox Status para conexão aberta 
        private void GuiCaseConexaoOpen()
        {
            //conexao.PortName = lblComPort.Text;
            //conexao.BaudRate = int.Parse(cbbBaudRate.Text);
            btnOpenPort.Enabled = false;
            btnOpenPort.BackColor = Color.LightGray;
            btnClosePort.Enabled = true;
            btnClosePort.BackColor = Color.Red;
            txbStatusPort.Text = "Port "+cbbComPort.SelectedItem+" is open";

            #region Botões iniciais Ativados
                btnInicio.Enabled = true;
                btnInicio.Visible = true;

                btnDashboard.Enabled = true;
                btnDashboard.BackColor = Color.Black;
                btnDashboard.Visible = true;

                btnMedicao.Enabled = true;
                btnMedicao.BackColor = Color.Black;
                btnMedicao.Visible = true;

                btnControle.Enabled = true;
                btnControle.BackColor = Color.Black;
                btnControle.Visible = true;

                btnBancoDados.Enabled = true;
                btnBancoDados.BackColor = Color.Black;
                btnBancoDados.Visible = true;
            #endregion
        }

        // GUI dos botões Open / Close Port e do textbox Status para conexão fechada 
        private void GuiCaseConexaoClosed()
        {          
            btnOpenPort.Enabled = true;
            btnOpenPort.BackColor = Color.Lime;
            btnClosePort.Enabled = false;
            btnClosePort.BackColor = Color.LightGray;
            txbStatusPort.Text = "Port is closed";

            #region Setando botões iniciais desativados
                btnInicio.Enabled = true;
                btnInicio.Visible = true;

                btnDashboard.Enabled = false;
                btnDashboard.BackColor = Color.Gray;
                btnDashboard.Visible = true;

                btnMedicao.Enabled = false;
                btnMedicao.BackColor = Color.Gray;
                btnMedicao.Visible = true;

                btnControle.Enabled = false;
                btnControle.BackColor = Color.Gray;
                btnControle.Visible = true;

                btnBancoDados.Enabled = false;
                btnBancoDados.BackColor = Color.Gray;
                btnBancoDados.Visible = true;
            #endregion
        }

        private void BtnClosePort_Click(object sender, EventArgs e)
        {            
            if (ConexaoSerial.Instancia.GetConexao().IsOpen == true) ConexaoSerial.Instancia.GetConexao().Close();
            cbbComPort.Enabled = true;
            cbbBaudRate.Enabled = true;
            GuiCaseConexaoClosed();
        }

        // Atualiza as portas seriais disponíveis toda vez que o comboBox ComPort é clickado
        private void CbbComPort_Click(object sender, EventArgs e)
        {
            cbbComPort.Items.Clear();
            cbbComPort.Text="";
            String[] arrayPortas = SerialPort.GetPortNames();
            for (int i = 0; i < arrayPortas.Length; i++)
            {
                cbbComPort.Items.Add(arrayPortas[i]);
            }
        }

    }
}

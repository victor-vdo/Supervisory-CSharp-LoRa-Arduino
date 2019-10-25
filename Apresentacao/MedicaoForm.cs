using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class MedicaoForm : Form
    {
        
        SerialPort conexao = new SerialPort();
        string str = ConexaoSerial.Instancia.GetConexao().ReadExisting();
        delegate void SetTextDelegate(string value);


        public MedicaoForm()
        {
            InitializeComponent();
        }

        private void MedicaoForm_Load(object sender, EventArgs e)
        {
    
            pgbDistancia.Minimum = 0;
            pgbDistancia.Maximum = 400;
            pgbDistancia.Step = 1;

            ckbDistancia.Checked = true;
            ckbNivel.Checked = true;
            ckbTemperatura.Checked = true;
            ckbPeso.Checked = true;
            ckbUmidade.Checked = true;
            ckbSpeedMotor.Checked = true;
            ConexaoSerial.Instancia.GetConexao().DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
         
        }

        //Timer
        

        // Métodos Set's de Medição
        #region SetMedicao

            // Setar Textos nos textBox
            #region SetTemperatura
                public void SetTexts(string value)
                {
                    if (InvokeRequired)
                        try
                        {
                            Invoke(new SetTextDelegate(SetTexts), value);
                        }
                        catch { }
                    else
                    {
                        if (value.Substring(0,1).Equals("["))
                        {
                                    
                            // Seta a temperatura
                            if (value.Substring(1, 1).Equals("T") && value.Substring(2, 1).Equals("P"))
                            {
                                txbTemperatura.Text = value.Replace("[TP", "").Replace("]", "");
                            }

                            // Seta a Umidade
                            if (value.Substring(1, 1).Equals("U") && value.Substring(2, 1).Equals("M"))
                            {                           
                                txbUmidade.Text = value.Replace("[UM", "").Replace("]","");
                            }

                            // Seta a Distância
                            if (value.Substring(1, 1).Equals("D") && value.Substring(2, 1).Equals("T"))
                            {
                                txbDistancia.Text = value.Replace("[DT", "").Replace("]", "");
                            }

                            // Seta a Speed Motor
                            if (value.Substring(1, 1).Equals("S") && value.Substring(2, 1).Equals("M"))
                            {
                                txbSpeedMotor.Text = value.Replace("[SM", "").Replace("]", "");
                            }


                            // Seta o Peso
                            if (value.Substring(1, 1).Equals("P") && value.Substring(2, 1).Equals("S"))
                            {
                                txbPeso.Text = value.Replace("[PS", "").Replace("]", "");
                            }
                            // Seta o Nível
                            if (value.Substring(1, 1).Equals("N") && value.Substring(2, 1).Equals("V"))
                            {
                                txbNivel.Text = value.Replace("[NV", "").Replace("]", "");
                            }
                }
                    }
                }

                    private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
                    {
                        string indata = ConexaoSerial.Instancia.GetConexao().ReadExisting();
                        SetTexts(indata);
                    }
            #endregion

            // Setar Umidade
            #region SetUmidade
            public void SetUmidade(string value)
            {
                if (InvokeRequired)
                    try
                    {
                        Invoke(new SetTextDelegate(SetUmidade), value);
                    }
                    catch { }
                else
                {
                    if (value.Substring(0, 1).Equals("[")
                    && value.Substring(1, 1).Equals("U") && value.Substring(2, 1).Equals("M"))
                    {
                        value.Replace("[UM", "");
                        txbUmidade.Text = value;
                    }
                }       
            }
            private void DataReceivedHandlerUmidade(object sender, SerialDataReceivedEventArgs e)
            {
                string indata = ConexaoSerial.Instancia.GetConexao().ReadLine().ToString();
                SetUmidade(indata);
            }
            #endregion

            // Setar SpeedMotor
            #region SetSpeedMotor
            public void SetSpeedMotor(string value)
            {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(SetSpeedMotor), value);
                }
                catch { }
            else
                txbSpeedMotor.Text = value;
            }
            private void DataReceivedHandlerSpeedMotor(object sender, SerialDataReceivedEventArgs e)
            {
                string indata = ConexaoSerial.Instancia.GetConexao().ReadExisting();
                
                SetSpeedMotor(indata);
            }
        #endregion

        #endregion

        // Métodos Checkbox para os módulos de medição
        #region Checkbox

            // CheckBox Temperatura
            #region ckbTemperatura
            private void CkbTemperatura_CheckedChanged(object sender, EventArgs e)
            {
                if(ckbTemperatura.Checked==true)
                {
                    pnlModuloTemperatura.Visible = true;
                    pnlModuloTemperatura.Enabled = true;

                }
                else
                {
                    pnlModuloTemperatura.Visible = false;
                    pnlModuloTemperatura.Enabled = false;
                }
            }
            #endregion

            // CheckBox SpeedMotor
            #region ckbSpeedMotor
            private void CkbSpeedMotor_CheckedChanged(object sender, EventArgs e)
            {
                if (ckbSpeedMotor.Checked == true)
                {
                    pnlModuloSpeedMotor.Visible = true;
                    pnlModuloSpeedMotor.Enabled = true;

                }
                else
                {
                    pnlModuloSpeedMotor.Visible = false;
                    pnlModuloSpeedMotor.Enabled = false;
                }
            }
            #endregion

            // CheckBox Umidade
            #region ckbUmidade
            private void CkbUmidade_CheckedChanged(object sender, EventArgs e)
            {
                if (ckbUmidade.Checked == true)
                {
                    pnlModuloUmidade.Visible = true;
                    pnlModuloUmidade.Enabled = true;

                }
                else
                {
                    pnlModuloUmidade.Visible = false;
                    pnlModuloUmidade.Enabled = false;
                }
            }
            #endregion

            // CheckBox Distância
            #region ckbDistância
            private void CkbDistancia_CheckedChanged(object sender, EventArgs e)
            {
                if (ckbDistancia.Checked == true)
                {
                    pnlModuloDistancia.Visible = true;
                    pnlModuloDistancia.Enabled = true;

                }
                else
                {
                    pnlModuloDistancia.Visible = false;
                    pnlModuloDistancia.Enabled = false;
                }
            }
            #endregion

            // CheckBox Peso
            #region ckbPeso
            private void CkbPeso_CheckedChanged(object sender, EventArgs e)
            {
                if (ckbPeso.Checked == true)
                {
                    pnlModuloPeso.Visible = true;
                    pnlModuloPeso.Enabled = true;

                }
                else
                {
                    pnlModuloPeso.Visible = false;
                    pnlModuloPeso.Enabled = false;
                }
            }
            #endregion

            // CheckBox Nivel
            #region ckbNivel
            private void CkbNivel_CheckedChanged(object sender, EventArgs e)
            {
                if (ckbNivel.Checked == true)
                {
                    pnlModuloNivel.Visible = true;
                    pnlModuloNivel.Enabled = true;

                }
                else
                {
                    pnlModuloNivel.Visible = false;
                    pnlModuloNivel.Enabled = false;
                }
            }
            #endregion

        #endregion

        // Botões de "atualização" para recepção de dados 

    }
}

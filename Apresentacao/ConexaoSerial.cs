using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    public class ConexaoSerial
    {
        private ConexaoSerial() { }
        private static ConexaoSerial instancia;
        public SerialPort conexao = new SerialPort();
        public static ConexaoSerial Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new ConexaoSerial();
                }
                return instancia;
            }
        }

        public SerialPort GetConexao()
        {
           return conexao;
        }
    }
}

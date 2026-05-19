using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AppCsTp2Pwm
{
    // Classe qui gére la réception d’un signal
    public class ReceiveSignal : Signal
    {
        private int[] m_tb_trameReceived;

        public int[] TrameReceived
        {
            get => m_tb_trameReceived;
            set => m_tb_trameReceived = value;
        }

        public override int ReceptionSignal()
        {
            return 1;
        }

        public virtual int DecoderTrame(string trame)
        {
            return 1;
        }
    }
}

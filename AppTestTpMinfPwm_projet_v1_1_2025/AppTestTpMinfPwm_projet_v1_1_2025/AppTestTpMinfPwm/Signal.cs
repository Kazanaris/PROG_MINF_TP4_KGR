using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCsTp2Pwm
{
    public class Signal
    {
        protected ushort m_amplitude;
        protected ushort m_frequence;
        protected short m_offset;
        protected string[] m_tb_signal;

        public string[] TbSignal
        {
            get => m_tb_signal;
            set => m_tb_signal = value;
        }
        public ushort Amplitude
        {
            get => m_amplitude;
            set => m_amplitude = value;
        }

        public ushort Frequence
        {
            get => m_frequence;
            set => m_frequence = value;
        }

        public short Offset
        {
            get => m_offset;
            set => m_offset = value;
        }


        public virtual int EnvoyerSignal() { return 0; }
        public virtual int ReceptionSignal() { return 0; }
    }

   

    
}
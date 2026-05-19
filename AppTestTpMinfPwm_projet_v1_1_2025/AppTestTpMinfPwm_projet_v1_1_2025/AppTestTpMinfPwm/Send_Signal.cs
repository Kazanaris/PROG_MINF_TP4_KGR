using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace AppCsTp2Pwm
{
    // Classe pour gérer l’envoi d’un signal via une trame UART
    public class SendSignal : Signal
    {
        private bool m_sauvegarde;
        private char[] m_tb_trameSend;

        public SerialPort PortSerie { get; set; } // Port com utilisé pour l’envoi des trames

        public bool Sauvegarde
        {
            get => m_sauvegarde;
            set => m_sauvegarde = value;
        }

        public char[] TrameSend
        {
            get => m_tb_trameSend;
            set => m_tb_trameSend = value;
        }

        public int FormeIndex { get; set; } // L'index qui defini la forme selectionner

        private char[] formes = { 'S', 'T', 'D', 'C' }; // Caractere definissant la forme du signal
                                                        // S = Sinus
                                                        // T = Triangle
                                                        // D = Dent de scie 
                                                        // C = Carré




        // Construit une trame a envoyer à partir des signaux
        public string CoderTrame()
        {
            string offsetString;

            if (Offset >= 0)
            {
                offsetString = "+" + Offset.ToString("D2");
            }
            else
            {
                offsetString = Offset.ToString("D2");
            }

            string trame = string.Format("!S={0}F={1}A={2}O={3}W={4}#",
                                         formes[FormeIndex],
                                         Frequence,
                                         Amplitude,
                                         offsetString,
                                         Sauvegarde ? 1 : 0);

            m_tb_trameSend = trame.ToCharArray();
            return trame;
        }

        // Envoie la trame générée via le port série
        public override int EnvoyerSignal()
        {
            
            if (PortSerie != null && PortSerie.IsOpen)
            {
                try
                {
                    string trame = CoderTrame();
                    PortSerie.Write(trame);
                    return 1; // succès
                }
                catch
                {
                    return -1; // erreur d'envoi
                }
            }
            return 0; // port non ouvert ou null
        }
    }
}

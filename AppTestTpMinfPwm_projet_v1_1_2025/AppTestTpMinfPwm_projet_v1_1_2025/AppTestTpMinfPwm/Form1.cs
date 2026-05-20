// *************************************************
//
// Form1.cs
//
// Appli CS de pilotage du TP2 MINF
//
// 13.03.2025 SCA@etml-es
//
// *************************************************



using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text;
using System.Linq;
using System.Drawing;

namespace AppCsTp2Pwm
{
    public partial class Form1 : Form
    {

        string MessageTX;
        const int step_offset_amp = 100;
        const int step_freq = 20;

        public delegate void ReceiverD();
        public ReceiverD myDelegate;

        private int m_SendCount = 0;
        private const byte stx = 0x21;  // caractère de début de trame ('!')

        private SendSignal signal = new SendSignal();

        private bool btSaveValue = false;
        private bool isSaveMode_On_Or_Off = false;

        public Form1()
        {
            InitializeComponent();                                 // Initialise les composants graphiques
            string[] ports = SerialPort.GetPortNames();            // Récupère les ports COM disponibles
            cboPortNames.Items.AddRange(ports);                    // Affiche dans la liste déroulante
            if (ports.Length > 0) cboPortNames.SelectedIndex = 0;
            lstDataIn.Items.Clear();
            myDelegate = new ReceiverD(DispInListRxData);          // Associe méthode de réception
        }

        // Affiche un message TX dans la ListBox et conserve 10 derniers
        void DispTxMess(string message)
        {
            lstDataOut.Items.Add(message);
            if (lstDataOut.Items.Count > 10)
                lstDataOut.Items.RemoveAt(0);
        }

        // Compose la trame à envoyer en remplissant les propriétés de SendSignal
        void ComposeMessage()
        {
            signal.FormeIndex = cboFormes.SelectedIndex;
            signal.Frequence = Convert.ToUInt16(nudFrequence.Value);
            signal.Amplitude = Convert.ToUInt16(nudAmplitude.Value);
            signal.Offset = Convert.ToInt16(nudOffset.Value);
            signal.Sauvegarde = btSaveValue;
            if (cboFormes.SelectedIndex < 0)
            {
                MessageBox.Show("Veuillez sélectionner une forme de signal avant l'envoi.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = signal.CoderTrame();
            DispTxMess(message);
            MessageTX = message;
        }


        // Envoie la trame sur le port série
        void SendMessage(int count)
        {
            if (serialPort1.IsOpen)
            {
                ComposeMessage();
                try
                {
                    signal.PortSerie = serialPort1;
                    int resultat = signal.EnvoyerSignal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur à l'envoi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    timer1.Stop();
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
            }
            else
            {
                MessageBox.Show("Port non ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }
        }

        // Ouvre ou ferme le port série
        private void btOpenClose_Click(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();
            if (!availablePorts.Contains(serialPort1.PortName))        //Test de si le port est disponible
            {
                MessageBox.Show($"Le port sélectionné n'existe pas sur ce système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!serialPort1.IsOpen)
                {
                    // Paramètres de communication
                    serialPort1.PortName = (string)cboPortNames.SelectedItem;

                    try
                    {
                        serialPort1.Open(); // ouverture du port
                        btOpenClose.Text = "Close";
                        gbTx.Enabled = true;
                        cboPortNames.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Erreur à l'ouverture du port !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    serialPort1.Close(); // fermeture
                    btOpenClose.Text = "Open";
                    gbTx.Enabled = false;
                    cboPortNames.Enabled = true;
                    timer1.Stop();
                }
            }
            
        }

        // Déclenché automatiquement quand des données arrivent sur le port série
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lstDataIn.BeginInvoke(myDelegate); // appel en thread UI
        }

        // Affiche la trame reçue dans la liste RX
        public void DispInListRxData()
        {
            byte[] buffer = new byte[1024];
            int bytesRead = 0;
            int indexTrame = 0;
            byte[] RxMess = new byte[30];
            string RxMessage = "";

            try
            {
                bytesRead = serialPort1.Read(buffer, 0, buffer.Length);

                if (bytesRead > 0)
                {
                    int startIndex = Array.IndexOf(buffer, stx, 0, bytesRead); // cherche '!'
                    if (startIndex >= 0)
                    {
                        for (int i = startIndex; i < bytesRead && buffer[i] != '#'; i++)
                        {
                            RxMess[indexTrame++] = buffer[i];
                        }
                        if (indexTrame < RxMess.Length)
                        {
                            RxMess[indexTrame++] = (byte)'#';
                        }

                        RxMessage = Encoding.ASCII.GetString(RxMess, 0, indexTrame);
                        lstDataIn.Items.Add(RxMessage);
                        if (lstDataIn.Items.Count > 10)
                        {
                            lstDataIn.Items.RemoveAt(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la réception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton pour envoyer une seule trame
        private void btSend_Click(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();
            if (!availablePorts.Contains(serialPort1.PortName))            //Test de si le port est disponible
            {
                MessageBox.Show($"Le port {serialPort1.PortName} n'existe pas sur ce système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            m_SendCount = 0;
            SendMessage(m_SendCount);

            if (timer1.Enabled)
            {
                timer1.Stop();
            }
        }

        // Envoi automatique toutes les X ms si activé
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                m_SendCount++;
                SendMessage(m_SendCount);
            }
            else
            {
                btOpenClose.Text = "Open";
                gbTx.Enabled = false;
            }
        }

        private void Send_Cycle_Bt_Click(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();
            if (!availablePorts.Contains(serialPort1.PortName))            //Test de si le port est disponible
            {
                MessageBox.Show($"Le port {serialPort1.PortName} n'existe pas sur ce système.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (timer1.Enabled)
            {
                timer1.Stop();
                btSendContinuous.Text = " Non Continue " + Environment.NewLine + "[appuyez pour envoie continue]";
            }
            else
            {
                timer1.Interval = 25;
                m_SendCount = 0;
                timer1.Start();
                btSendContinuous.Text = "Envoie Continue" + Environment.NewLine + "[appuyez pour stopper l'envoie continue]";
            }
        }

        private void Save_Bt_Click(object sender, EventArgs e)
        {
            if (!isSaveMode_On_Or_Off)
            {
                btSaveValue = true;
                isSaveMode_On_Or_Off = true;
                btSave.Text = "Saved";
                gbRx.Enabled = true;
                SavedForme.Text = cboFormes.Text;
                SavedFrequence.Text = nudFrequence.Text;
                SavedAmplitude.Text = nudAmplitude.Text;
                SavedOffset.Text = nudOffset.Text;
            }
            else
            {
                btSaveValue = false;
                isSaveMode_On_Or_Off = false;
                btSave.Text = "Not Saved";
                gbRx.Enabled = false;
            }
        }

        private void CLose_Form1(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            try
            {
                serialPort1.Handshake = Handshake.None;
                serialPort1.DtrEnable = false;
                serialPort1.RtsEnable = false;
                serialPort1.DataReceived -= serialPort1_DataReceived;
                Thread.Sleep(200);
                if (serialPort1.IsOpen)
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur à la fermeture du port ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frequency_Value_Changed(object sender, EventArgs e)            
        {
            nudFrequence.Value = RoundToStep(nudFrequence.Value, step_freq);            //Arrondi la valeur de la fréquence à la valeur d'une step
        }

        private void Amplitude_Value_Changed(object sender, EventArgs e)
        {
            nudAmplitude.Value = RoundToStep(nudAmplitude.Value, step_offset_amp);      //Arrondi la valeur de l'Amplitude à la valeur d'une step

        }

        private void Offset_Value_Changed(object sender, EventArgs e)
        {
            nudOffset.Value = RoundToStep(nudOffset.Value, step_offset_amp);            //Arrondi la valeur de l'offset à la valeur d'une step
        }
        private decimal RoundToStep(decimal value, decimal step)
        {
            return Math.Round(value / step) * step;                                     //Calcule pour avoir la bonne valeur de l'arrondi
        }
        //Précédente tentative de régler le problème du port com pas disponible
        /*public class SerialPortHelper
        {
            public static bool IsPortAvailable(string portName)
            {
                // 1. Vérifier si le port existe physiquement/virtuellement sur la machine
                string[] availablePorts = SerialPort.GetPortNames();

                if (!availablePorts.Contains(portName))
                {
                    Console.WriteLine($"Le port {portName} n'existe pas sur ce système.");
                    return false;
                }

                // 2. Tenter d'ouvrir le port pour voir s'il est occupé par une autre application
                using (SerialPort testPort = new SerialPort(portName))
                {
                    try
                    {
                        testPort.Open();
                        testPort.Close(); // On le referme immédiatement si l'ouverture a réussi
                        return true;
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Le port existe mais est déjà ouvert par un autre programme
                        Console.WriteLine($"Le port {portName} est déjà utilisé.");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Autres erreurs possibles (ex: périphérique déconnecté subitement)
                        Console.WriteLine($"Erreur lors du test du port {portName} : {ex.Message}");
                        return false;
                    }
                }
            }
        }*/
    }
   

}




namespace AppCsTp2Pwm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.btOpenClose = new System.Windows.Forms.Button();
            this.cboPortNames = new System.Windows.Forms.ComboBox();
            this.gbTx = new System.Windows.Forms.GroupBox();
            this.cboFormes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOffset = new System.Windows.Forms.NumericUpDown();
            this.lstDataOut = new System.Windows.Forms.ListBox();
            this.btSendContinuous = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.chkBad = new System.Windows.Forms.CheckBox();
            this.nudAmplitude = new System.Windows.Forms.NumericUpDown();
            this.nudFrequence = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRx = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SavedOffset = new System.Windows.Forms.TextBox();
            this.SavedAmplitude = new System.Windows.Forms.TextBox();
            this.lstDataIn = new System.Windows.Forms.ListBox();
            this.SavedFrequence = new System.Windows.Forms.TextBox();
            this.SavedForme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSave = new System.Windows.Forms.Button();
            this.gbCom.SuspendLayout();
            this.gbTx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequence)).BeginInit();
            this.gbRx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.btOpenClose);
            this.gbCom.Controls.Add(this.cboPortNames);
            this.gbCom.Location = new System.Drawing.Point(12, 12);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(250, 70);
            this.gbCom.TabIndex = 20;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Réglages communication";
            // 
            // btOpenClose
            // 
            this.btOpenClose.Location = new System.Drawing.Point(16, 30);
            this.btOpenClose.Name = "btOpenClose";
            this.btOpenClose.Size = new System.Drawing.Size(75, 23);
            this.btOpenClose.TabIndex = 19;
            this.btOpenClose.Text = "Open";
            this.btOpenClose.UseVisualStyleBackColor = true;
            this.btOpenClose.Click += new System.EventHandler(this.btOpenClose_Click);
            // 
            // cboPortNames
            // 
            this.cboPortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPortNames.FormattingEnabled = true;
            this.cboPortNames.Location = new System.Drawing.Point(114, 32);
            this.cboPortNames.Margin = new System.Windows.Forms.Padding(2);
            this.cboPortNames.Name = "cboPortNames";
            this.cboPortNames.Size = new System.Drawing.Size(98, 21);
            this.cboPortNames.Sorted = true;
            this.cboPortNames.TabIndex = 17;
            // 
            // gbTx
            // 
            this.gbTx.Controls.Add(this.cboFormes);
            this.gbTx.Controls.Add(this.label4);
            this.gbTx.Controls.Add(this.label1);
            this.gbTx.Controls.Add(this.nudOffset);
            this.gbTx.Controls.Add(this.lstDataOut);
            this.gbTx.Controls.Add(this.btSendContinuous);
            this.gbTx.Controls.Add(this.btSend);
            this.gbTx.Controls.Add(this.chkBad);
            this.gbTx.Controls.Add(this.nudAmplitude);
            this.gbTx.Controls.Add(this.nudFrequence);
            this.gbTx.Controls.Add(this.label3);
            this.gbTx.Controls.Add(this.label2);
            this.gbTx.Enabled = false;
            this.gbTx.Location = new System.Drawing.Point(12, 88);
            this.gbTx.Name = "gbTx";
            this.gbTx.Size = new System.Drawing.Size(250, 420);
            this.gbTx.TabIndex = 21;
            this.gbTx.TabStop = false;
            this.gbTx.Text = "TX";
            // 
            // cboFormes
            // 
            this.cboFormes.FormattingEnabled = true;
            this.cboFormes.Items.AddRange(new object[] {
            "Sinus",
            "Triangle",
            "Dent de scie",
            "Carre"});
            this.cboFormes.Location = new System.Drawing.Point(156, 25);
            this.cboFormes.Name = "cboFormes";
            this.cboFormes.Size = new System.Drawing.Size(56, 21);
            this.cboFormes.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Offset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Amplitude";
            // 
            // nudOffset
            // 
            this.nudOffset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudOffset.Location = new System.Drawing.Point(156, 178);
            this.nudOffset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudOffset.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudOffset.Name = "nudOffset";
            this.nudOffset.Size = new System.Drawing.Size(56, 20);
            this.nudOffset.TabIndex = 58;
            this.nudOffset.ValueChanged += new System.EventHandler(this.Offset_Value_Changed);
            // 
            // lstDataOut
            // 
            this.lstDataOut.FormattingEnabled = true;
            this.lstDataOut.Location = new System.Drawing.Point(16, 281);
            this.lstDataOut.Margin = new System.Windows.Forms.Padding(2);
            this.lstDataOut.Name = "lstDataOut";
            this.lstDataOut.Size = new System.Drawing.Size(221, 134);
            this.lstDataOut.TabIndex = 56;
            // 
            // btSendContinuous
            // 
            this.btSendContinuous.Location = new System.Drawing.Point(137, 232);
            this.btSendContinuous.Name = "btSendContinuous";
            this.btSendContinuous.Size = new System.Drawing.Size(100, 23);
            this.btSendContinuous.TabIndex = 54;
            this.btSendContinuous.Text = "Envoi continu";
            this.btSendContinuous.UseVisualStyleBackColor = true;
            this.btSendContinuous.Click += new System.EventHandler(this.Send_Cycle_Bt_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(16, 232);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(100, 23);
            this.btSend.TabIndex = 52;
            this.btSend.Text = "Envoi";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // chkBad
            // 
            this.chkBad.AutoSize = true;
            this.chkBad.Location = new System.Drawing.Point(16, 260);
            this.chkBad.Margin = new System.Windows.Forms.Padding(2);
            this.chkBad.Name = "chkBad";
            this.chkBad.Size = new System.Drawing.Size(105, 17);
            this.chkBad.TabIndex = 49;
            this.chkBad.Text = "Trames erronées";
            this.chkBad.UseVisualStyleBackColor = true;
            // 
            // nudAmplitude
            // 
            this.nudAmplitude.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAmplitude.Location = new System.Drawing.Point(156, 129);
            this.nudAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.nudAmplitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmplitude.Name = "nudAmplitude";
            this.nudAmplitude.Size = new System.Drawing.Size(56, 20);
            this.nudAmplitude.TabIndex = 29;
            this.nudAmplitude.ValueChanged += new System.EventHandler(this.Amplitude_Value_Changed);
            // 
            // nudFrequence
            // 
            this.nudFrequence.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFrequence.Location = new System.Drawing.Point(156, 75);
            this.nudFrequence.Margin = new System.Windows.Forms.Padding(2);
            this.nudFrequence.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFrequence.Name = "nudFrequence";
            this.nudFrequence.Size = new System.Drawing.Size(56, 20);
            this.nudFrequence.TabIndex = 27;
            this.nudFrequence.ValueChanged += new System.EventHandler(this.Frequency_Value_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fréquence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Forme";
            // 
            // gbRx
            // 
            this.gbRx.Controls.Add(this.label8);
            this.gbRx.Controls.Add(this.label7);
            this.gbRx.Controls.Add(this.SavedOffset);
            this.gbRx.Controls.Add(this.SavedAmplitude);
            this.gbRx.Controls.Add(this.lstDataIn);
            this.gbRx.Controls.Add(this.SavedFrequence);
            this.gbRx.Controls.Add(this.SavedForme);
            this.gbRx.Controls.Add(this.label6);
            this.gbRx.Controls.Add(this.label5);
            this.gbRx.Enabled = false;
            this.gbRx.Location = new System.Drawing.Point(277, 88);
            this.gbRx.Name = "gbRx";
            this.gbRx.Size = new System.Drawing.Size(250, 420);
            this.gbRx.TabIndex = 22;
            this.gbRx.TabStop = false;
            this.gbRx.Text = "RX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Offset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Amplitude";
            // 
            // SavedOffset
            // 
            this.SavedOffset.Location = new System.Drawing.Point(147, 178);
            this.SavedOffset.Margin = new System.Windows.Forms.Padding(2);
            this.SavedOffset.Name = "SavedOffset";
            this.SavedOffset.ReadOnly = true;
            this.SavedOffset.Size = new System.Drawing.Size(61, 20);
            this.SavedOffset.TabIndex = 59;
            // 
            // SavedAmplitude
            // 
            this.SavedAmplitude.Location = new System.Drawing.Point(147, 129);
            this.SavedAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.SavedAmplitude.Name = "SavedAmplitude";
            this.SavedAmplitude.ReadOnly = true;
            this.SavedAmplitude.Size = new System.Drawing.Size(61, 20);
            this.SavedAmplitude.TabIndex = 58;
            // 
            // lstDataIn
            // 
            this.lstDataIn.FormattingEnabled = true;
            this.lstDataIn.Location = new System.Drawing.Point(16, 281);
            this.lstDataIn.Margin = new System.Windows.Forms.Padding(2);
            this.lstDataIn.Name = "lstDataIn";
            this.lstDataIn.Size = new System.Drawing.Size(221, 134);
            this.lstDataIn.TabIndex = 52;
            // 
            // SavedFrequence
            // 
            this.SavedFrequence.Location = new System.Drawing.Point(147, 75);
            this.SavedFrequence.Margin = new System.Windows.Forms.Padding(2);
            this.SavedFrequence.Name = "SavedFrequence";
            this.SavedFrequence.ReadOnly = true;
            this.SavedFrequence.Size = new System.Drawing.Size(61, 20);
            this.SavedFrequence.TabIndex = 57;
            // 
            // SavedForme
            // 
            this.SavedForme.Location = new System.Drawing.Point(147, 26);
            this.SavedForme.Margin = new System.Windows.Forms.Padding(2);
            this.SavedForme.Name = "SavedForme";
            this.SavedForme.ReadOnly = true;
            this.SavedForme.Size = new System.Drawing.Size(61, 20);
            this.SavedForme.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Fréquence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Forme";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 70);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sauvegarde";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(16, 30);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.Save_Bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbRx);
            this.Controls.Add(this.gbTx);
            this.Controls.Add(this.gbCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "App de test TP MINF PWM";
            this.gbCom.ResumeLayout(false);
            this.gbTx.ResumeLayout(false);
            this.gbTx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrequence)).EndInit();
            this.gbRx.ResumeLayout(false);
            this.gbRx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.ComboBox cboPortNames;
        private System.Windows.Forms.GroupBox gbTx;
        private System.Windows.Forms.CheckBox chkBad;
        private System.Windows.Forms.NumericUpDown nudAmplitude;
        private System.Windows.Forms.NumericUpDown nudFrequence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOpenClose;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btSendContinuous;
        private System.Windows.Forms.GroupBox gbRx;
        private System.Windows.Forms.ListBox lstDataIn;
        private System.Windows.Forms.TextBox SavedFrequence;
        private System.Windows.Forms.TextBox SavedForme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDataOut;
        private System.Windows.Forms.ComboBox cboFormes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOffset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SavedOffset;
        private System.Windows.Forms.TextBox SavedAmplitude;
    }
}


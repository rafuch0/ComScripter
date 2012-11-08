namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.sendData = new System.Windows.Forms.Button();
            this.txtRcv = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbCommPort = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmbRcvDelay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReadTimeout = 1;
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(4, 49);
            this.txtCmd.Multiline = true;
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCmd.Size = new System.Drawing.Size(602, 264);
            this.txtCmd.TabIndex = 6;
            // 
            // sendData
            // 
            this.sendData.Location = new System.Drawing.Point(531, 26);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(75, 20);
            this.sendData.TabIndex = 8;
            this.sendData.Text = "Send Data";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // txtRcv
            // 
            this.txtRcv.Location = new System.Drawing.Point(4, 319);
            this.txtRcv.MaxLength = 1280000;
            this.txtRcv.Multiline = true;
            this.txtRcv.Name = "txtRcv";
            this.txtRcv.ReadOnly = true;
            this.txtRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRcv.Size = new System.Drawing.Size(602, 154);
            this.txtRcv.TabIndex = 9;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(87, 26);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(54, 20);
            this.txtBaudRate.TabIndex = 1;
            this.txtBaudRate.Text = "9600";
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(147, 26);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(42, 20);
            this.txtDataBits.TabIndex = 2;
            this.txtDataBits.Text = "8";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(195, 25);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(80, 21);
            this.cmbParity.TabIndex = 3;
            this.cmbParity.Text = "None";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.cmbStopBits.Location = new System.Drawing.Point(281, 25);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(83, 21);
            this.cmbStopBits.TabIndex = 4;
            this.cmbStopBits.Text = "One";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(449, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 20);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbCommPort
            // 
            this.cmbCommPort.FormattingEnabled = true;
            this.cmbCommPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.cmbCommPort.Location = new System.Drawing.Point(4, 25);
            this.cmbCommPort.Name = "cmbCommPort";
            this.cmbCommPort.Size = new System.Drawing.Size(77, 21);
            this.cmbCommPort.TabIndex = 0;
            this.cmbCommPort.Text = "COM1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 479);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(602, 18);
            this.progressBar1.TabIndex = 10;
            // 
            // cmbRcvDelay
            // 
            this.cmbRcvDelay.FormattingEnabled = true;
            this.cmbRcvDelay.Items.AddRange(new object[] {
            "0",
            "10",
            "25",
            "50",
            "75",
            "100",
            "250",
            "333",
            "500",
            "666",
            "888",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000"});
            this.cmbRcvDelay.Location = new System.Drawing.Point(371, 25);
            this.cmbRcvDelay.Name = "cmbRcvDelay";
            this.cmbRcvDelay.Size = new System.Drawing.Size(72, 21);
            this.cmbRcvDelay.TabIndex = 5;
            this.cmbRcvDelay.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "DataBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "StopBits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rcv Delay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Clear RCV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Send Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 497);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRcvDelay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmbCommPort);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbStopBits);
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtRcv);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.txtCmd);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(615, 524);
            this.Name = "Form1";
            this.Text = "ComScripter";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox txtRcv;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbCommPort;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cmbRcvDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


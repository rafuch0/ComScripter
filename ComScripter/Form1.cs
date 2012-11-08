using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbCommPort.Text;
            serialPort1.BaudRate = Convert.ToInt16(txtBaudRate.Text);
            serialPort1.DataBits = Convert.ToInt16(txtDataBits.Text);

            switch (cmbParity.Text)
            {
                default:
                case "None":
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    break;
                case "Odd":
                    serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    break;
                case "Even":
                    serialPort1.Parity = System.IO.Ports.Parity.Even;
                    break;
                case "Mark":
                    serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    break;
                case "Space":
                    serialPort1.Parity = System.IO.Ports.Parity.Space;
                    break;
            }

            switch (cmbStopBits.Text)
            {
                default:
                case "None":
                    serialPort1.StopBits = System.IO.Ports.StopBits.None;
                    break;
                case "One":
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    break;
                case "OnePointFive":
                    serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    break;
                case "Two":
                    serialPort1.StopBits = System.IO.Ports.StopBits.Two;
                    break;
            }

            string[] cmds = Regex.Split(txtCmd.Text, "\r\n");
            var interval = 100 / (cmds.Length);
            var progress = 0;

            serialPort1.Open();
            System.Threading.Thread.Sleep(1000);

            foreach(String cmd in cmds)
            {
                progress += interval;
                progressBar1.Value = progress;

                Match match = Regex.Match(cmd, "sleep([0-9]+)");
                if (match.Success)
                {
                    System.Threading.Thread.Sleep(Convert.ToInt16(match.Groups[1].Value));
                }
                else
                {
                    serialPort1.WriteLine(cmd);
                }

                System.Threading.Thread.Sleep(Convert.ToInt16(cmbRcvDelay.Text));
                txtRcv.AppendText((serialPort1.ReadExisting()).Replace("\n", "\r\n"));
            }

            progressBar1.Value = 100;
            
            serialPort1.Close();

            for (var i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(175);
                progressBar1.Value = 0;
                System.Threading.Thread.Sleep(175);
                progressBar1.Value = 100;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRcv.Text = "";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control control = (Control) sender;

            var newWidth = control.Size.Width;
            var newHeight = control.Size.Height;

            txtRcv.Width = newWidth - 13;
            txtCmd.Width = newWidth - 13;
            progressBar1.Width = newWidth - 13;

            txtCmd.Height = Convert.ToInt16((newHeight - 106)* 0.63);
            txtRcv.Height = Convert.ToInt16((newHeight - 106)* 0.37);
            txtRcv.Top = txtCmd.Bottom + 3;
            progressBar1.Top = txtRcv.Bottom + 3;
        }
    }
}

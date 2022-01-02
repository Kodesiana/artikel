//     MainForm.cs is part of PBXListener.
//     Copyright (C) 2018  Fahmi Noor Fiqri
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <https://www.gnu.org/licenses/>.

#region

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

#endregion

namespace PBXListener.CSharpDemo
{
    public partial class MainForm : Form
    {
        private readonly BindingList<PbxMessage> _messageSource;
        private readonly PbxSerialPort _pbxSerialPort;

        public MainForm()
        {
            InitializeComponent();
            
            _messageSource = new BindingList<PbxMessage>();
            dgvData.DataSource = _messageSource;

            _pbxSerialPort = new PbxSerialPort();
            _pbxSerialPort.MessageReceived += PbxSerialPort_MessageReceived;
            propSerial.SelectedObject = _pbxSerialPort;
        }

        private void PbxSerialPort_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            _messageSource.Add((PbxMessage) e.Message);
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            lstPort.DataSource = SerialPort.GetPortNames();
        }

        private void cmdHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(cmdHomepage.Text);
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _pbxSerialPort.Open();
                cmdConnect.Enabled = false;
                cmdDisconnect.Enabled = true;
                lblStatus.Text = "Connected.";
                lblStatus.ForeColor = Color.DodgerBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                _pbxSerialPort.Close();
                cmdConnect.Enabled = true;
                cmdDisconnect.Enabled = false;
                lblStatus.Text = "Disconnected.";
                lblStatus.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

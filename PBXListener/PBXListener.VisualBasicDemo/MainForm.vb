'     MainForm.vb is part of PBXListener.
'     Copyright (C) 2018  Fahmi Noor Fiqri
' 
'     This program is free software: you can redistribute it and/or modify
'     it under the terms of the GNU General Public License as published by
'     the Free Software Foundation, either version 3 of the License, or
'     (at your option) any later version.
' 
'     This program is distributed in the hope that it will be useful,
'     but WITHOUT ANY WARRANTY; without even the implied warranty of
'     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'     GNU General Public License for more details.
' 
'     You should have received a copy of the GNU General Public License
'     along with this program.  If not, see <https:'www.gnu.org/licenses/>.

Imports System.ComponentModel
Imports System.IO.Ports

Public Class MainForm
    Private ReadOnly _messageSource As BindingList(Of PbxMessage)
    Private ReadOnly _pbxSerialPort As PbxSerialPort

    Public Sub New()
        InitializeComponent()

        _messageSource = New BindingList(Of PbxMessage)
        dgvData.DataSource = _messageSource

        _pbxSerialPort = New PbxSerialPort()
        AddHandler _pbxSerialPort.MessageReceived, AddressOf PbxSerialPort_MessageReceived
        propSerial.SelectedObject = _pbxSerialPort
    End Sub

    Private Sub PbxSerialPort_MessageReceived(sender As Object, e As MessageReceivedEventArgs)
        _messageSource.Add(DirectCast(e.Message, PbxMessage))
    End Sub

    Private Sub cmdScan_Click(sender As Object, e As EventArgs) Handles cmdScan.Click
        lstPort.DataSource = SerialPort.GetPortNames()
    End Sub

    Private Sub cmdHomepage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdHomepage.LinkClicked
        Process.Start(cmdHomepage.Text)
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        Try
            _pbxSerialPort.Open
            cmdConnect.Enabled = False
            cmdDisconnect.Enabled = True
            lblStatus.Text = "Connected."
            lblStatus.ForeColor = Color.DodgerBlue
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cmdDisconnect_Click(sender As Object, e As EventArgs) Handles cmdDisconnect.Click
        Try
            _pbxSerialPort.Close
            cmdConnect.Enabled = True
            cmdDisconnect.Enabled = False
            lblStatus.Text = "Disconnected."
            lblStatus.ForeColor = Color.Red
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class

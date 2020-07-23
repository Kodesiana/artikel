<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmdHomepage = New System.Windows.Forms.LinkLabel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.propSerial = New System.Windows.Forms.PropertyGrid()
        Me.cmdDisconnect = New System.Windows.Forms.Button()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.cmdScan = New System.Windows.Forms.Button()
        Me.lstPort = New System.Windows.Forms.ListBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout
        Me.tabControl1.SuspendLayout
        Me.tabPage1.SuspendLayout
        CType(Me.dgvData,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabPage3.SuspendLayout
        Me.SuspendLayout
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Black
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.cmdHomepage)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.ForeColor = System.Drawing.Color.White
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(517, 74)
        Me.panel1.TabIndex = 9
        '
        'label4
        '
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(360, 53)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(150, 13)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Licensed under GPL version 3"
        '
        'cmdHomepage
        '
        Me.cmdHomepage.AutoSize = true
        Me.cmdHomepage.LinkColor = System.Drawing.Color.White
        Me.cmdHomepage.Location = New System.Drawing.Point(395, 27)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(115, 13)
        Me.cmdHomepage.TabIndex = 3
        Me.cmdHomepage.TabStop = true
        Me.cmdHomepage.Text = "https://kodesiana.com"
        '
        'label3
        '
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(337, 10)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(173, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Copyright (C) Fahmi Noor Fiqri 2018"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(19, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(152, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "PBX logger using C#/VB.NET."
        '
        'label1
        '
        Me.label1.AutoSize = true
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label1.Location = New System.Drawing.Point(12, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(268, 31)
        Me.label1.TabIndex = 0
        Me.label1.Text = "PBX Listener Demo"
        '
        'propSerial
        '
        Me.propSerial.LineColor = System.Drawing.SystemColors.ControlDark
        Me.propSerial.Location = New System.Drawing.Point(12, 88)
        Me.propSerial.Name = "propSerial"
        Me.propSerial.Size = New System.Drawing.Size(188, 240)
        Me.propSerial.TabIndex = 8
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.Enabled = false
        Me.cmdDisconnect.Location = New System.Drawing.Point(302, 305)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.cmdDisconnect.TabIndex = 7
        Me.cmdDisconnect.Text = "Disconnect"
        Me.cmdDisconnect.UseVisualStyleBackColor = true
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(221, 305)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnect.TabIndex = 6
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = true
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Location = New System.Drawing.Point(217, 88)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(288, 211)
        Me.tabControl1.TabIndex = 10
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.dgvData)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(280, 185)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Received data"
        Me.tabPage1.UseVisualStyleBackColor = true
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = false
        Me.dgvData.AllowUserToDeleteRows = false
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(6, 6)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = true
        Me.dgvData.Size = New System.Drawing.Size(268, 173)
        Me.dgvData.TabIndex = 0
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.cmdScan)
        Me.tabPage3.Controls.Add(Me.lstPort)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(280, 185)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "Port scanner"
        Me.tabPage3.UseVisualStyleBackColor = true
        '
        'cmdScan
        '
        Me.cmdScan.Location = New System.Drawing.Point(180, 34)
        Me.cmdScan.Name = "cmdScan"
        Me.cmdScan.Size = New System.Drawing.Size(75, 23)
        Me.cmdScan.TabIndex = 1
        Me.cmdScan.Text = "Scan"
        Me.cmdScan.UseVisualStyleBackColor = true
        '
        'lstPort
        '
        Me.lstPort.FormattingEnabled = true
        Me.lstPort.Location = New System.Drawing.Point(6, 6)
        Me.lstPort.Name = "lstPort"
        Me.lstPort.Size = New System.Drawing.Size(150, 173)
        Me.lstPort.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = true
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(388, 309)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(89, 13)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Disconnected."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 340)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.propSerial)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.lblStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "MainForm"
        Me.Text = "PBX Listener Demo"
        Me.panel1.ResumeLayout(false)
        Me.panel1.PerformLayout
        Me.tabControl1.ResumeLayout(false)
        Me.tabPage1.ResumeLayout(false)
        CType(Me.dgvData,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabPage3.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label4 As Label
    Private WithEvents cmdHomepage As LinkLabel
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents propSerial As PropertyGrid
    Private WithEvents cmdDisconnect As Button
    Private WithEvents cmdConnect As Button
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents dgvData As DataGridView
    Private WithEvents tabPage3 As TabPage
    Private WithEvents cmdScan As Button
    Private WithEvents lstPort As ListBox
    Private WithEvents lblStatus As Label
End Class

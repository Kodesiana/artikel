<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoForm
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
        Me.cmdNextPage = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.lblPageTotal = New System.Windows.Forms.Label()
        Me.cmdFirstPage = New System.Windows.Forms.Button()
        Me.cmdPrevPage = New System.Windows.Forms.Button()
        Me.cmdLastPage = New System.Windows.Forms.Button()
        Me.cboTheme = New System.Windows.Forms.ComboBox()
        Me.chkDoubleBuffer = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmdHomepage = New System.Windows.Forms.LinkLabel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.SuspendLayout
        '
        'cmdNextPage
        '
        Me.cmdNextPage.FlatAppearance.BorderSize = 0
        Me.cmdNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNextPage.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.cmdNextPage.Location = New System.Drawing.Point(166, 3)
        Me.cmdNextPage.Name = "cmdNextPage"
        Me.cmdNextPage.Size = New System.Drawing.Size(30, 30)
        Me.cmdNextPage.TabIndex = 0
        Me.cmdNextPage.Text = ">"
        Me.cmdNextPage.UseVisualStyleBackColor = true
        '
        'dgv
        '
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 130)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(736, 353)
        Me.dgv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(19, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tema:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.txtPage)
        Me.Panel1.Controls.Add(Me.lblPageTotal)
        Me.Panel1.Controls.Add(Me.cmdFirstPage)
        Me.Panel1.Controls.Add(Me.cmdPrevPage)
        Me.Panel1.Controls.Add(Me.cmdLastPage)
        Me.Panel1.Controls.Add(Me.cmdNextPage)
        Me.Panel1.Location = New System.Drawing.Point(505, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 36)
        Me.Panel1.TabIndex = 3
        '
        'txtPage
        '
        Me.txtPage.Location = New System.Drawing.Point(83, 7)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(28, 23)
        Me.txtPage.TabIndex = 4
        Me.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPageTotal
        '
        Me.lblPageTotal.BackColor = System.Drawing.Color.White
        Me.lblPageTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPageTotal.Location = New System.Drawing.Point(110, 7)
        Me.lblPageTotal.Name = "lblPageTotal"
        Me.lblPageTotal.Size = New System.Drawing.Size(50, 23)
        Me.lblPageTotal.TabIndex = 5
        Me.lblPageTotal.Text = "dari 0"
        Me.lblPageTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdFirstPage
        '
        Me.cmdFirstPage.FlatAppearance.BorderSize = 0
        Me.cmdFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFirstPage.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.cmdFirstPage.Location = New System.Drawing.Point(3, 3)
        Me.cmdFirstPage.Name = "cmdFirstPage"
        Me.cmdFirstPage.Size = New System.Drawing.Size(38, 30)
        Me.cmdFirstPage.TabIndex = 3
        Me.cmdFirstPage.Text = "<<"
        Me.cmdFirstPage.UseVisualStyleBackColor = true
        '
        'cmdPrevPage
        '
        Me.cmdPrevPage.FlatAppearance.BorderSize = 0
        Me.cmdPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrevPage.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.cmdPrevPage.Location = New System.Drawing.Point(47, 3)
        Me.cmdPrevPage.Name = "cmdPrevPage"
        Me.cmdPrevPage.Size = New System.Drawing.Size(30, 30)
        Me.cmdPrevPage.TabIndex = 2
        Me.cmdPrevPage.Text = "<"
        Me.cmdPrevPage.UseVisualStyleBackColor = true
        '
        'cmdLastPage
        '
        Me.cmdLastPage.FlatAppearance.BorderSize = 0
        Me.cmdLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLastPage.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Bold)
        Me.cmdLastPage.Location = New System.Drawing.Point(202, 3)
        Me.cmdLastPage.Name = "cmdLastPage"
        Me.cmdLastPage.Size = New System.Drawing.Size(38, 30)
        Me.cmdLastPage.TabIndex = 1
        Me.cmdLastPage.Text = ">>"
        Me.cmdLastPage.UseVisualStyleBackColor = true
        '
        'cboTheme
        '
        Me.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTheme.FormattingEnabled = true
        Me.cboTheme.Items.AddRange(New Object() {"Green", "Mars"})
        Me.cboTheme.Location = New System.Drawing.Point(84, 93)
        Me.cboTheme.Name = "cboTheme"
        Me.cboTheme.Size = New System.Drawing.Size(155, 23)
        Me.cboTheme.TabIndex = 4
        '
        'chkDoubleBuffer
        '
        Me.chkDoubleBuffer.AutoSize = true
        Me.chkDoubleBuffer.Location = New System.Drawing.Point(257, 95)
        Me.chkDoubleBuffer.Name = "chkDoubleBuffer"
        Me.chkDoubleBuffer.Size = New System.Drawing.Size(156, 19)
        Me.chkDoubleBuffer.TabIndex = 5
        Me.chkDoubleBuffer.Text = "Double Buffer (Anti-Lag)"
        Me.chkDoubleBuffer.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.label4)
        Me.Panel2.Controls.Add(Me.cmdHomepage)
        Me.Panel2.Controls.Add(Me.label3)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 74)
        Me.Panel2.TabIndex = 10
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label4.AutoSize = true
        Me.label4.Location = New System.Drawing.Point(587, 52)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(161, 15)
        Me.label4.TabIndex = 4
        Me.label4.Text = "Licensed under GPL version 3"
        '
        'cmdHomepage
        '
        Me.cmdHomepage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmdHomepage.AutoSize = true
        Me.cmdHomepage.LinkColor = System.Drawing.Color.White
        Me.cmdHomepage.Location = New System.Drawing.Point(621, 26)
        Me.cmdHomepage.Name = "cmdHomepage"
        Me.cmdHomepage.Size = New System.Drawing.Size(127, 15)
        Me.cmdHomepage.TabIndex = 3
        Me.cmdHomepage.TabStop = true
        Me.cmdHomepage.Text = "https://kodesiana.com"
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = true
        Me.label3.Location = New System.Drawing.Point(550, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(198, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Copyright (C) Fahmi Noor Fiqri 2018"
        '
        'label2
        '
        Me.label2.AutoSize = true
        Me.label2.Location = New System.Drawing.Point(19, 46)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(267, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "DataGridView extension for pagination and styles."
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(345, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DataGridEnhanced Demo"
        '
        'DemoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 495)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkDoubleBuffer)
        Me.Controls.Add(Me.cboTheme)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Segoe UI", 9!)
        Me.Name = "DemoForm"
        Me.Text = "Kodesiana DataGridEnhanced"
        CType(Me.dgv,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents cmdNextPage As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdFirstPage As Button
    Friend WithEvents cmdPrevPage As Button
    Friend WithEvents cmdLastPage As Button
    Friend WithEvents cboTheme As ComboBox
    Friend WithEvents txtPage As TextBox
    Friend WithEvents lblPageTotal As Label
    Friend WithEvents chkDoubleBuffer As CheckBox
    Private WithEvents Panel2 As Panel
    Private WithEvents label4 As Label
    Private WithEvents cmdHomepage As LinkLabel
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents Label5 As Label
End Class

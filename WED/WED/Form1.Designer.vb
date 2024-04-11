<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtbReceived = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtTransmit = New System.Windows.Forms.TextBox()
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rtbReceived)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 287)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 125)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Received Data"
        '
        'rtbReceived
        '
        Me.rtbReceived.Location = New System.Drawing.Point(20, 15)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(322, 96)
        Me.rtbReceived.TabIndex = 0
        Me.rtbReceived.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSend)
        Me.GroupBox1.Controls.Add(Me.txtTransmit)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 119)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transmit Data"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(348, 43)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 45)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtTransmit
        '
        Me.txtTransmit.Location = New System.Drawing.Point(20, 19)
        Me.txtTransmit.Multiline = True
        Me.txtTransmit.Name = "txtTransmit"
        Me.txtTransmit.Size = New System.Drawing.Size(322, 94)
        Me.txtTransmit.TabIndex = 0
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Location = New System.Drawing.Point(218, 96)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cmbBaud.TabIndex = 29
        '
        'cmbPort
        '
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(218, 39)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "BAUD RATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "COMM PORT"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(370, 94)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 25
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(370, 37)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 24
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.cmbPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frmMain"
        Me.Text = "frm main"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rtbReceived As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSend As Button
    Friend WithEvents txtTransmit As TextBox
    Friend WithEvents cmbBaud As ComboBox
    Friend WithEvents cmbPort As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class

Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports

Public Class frmMain
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        cmbBaud.Items.Add(9600)
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)
        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)
        cmbBaud.Text = cmbBaud.Items.Item(0)
        btnDisconnect.Enabled = False
    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        SerialPort1.PortName = cmbPort.Text
        SerialPort1.BaudRate = cmbBaud.Text
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Open()
        btnConnect.Enabled = False
        btnDisconnect.Enabled = True
    End Sub
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        SerialPort1.Close()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
    End Sub
    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        SerialPort1.Write(txtTransmit.Text)
    End Sub
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub
    Private Sub ReceivedText(ByVal [text] As String)
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.rtbReceived.Text &= [text]
        End If
    End Sub
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPort.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBaud.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text
        Else
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
End Class
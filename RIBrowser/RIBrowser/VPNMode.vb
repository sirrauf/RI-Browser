Imports System.Runtime.InteropServices
Public Class VPNMode
    Private Sub VPNMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    <Runtime.InteropServices.DllImport("wininet.dll", SetLastError:=True)>
    Private Shared Function InternetSetOption(ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    End Function

    Public Structure Struct_INTERNET_PROXY_INFO
        Public dwAccessType As Integer
        Public proxy As IntPtr
        Public proxyBypass As IntPtr
    End Structure

    Private Sub UseProxy(ByVal strProxy As String)
        Const INTERNET_OPTION_PROXY As Integer = 38
        Const INTERNET_OPEN_TYPE_PROXY As Integer = 3

        Dim struct_IPI As Struct_INTERNET_PROXY_INFO

        struct_IPI.dwAccessType = INTERNET_OPEN_TYPE_PROXY
        struct_IPI.proxy = Marshal.StringToHGlobalAnsi(strProxy)
        struct_IPI.proxyBypass = Marshal.StringToHGlobalAnsi("local")

        Dim intptrStruct As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_IPI))

        Marshal.StructureToPtr(struct_IPI, intptrStruct, True)

        Dim iReturn As Boolean = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_PROXY, intptrStruct, System.Runtime.InteropServices.Marshal.SizeOf(struct_IPI))
    End Sub
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonQuit.Click
        Dim confirmation
        confirmation = MsgBox("Are you sure quit ?", vbQuestion + vbYesNo, "Confirmation")
        If confirmation = vbYes Then
            Close()
        Else

            Me.Show()
        End If
    End Sub

    Private Sub ButtonGermany_Click(sender As Object, e As EventArgs) Handles ButtonGermany.Click
        Dim confirmation
        confirmation = MsgBox("Are you sure using ip address germany ?", vbQuestion + vbYesNo, "Confirmation")
        If confirmation = vbYes Then
            IPBox1.Text = "88.198.50.103"
            PortBox1.Text = "8080"
            UseProxy(IPBox1.Text & ":" & PortBox1.Text)
            LabelGermany.Text = "Connected"

            MessageBox.Show("Connected Germany Successfull")
        Else
            Dim no
            no = vbNo


            IPBox1.Text = "125.161.86.148"
            PortBox1.Text = "80"
            UseProxy(IPBox1.Text & ":" & PortBox1.Text)
            LabelGermany.Text = "Germany"
            MessageBox.Show("Disconnected Germany Successfull")

        End If
    End Sub



End Class
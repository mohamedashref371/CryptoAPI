Imports System.Text

Public Class Form2
    Public I As String = "/QyRPsw/wkyXM9hxsdNRWYjTudxajEMobS0fjwSNIRs="
    Public Dr As String = "RURV5Yb2ZDo3vS+qQyRAouDp5k1xa6p2rJXkiwVGpI0="
    Dim encoding As Encoding = Encoding.UTF8

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        Process.Start(encoding.GetString(CryptoAPI.CaesarShift(encoding.GetBytes("kwwsv=22idfherrn1frp2Prkdphg6:4664:"), -3)))
    End Sub
End Class
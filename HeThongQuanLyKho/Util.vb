Imports System.Text
Imports System.Security.Cryptography
Module Util
    Public Function MaHoa(ByVal chuoi As String) As String
        Dim kq As String
        Dim maybam As MD5 = MD5.Create
        Dim chuoibam() As Byte
        chuoibam = maybam.ComputeHash(Encoding.UTF8.GetBytes(chuoi))
        Dim chuoimahoa As StringBuilder = New StringBuilder
        For i As Integer = 0 To chuoibam.Length - 1
            chuoimahoa.Append(chuoibam(i).ToString("X3"))
        Next
        kq = chuoimahoa.ToString
        Return kq
    End Function
    Public Sub XoaDuLieuTxb(ByRef mh As Form)
        For Each clts As Control In mh.Controls()
            If TypeName(clts).ToLower = "panel" Or TypeName(clts).ToLower = "splitcontainer" Then
                For Each chau As Control In clts.Controls
                    If TypeName(chau).ToLower = "textbox" Then
                        chau.ResetText()
                    End If
                Next
            Else
                If TypeName(clts).ToLower = "textbox" Then
                    clts.ResetText()
                End If
            End If
        Next
    End Sub
End Module

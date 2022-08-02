Imports System.Windows.Forms

Public Class NTextBox
    Inherits TextBox
    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        'MyBase.OnKeyPress(e)
        If Not (e.KeyChar >= "0"c And e.KeyChar <= "9"c) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 44 And Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 127 Then
            e.Handled = True
        End If
    End Sub

End Class

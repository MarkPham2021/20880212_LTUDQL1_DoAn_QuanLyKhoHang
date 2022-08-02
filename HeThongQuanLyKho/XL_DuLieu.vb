Imports System.Data.SqlClient

Public Class XL_DuLieu
    Const chuoiketnoi As String = "Server=localhost\SQLEXPRESS;Database=HeThongQuanLyKho;Trusted_Connection=True"
    Function DocDuLieu(cautruyvan As String) As DataTable
        Dim ketnoicsdl As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim xuly As SqlCommand = New SqlCommand(cautruyvan, ketnoicsdl)
        Dim bangdulieu As DataTable = New DataTable()
        Dim dongbo As SqlDataAdapter = New SqlDataAdapter(xuly)
        dongbo.Fill(bangdulieu)
        Return bangdulieu
    End Function
    Function DocCauTruc(cautruyvan As String) As DataTable
        Dim ketnoicsdl As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim xuly As SqlCommand = New SqlCommand(cautruyvan, ketnoicsdl)
        Dim bangdulieu As DataTable = New DataTable()
        Dim dongbo As SqlDataAdapter = New SqlDataAdapter(xuly)
        dongbo.FillSchema(bangdulieu, SchemaType.Source)
        Return bangdulieu
    End Function
    Sub GhiDuLieu(tenbang As String, dulieu As DataTable)
        Dim ketnoicsdl As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim xuly As SqlCommand = New SqlCommand("select * from " + tenbang, ketnoicsdl)
        Dim dongbo As SqlDataAdapter = New SqlDataAdapter(xuly)
        Dim khoitao As SqlCommandBuilder = New SqlCommandBuilder(dongbo)
        AddHandler dongbo.RowUpdated, AddressOf CapNhatMaSo
        dongbo.Update(dulieu)
    End Sub
    Sub GhiDuLieuTuDo(cautruyvan As String, dulieu As DataTable)
        Dim ketnoicsdl As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim xuly As SqlCommand = New SqlCommand(cautruyvan, ketnoicsdl)
        Dim dongbo As SqlDataAdapter = New SqlDataAdapter(xuly)
        Dim khoitao As SqlCommandBuilder = New SqlCommandBuilder(dongbo)
        AddHandler dongbo.RowUpdated, AddressOf CapNhatMaSo
        dongbo.Update(dulieu)
    End Sub
    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        Dim Ket_noi As SqlConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim Lenh As SqlCommand = New SqlCommand("Select @@IDENTITY", Ket_noi)
            Dim ma_so As Integer = Integer.Parse(Lenh.ExecuteScalar())
            e.Row(0) = ma_so
        End If
    End Sub
End Class

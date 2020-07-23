Imports KF.DataGridEnhanced.Styles

Public Class DemoForm
    Private _datagridEnhanced As EnhancedDataGridView

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Buat instance baru untuk setiap services
        _datagridEnhanced = New EnhancedDataGridView

        ' Set datagridview
        _datagridEnhanced.SetDataGridView(dgv)

        ' Set connectionstring dan tabel
        _datagridEnhanced.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=WiyataBhakti;Integrated Security=True"
        _datagridEnhanced.TableName = "Product"      ' nama tabel
        _datagridEnhanced.OrderColumn = "ProductId"  ' primary key atau kolom lain untuk ordering
        _datagridEnhanced.PageSize = 20              ' jumlah entri per halaman
        _datagridEnhanced.ReloadData()               ' reload data, hanya panggil 1 kali sebelum ambil data

        AddHandler _datagridEnhanced.PageSwitched, AddressOf Pagination_PageSwitched ' event handler halaman
        
        ' Set style
        cboTheme.SelectedIndex = 0

        ' tampilkan data pada halaman pertama
        lblPageTotal.Text = "dari " & _datagridEnhanced.GetPageCount()
        _datagridEnhanced.GotoPage(1)
    End Sub

    ' event saat page sudah berubah
    Private Sub Pagination_PageSwitched(sender As Object, e As PageSwitchedEventArgs)
        txtPage.Text = e.CurrentPage.ToString()
    End Sub
    
    #Region " Pagination Buttons "

    Private Sub cmdLastPage_Click(sender As Object, e As EventArgs) Handles cmdLastPage.Click
        _datagridEnhanced.GotoPage(_datagridEnhanced.GetPageCount()) ' pidah halaman terakhir
    End Sub

    Private Sub cmdNextPage_Click(sender As Object, e As EventArgs) Handles cmdNextPage.Click
        _datagridEnhanced.NextPage() ' maju halaman
    End Sub

    Private Sub cmdPrevPage_Click(sender As Object, e As EventArgs) Handles cmdPrevPage.Click
        _datagridEnhanced.PrevPage() ' mundur halaman
    End Sub

    Private Sub cmdFirstPage_Click(sender As Object, e As EventArgs) Handles cmdFirstPage.Click
        _datagridEnhanced.GotoPage(1) ' pindah halaman 1
    End Sub

    #End Region
    
    Private Sub txtPage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPage.KeyDown
        If e.KeyCode = Keys.Enter Then
            _datagridEnhanced.GotoPage(Convert.ToInt32(txtPage.Text)) ' saat tekan enter tampilkan halaman yang dituju
        End If
    End Sub

    Private Sub chkDoubleBuffer_CheckedChanged(sender As Object, e As EventArgs) Handles chkDoubleBuffer.CheckedChanged
        _datagridEnhanced.DoubleBufferMode(chkDoubleBuffer.Checked) ' aktifkan/matikan double buffer
    End Sub

    Private Sub cboTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTheme.SelectedIndexChanged
        Select Case cboTheme.SelectedIndex
            Case 0
                _datagridEnhanced.ApplyStyle(new GreenPallete) ' ganti style tema Green

            Case 1
                _datagridEnhanced.ApplyStyle(new MarsPallete)  ' ganti style tema Mars
        End Select
    End Sub

    Private Sub cmdHomepage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cmdHomepage.LinkClicked
        Process.Start("https://kodesiana.com")
    End Sub
End Class

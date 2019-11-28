Public Class FormPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScraperAnuncios.Show()
        ScraperAnuncios.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PesquisarPorn.Show()
        PesquisarPorn.WindowState = FormWindowState.Normal
        Me.Close()
    End Sub
End Class
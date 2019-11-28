Public Class BruteScraper
    Dim LinkNumero As Integer
    Dim link As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnCOPIAR.Visible = False
        LinkNumero = 10000000
    End Sub

    Private Sub BtnCOPIAR_Click(sender As Object, e As EventArgs) Handles BtnCOPIAR.Click
        My.Computer.Clipboard.SetText(ListBox1.SelectedItem)
        MsgBox("Item Selecionado Copiado com Sucesso!!")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        BtnCOPIAR.Visible = True
        ScraperAnuncios.Link = ListBox1.SelectedItem
        ScraperAnuncios.TextBox1.Text = ListBox1.SelectedItem
    End Sub

    Private Sub BtnGOO_Click(sender As Object, e As EventArgs) Handles BtnGOO.Click
        If BtnGOO.Text = "GOO!!" Then
            ProcurarLinks()
            BtnGOO.Text = "Pause!!"
        ElseIf BtnGOO.Text = "Pause!!" Then
            BtnGOO.Text = "GOO!!"
        End If
    End Sub
    Sub ProcurarLinks()
        link = "https://a.adtng.com/get/" & LinkNumero
        WebBrowser1.Navigate(link)
        Label1.Text = LinkNumero
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            Dim Existe = WebBrowser1.Document.GetElementById("mp4").InnerHtml
            ListBox1.Items.Add(link)
            LinkNumero = LinkNumero + 1
            BtnCopiarTodos.Visible = True
            If BtnGOO.Text = "Pause!!" Then
                ProcurarLinks()
            End If
        Catch ex As Exception
            LinkNumero = LinkNumero + 1
            If BtnGOO.Text = "Pause!!" Then
                ProcurarLinks()
            End If
        End Try
    End Sub

    Private Sub BtnCopiarTodos_Click(sender As Object, e As EventArgs) Handles BtnCopiarTodos.Click
        Dim Lista As String = "Lista:"

        For Each Item In ListBox1.Items
            Lista = Lista & vbNewLine & Item
            My.Computer.Clipboard.SetText(Lista)
        Next
    End Sub

    Private Sub BruteScraper_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ScraperAnuncios.Show()
        ScraperAnuncios.WindowState = FormWindowState.Normal
    End Sub
End Class

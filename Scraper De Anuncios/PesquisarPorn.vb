Public Class PesquisarPorn
    Public LinkGif As String
    Public VeiodoScraper As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pesquisar()
    End Sub
    Sub Pesquisar()
        LinkGif = TextBox1.Text
        LinkGif.Replace("/", "%2F")
        LinkGif.Replace(":", "%3A")
        WebBrowser1.Navigate("https://www.yandex.com/images/search?url=" & LinkGif & "&rpt=imagelike")
    End Sub

    Private Sub PesquisarPorn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If VeiodoScraper Then
            ScraperAnuncios.Show()
            ScraperAnuncios.WindowState = FormWindowState.Normal
            VeiodoScraper = False
        ElseIf Not VeiodoScraper Then
            FormPrincipal.Show()
            FormPrincipal.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Caso tenha sido redirecionado pelo scraper voce nao precisara fazer nada apenas escolher uma imagem que queira e ir para o link para se divetir(HeHe Boy)." & vbNewLine & vbNewLine & "Caso voce ja tenha o link direto da imagem e veio da pagina incial é só coloca-lo  no campo 'Imagem' que você encontrara o Video que quer ou então um parecido." & vbNewLine & vbNewLine & "É só você clicar em uma das imagems e dps no titulo em azul que voce sera redirecionado para a pagina do video ai é só se divertir." & vbNewLine & vbNewLine & "Caso tenha clicado no link e tenha ido para o Internet Explorer, para ter uma melhor experiencia copie o link e acesse-o em outro navegador ( Convenhamos que  ninguem gostaria de bater uma usando o Internet Explorer, só é lucro para quem é Precóce kkkk)")
    End Sub

    Private Sub PesquisarPorn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
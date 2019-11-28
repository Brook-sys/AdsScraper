Public Class ScraperAnuncios
    Public Link As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNScrap.Click
        WebBrowser1.Navigate(Link)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxGIF.SelectedIndexChanged
        PictureBoxGIF.ImageLocation = ListBoxGIF.SelectedItem
        Try
            If RadioButton1.Checked Then
                PesquisarPorn.Show()
                Me.WindowState = FormWindowState.Minimized
                PesquisarPorn.TextBox1.Text = ListBoxGIF.Items.Item(ListBoxGIF.SelectedIndex)
                PesquisarPorn.Pesquisar()
                PesquisarPorn.VeiodoScraper = True
            End If
        Catch ex As Exception
            PesquisarPorn.VeiodoScraper = True
            PesquisarPorn.Close()
        End Try

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMP4.SelectedIndexChanged
        MediaPlayerMP4.URL = ListBoxMP4.SelectedItem
        Try
            If RadioButton1.Checked Then
                PesquisarPorn.Show()
                Me.WindowState = FormWindowState.Minimized
                PesquisarPorn.TextBox1.Text = ListBoxGIF.Items.Item(ListBoxMP4.SelectedIndex)
                PesquisarPorn.Pesquisar()

            End If
        Catch ex As Exception
            PesquisarPorn.VeiodoScraper = True
            PesquisarPorn.Close()
        End Try

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            Dim conteudo = WebBrowser1.Document.GetElementById("video").OuterHtml
            If ListBoxGIF.Items.Contains(conteudo.Split("""")(9)) = False Then
                ListBoxGIF.Items.Add(conteudo.Split("""")(9))
                ListBoxMP4.Items.Add(conteudo.Split("""")(5))
            End If
        Catch ex As Exception

        End Try
        If RadioAutomatico.Checked And BTNIniciarParar.Text = "Parar" Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MediaPlayerMP4.settings.setMode("loop", True)
    End Sub

    Private Sub RadioGIF_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGIF.CheckedChanged
        If RadioGIF.Checked Then
            ListBoxGIF.Visible = True
            PictureBoxGIF.Visible = True
            LabelGIF.Text = "Lista GIF:"
            ListBoxMP4.Visible = False
            MediaPlayerMP4.Visible = False
        End If
    End Sub

    Private Sub RadioMP4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMP4.CheckedChanged
        If RadioMP4.Checked Then
            ListBoxMP4.Visible = True
            MediaPlayerMP4.Visible = True
            LabelGIF.Text = "Lista MP4:"
            ListBoxGIF.Visible = False
            PictureBoxGIF.Visible = False
        End If
    End Sub

    Private Sub RadioManual_CheckedChanged(sender As Object, e As EventArgs) Handles RadioManual.CheckedChanged
        If RadioManual.Checked Then
            If ComboBox1.SelectedItem = "RedTube" Or ComboBox1.SelectedItem = "PornHub" Or ComboBox1.SelectedItem = "Konachan" Or TextBox1.Text <> "" Then
                BTNScrap.Visible = True
            End If
            BTNIniciarParar.Visible = False
            BTNIniciarParar.Text = "Iniciar"
        End If
    End Sub

    Private Sub RadioAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAutomatico.CheckedChanged
        If RadioAutomatico.Checked Then
            If ComboBox1.SelectedItem = "RedTube" Or ComboBox1.SelectedItem = "PornHub" Or ComboBox1.SelectedItem = "Konachan" Or TextBox1.Text <> "" Then
                BTNIniciarParar.Visible = True
            End If
            BTNScrap.Visible = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        WebBrowser1.Navigate(Link)
        Timer2.Stop()
    End Sub

    Private Sub BTNIniciarParar_Click(sender As Object, e As EventArgs) Handles BTNIniciarParar.Click
        If BTNIniciarParar.Text = "Iniciar" Then
            Timer2.Start()
            BTNIniciarParar.Text = "Parar"
            BTNIniciarParar.ForeColor = Color.Red

        ElseIf BTNIniciarParar.Text = "Parar" Then
            Timer2.Stop()
            BTNIniciarParar.Text = "Iniciar"
            BTNIniciarParar.ForeColor = Color.Lime
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "RedTube" Then
            Link = "https://ads.trafficjunky.net/ad7/get/10000360"
            TextBox1.Text = Link
        ElseIf ComboBox1.SelectedItem = "PornHub" Then
            Link = "https://a.adtng.com/get/10000021"
            TextBox1.Text = Link
        ElseIf ComboBox1.SelectedItem = "Konachan" Then
            Link = "https://a.adtng.com/get/10000723"
            TextBox1.Text = Link
        ElseIf ComboBox1.SelectedItem = "Pegar Apartir do Scraper" Then
            BruteScraper.Show()
        End If
        If ComboBox1.SelectedItem = "RedTube" Or ComboBox1.SelectedItem = "PornHub" Or ComboBox1.SelectedItem = "Konachan" Then
            If RadioAutomatico.Checked Then
                BTNIniciarParar.Visible = True
            ElseIf RadioManual.Checked Then
                BTNScrap.Visible = True
            End If
            TextBox1.ReadOnly = True
        Else
            TextBox1.Text = ""
            BTNIniciarParar.Visible = False
            BTNScrap.Visible = False
            TextBox1.ReadOnly = False
        End If
    End Sub

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            BTNIniciarParar.Visible = False
            BTNScrap.Visible = False
        Else
            If RadioAutomatico.Checked Then
                BTNIniciarParar.Visible = True
            ElseIf RadioManual.Checked Then
                BTNScrap.Visible = True
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Na aba 'Site:' voce pode escolher um dos sites na lista, ou pode pegar um dos links que aparecer no brute Scraper ou ainda um customizado de sua Preferencia." & vbNewLine & vbNewLine & "Na aba 'Modo:' voce pode optar por automatico que ira ficar pegando anuncios até voce clicar no botao parar." & vbNewLine & vbNewLine & "Na aba 'Formato:' voce pode optar por .MP4(video) ou Gif que sera uma qualidade inferior." & vbNewLine & vbNewLine & "Voce clica no botão 'Scrap' ou 'Iniciar' para ir pegando anuncios do site ou link desejado." & vbNewLine & vbNewLine & "Na lista abaixo do botão aparecera os links que foram pegos é só clicar em cada um para ver o respectivo anuncio." & vbNewLine & vbNewLine & "Abaixo da lista há um texto escrito 'Pesquisar a Imagem?' caso opte por sim quando clicares em algum dos anuncios da lista acima ele pesquisara para encontra o porno correspondente.")
    End Sub

    Private Sub ScraperAnuncios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FormPrincipal.Show()
        FormPrincipal.WindowState = FormWindowState.Normal
    End Sub
End Class

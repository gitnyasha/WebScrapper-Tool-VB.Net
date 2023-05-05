Imports PuppeteerSharp
Public Class Form1
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles scrapeButton.Click
    Dim url As String = urlTextbox.Text

    Dim webClient As New System.Net.WebClient()
    Dim html As String = webClient.DownloadString(url)

    Dim htmlDoc As New HtmlAgilityPack.HtmlDocument()
    htmlDoc.LoadHtml(html)

    Dim headingNode As HtmlAgilityPack.HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//h1")
    Dim paragraphNode As HtmlAgilityPack.HtmlNode = htmlDoc.DocumentNode.SelectSingleNode("//p")

    outputTextbox.Text = headingNode.InnerText + vbCrLf + vbCrLf + paragraphNode.InnerText

    Dim links As HtmlAgilityPack.HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//div[@class='div-col']//a | //div[@class='div-col']//ul")
    For Each link As HtmlAgilityPack.HtmlNode In links
      outputTextbox.AppendText(vbCrLf + link.GetAttributeValue("href", "") + vbCrLf)
    Next

    Dim tableHeadingNodes As HtmlAgilityPack.HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//table[contains(@class, 'sidebar')][contains(@class, 'nomobile')][contains(@class, 'nowraplinks')][contains(@class, 'hlist')]//th[contains(@class, 'sidebar-heading')]")

    For Each tableHeadingNode As HtmlAgilityPack.HtmlNode In tableHeadingNodes
      outputTextbox.AppendText(vbCrLf + tableHeadingNode.InnerText + vbCrLf)
    Next

  End Sub

  Private Async Sub HeadlessBtn_Click(sender As Object, e As EventArgs) Handles HeadlessBtn.Click
    Dim url As String = "https://edition.cnn.com/sport"

    Dim browserFetcher As New BrowserFetcher()
    Await browserFetcher.DownloadAsync()

    Dim launchOptions As New LaunchOptions()
    launchOptions.Headless = True
    Dim browser As Browser = Await Puppeteer.LaunchAsync(launchOptions)

    Dim page As Page = Await browser.NewPageAsync()
    Dim timeoutMilliseconds As Integer = 1200000
    Await page.GoToAsync(url, New NavigationOptions() With {.Timeout = timeoutMilliseconds})

    Await page.WaitForSelectorAsync("div.container_lead-plus-headlines-with-images__headline > span[data-editable='headline']")

    Dim headlineNodes As IElementHandle() = Await page.QuerySelectorAllAsync("div.container_lead-plus-headlines-with-images__headline > span[data-editable='headline']")
    Dim headlines As New List(Of String)()

    For Each headlineNode As ElementHandle In headlineNodes
      Dim headlineText As String = Await page.EvaluateFunctionAsync(Of String)("(element) => element.textContent", headlineNode)
      headlines.Add(headlineText)
    Next

    outputTextbox.Text = "Headlines from " + url + ":" + vbCrLf + vbCrLf
    For Each headline As String In headlines
      outputTextbox.AppendText(headline + vbCrLf)
    Next

    Await browser.CloseAsync()
  End Sub

End Class

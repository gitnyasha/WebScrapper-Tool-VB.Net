<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.scrapeButton = New System.Windows.Forms.Button()
        Me.urlTextbox = New System.Windows.Forms.TextBox()
        Me.outputTextbox = New System.Windows.Forms.TextBox()
        Me.HeadlessBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'scrapeButton
        '
        Me.scrapeButton.Location = New System.Drawing.Point(254, 386)
        Me.scrapeButton.Name = "scrapeButton"
        Me.scrapeButton.Size = New System.Drawing.Size(139, 23)
        Me.scrapeButton.TabIndex = 0
        Me.scrapeButton.Text = "Basic Scrape"
        Me.scrapeButton.UseVisualStyleBackColor = True
        '
        'urlTextbox
        '
        Me.urlTextbox.Location = New System.Drawing.Point(170, 33)
        Me.urlTextbox.Name = "urlTextbox"
        Me.urlTextbox.Size = New System.Drawing.Size(464, 22)
        Me.urlTextbox.TabIndex = 1
        Me.urlTextbox.Text = "https://en.wikipedia.org/wiki/History_of_programming_languages"
        '
        'outputTextbox
        '
        Me.outputTextbox.Location = New System.Drawing.Point(170, 76)
        Me.outputTextbox.Multiline = True
        Me.outputTextbox.Name = "outputTextbox"
        Me.outputTextbox.Size = New System.Drawing.Size(464, 289)
        Me.outputTextbox.TabIndex = 2
        '
        'HeadlessBtn
        '
        Me.HeadlessBtn.Location = New System.Drawing.Point(394, 386)
        Me.HeadlessBtn.Name = "HeadlessBtn"
        Me.HeadlessBtn.Size = New System.Drawing.Size(159, 23)
        Me.HeadlessBtn.TabIndex = 3
        Me.HeadlessBtn.Text = "Headless Scrape"
        Me.HeadlessBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HeadlessBtn)
        Me.Controls.Add(Me.outputTextbox)
        Me.Controls.Add(Me.urlTextbox)
        Me.Controls.Add(Me.scrapeButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scrapeButton As Button
    Friend WithEvents urlTextbox As TextBox
    Friend WithEvents outputTextbox As TextBox
    Friend WithEvents HeadlessBtn As Button
End Class

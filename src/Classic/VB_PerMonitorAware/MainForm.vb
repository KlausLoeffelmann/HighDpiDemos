Imports System.Collections.Specialized
Imports System.Configuration

Public Class MainForm

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub showLayoutButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showLayoutButton.Click
        Call New SimpleLayout().Show()
    End Sub

    ' Install targeting pack from the appropriate build
    ' \\vsufile\patches\sign\NETFX\4.7\S112.2\02032.00\MTPack\NDP463-TargetingPack-KB3183844.exe

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim settingsCollection As NameValueCollection = Nothing
        Try
            settingsCollection = TryCast(ConfigurationManager.GetSection("System.Windows.Forms.ApplicationConfigurationSection"), NameValueCollection)
        Catch
        End Try

        If settingsCollection IsNot Nothing Then
            dpiAwarenessLabel.Text = $"Application DPI Awareness is {settingsCollection.Get("DpiAwareness")}."
        End If
        formSizeLabel.Text = $"Form size is {Size.Width.ToString()} x {Size.Height.ToString()}"
    End Sub

    Private Sub MainForm_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Me.SizeChanged
        formSizeLabel.Text = $"Form size is {Size.Width.ToString()} x {Size.Height.ToString()}"
    End Sub

    Private Sub formSizeLabel_DpiChangedAfterParent(ByVal sender As Object, ByVal e As EventArgs) Handles formSizeLabel.DpiChangedAfterParent
        formSizeLabel.Text = $"Form size is {Size.Width.ToString()} x {Size.Height.ToString()}"
    End Sub

    Private Sub customDrawing_Click(ByVal sender As Object, ByVal e As EventArgs) Handles customDrawing.Click
        CType(New CustomDrawing(), CustomDrawing).Show()
    End Sub

    'Private Sub buttonImages_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    CType(New ScaleButtonImages(), ScaleButtonImages).Show()
    'End Sub

End Class

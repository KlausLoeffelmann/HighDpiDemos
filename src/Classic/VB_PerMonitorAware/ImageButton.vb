Friend Class ImageButton
    Inherits Button

    Public Sub New()
        MyBase.New()
    End Sub

    Private myOriginalIcon As Icon

    Public Property OriginalIcon() As Icon
        Private Get
            Return myOriginalIcon
        End Get

        Set(ByVal value As Icon)
            myOriginalIcon = value
            Image = GetScaledBitmapFromIcon(myOriginalIcon)
        End Set
    End Property

    Private Function GetScaledBitmapFromIcon(ByVal icon As Icon) As Bitmap
        Dim scaledIcon As New Icon(icon, GetScaledSize())
        Dim bitmap As Bitmap = scaledIcon.ToBitmap()
        scaledIcon.Dispose()

        Return bitmap
    End Function

    Private Function GetScaledSize() As Size
        Dim dimention As Integer = LogicalToDeviceUnits(32)
        Return New Size(dimention, dimention)
    End Function

    Protected Overrides Sub OnDpiChangedAfterParent(ByVal e As EventArgs)
        MyBase.OnDpiChangedAfterParent(e)
        Image = GetScaledBitmapFromIcon(myOriginalIcon)
    End Sub
End Class

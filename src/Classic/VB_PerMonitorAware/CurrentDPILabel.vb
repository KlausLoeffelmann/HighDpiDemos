Imports System.ComponentModel

Public Class CurrentDPILabel
    Inherits Label

    Public Sub New()
        MyBase.New
        AddHandler DpiChangedAfterParent, AddressOf CurrentDPILabel_DpiChangedAfterParent
        AddHandler HandleCreated, AddressOf CurrentDPILabel_HandleCreated
    End Sub

    <DefaultValue(False)>
    Public Overrides Property AutoSize() As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(ByVal value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property

    Private Sub CurrentDPILabel_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
        SetText()
    End Sub

    Private Sub CurrentDPILabel_DpiChangedAfterParent(ByVal sender As Object, ByVal e As EventArgs)
        SetText()
    End Sub

    Private Sub SetText()
        Text = $"Current scaling is {CInt((DeviceDpi / 96.0) * 100)}%"
    End Sub
End Class

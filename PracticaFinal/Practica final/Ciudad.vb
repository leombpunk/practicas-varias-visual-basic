﻿Public Class Ciudad
    Private _nombre As String
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class

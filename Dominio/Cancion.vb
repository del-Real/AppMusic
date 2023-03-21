﻿Public Class Cancion
    Public Property IDCancion As Integer
    Public Property NomCancion As String
    Public Property Duracion As Integer
    Public Property OrdenCancion As Integer
    Public Property Album As Album
    Public ReadOnly Property CanDAO As CancionDAO

    Public Sub New(id As Integer, nombre As String, duracion As Integer, orden As Integer, album As Album)
        Me.IDCancion = id
        Me.NomCancion = nombre
        Me.Duracion = duracion
        Me.OrdenCancion = orden
        Me.Album = album
        Me.CanDAO = New CancionDAO
    End Sub
    Public Sub LeerTodasCanciones(ruta As String)
        Me.CanDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerCancion()
        Me.CanDAO.Leer(Me)
    End Sub

    Public Function InsertarCancion() As Integer
        Return Me.CanDAO.Insertar(Me)
    End Function

    Public Function ActualizarCancion() As Integer
        Return Me.CanDAO.Actualizar(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CanDAO.Borrar(Me)
    End Function
End Class
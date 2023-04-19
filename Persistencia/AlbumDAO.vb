﻿Public Class AlbumDAO

    Public ReadOnly Property Albumes As Collection

    Public Sub New()
        Me.Albumes = New Collection
    End Sub

    Public Sub LeerTodos(ruta As String)
        Dim a As Album
        Dim ar As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM albumes ORDER BY idAlbum")
        For Each aux In col
            a = New Album(CInt(aux(1)))
            a.NomAlbum = aux(2).ToString
            a.Artista = New Artista(aux(3).ToString)
            a.AnoAlbum = CInt(aux(4))
            Me.Albumes.Add(a)
        Next
    End Sub

    Public Sub Leer(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM albumes WHERE idAlbum='" & a.IDAlbum & "';")
        For Each aux In col
            a.NomAlbum = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO albumes VALUES ('" & a.IDAlbum & "', '" & a.NomAlbum & "');")
    End Function

    Public Function Actualizar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE albumes SET NombreAlbum='" & a.NomAlbum & "' WHERE idAlbum='" & a.IDAlbum & "';")
    End Function

    Public Function Borrar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM albumes WHERE idAlbum='" & a.IDAlbum & "';")
    End Function

End Class

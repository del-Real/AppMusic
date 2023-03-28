Public Class AlbumDAO

    Public ReadOnly Property Albumes As Collection

    Public Sub New()
        Me.Albumes = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim a As Album
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            a = New Album(aux(1), aux(2).ToString, CInt(aux(3)), aux(4))
            Me.Albumes.Add(a)
        Next
    End Sub

    Public Sub Leer(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & a.IDAlbum & "';")
        For Each aux In col
            a.NomAlbum = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & a.IDAlbum & "', '" & a.NomAlbum & "');")
    End Function

    Public Function Actualizar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & a.NomAlbum & "' WHERE IDPersona='" & a.IDAlbum & "';")
    End Function

    Public Function Borrar(ByVal a As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & a.IDAlbum & "';")
    End Function

End Class

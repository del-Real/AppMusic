Public Class ArtistaDAO

    Public ReadOnly Property Artistas As Collection

    Public Sub New()
        Me.Artistas = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM artistas ORDER BY IdArtista")
        For Each aux In col
            a = New Artista(CInt(aux(1)))
            a.NomArtista = aux(2).ToString
            a.Pais = New Pais(aux(3).ToString)
            Me.Artistas.Add(a)
        Next
    End Sub

    Public Sub Leer(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM artistas WHERE IdArtista='" & a.IDArtista & "';")
        For Each aux In col
            a.NomArtista = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO artistas VALUES ('" & a.IDArtista & "', '" & a.NomArtista & "' , '" & a.Pais.IDPais & "');")
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE artistas SET Nombre='" & a.NomArtista & "', País='" & a.Pais.IDPais & "' WHERE IDArtista='" & a.IDArtista & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM artistas WHERE IdArtista='" & a.IDArtista & "';")
    End Function

End Class

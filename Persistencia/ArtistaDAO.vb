Public Class ArtistaDAO

    Public ReadOnly Property Artistas As Collection
    Public ReadOnly Property ArtistasInforme3 As Collection
    Public Sub New()
        Me.Artistas = New Collection
        Me.ArtistasInforme3 = New Collection
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
        Dim cadena As String = AgenteBD.ObtenerAgente.Modificar("INSERT INTO artistas(Nombre,País) VALUES ('" & a.NomArtista & "' , '" & a.Pais.IDPais & "');")
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT LAST_INSERT_ID();")
        For Each aux In col
            a.IDArtista = CInt(aux(1))
        Next
        Return cadena
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE artistas SET Nombre='" & a.NomArtista & "', País='" & a.Pais.IDPais & "' WHERE IDArtista='" & a.IDArtista & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM artistas WHERE IdArtista='" & a.IDArtista & "';")
    End Function

    Public Function Informe3()
        Dim col, aux As Collection
        'c.LeerTodasCanciones()
        col = AgenteBD.ObtenerAgente.Leer("      ")
        For Each aux In col
            Dim a As Artista = New Artista
            a.IDArtista = CInt(aux(2))
            Me.ArtistasInforme3.Add(a)
        Next
    End Function


End Class

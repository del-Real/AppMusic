Public Class ArtistaDAO

    Public ReadOnly Property Artistas As Collection
    Public ReadOnly Property CancionesInforme1 As Collection
    Public ReadOnly Property AlbumesInforme2 As Collection
    Public ReadOnly Property ArtistasInforme3 As Collection
    Public ReadOnly Property ArtistasInforme5 As Collection
    Public Sub New()
        Me.Artistas = New Collection
        Me.CancionesInforme1 = New Collection
        Me.AlbumesInforme2 = New Collection
        Me.ArtistasInforme3 = New Collection
        Me.ArtistasInforme5 = New Collection
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

    Public Sub Informe1(ByVal a As Artista)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT setlist.canciones.idCancion, setlist.canciones.NombreCancion, COUNT(*) AS VecesInterpretada " &
                                          "FROM setlist.setlists " &
                                          "JOIN setlist.conciertos ON setlist.setlists.Concierto=setlist.conciertos.IDConcierto " &
                                          "JOIN setlist.canciones ON setlist.setlists.Canción = setlist.canciones.idCancion " &
                                          "JOIN setlist.artistas ON setlist.conciertos.Artista = setlist.artistas.IDArtista " &
                                          "WHERE setlist.artistas.Nombre = '" & a.NomArtista & "' " &
                                          "GROUP BY setlist.canciones.idCancion, setlist.canciones.NombreCancion " &
                                          "ORDER BY VecesInterpretada DESC;")
        For Each aux In col
            Dim c As Cancion = New Cancion
            c.IDCancion = CInt(aux(1))
            Me.CancionesInforme1.Add(c)
        Next
    End Sub

    Public Sub Informe2(ByRef a As Artista)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT albumes.idAlbum, COUNT(*) AS VecesInterpretado " &
                                  "FROM setlists " &
                                  "JOIN setlist.conciertos ON setlists.Concierto = conciertos.idConcierto " &
                                  "JOIN setlist.artistas ON conciertos.Artista = artistas.IDArtista " &
                                  "JOIN setlist.canciones ON setlists.Canción = canciones.idCancion " &
                                  "JOIN setlist.albumes ON canciones.Album = albumes.idAlbum " &
                                  "WHERE artistas.Nombre = '" & a.NomArtista & "' " &
                                  "GROUP BY albumes.idAlbum " &
                                  "ORDER BY VecesInterpretado DESC")
        For Each aux In col
            Dim al As Album = New Album
            al.IDAlbum = CInt(aux(1))
            Me.AlbumesInforme2.Add(al)
        Next
    End Sub

    Public Sub Informe3()
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("
                                    SELECT DISTINCT artistas.Nombre
                                    FROM artistas
                                    JOIN albumes ON artistas.IdArtista = albumes.Artista
                                    WHERE EXISTS (
                                        SELECT 1
                                        FROM canciones
                                        WHERE canciones.Album = albumes.idAlbum
                                        AND NOT EXISTS (
                                            SELECT 1
                                            FROM canciones c2
                                            WHERE c2.Album = albumes.idAlbum
                                            AND NOT EXISTS (
                                                SELECT 1
                                                FROM setlists
                                                JOIN conciertos ON setlists.Concierto = conciertos.idConcierto
                                                WHERE setlists.Canción = c2.idCancion
                                                AND conciertos.Artista = artistas.IdArtista
                                            )
                                        )
                                    )")
        For Each aux In col
            Dim a As Artista = New Artista
            a.IDArtista = CInt(aux(2))
            a.LeerArtista()
            Me.ArtistasInforme3.Add(a)
        Next
    End Sub


    Public Sub Informe5(startDate As Date, endDate As Date)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT artistas.Nombre, COUNT(conciertos.idConcierto) AS NumeroConciertos " &
                                      "FROM setlist.conciertos " &
                                      "JOIN setlist.artistas ON conciertos.Artista = artistas.IdArtista " &
                                      "WHERE conciertos.FechaConcierto BETWEEN '" & startDate.ToString("yyyy-MM-dd") & "' AND '" & endDate.ToString("yyyy-MM-dd") & "' " &
                                      "GROUP BY artistas.Nombre " &
                                      "ORDER BY NumeroConciertos DESC;")
        For Each aux In col
            Dim a As Artista = New Artista
            a.IDArtista = CInt(aux(2))
            a.LeerArtista()
            Me.ArtistasInforme5.Add(a)
        Next
    End Sub


End Class

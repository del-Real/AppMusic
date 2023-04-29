Public Class CancionDAO

    Public ReadOnly Property Canciones As Collection

    Public ReadOnly Property CancionesInforme4 As Collection

    Public Sub New()
        Me.Canciones = New Collection
        Me.CancionesInforme4 = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim c As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM canciones ORDER BY idCancion")
        For Each aux In col
            c = New Cancion(CInt(aux(1)))
            c.NomCancion = aux(2).ToString
            c.Duracion = CInt(aux(3))
            c.Album = New Album(aux(4).ToString)
            c.OrdenCancion = CInt(aux(5))
            Me.Canciones.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM canciones WHERE idCancion='" & c.IDCancion & "';")
        For Each aux In col
            c.NomCancion = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal c As Cancion) As Integer
        Dim cadena As String = AgenteBD.ObtenerAgente.Modificar("INSERT INTO canciones(NombreCancion,Duración,Album,OrdenCanción) VALUES ('" & c.NomCancion & "' , '" & c.Duracion & "' , '" & c.Album.IDAlbum & "' , '" & c.OrdenCancion & "');")
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT LAST_INSERT_ID();")
        For Each aux In col
            c.IDCancion = CInt(aux(1))
        Next
        Return cadena
    End Function

    Public Function Actualizar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE canciones SET NombreCancion='" & c.NomCancion & "', Duración='" & c.Duracion & "', Album ='" & c.Album.IDAlbum & "', OrdenCanción ='" & c.OrdenCancion & "' WHERE idCancion='" & c.IDCancion & "';")
    End Function

    Public Function Borrar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM canciones WHERE idCancion='" & c.IDCancion & "';")
    End Function

    Public Sub Informe4()
        Dim c As Cancion = New Cancion
        Dim col, aux As Collection
        c.LeerTodasCanciones()
        col = AgenteBD.ObtenerAgente.Leer("SELECT canciones.NombreCancion, canciones.idCancion, canciones.Duración, albumes.NombreAlbum, COUNT(*) AS VecesInterpretado " &
                                                "FROM setlists " &
                                                "JOIN setlist.conciertos ON setlists.Concierto = conciertos.idConcierto " &
                                                "JOIN setlist.canciones ON setlists.Canción = canciones.idCancion " &
                                                "JOIN setlist.albumes ON canciones.Album = albumes.idAlbum " &
                                                "GROUP BY canciones.NombreCancion, canciones.idCancion, canciones.Duración, albumes.NombreAlbum " &
                                                "ORDER BY VecesInterpretado DESC")
        For Each aux In col
            c.IDCancion = CInt(aux(2))
            Me.CancionesInforme4.Add(c)
        Next
    End Sub
End Class

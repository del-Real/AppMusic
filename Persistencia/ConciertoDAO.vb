Public Class ConciertoDAO

    Public ReadOnly Property Conciertos As Collection

    Private contadorCanciones As Integer = 0

    Public Sub New()
        Me.Conciertos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim c As Concierto
        Dim a As Artista
        Dim s As Sitio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM conciertos ORDER BY idConcierto")
        For Each aux In col
            c = New Concierto(CInt(aux(1)))
            a = New Artista(CInt(aux(2)))
            s = New Sitio(CInt(aux(3)))
            c.Artista = a
            c.Sitio = s
            c.FechaConcierto = CDate(aux(4).ToString)
            Me.Conciertos.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM conciertos WHERE idConcierto = '" & c.IDConcierto & "';")
        For Each aux In col
            c.Artista = New Artista(CInt(aux(2)))
            c.Sitio = New Sitio(CInt(aux(3)))
            c.FechaConcierto = aux(4)
            c.Canciones = New List(Of Cancion)
        Next
    End Sub

    Public Sub LeerSetlist(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        Dim col2 As Collection : Dim aux2 As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM setlists WHERE Concierto = '" & c.IDConcierto & "';")
        For Each aux In col
            Dim can As Cancion = New Cancion ' Nueva instancia de objeto Cancion
            can.IDCancion = CInt(aux(2))
            col2 = AgenteBD.ObtenerAgente.Leer("SELECT * FROM canciones WHERE idCancion = '" & can.IDCancion & "';")
            For Each aux2 In col2
                can.NomCancion = aux2(2).ToString
                can.Duracion = CInt(aux2(3))
                can.Album = New Album(CInt(aux2(4)))
                can.Album.LeerAlbum()
                can.OrdenCancion = CInt(aux2(5))
                c.Canciones.Add(can)
            Next
        Next
    End Sub

    Public Sub LeerPorArtista(ByRef id_Artista As Integer)
        Dim c As Concierto
        Dim a As Artista
        Dim s As Sitio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM conciertos WHERE idConcierto = '" & id_Artista & "' ORDER BY idConcierto")
        For Each aux In col
            c = New Concierto(CInt(aux(1)))
            a = New Artista(CInt(aux(2)))
            s = New Sitio(CInt(aux(3)))
            c.Artista = a
            c.Sitio = s
            c.FechaConcierto = CDate(aux(4).ToString)
            Me.Conciertos.Add(c)
        Next
    End Sub

    Public Function Insertar(ByVal c As Concierto) As Integer
        Dim cadena As String = AgenteBD.ObtenerAgente.Modificar("INSERT INTO conciertos(Artista,Sitio,FechaConcierto) VALUES ('" & c.Artista.IDArtista & "', '" & c.Sitio.IDSitio & "' , '" & c.FechaConcierto.ToString("yyyy-MM-dd") & "');")
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT LAST_INSERT_ID();")
        For Each aux In col
            c.IDConcierto = CInt(aux(1))
        Next
        Return cadena
    End Function

    Public Function Actualizar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE conciertos SET Artista='" & c.Artista.IDArtista & "', Sitio='" & c.Sitio.IDSitio & "', FechaConcierto='" & c.FechaConcierto.ToString("yyyy-MM-dd") & "' WHERE idConcierto='" & c.IDConcierto & "';")
    End Function

    Public Function Borrar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM conciertos WHERE idConcierto='" & c.IDConcierto & "';")
    End Function

    ' SETLIST QUERYS

    Public Function InsertarSetlist(ByVal c As Concierto, ByVal ca As Cancion) As Integer
        contadorCanciones += 1
        Dim cadena As String = AgenteBD.ObtenerAgente.Modificar("INSERT INTO setlists VALUES ('" & c.IDConcierto & "', '" & ca.IDCancion & "', '" & contadorCanciones & "');")
        Return cadena
    End Function

    Public Function BorrarSetlist(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM setlists WHERE Concierto='" & c.IDConcierto & "';")
    End Function

    Public Function ActualizarSetlistAdd(ByVal c As Concierto, ByVal can As Cancion) As Integer
        Dim sql As String = "INSERT INTO setlists (Concierto, Canción, OrdenSetlist) VALUES ('" & c.IDConcierto & "', '" & can.IDCancion & "', 0) ON DUPLICATE KEY UPDATE OrdenSetlist = OrdenSetlist"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function

    Public Function ActualizarSetlistRemove(ByVal c As Concierto, ByVal can As Cancion) As Integer
        Dim sql As String = "DELETE FROM setlists WHERE Concierto = " & c.IDConcierto & " AND Canción = " & can.IDCancion & ";"
        Return AgenteBD.ObtenerAgente.Modificar(sql)
    End Function


End Class
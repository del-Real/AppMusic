Public Class ConciertoDAO

    Public ReadOnly Property Conciertos As Collection

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
            a = New Artista(aux(2).ToString)
            s = New Sitio(aux(3).ToString)
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
            c.IDConcierto = CInt(aux(1))
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
End Class
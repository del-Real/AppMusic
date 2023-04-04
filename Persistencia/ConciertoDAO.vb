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
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Conciertos ORDER BY IDConcierto")
        For Each aux In col
            c = New Concierto(CInt(aux(1)))
            a = aux(2)
            s = aux(3)
            c.Artista = a
            c.Sitio = s
            c.FechaConcierto = CDate(aux(4).ToString)
            Me.Conciertos.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Conciertos WHERE IDConcierto = '" & c.IDConcierto & "';")
        For Each aux In col
            c.IDConcierto = CInt(aux(1))
        Next
    End Sub

    Public Function Insertar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & c.IDConcierto & "', '" & c.Artista.NomArtista & "');")
    End Function

    Public Function Actualizar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Conciertos SET Artista='" & c.Artista.NomArtista & "' WHERE IDConcierto='" & c.IDConcierto & "';")
    End Function

    Public Function Borrar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDConcierto='" & c.IDConcierto & "';")
    End Function
End Class
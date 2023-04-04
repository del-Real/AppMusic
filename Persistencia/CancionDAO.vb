Public Class CancionDAO

    Public ReadOnly Property Canciones As Collection

    Public Sub New()
        Me.Canciones = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim c As Cancion
        Dim a As Album
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            c = New Cancion(CInt(aux(1)))
            c.NomCancion = aux(2).ToString
            c.Duracion = CInt(aux(3))
            a = aux(4)
            c.Album = a
            c.OrdenCancion = CInt(aux(5))
            Me.Canciones.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & c.IDCancion & "';")
        For Each aux In col
            c.NomCancion = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & c.IDCancion & "', '" & c.NomCancion & "');")
    End Function

    Public Function Actualizar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & c.NomCancion & "' WHERE IDPersona='" & c.IDCancion & "';")
    End Function

    Public Function Borrar(ByVal c As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & c.IDCancion & "';")
    End Function

End Class

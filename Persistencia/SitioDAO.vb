Public Class SitioDAO

    Public ReadOnly Property Sitios As Collection

    Public Sub New()
        Me.Sitios = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim s As Sitio
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            s = New Sitio(CInt(aux(1)))
            s.NomSitio = aux(2).ToString
            p = aux(3)
            s.Pais = p
            s.tipo = aux(4).ToString
            Me.Sitios.Add(s)
        Next
    End Sub

    Public Sub Leer(ByRef s As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & s.IDSitio & "';")
        For Each aux In col
            s.NomSitio = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & s.IDSitio & "', '" & s.NomSitio & "');")
    End Function

    Public Function Actualizar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & s.NomSitio & "' WHERE IDPersona='" & s.IDSitio & "';")
    End Function

    Public Function Borrar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & s.IDSitio & "';")
    End Function

End Class

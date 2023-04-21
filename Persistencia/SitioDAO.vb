Public Class SitioDAO

    Public ReadOnly Property Sitios As Collection

    Public Sub New()
        Me.Sitios = New Collection
    End Sub

    Public Sub LeerTodos(ruta As String)
        Dim s As Sitio
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM sitio ORDER BY idSitio")
        For Each aux In col
            s = New Sitio(CInt(aux(1)))
            s.NomSitio = aux(2).ToString
            s.Pais = New Pais(aux(3).ToString)
            s.tipo = aux(4).ToString
            Me.Sitios.Add(s)
        Next
    End Sub

    Public Sub Leer(ByRef s As Sitio)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM sitio WHERE idSitio='" & s.IDSitio & "';")
        For Each aux In col
            s.NomSitio = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO sitio VALUES ('" & s.IDSitio & "', '" & s.NomSitio & "', '" & s.Pais.IDPais & "', '" & s.tipo & "');")
    End Function

    Public Function Actualizar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE sitio SET NombreSitio='" & s.NomSitio & "', País='" & s.Pais.IDPais & "', Tipo='" & s.tipo & "' WHERE idSitio='" & s.IDSitio & "';")
    End Function

    Public Function Borrar(ByVal s As Sitio) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM sitio WHERE idSitio='" & s.IDSitio & "';")
    End Function

End Class

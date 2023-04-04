Public Class PaisDAO

    Public ReadOnly Property Paises As Collection

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.NomPais = aux(2).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & p.IDPais & "';")
        For Each aux In col
            p.NomPais = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & p.IDPais & "', '" & p.NomPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & p.NomPais & "' WHERE IDPersona='" & p.IDPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & p.IDPais & "';")
    End Function

End Class

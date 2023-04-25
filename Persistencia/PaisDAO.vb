Public Class PaisDAO

    Public ReadOnly Property Paises As Collection

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM paises ORDER BY idPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.NomPais = aux(2).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM paises WHERE idPais='" & p.IDPais & "';")
        For Each aux In col
            p.NomPais = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Dim cadena As String = AgenteBD.ObtenerAgente.Modificar("INSERT INTO paises(NombrePais) VALUES ('" & p.NomPais & "');")
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT LAST_INSERT_ID();")
        For Each aux In col
            p.IDPais = CInt(aux(1))
        Next
        Return cadena
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE paises SET NombrePais='" & p.NomPais & "' WHERE idPais='" & p.IDPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM paises WHERE idPais='" & p.IDPais & "';")
    End Function

End Class

Public Class ArtistaDAO

    Public ReadOnly Property Artistas As Collection

    Public Sub New()
        Me.Artistas = New Collection
    End Sub

    Public Sub LeerTodos()
        Dim a As Artista
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Personas ORDER BY IDPersona")
        For Each aux In col
            a = New Artista(CInt(aux(1)))
            a.NomArtista = aux(2).ToString
            p = aux(3)
            a.Pais = p
            Me.Artistas.Add(a)
        Next
    End Sub

    Public Sub Leer(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Personas WHERE IDPersona='" & a.IDArtista & "';")
        For Each aux In col
            a.NomArtista = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Personas VALUES ('" & a.IDArtista & "', '" & a.NomArtista & "');")
    End Function

    Public Function Actualizar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Personas SET NombrePersona='" & a.NomArtista & "' WHERE IDPersona='" & a.IDArtista & "';")
    End Function

    Public Function Borrar(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Personas WHERE IDPersona='" & a.IDArtista & "';")
    End Function

End Class

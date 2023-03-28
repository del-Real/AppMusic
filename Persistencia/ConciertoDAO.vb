Imports Microsoft.VisualBasic

Public Class ConciertoDAO

    Public ReadOnly Property Conciertos As Collection

    Public Sub New()
        Me.Conciertos = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim c As Concierto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Conciertos ORDER BY IDConcierto")
        For Each aux In col
            c = New Concierto(aux(1).ToString)
            c.IDConcierto = aux(2).ToString
            Me.Conciertos.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Concierto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Conciertos WHERE IDConcierto = '" & c.IDConcierto & "';")
        For Each aux In col
            c.IDConcierto = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal c As Concierto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Conciertos VALUES ('" & c.IDConcierto & "', '" & c.Artista & "');")
    End Function

    Public Function Actualizar(ByVal c As Concierto) As Integer
        Return AgenteDB.OBtenerAgente.Modificar("UPDATE Conciertos SET IDConcierto='" & c.IDConcierto & "' WHERE IDConcierto='" & c.Artista & "';")
    End Function
End Class

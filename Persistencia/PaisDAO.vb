Public Class PaisDAO

    Public ReadOnly Property Paises As Collection
    Public ReadOnly Property PaisesInforme6 As Collection

    Public Sub New()
        Me.Paises = New Collection
        Me.PaisesInforme6 = New Collection
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
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO paises VALUES ('" & p.IDPais & "', '" & p.NomPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE paises SET NombrePais='" & p.NomPais & "' WHERE idPais='" & p.IDPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM paises WHERE idPais='" & p.IDPais & "';")
    End Function

    Public Sub Informe6(fi As Date, ff As Date)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT paises.NombrePais, COUNT(conciertos.idConcierto) AS NumeroConciertos " &
                                      "FROM setlist.conciertos " &
                                      "JOIN setlist.sitio ON conciertos.Sitio = sitio.idSitio " &
                                      "JOIN setlist.paises ON sitio.País = paises.idPais " &
                                      "WHERE conciertos.FechaConcierto BETWEEN '" & fi.ToString("yyyy-MM-dd") & "' AND '" & ff.ToString("yyyy-MM-dd") & "' " &
                                      "GROUP BY paises.NombrePais " &
                                      "ORDER BY NumeroConciertos DESC")
        For Each aux In col
            Dim pa As Pais = New Pais
            pa.IDPais = aux(1).ToString
            pa.LeerPais()
            Me.PaisesInforme6.Add(pa)
        Next
    End Sub

End Class

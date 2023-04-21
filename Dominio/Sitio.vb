Public Class Sitio
    Public Property IDSitio As String
    Public Property NomSitio As String
    Public Property Pais As Pais
    Enum TipoSitio
        sala
        pabellón
        estadio
        festival
    End Enum
    Public Property tipo As String
    Public ReadOnly Property SitDAO As SitioDAO

    Public Sub New(id As Integer, nombre As String, pais As Pais, tipo As String)
        Me.IDSitio = id
        Me.NomSitio = nombre
        Me.Pais = pais
        Me.tipo = tipo
        Me.SitDAO = New SitioDAO
    End Sub

    Public Sub New(id As Integer, nombre As String)
        Me.IDSitio = id
        Me.NomSitio = nombre
        Me.SitDAO = New SitioDAO
    End Sub

    Public Sub New()
        Me.SitDAO = New SitioDAO
    End Sub

    Public Sub New(id As Integer)
        Me.IDSitio = id
        Me.SitDAO = New SitioDAO
    End Sub

    Public Sub LeerTodosSitios(ruta As String)
        Me.SitDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerSitio()
        Me.SitDAO.Leer(Me)
    End Sub

    Public Function InsertarSitio() As Integer
        Return Me.SitDAO.Insertar(Me)
    End Function

    Public Function ActualizarSitio() As Integer
        Return Me.SitDAO.Actualizar(Me)
    End Function

    Public Function BorrarSitio() As Integer
        Return Me.SitDAO.Borrar(Me)
    End Function

    Public Overrides Function ToString() As String
        Return Me.IDSitio + " " + Me.NomSitio + " " + Me.Pais.NomPais + " " + Me.tipo
    End Function
End Class

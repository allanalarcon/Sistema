Public Class vproveedor
    Dim idproveedor As Integer
    Dim nombre, direccion, telefono, email As String

    'Setter and getter

    Public Property gidproveedor
        Get
            Return idproveedor
        End Get
        Set(ByVal value)
            idproveedor = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property

    Public Property gemail
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idproveedor As Integer, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String)
        gidproveedor = idproveedor
        gnombre = nombre
        gdireccion = direccion
        gtelefono = telefono
        gemail = email
    End Sub
End Class
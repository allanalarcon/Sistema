Public Class vvendedor
    Dim idvendedor, idproveedor As Integer
    Dim nombre, apellido, telefono, cedula As String

    'Setter and getter

    Public Property gidvendedor
        Get
            Return idvendedor
        End Get
        Set(ByVal value)
            idvendedor = value
        End Set
    End Property

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

    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
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

    Public Property gcedula
        Get
            Return cedula
        End Get
        Set(ByVal value)
            cedula = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idvendedor As Integer, ByVal idproveedor As Integer, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal cedula As String)
        gidvendedor = idvendedor
        gidproveedor = idproveedor
        gnombre = nombre
        gapellido = apellido
        gtelefono = telefono
        gcedula = cedula
    End Sub
End Class
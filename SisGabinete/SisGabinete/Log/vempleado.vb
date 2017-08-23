Public Class vempleado
    Dim idempleado, tipo As Integer
    Dim nombre, apellido, direccion, telefono, email, cedula As String
    Dim fechanacimiento As Date
    'Dim imagen As Image

    'Setter and getter

    Public Property gidempleado
        Get
            Return idempleado
        End Get
        Set(ByVal value)
            idempleado = value
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

    Public Property gfechanacimiento
        Get
            Return fechanacimiento

        End Get
        Set(ByVal value)
            fechanacimiento = value
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

    Public Property gtipo
        Get
            Return nombre
        End Get
        Set(ByVal value)
            cedula = value
        End Set
    End Property

    'Public Property gimagen
    'Get
    'Return imagen
    'End Get
    'Set(ByVal value)
    'imagen = value
    'End Set
    'End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idempleado As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String, ByVal fechanacimiento As Date, ByVal cedula As String, ByVal tipo As Integer) 'ByVal imagen As Image)
        gidempleado = idempleado
        gnombre = nombre
        gapellido = apellido
        gdireccion = direccion
        gtelefono = telefono
        gemail = email
        gfechanacimiento = fechanacimiento
        gcedula = cedula
        gtipo = tipo
        'gimagen = imagen
    End Sub
End Class
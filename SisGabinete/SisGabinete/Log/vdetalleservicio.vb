Public Class vdetalleservicio
    Dim iddetalleservicio, idventa, idservicio, idempleado, cantidad As Integer
    Dim preciounitario As Double

    'Setter and getter

    Public Property giddetalleservicio
        Get
            Return iddetalleservicio
        End Get
        Set(ByVal value)
            iddetalleservicio = value
        End Set
    End Property

    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
        End Set
    End Property

    Public Property gidservicio
        Get
            Return idservicio
        End Get
        Set(ByVal value)
            idservicio = value
        End Set
    End Property

    Public Property gidempleado
        Get
            Return idempleado
        End Get
        Set(ByVal value)
            idempleado = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property

    Public Property gpreciounitario
        Get
            Return preciounitario
        End Get
        Set(ByVal value)
            preciounitario = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal iddetalleservicio As Integer, ByVal idventa As Integer, ByVal idservicio As Integer, ByVal idempleado As Integer, ByVal cantidad As Integer, ByVal preciounitario As Double)
        giddetalleservicio = iddetalleservicio
        gidventa = idventa
        gidservicio = idservicio
        gidempleado = idempleado
        gcantidad = cantidad
        preciounitario = preciounitario
    End Sub
End Class
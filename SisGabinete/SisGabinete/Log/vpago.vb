Public Class vpago
    Dim idpago, idempleado As Integer
    Dim pago As Double
    Dim fechapago As Date

    'Setter and getter

    Public Property gidpago
        Get
            Return idpago
        End Get
        Set(ByVal value)
            idpago = value
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

    Public Property gpago
        Get
            Return pago
        End Get
        Set(ByVal value)
            pago = value
        End Set
    End Property

    Public Property gfechapago
        Get
            Return fechapago

        End Get
        Set(ByVal value)
            fechapago = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idpago As Integer, ByVal idempleado As Integer, ByVal pago As Double, ByVal fechapago As Date)
        gidpago = idpago
        gidempleado = idempleado
        gpago = pago
        gfechapago = fechapago
    End Sub
End Class
Public Class vservicio
    Dim idservicio As Integer
    Dim descripcion As String
    Dim precio As Double

    'Setter and getter

    Public Property gidservicio
        Get
            Return idservicio
        End Get
        Set(ByVal value)
            idservicio = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Property gprecio
        Get
            Return precio
        End Get
        Set(ByVal value)
            precio = value
        End Set
    End Property

    'Constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idservicio As Integer, ByVal descripcion As String, ByVal precio As Double)
        gidservicio = idservicio
        gdescripcion = descripcion
        gprecio = precio
    End Sub
End Class
Namespace Entities
    Public Class pendientesEntity

        Private _NOMBRE
        Private _ESTADO
        Private _CANTIDAD

        Public Property NOMBRE() As String
            Get
                Return Me._NOMBRE
            End Get
            Set(ByVal value As String)
                Me._NOMBRE = value
            End Set
        End Property
        Public Property ESTADO() As String
            Get
                Return Me._ESTADO
            End Get
            Set(ByVal value As String)
                Me._ESTADO = value
            End Set
        End Property
        Public Property CANTIDAD() As Double
            Get
                Return Me._CANTIDAD
            End Get
            Set(ByVal value As Double)
                Me._CANTIDAD = value
            End Set
        End Property

    End Class
End Namespace
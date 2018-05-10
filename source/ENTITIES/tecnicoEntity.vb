Namespace Entities

    Public Class tecnicoEntity

        Private _CEPERS_CODIGO As Integer
        Private _NOMBRE As String
        Private _CARGO As String

        Public Property CEPERS_CODIGO() As Integer
            Get
                Return Me._CEPERS_CODIGO
            End Get
            Set(ByVal value As Integer)
                Me._CEPERS_CODIGO = value
            End Set
        End Property
        Public Property NOMBRE() As String
            Get
                Return Me._NOMBRE
            End Get
            Set(ByVal value As String)
                Me._NOMBRE = value
            End Set
        End Property
        Public Property CARGO() As String
            Get
                Return Me._CARGO
            End Get
            Set(ByVal value As String)
                Me._CARGO = value
            End Set
        End Property

    End Class

End Namespace

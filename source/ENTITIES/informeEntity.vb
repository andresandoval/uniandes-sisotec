Namespace Entities

    Public Class informeEntity

        Private _ceinfo_codigo As Integer

        ''' <summary>
        ''' CEINFO_CODIGO
        ''' </summary>
        Public Property CEINFO_CODIGO() As Integer
            Get
                Return _ceinfo_codigo
            End Get
            Set(ByVal value As Integer)
                _ceinfo_codigo = value
            End Set
        End Property

        Private _ceinfo_fecini As String

        ''' <summary>
        ''' CEINFO_FECINI
        ''' </summary>
        Public Property CEINFO_FECINI() As String
            Get
                Return _ceinfo_fecini
            End Get
            Set(ByVal value As String)
                _ceinfo_fecini = value
            End Set
        End Property

        Private _ceinfo_fecfin As String

        ''' <summary>
        ''' CEINFO_FECFIN
        ''' </summary>
        Public Property CEINFO_FECFIN() As String
            Get
                Return _ceinfo_fecfin
            End Get
            Set(ByVal value As String)
                _ceinfo_fecfin = value
            End Set
        End Property

        Private _ceinfo_tipoxx As String

        ''' <summary>
        ''' CEINFO_TIPOXX
        ''' </summary>
        Public Property CEINFO_TIPOXX() As String
            Get
                Return _ceinfo_tipoxx
            End Get
            Set(ByVal value As String)
                _ceinfo_tipoxx = value
            End Set
        End Property


        Private _cepers_codigo As Nullable(Of Integer)

        ''' <summary>
        ''' CEPERS_CODIGO
        ''' </summary>
        Public Property CEPERS_CODIGO() As Nullable(Of Integer)
            Get
                Return _cepers_codigo
            End Get
            Set(ByVal value As Nullable(Of Integer))
                _cepers_codigo = value
            End Set
        End Property

        Private _cehor_hora As String

        ''' <summary>
        ''' CEHOR_HORA
        ''' </summary>
        Public Property CEHOR_HORA() As String
            Get
                Return _cehor_hora
            End Get
            Set(ByVal value As String)
                _cehor_hora = value
            End Set
        End Property

        Private _ceinfo_estado As String

        ''' <summary>
        ''' CEINFO_ESTADO
        ''' </summary>
        Public Property CEINFO_ESTADO() As String
            Get
                Return _ceinfo_estado
            End Get
            Set(ByVal value As String)
                _ceinfo_estado = value
            End Set
        End Property

        Private _ceinfo_timeini As String

        ''' <summary>
        ''' CEINFO_FECINI
        ''' </summary>
        Public Property CEINFO_TIMEINI() As String
            Get
                Return _ceinfo_timeini
            End Get
            Set(ByVal value As String)
                _ceinfo_timeini = value
            End Set
        End Property

        Private _ceinfo_timefin As String

        ''' <summary>
        ''' CEINFO_FECFIN
        ''' </summary>
        Public Property CEINFO_TIMEFIN() As String
            Get
                Return _ceinfo_timefin
            End Get
            Set(ByVal value As String)
                _ceinfo_timefin = value
            End Set
        End Property


    End Class

End Namespace

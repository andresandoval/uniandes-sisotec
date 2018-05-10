Namespace Entities

    Public Class AppointmentsEntity

        Private _UniqueID As Integer
        Private _Type As Integer
        Private _StartDate As DateTime
        Private _EndDate As DateTime
        Private _AllDay As Boolean
        Private _Subject As String
        Private _Location As String
        Private _Description As String
        Private _Status As Integer
        Private _Label As Integer
        Private _ResourceID As Integer
        Private _ResourceIDs As String
        Private _ReminderInfo As String
        Private _RecurrenceInfo As String
        Private _allowEdit As Boolean

        Public Property UniqueID() As Integer
            Get
                Return Me._UniqueID
            End Get
            Set(ByVal value As Integer)
                Me._UniqueID = value
            End Set
        End Property
        Public Property Type() As Integer
            Get
                Return Me._Type
            End Get
            Set(ByVal value As Integer)
                Me._Type = value
            End Set
        End Property
        Public Property StartDate() As DateTime
            Get
                Return Me._StartDate
            End Get
            Set(ByVal value As DateTime)
                Me._StartDate = value
            End Set
        End Property
        Public Property EndDate() As DateTime
            Get
                Return Me._EndDate
            End Get
            Set(ByVal value As DateTime)
                Me._EndDate = value
            End Set
        End Property
        Public Property AllDay() As Boolean
            Get
                Return Me._AllDay
            End Get
            Set(ByVal value As Boolean)
                Me._AllDay = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return Me._Subject
            End Get
            Set(ByVal value As String)
                Me._Subject = value
            End Set
        End Property
        Public Property Location() As String
            Get
                Return Me._Location
            End Get
            Set(ByVal value As String)
                Me._Location = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return Me._Description
            End Get
            Set(ByVal value As String)
                Me._Description = value
            End Set
        End Property
        Public Property Status() As Integer
            Get
                Return Me._Status
            End Get
            Set(ByVal value As Integer)
                Me._Status = value
            End Set
        End Property
        Public Property Label() As Integer
            Get
                Return Me._Label
            End Get
            Set(ByVal value As Integer)
                Me._Label = value
            End Set
        End Property
        Public Property ResourceID() As Integer
            Get
                Return Me._ResourceID
            End Get
            Set(ByVal value As Integer)
                Me._ResourceID = value
            End Set
        End Property
        Public Property ResourceIDs() As String
            Get
                Return Me._ResourceIDs
            End Get
            Set(ByVal value As String)
                Me._ResourceIDs = value
            End Set
        End Property
        Public Property ReminderInfo() As String
            Get
                Return Me._ReminderInfo
            End Get
            Set(ByVal value As String)
                Me._ReminderInfo = value
            End Set
        End Property
        Public Property RecurrenceInfo() As String
            Get
                Return Me._RecurrenceInfo
            End Get
            Set(ByVal value As String)
                Me._RecurrenceInfo = value
            End Set
        End Property
        Public Property allowEdit() As Boolean
            Get
                Return Me._allowEdit
            End Get
            Set(ByVal value As Boolean)
                Me._allowEdit = value
            End Set
        End Property

    End Class

End Namespace
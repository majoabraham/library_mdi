Imports DevExpress.Xpo

Public Class Reader : Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _firstName As String

    Private _lastName As String

    Private _idCard As String

    Private _birthDate As DateTime

    Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(FirstName), _firstName, value)
        End Set
    End Property

    Property LastName As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(LastName), _lastName, value)
        End Set
    End Property

    Property IdCard As String
        Get
            Return _idCard
        End Get
        Set(ByVal value As String)
            SetPropertyValue(NameOf(IdCard), _idCard, value)
        End Set
    End Property

    Property BirthDate As Date
        Get
            Return _birthDate
        End Get
        Set(ByVal value As Date)
            SetPropertyValue(NameOf(BirthDate), _birthDate, value)
        End Set
    End Property

    <Association("Reader-Borrowings")>
    Public ReadOnly Property Borrowings As XPCollection(Of Borrowing)
        Get
            Return GetCollection(Of Borrowing)("Borrowings")
        End Get
    End Property

    <PersistentAlias("Concat([FirstName], ' ', [LastName])")>
    Public ReadOnly Property FullName() As String
        Get
            Return CType(EvaluateAlias(NameOf(FullName)), String)
        End Get
    End Property

End Class

Imports DevExpress.Xpo

Public Class Borrowing : Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _reader As Reader

    Private _book As Book

    Private _checkoutDate As Date?

    Private _checkinDate As Date?

    <Association("Reader-Borrowings")>
    Property Reader As Reader
        Get
            Return _reader
        End Get
        Set(ByVal value As Reader)
            SetPropertyValue(NameOf(Reader), _reader, value)
        End Set
    End Property

    <Association("Book-Borrowings")>
    Property Book As Book
        Get
            Return _book
        End Get
        Set(ByVal value As Book)
            SetPropertyValue(NameOf(Book), _book, value)
        End Set
    End Property

    Property CheckoutDate As Date?
        Get
            Return _checkoutDate
        End Get
        Set(ByVal value As Date?)
            SetPropertyValue(NameOf(CheckoutDate), _checkoutDate, value)
        End Set
    End Property

    Property CheckinDate As Date?
        Get
            Return _checkinDate
        End Get
        Set(ByVal value As Date?)
            SetPropertyValue(NameOf(CheckinDate), _checkinDate, value)
        End Set
    End Property

End Class

﻿Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid

Public Class CheckoutXtraForm

    Private _uow As UnitOfWork
    Private _gridControl As GridControl
    Public Sub New()

        InitializeComponent()
        _uow = New UnitOfWork()

    End Sub

    Public Sub New(gridControl As GridControl)

        InitializeComponent()
        _uow = New UnitOfWork()
        _gridControl = gridControl

    End Sub

    Private Sub CheckoutXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'books lookup
        Dim criteria As BinaryOperator = New BinaryOperator(NameOf(Book.IsAvailable), True, BinaryOperatorType.Equal)
        BookLookUpEdit.Properties.DataSource = New XPCollection(Of Book)(_uow, criteria)
        BookLookUpEdit.Properties.DisplayMember = NameOf(Book.Title)
        BookLookUpEdit.Properties.ValueMember = NameOf(Book.Oid)
        BookLookUpEdit.EditValue = 0

        'readers lookup
        ReaderLookUpEdit.Properties.DataSource = New XPCollection(Of Reader)(_uow)
        ReaderLookUpEdit.Properties.DisplayMember = NameOf(Reader.FullName)
        ReaderLookUpEdit.Properties.ValueMember = NameOf(Reader.Oid)
        ReaderLookUpEdit.EditValue = 0

        CheckoutDateEdit.DateTime = DateTime.Now()

    End Sub

    Private Sub CancelSimpleButton_Click(sender As Object, e As EventArgs) Handles CancelSimpleButton.Click
        Close()
    End Sub

    Private Sub SaveSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveSimpleButton.Click
        Using _uow

            Dim book = _uow.GetObjectByKey(Of Book)(BookLookUpEdit.EditValue)
            Dim reader = _uow.GetObjectByKey(Of Reader)(ReaderLookUpEdit.EditValue)

            Dim borrowing = New Borrowing(_uow) With {
                .Book = book,
                .Reader = reader,
                .CheckoutDate = CheckoutDateEdit.DateTime
            }

            book.InStock -= 1
            book.IsAvailable = book.InStock > 0

            _uow.CommitChanges()
        End Using

        _gridControl.DataSource = DataManipulation.GetAllBorrowings()


        For Each child In MainXtraForm.MdiChildren
            Dim form = TryCast(child, BooksXtraForm)
            If form IsNot Nothing Then
                form.BooksGridControl.DataSource = DataManipulation.GetAllBooks()
            End If
        Next

        Close()
    End Sub
End Class

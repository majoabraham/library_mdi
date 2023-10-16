Imports DevExpress.Xpo

Module DataManipulation

    Function GetAllBooks() As XPCollection(Of Book)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Book)(uow)

    End Function

    Function GetAllReaders() As XPCollection(Of Reader)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Reader)(uow)

    End Function

    Function GetAllBorrowings() As XPCollection(Of Borrowing)

        Dim uow As New UnitOfWork()

        Return New XPCollection(Of Borrowing)(uow)

    End Function

End Module

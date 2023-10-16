Imports DevExpress.Xpo

Module Init
    Sub Init()
        Using uow = New UnitOfWork()
            Dim book1 = New Book(uow) With {
                .Author = "James Joyce",
                .Title = "Ulysses",
                .IsAvailable = False
                }

            Dim book2 = New Book(uow) With {
                .Author = "Marcel Proust",
                .Title = "In Search of Lost Time",
                .IsAvailable = True
                }

            Dim book3 = New Book(uow) With {
                .Author = "Miguel de Cervantes",
                .Title = "Don Quixote",
                .IsAvailable = True
                }

            Dim reader1 = New Reader(uow) With {
                .FirstName = "Betty",
                .LastName = "Bowen",
                .IdCard = "XYZ001002",
                .BirthDate = New Date(2002, 5, 23)
                }

            Dim reader2 = New Reader(uow) With {
                .FirstName = "Imran",
                .LastName = "Byrd",
                .IdCard = "AYZ001004",
                .BirthDate = New Date(1987, 10, 7)
                }

            Dim reader3 = New Reader(uow) With {
                .FirstName = "Katy",
                .LastName = "Rosario",
                .IdCard = "YTZ001087",
                .BirthDate = New Date(2008, 7, 14)
                }

            uow.CommitChanges()
            uow.Dispose()
        End Using
    End Sub
End Module

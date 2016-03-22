USE [dbLibrary]
GO

INSERT INTO [dbo].[tblBook]
           ([Name], [Author], [Genre], [YearPublished], [Publisher], [StatusId])
     VALUES('The Hobbit', 'Tolkien J. R. R.', 'Fiction', '1933', 'George Allen & Unwin', 1),     
		   ('From a Buick 8', 'Stephen King', 'Science Fiction', '2002', 'Scribner', 1),                                 
		   ('The Great Gatsby', 'F. Scott Fitzgerald', 'Novel', '1925', 'Scribner', 1)                                                             

INSERT INTO [dbo].[tblMember]
           ([PassportId], [PhotoID], [FirstName], [SecondName], [DateOfMembership], [Phone], [MemberAddress], [Email], [Deleted])
     VALUES('KC123456', NULL, 'Paul', 'White', '2016-01-05', '+380(93)3275345', 'Green st. 9', 'superGuy@gmail.com', 0),
		   ('LV958425', NULL, 'Peter', 'Pen', '2011-05-07', '+380(60)987654', 'Shevchenko st. 34', 'FlyingGuy@gmail.com', 0),       
		   ('VK751536', NULL, 'Anna', 'Eastwood', '2012-10-20', '+380(63)123456', 'Lev st. 95', 'AnnaEast@gmail.com', 0)                    
USE [dbLibrary]
GO

INSERT INTO [dbo].[tblBook]
           ([Name], [Author], [Genre], [YearPublished], [Publisher], [StatusId])
     VALUES('The Hobbit', 'Tolkien J. R. R.', 'Fiction', '1933', 'George Allen & Unwin', 1),     
		   ('From a Buick 8', 'Stephen King', 'Science Fiction', '2002', 'Scribner', 1),                                 
		   ('The Great Gatsby', 'F. Scott Fitzgerald', 'Novel', '1925', 'Scribner', 1),
		   ('A Tale of Two Cities', 'Charles Dickens', 'Historical novel', '1859', 'Chapman and Hall', 1),
		   ('World War Z', 'Max Brooks', 'Horror, post-apocalyptic fiction', '2006', 'Publishers Weekly', 1),
		   ('Harry Potter', 'J. K. Rownling', 'Fantasy', '1997', 'Bloomsbuty Publishing', 1)                                                             

INSERT INTO tblUser ([FirstName], [SecondName], [Login], [Password], [Disabled])
	 VALUES('Mr', 'Bean', 'admin', '21232f297a57a5a743894a0e4a801fc3', 0)	
CREATE DATABASE dbLibrary
GO

USE dbLibrary
GO

CREATE TABLE tblBook
(
	Id INT NOT NULL IDENTITY(1, 1),
	Name NVARCHAR(150) NOT NULL,
	Author NVARCHAR(70),
	Genre NVARCHAR(50),
	YearPublished INT,
	Publisher NVARCHAR(50),
	PhotoId IMAGE,
	StatusId INT NOT NULL,  -- 1 means book is present in library, 0 means book is not in library

	CONSTRAINT PK_BookId PRIMARY KEY(Id)
);

CREATE TABLE tblMember
(
	Id INT NOT NULL IDENTITY(1, 1),	
	PhotoId IMAGE NOT NULL,
	FirstName NVARCHAR(50) NOT NULL,
	SecondName NVARCHAR(50) NOT NULL,
	DateOfMembership DATETIME NOT NULL,
	Phone NVARCHAR(50),
	[Address] NVARCHAR(50),
	Email NVARCHAR(50),
	PassportId NVARCHAR(50) NOT NULL,
	Deleted BIT NOT NULL, -- 0 not deleted, 1 - deleted
	
	CONSTRAINT PK_MemberId PRIMARY KEY(Id)
);

CREATE TABLE tblUser
(
	Id INT NOT NULL IDENTITY(1, 1),
	FirstName NVARCHAR(50) NOT NULL,
	SecondName NVARCHAR(50) NOT NULL,
	[Login] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(100) NOT NULL,
	[Disabled] BIT NOT NULL, --0 meas user active, 1 - is disabled

	CONSTRAINT AK_Login UNIQUE([Login]),
	CONSTRAINT PK_UserId PRIMARY KEY(Id)
);

CREATE TABLE tblBooked
(
	BookedId INT NOT NULL IDENTITY(1, 1),
	MemberId INT NOT NULL,
	BookId INT NOT NULL,
	DateBooked DATETIME NOT NULL,
	DueDate DATETIME NOT NULL,
	StatusId INT NOT NULL, -- 1 means active booked, 0 means book was returned
	FineAmount NUMERIC(18, 4),
	UserId INT NOT NULL,

	CONSTRAINT PK_BookedId PRIMARY KEY(BookedId),
	CONSTRAINT FK_tblBooked_BookId_tblBook_Id FOREIGN KEY(BookId) REFERENCES tblBook(Id),
	CONSTRAINT FK_tblBooked_MemberId_tblMember_Id FOREIGN KEY(MemberId) REFERENCES tblMember(Id),
	CONSTRAINT FK_tblBooked_UserId_tblUser_Id FOREIGN KEY(UserId) REFERENCES tblUser(Id),
	CONSTRAINT CHK_Dates CHECK(DateBooked < DueDate)
);
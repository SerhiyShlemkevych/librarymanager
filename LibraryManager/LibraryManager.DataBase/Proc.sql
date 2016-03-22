USE [dbLibrary]
GO

CREATE PROC spGetUserByLogin
	@Login VARCHAR(50),
	@Password VARCHAR(100)
AS

BEGIN
	SELECT Id, [FirstName], [SecondName], [Login], [Password], [Disabled] 
	FROM [dbo].[tblUser]
	WHERE [Login] = @Login AND [Password] = @Password AND [Disabled] <> 1;
END;
GO

CREATE PROC spAddBooked		
	@MemberId INT,
	@BookId INT,
	@DateBooked DATETIME,
	@DueDate DATETIME,
	@StatusId INT, -- 1 means active booked, 0 means book was returned
	@FineAmount NUMERIC,
	@UserId INT,
	@BookedIdOut INT OUT
AS

BEGIN	
	IF(@MemberId IS NOT NULL OR @BookId IS NOT NULL)
	BEGIN
		UPDATE [dbo].[tblBook] SET [StatusId] = 0 WHERE [Id] = @BookId ;

		INSERT INTO [dbo].[tblBooked]
					([MemberId], [BookId], [DateBooked], [DueDate], [StatusId], [FineAmount], [UserId])
			  VALUES(@MemberId, @BookId, @DateBooked, @DueDate, @StatusId, @FineAmount, @UserId);	
	
		SET @BookedIdOut = @@IDENTITY;
	END
END;
GO

CREATE PROC spDeleteBooked			
	@BookId INT,
	@BookedId INT,
	@StatusId INT -- 1 means active booked, 0 means book was returned		
AS

BEGIN	
	IF(@BookedId IS NOT NULL OR @BookId IS NOT NULL)
	BEGIN
		UPDATE [dbo].[tblBook] 
		SET [StatusId] = 1 
		WHERE [Id] = @BookId ;

		UPDATE [dbo].[tblBooked]
		SET	[StatusId] = @StatusId
		WHERE [BookedId] = @BookedId;								  			
	END
END;
GO

CREATE PROC spSetBookedFine			
	@Fine NUMERIC(18, 4),
	@BookedId INT,
	@StatusId INT -- 1 means active booked, 0 means book was returned		
AS

BEGIN	
	IF(@BookedId IS NOT NULL OR @Fine IS NOT NULL OR @StatusId IS NOT NULL)
	BEGIN
		UPDATE [dbo].[tblBooked] 
		SET [StatusId] = 1 
		WHERE [BookedID] = @BookedId AND [StatusId] = 1;
							  			
	END
END;
GO
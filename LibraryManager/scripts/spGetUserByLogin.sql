CREATE PROC spGetUserByLogin
	@Login VARCHAR(50),
	@Password VARCHAR(100)
AS

BEGIN
	SELECT Id, [Login], [Password], [Disabled] 
	FROM tblUser
	WHERE [Login] = @Login and [Password] = @Password and [Disabled] <> 1;
END;
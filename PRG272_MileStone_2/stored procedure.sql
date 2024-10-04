
CREATE PROCEDURE spInsertStudent
(@StudentNo INT,
@FirstName VARCHAR (20),
@Surname VARCHAR (20),
@Surname VARCHAR (20),
@Gender VARCHAR (30),
@Phone VARCHAR (20),
@Address VARCHAR (20),
@ModuleCode INT)
AS
BEGIN
INSERT INTO Students
VALUES (@StudentNo,@FirstName,@Surname,@Gender,@Phone,@Address  ,@ModuleCode)
END
CREATE PROCEDURE sproc_tblStock_SelectAll
@ShoeID int
AS
	SELECT * from dbo.tblStock where  ShoeID = @ShoeID
RETURN 0
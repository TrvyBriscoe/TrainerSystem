CREATE PROCEDURE sproc_tblStock_Insert
	@Name varchar (50),
	@Release date,
	@Quantity int,
	@Price money,
	@Size decimal (18,0)


AS
	INSERT INTO tblStock (Name, Release, Quantity, Price, Size)
	values (@Name, @Release, @Quantity, @Price, @Size)

	return @@Identity


CREATE PROCEDURE sproc_tblStock_Update

	@ShoeID int,
	@Name varchar (50),
	@Release date,
	@Quantity int,
	@Price money,
	@Size decimal (18,0)

	AS

	update tblStock
	set Name = @Name,
		Release = @Release,
		Quantity = @Quantity,
		Price = @Price,
		Size = @Size

	where ShoeID = @ShoeID


RETURN 0

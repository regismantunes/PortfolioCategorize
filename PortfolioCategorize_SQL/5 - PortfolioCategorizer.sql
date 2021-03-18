CREATE PROCEDURE PortfolioCategorizer
AS
BEGIN
	
	DECLARE @Categories AS CategoryTableType

	INSERT INTO @Categories (Category_Id, Category_MinimunValue, Category_MaximunValue, Client_Sector_Id)
		SELECT Category_Id, Category_MinimunValue, Category_MaximunValue, Client_Sector_Id
		FROM Category

	IF dbo.ValidateCategories(@Categories) = 0
	BEGIN
		RETURN
	END

	DECLARE @TradeId INT, @CategoryId INT, @ClientSectorId INT, @TradeValue DECIMAL(15,2)
	
	DECLARE cPortfolio CURSOR FOR SELECT Trade_Value, Client_Sector_Id
									FROM Trade
									FOR UPDATE OF Category_Id
	
	OPEN cPortfolio

	FETCH NEXT FROM cPortfolio INTO @TradeValue, @ClientSectorId

	WHILE @@FETCH_STATUS = 0
	BEGIN
		
		SELECT @CategoryId = Category_Id
			FROM @Categories 
			WHERE Client_Sector_Id = @ClientSectorId
				AND @TradeValue BETWEEN Category_MinimunValue AND Category_MaximunValue
		
		UPDATE Trade
			SET Category_Id = @CategoryId
			WHERE CURRENT OF cPortfolio

		FETCH NEXT FROM cPortfolio INTO @TradeValue, @ClientSectorId
	END
	
	CLOSE cPortfolio
	DEALLOCATE cPortfolio

	RETURN
END

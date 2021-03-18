CREATE VIEW TradeCategorized
AS
SELECT Trade.Trade_Value, Client_Sector.Client_Sector_Description, Category.Category_Name
FROM Trade
	INNER JOIN Client_Sector
		ON Trade.Client_Sector_Id = Client_Sector.Client_Sector_Id
	LEFT JOIN Category
		ON Trade.Category_Id = Category.Category_Id
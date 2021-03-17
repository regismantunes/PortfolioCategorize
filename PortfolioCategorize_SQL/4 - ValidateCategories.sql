CREATE FUNCTION ValidateCategories(@Categories AS CategoryTableType READONLY)
RETURNS BIT
AS
BEGIN
	
	IF (SELECT COUNT(Categories1.Client_Sector_Id)
		FROM @Categories AS Categories1, @Categories AS Categories2
		WHERE Categories1.Client_Sector_Id = Categories2.Client_Sector_Id
			AND Categories1.Category_MinimunValue <= Categories2.Category_MaximunValue
			AND Categories1.Category_MaximunValue >= Categories2.Category_MinimunValue
			AND Categories1.Category_Id <> Categories2.Category_Id) > 0
	BEGIN
		RETURN 0
	END

	RETURN 1
END

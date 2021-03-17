CREATE TYPE CategoryTableType AS TABLE
(
	Category_Id INT NOT NULL,
	Category_MinimunValue DECIMAL(15,2) NOT NULL,
	Category_MaximunValue DECIMAL(15,2) NOT NULL,
	Client_Sector_Id VARCHAR(10) NOT NULL
)
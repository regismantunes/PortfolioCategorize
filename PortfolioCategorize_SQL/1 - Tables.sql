CREATE TABLE Client_Sector
(
	Client_Sector_Id INT NOT NULL,
	Client_Sector_Description VARCHAR(10) NOT NULL,

	CONSTRAINT PK_Client_Sector PRIMARY KEY (Client_Sector_Id)
)

CREATE TABLE Category
(
	Category_Id INT IDENTITY(1,1),
	Category_Name VARCHAR(15) NOT NULL,
	Category_MinimunValue DECIMAL(15,2) NOT NULL,
	Category_MaximunValue DECIMAL(15,2) NOT NULL,
	Client_Sector_Id INT NOT NULL,

	CONSTRAINT PK_Category PRIMARY KEY (Category_Id),
	CONSTRAINT FK_Category_ClientSector FOREIGN KEY (Client_Sector_Id) REFERENCES Client_Sector (Client_Sector_Id),
)

CREATE TABLE Trade
(
	Trade_Id INT IDENTITY(1,1), 
    Trade_Value DECIMAL(15, 2) NOT NULL,
	Client_Sector_Id INT NOT NULL,
	Category_Id INT NULL,

	CONSTRAINT PK_Trade PRIMARY KEY (Trade_Id),
	CONSTRAINT FK_Trade_ClientSector FOREIGN KEY (Client_Sector_Id) REFERENCES Client_Sector (Client_Sector_Id),
	CONSTRAINT FK_Trade_Category FOREIGN KEY (Category_Id) REFERENCES Category (Category_Id)
)

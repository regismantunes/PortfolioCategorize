INSERT INTO Client_Sector (Client_Sector_Id, Client_Sector_Description)
	VALUES (1, 'Public');
INSERT INTO Client_Sector (Client_Sector_Id, Client_Sector_Description)
	VALUES (2, 'Private');

INSERT INTO Category (Category_Name, Category_MinimunValue, Category_MaximunValue, Client_Sector_Id) 
	VALUES ('LOWRISK', 0, 1000000, 1);
INSERT INTO Category (Category_Name, Category_MinimunValue, Category_MaximunValue, Client_Sector_Id) 
	VALUES ('MEDIUMRISK', 1000000.01, 9999999999999.99, 1);
INSERT INTO Category (Category_Name, Category_MinimunValue, Category_MaximunValue, Client_Sector_Id) 
	VALUES ('HIGHRISK', 1000000, 9999999999999.99, 2);

INSERT INTO Trade (Trade_Value, Client_Sector_Id)
	VALUES (2000000, 2);
INSERT INTO Trade (Trade_Value, Client_Sector_Id)
	VALUES (400000, 1);
INSERT INTO Trade (Trade_Value, Client_Sector_Id)
	VALUES (500000, 1);
INSERT INTO Trade (Trade_Value, Client_Sector_Id)
	VALUES (3000000, 1);
INSERT INTO Trade (Trade_Value, Client_Sector_Id)
	VALUES (100000, 2);
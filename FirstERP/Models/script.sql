-- Criando tabelas
CREATE TABLE Item
(
	ItemID				int not null identity(1,1) PRIMARY KEY,	
	Name				varchar(100) not null,
	Description			varchar(256),
	CreateDate			datetime not null,
)

CREATE TABLE Users
(
	UserID				int identity PRIMARY KEY,
	Name				varchar(100) not null,
	Description			varchar(256),
	CreateDate			datetime not null,
	Login				varchar(50),
	Password			varBinary(50)
)

CREATE TABLE Warehouse
(
	WarehouseID			int identity PRIMARY KEY not null,
	Locator				varchar(6) not null, --Ex: AA-001
	ItemID				int,
	Qty					decimal
)

ALTER TABLE Users DROP COLUMN Description;

INSERT INTO Users (Name, CreateDate)
VALUES ('Gustavo', GETDATE());

SELECT * FROM Users

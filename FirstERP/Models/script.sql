-- Criando tabelas
CREATE TABLE Item
(
	ItemID				int not null identity(1,1) PRIMARY KEY,	
	ItemCode			varchar(10) not null,
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

INSERT INTO ITEM (ItemCode,Name,Description,CreateDate) VALUES
('01.22.0101','Manga','Amarela e cítrica',GETDATE()),
('01.22.0102','Abacaxi','Amarela e cítrica',GETDATE()),
('01.22.0103','Uva','Verde e doce',GETDATE()),
('01.22.0104','Pera','Doce e macia',GETDATE()),
('01.22.0105','Melão','Pouco doce',GETDATE()),
('01.22.0106','Melancia','Aguado',GETDATE()),
('01.22.0107','Jabuticaba','Só tem caroço mas é bom',GETDATE()),
('01.22.0108','Limão','Azedo',GETDATE()),
('01.22.0109','Laranja','Azedo e doce',GETDATE()),
('01.22.0110','Mamão','Estranho',GETDATE()),
('01.22.0111','Pêssego','Delicia',GETDATE()),
('01.22.0112','Lima','Tipo laranja mas sem gosto',GETDATE()),
('01.22.0113','Tâmara','Parece bananinha',GETDATE()),
('01.22.0114','Ameixa','Azeda e doce, parece pêssego',GETDATE()),
('01.22.0115','Côco','Tem água e da pra fazer doce',GETDATE()),
('01.22.0116','Lichia','Néctar dos deuses',GETDATE()),
('01.22.0117','Maçã','Nhé',GETDATE()),
('01.22.0118','Kiwi','Xique e sem graça',GETDATE()),
('01.22.0119','Banana','Mata a fome',GETDATE())


SELECT * FROM Users

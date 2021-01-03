USE Skatedb

CREATE TABLE dbo.Categories(
	CategoryId INT IDENTITY(1,1) PRIMARY KEY,
	CategoryName NVARCHAR(50) NOT NULL,
);

INSERT INTO dbo.Categories(CategoryName) VALUES (N'Cars');
INSERT INTO dbo.Categories(CategoryName) VALUES (N'Food');

CREATE TABLE dbo.Orders(
	OrderId INT IDENTITY(1,1) PRIMARY KEY,
	PhoneName NVARCHAR(45) NOT NULL,
	[Address] NVARCHAR(85) NOT NULL,
	TotalPrice DECIMAL(12,3)
);

CREATE TABLE dbo.Products(
	ProductId INT IDENTITY(1,1) PRIMARY KEY,
	ProductName NVARCHAR(35) NOT NULL,
	ProductDesc NVARCHAR(120) NOT NULL,
	Price DECIMAL(12,3) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES dbo.Categories(CategoryId) NOT NULL,
	OrderId INT FOREIGN KEY REFERENCES dbo.Orders(OrderId)
);

INSERT INTO Products(ProductName, ProductDesc, Price, CategoryId) 
	VALUES (N'BMW i8', N'New car, from factory', 50, 1);
INSERT INTO Products(ProductName, ProductDesc, Price, CategoryId) 
	VALUES (N'Marusia', N'New car, from factory', 150, 1);

INSERT INTO Products(ProductName, ProductDesc, Price, CategoryId) 
	VALUES (N'Eggs', N'Fresh eggs', 0.5, 2);
INSERT INTO Products(ProductName, ProductDesc, Price, CategoryId) 
	VALUES (N'Steak', N'Fresh steak', 2, 2);
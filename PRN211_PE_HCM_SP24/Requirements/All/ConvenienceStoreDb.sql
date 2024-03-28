CREATE DATABASE ConvenienceStoreDb
GO

USE ConvenienceStoreDb
GO

CREATE TABLE StoreAccount (   
  UserId INT PRIMARY KEY,
  Password NVARCHAR(40) NOT NULL,
  FullName NVARCHAR(60) NOT NULL,
  Email NVARCHAR(60) UNIQUE, 
  Role INT
)
GO

INSERT INTO StoreAccount VALUES(5, N'@1Ad', N'Administrator', 'admin@gs25.com.vn', 1);
GO
INSERT INTO StoreAccount VALUES(10, N'@2St', N'Staff', 'staff@gs25.com.vn', 2);
GO
INSERT INTO StoreAccount VALUES(15, N'@3Mn', N'Manager', 'manager@gs25.com.vn', 3);
GO

CREATE TABLE Vendor (
    VendorId INT PRIMARY KEY,
    VendorName NVARCHAR(100),
    Address NVARCHAR(255),
    Phone NVARCHAR(20)
)
GO
INSERT INTO Vendor (VendorId, VendorName, Address, Phone) VALUES (1, 'Coca-Cola', '1 Coca-Cola Plaza, Atlanta, GA', '1-800-GET-COKE');
GO
INSERT INTO Vendor (VendorId, VendorName, Address, Phone) VALUES (2, 'Heineken', 'Heinekenplein 1, 1072 MH Amsterdam, Netherlands', '+31 20 523 9239');
GO
INSERT INTO Vendor (VendorId, VendorName, Address, Phone) VALUES (3, 'Dole', '5320 Bolsa Ave, Huntington Beach, CA', '1-800-232-8888');
GO
INSERT INTO Vendor (VendorId, VendorName, Address, Phone) VALUES (4, 'PepsiCo', '700 Anderson Hill Rd, Purchase, NY', '1-800-433-2652');
GO

CREATE TABLE Product (
    ProductId INT PRIMARY KEY,
    ProductName NVARCHAR(100),	
    Price DECIMAL(10, 2),
    ExpiredDate DATE,
    ManufactureDate DATE,
    Quantity INT,   
	Description NVARCHAR(255),
    VendorId INT,
    FOREIGN KEY (VendorId) REFERENCES Vendor(VendorId)
)
GO
-- Insert data into Product table (Coca-Cola products)
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (1, 'Coca-Cola Classic', 1.50, '2024-12-31', '2024-01-01', 100, 'Classic Coca-Cola flavor', 1);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (2, 'Sprite', 1.25, '2024-12-31', '2024-01-01', 80, 'Lemon-lime flavored soda', 1);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (3, 'Dasani Water', 1.00, '2025-12-31', '2024-01-01', 120, 'Bottled water', 1);
GO

-- Insert data into Product table (Heineken products)
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (4, 'Heineken Lager Beer', 2.00, '2024-12-31', '2024-01-01', 50, 'Premium lager beer', 2);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (5, 'Heineken 0.0', 1.75, '2024-12-31', '2024-01-01', 60, 'Non-alcoholic beer', 2);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (6, 'Amstel Light', 1.50, '2024-12-31', '2024-01-01', 40, 'Light beer', 2);
GO

-- Insert data into Product table (Dole products)
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (7, 'Dole Pineapple Juice', 2.50, '2024-12-31', '2024-01-01', 70, '100% pineapple juice', 3);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (8, 'Dole Fruit Bowls', 1.75, '2024-12-31', '2024-01-01', 90, 'Fruit bowls in juice', 3);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (9, 'Dole Banana', 0.50, '2024-12-31', '2024-01-01', 110, 'Fresh bananas', 3);
GO

-- Insert data into Product table (PepsiCo products)
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (10, 'Pepsi-Cola', 1.50, '2024-12-31', '2024-01-01', 80, 'Classic Pepsi-Cola flavor', 4);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorId) 
VALUES (11, 'Mountain Dew', 1.25, '2024-12-31', '2024-01-01', 60, 'Citrus-flavored soda', 4);
GO
INSERT INTO Product (ProductId, ProductName, Price, ExpiredDate, ManufactureDate, Quantity, Description, VendorID) 
VALUES (12, 'Lipton Iced Tea', 2.00, '2024-12-31', '2024-01-01', 70, 'Bottled iced tea', 4);
GO
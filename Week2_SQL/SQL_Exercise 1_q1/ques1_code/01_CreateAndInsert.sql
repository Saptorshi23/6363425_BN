DROP TABLE IF EXISTS Products;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100),
    Category VARCHAR(100),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductName, Category, Price) VALUES
('iPhone 13', 'Electronics', 799.99),
('Samsung Galaxy S22', 'Electronics', 749.99),
('MacBook Pro', 'Electronics', 1299.99),
('Dell XPS', 'Electronics', 1099.99),
('HP Pavilion', 'Electronics', 699.99),
('Nike Air Max', 'Footwear', 159.99),
('Adidas Ultraboost', 'Footwear', 179.99),
('Puma Sneakers', 'Footwear', 139.99),
('Reebok Classic', 'Footwear', 129.99),
('Skechers Go Walk', 'Footwear', 119.99);

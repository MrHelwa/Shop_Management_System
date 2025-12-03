USE ProductShopDB_ITP;

-- Insert Customers
INSERT INTO Customer (Name, Gender, Email, PhoneNum) VALUES
('Ahmed Ali', 'Male', 'ahmed@example.com', '01012345678'),
('Sara Mohamed', 'Female', 'sara@example.com', '01098765432'),
('Omar Hassan', 'Male', 'omar@example.com', '01123456789'),
('Fatma Ibrahim', 'Female', 'fatma@example.com', '01234567890');

-- Insert Products
INSERT INTO Product (Name, Image, Price, Description, CustID) VALUES
('Laptop', 'laptop.jpg', 1200.00, 'High-performance laptop with 16GB RAM', 1),
('Smartphone', 'phone.jpg', 800.00, 'Latest Android smartphone', 1),
('Tablet', 'tablet.jpg', 500.00, 'Portable tablet for work and entertainment', 2),
('Headphones', 'headphones.jpg', 150.00, 'Wireless noise-canceling headphones', 2),
('Smartwatch', 'watch.jpg', 300.00, 'Fitness tracking smartwatch', 3),
('Camera', 'camera.jpg', 900.00, 'Professional DSLR camera', 3),
('Keyboard', 'keyboard.jpg', 80.00, 'Mechanical gaming keyboard', 4),
('Mouse', 'mouse.jpg', 50.00, 'Wireless ergonomic mouse', 4);
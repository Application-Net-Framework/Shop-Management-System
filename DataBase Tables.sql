CREATE DATABASE SuperShopManagement;

USE SuperShopManagement;

CREATE TABLE Employees (
    UserID INT IDENTITY(1000,1) PRIMARY KEY,
    UserName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20) NULL,
    JoiningDate DATE DEFAULT GETDATE(),
    Role NVARCHAR(50) NULL,
    Gender NVARCHAR(20) NULL,
    Password NVARCHAR(100) NULL,
    Qualification NVARCHAR(100) NULL,
    Address NVARCHAR(200) NULL,
    Religion NVARCHAR(50) NULL,
    DOB DATE NULL,
    AccountStatus NVARCHAR(20) DEFAULT 'Active'
);


CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    CategoryName NVARCHAR(50) NOT NULL,
    Stock INT NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(255) NULL,
    ExpiryDate DATETIME NULL,
    BuyQuantity INT NULL,
    SaleQuantity INT NULL
);
CREATE TABLE Discounts (
    DiscountID INT IDENTITY(1,1) PRIMARY KEY,
    DiscountCode NVARCHAR(50) NOT NULL UNIQUE,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    DiscountStatus NVARCHAR(20) DEFAULT 'Active'
);
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1000,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Mobile NVARCHAR(20) UNIQUE,
    Email NVARCHAR(100),
    JoinDate DATETIME DEFAULT GETDATE(),
    MembershipType NVARCHAR(50) NULL
);
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
    TotalAmount DECIMAL(10,2) NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE()
);


CREATE TABLE OrderDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
    ProductName NVARCHAR(100),
    Quantity INT,
    UnitPrice DECIMAL(10,2)
);


CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
    PaymentMethod NVARCHAR(50),
    Amount DECIMAL(10,2),
    TransactionID NVARCHAR(100),
    PaymentDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE CartView (
    RowID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
    ProductName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL
);
CREATE TABLE SupplierRequest (
    RequestID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
    RequestedQuantity INT,
    RequestDate DATETIME DEFAULT GETDATE(),
    ApprovalStatus NVARCHAR(50)
);
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
    Name NVARCHAR(100) NULL,
    Mobile NVARCHAR(20) NULL,
    FeedbackType NVARCHAR(50) NOT NULL,
    Subject NVARCHAR(100) NOT NULL,
    Details NVARCHAR(500) NOT NULL,
    Response NVARCHAR(500) NULL,
    FeedbackDate DATETIME DEFAULT GETDATE()
);
CREATE TABLE PreOrderProduct (
    PreOrderProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50),
    Description NVARCHAR(255),
    UnitPrice DECIMAL(10,2),
    StockQuantity INT
);


CREATE TABLE PreOrder (
    PreOrderID INT IDENTITY(1,1) PRIMARY KEY,
    PreOrderProductID INT FOREIGN KEY REFERENCES PreOrderProduct(PreOrderProductID),
    ProductName NVARCHAR(100),
    Quantity INT,
    CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
    CustomerName NVARCHAR(100),
    CustomerMobile NVARCHAR(20),
    DateRequested DATETIME DEFAULT GETDATE(),
    PreferredDate DATE,
    ApprovalStatus NVARCHAR(50)
);

INSERT INTO Employees (UserName, Email, PhoneNumber, JoiningDate, Role, Gender, Password, Qualification, Address, Religion, DOB)
VALUES
('Roshni Akter', 'roshni@shop.com', '01711111111', '2024-01-05', 'Manager', 'Female', '12345', 'MBA', 'Dhaka', 'Islam', '1998-03-15'),
('Siam Hossain', 'siam@shop.com', '01711111112', '2024-02-10', 'Cashier', 'Male', '12345', 'BBA', 'Narayanganj', 'Islam', '2000-04-20'),
('Arif Rahman', 'arif@shop.com', '01711111113', '2024-03-01', 'Sales Executive', 'Male', '12345', 'BSc', 'Gazipur', 'Islam', '1999-02-11'),
('Hacin Ahmed', 'hacin@shop.com', '01711111114', '2024-01-20', 'Supervisor', 'Male', '12345', 'BBA', 'Dhaka', 'Islam', '1997-12-25'),
('Tania Islam', 'tania@shop.com', '01711111115', '2024-03-15', 'Accountant', 'Female', '12345', 'BCom', 'Mirpur', 'Islam', '1998-10-10'),
('Rafi Khan', 'rafi@shop.com', '01711111116', '2024-04-01', 'IT Support', 'Male', '12345', 'BSc IT', 'Uttara', 'Islam', '1997-11-11'),
('Mitu Akter', 'mitu@shop.com', '01711111117', '2024-05-01', 'Receptionist', 'Female', '12345', 'HSC', 'Banani', 'Islam', '2001-08-09'),
('Sabbir Hasan', 'sabbir@shop.com', '01711111118', '2024-05-15', 'Store Keeper', 'Male', '12345', 'Diploma', 'Mohakhali', 'Islam', '1998-07-05'),
('Nabila Noor', 'nabila@shop.com', '01711111119', '2024-06-10', 'HR Officer', 'Female', '12345', 'MBA', 'Dhanmondi', 'Islam', '1996-09-15'),
('Rony Alam', 'rony@shop.com', '01711111120', '2024-07-01', 'Cleaner', 'Male', '12345', 'SSC', 'Tejgaon', 'Islam', '2002-01-01');


INSERT INTO Product (ProductName, CategoryName, Stock, Price, Description, ExpiryDate, BuyQuantity, SaleQuantity)
VALUES
('Rice Premium 5kg', 'Grocery', 100, 550.00, 'Premium rice', '2026-12-31', 100, 25),
('Sugar 1kg', 'Grocery', 200, 90.00, 'Refined sugar', '2026-10-01', 200, 70),
('Milk Powder 500g', 'Dairy', 150, 420.00, 'Full cream milk powder', '2025-12-01', 150, 80),
('Olive Oil 1L', 'Cooking', 120, 890.00, 'Extra virgin olive oil', '2027-01-01', 120, 40),
('Shampoo 400ml', 'Cosmetics', 80, 350.00, 'Anti-hair fall shampoo', '2027-03-01', 80, 30),
('Toothpaste 150g', 'Cosmetics', 200, 150.00, 'Mint flavor', '2027-02-15', 200, 110),
('Soap 100g', 'Cosmetics', 300, 60.00, 'Herbal body soap', '2027-04-30', 300, 150),
('Cooking Salt 1kg', 'Grocery', 250, 35.00, 'Refined iodized salt', '2026-09-30', 250, 200),
('Tea Pack 200g', 'Grocery', 180, 210.00, 'Premium black tea', '2026-07-31', 180, 100),
('Soft Drink 1L', 'Beverage', 90, 120.00, 'Lemon flavor', '2025-11-30', 90, 70);


INSERT INTO Discounts (DiscountCode, StartDate, EndDate, DiscountStatus)
VALUES
('DISC10', '2025-01-01', '2025-03-01', 'Expired'),
('NEWYEAR25', '2025-12-20', '2026-01-05', 'Upcoming'),
('SUMMER15', '2025-06-01', '2025-08-31', 'Expired'),
('FEST20', '2025-09-01', '2025-10-31', 'Active'),
('WINTER30', '2025-11-01', '2026-01-31', 'Active'),
('BUNDLE5', '2025-02-01', '2025-03-30', 'Expired'),
('VIP10', '2025-04-01', '2025-12-31', 'Active'),
('LOYAL15', '2025-05-01', '2025-07-31', 'Expired'),
('FLASH20', '2025-10-01', '2025-10-15', 'Active'),
('FREESHIP', '2025-08-01', '2025-08-31', 'Expired');


INSERT INTO Customer (Name, Mobile, Email, MembershipType)
VALUES
('Rahim Uddin', '01811111111', 'rahim@gmail.com', 'Gold'),
('Karim Hossain', '01811111112', 'karim@gmail.com', 'Silver'),
('Sultana Begum', '01811111113', 'sultana@gmail.com', 'Gold'),
('Hasan Ali', '01811111114', 'hasan@gmail.com', 'Regular'),
('Nadia Khatun', '01811111115', 'nadia@gmail.com', 'Silver'),
('Rakibul Islam', '01811111116', 'rakib@gmail.com', 'Gold'),
('Sumaiya Rahman', '01811111117', 'sumaiya@gmail.com', 'Platinum'),
('Rasel Ahmed', '01811111118', 'rasel@gmail.com', 'Regular'),
('Tania Sultana', '01811111119', 'tania@gmail.com', 'Gold'),
('Imran Khan', '01811111120', 'imran@gmail.com', 'Silver');


INSERT INTO Orders (CustomerID, TotalAmount)
VALUES
(1000, 850.50),
(1001, 1200.00),
(1002, 450.00),
(1003, 2200.00),
(1004, 700.00),
(1005, 550.00),
(1006, 3500.00),
(1007, 1150.00),
(1008, 400.00),
(1009, 600.00);


INSERT INTO OrderDetails (OrderID, ProductID, ProductName, Quantity, UnitPrice)
VALUES
(1, 1, 'Rice Premium 5kg', 2, 550.00),
(2, 2, 'Sugar 1kg', 5, 90.00),
(3, 3, 'Milk Powder 500g', 1, 420.00),
(4, 4, 'Olive Oil 1L', 2, 890.00),
(5, 5, 'Shampoo 400ml', 3, 350.00),
(6, 6, 'Toothpaste 150g', 2, 150.00),
(7, 7, 'Soap 100g', 10, 60.00),
(8, 8, 'Cooking Salt 1kg', 4, 35.00),
(9, 9, 'Tea Pack 200g', 3, 210.00),
(10, 10, 'Soft Drink 1L', 5, 120.00);


INSERT INTO Payment (OrderID, PaymentMethod, Amount, TransactionID)
VALUES
(1, 'Cash', 850.50, 'TXN001'),
(2, 'bKash', 1200.00, 'TXN002'),
(3, 'Nagad', 450.00, 'TXN003'),
(4, 'Card', 2200.00, 'TXN004'),
(5, 'Cash', 700.00, 'TXN005'),
(6, 'bKash', 550.00, 'TXN006'),
(7, 'Card', 3500.00, 'TXN007'),
(8, 'Nagad', 1150.00, 'TXN008'),
(9, 'Cash', 400.00, 'TXN009'),
(10, 'Card', 600.00, 'TXN010');


INSERT INTO CartView (ProductID, ProductName, Quantity, UnitPrice)
VALUES
(1, 'Rice Premium 5kg', 1, 550.00),
(2, 'Sugar 1kg', 3, 90.00),
(3, 'Milk Powder 500g', 1, 420.00),
(4, 'Olive Oil 1L', 1, 890.00),
(5, 'Shampoo 400ml', 2, 350.00),
(6, 'Toothpaste 150g', 3, 150.00),
(7, 'Soap 100g', 4, 60.00),
(8, 'Cooking Salt 1kg', 2, 35.00),
(9, 'Tea Pack 200g', 1, 210.00),
(10, 'Soft Drink 1L', 2, 120.00);


INSERT INTO SupplierRequest (ProductID, RequestedQuantity, ApprovalStatus)
VALUES
(1, 50, 'Approved'),
(2, 100, 'Pending'),
(3, 80, 'Approved'),
(4, 40, 'Approved'),
(5, 60, 'Pending'),
(6, 120, 'Pending'),
(7, 90, 'Approved'),
(8, 200, 'Approved'),
(9, 70, 'Pending'),
(10, 30, 'Approved');


INSERT INTO Feedback (CustomerID, Name, Mobile, FeedbackType, Subject, Details, Response)
VALUES
(1000, 'Rahim Uddin', '01811111111', 'Product', 'Rice Quality', 'Rice was fresh and good.', 'Thank you for feedback'),
(1001, 'Karim Hossain', '01811111112', 'Service', 'Cashier Delay', 'Had to wait too long.', 'We will improve service'),
(1002, 'Sultana Begum', '01811111113', 'Product', 'Expired Item', 'One soap was near expiry.', 'Apology and replaced'),
(1003, 'Hasan Ali', '01811111114', 'Billing', 'Wrong Bill', 'Bill had mistake.', 'Issue fixed'),
(1004, 'Nadia Khatun', '01811111115', 'Product', 'Good Quality', 'Happy with product quality.', 'Thank you'),
(1005, 'Rakibul Islam', '01811111116', 'Delivery', 'Late Delivery', 'Delivery was late by 2 hours.', 'Noted for improvement'),
(1006, 'Sumaiya Rahman', '01811111117', 'Product', 'Tea Taste', 'Loved the tea flavor.', 'Glad you liked it'),
(1007, 'Rasel Ahmed', '01811111118', 'App', 'Login Issue', 'App keeps logging out.', 'Fixed in update'),
(1008, 'Tania Sultana', '01811111119', 'Service', 'Polite Staff', 'Staff were polite and kind.', 'Thank you'),
(1009, 'Imran Khan', '01811111120', 'Billing', 'Discount Missing', 'Discount not applied.', 'Refunded difference');


INSERT INTO PreOrderProduct (ProductName, Category, Description, UnitPrice, StockQuantity)
VALUES
('Air Fryer', 'Appliance', '2L Air Fryer', 7500.00, 10),
('Smart Watch', 'Electronics', 'Bluetooth fitness tracker', 3200.00, 15),
('Rice Cooker', 'Appliance', 'Automatic rice cooker 1.8L', 2500.00, 20),
('Headphones', 'Electronics', 'Wireless Bluetooth headset', 1800.00, 30),
('Hair Dryer', 'Appliance', '1500W quick dry', 1400.00, 25),
('Electric Kettle', 'Appliance', '1.5L stainless steel', 900.00, 40),
('USB Flash Drive 32GB', 'Electronics', 'USB 3.0', 550.00, 50),
('LED Bulb 9W', 'Home', 'Energy saving bulb', 180.00, 100),
('Smartphone Cover', 'Accessories', 'Silicone soft case', 250.00, 200),
('Washing Machine', 'Appliance', 'Top load 7kg', 22000.00, 5);


INSERT INTO PreOrder (PreOrderProductID, ProductName, Quantity, CustomerID, CustomerName, CustomerMobile, PreferredDate, ApprovalStatus)
VALUES
(1, 'Air Fryer', 1, 1000, 'Rahim Uddin', '01811111111', '2025-10-15', 'Approved'),
(2, 'Smart Watch', 2, 1001, 'Karim Hossain', '01811111112', '2025-10-20', 'Pending'),
(3, 'Rice Cooker', 1, 1002, 'Sultana Begum', '01811111113', '2025-10-18', 'Approved'),
(4, 'Headphones', 3, 1003, 'Hasan Ali', '01811111114', '2025-10-22', 'Pending'),
(5, 'Hair Dryer', 1, 1004, 'Nadia Khatun', '01811111115', '2025-10-19', 'Approved'),
(6, 'Electric Kettle', 2, 1005, 'Rakibul Islam', '01811111116', '2025-10-25', 'Pending'),
(7, 'USB Flash Drive 32GB', 4, 1006, 'Sumaiya Rahman', '01811111117', '2025-10-28', 'Approved'),
(8, 'LED Bulb 9W', 10, 1007, 'Rasel Ahmed', '01811111118', '2025-10-29', 'Pending'),
(9, 'Smartphone Cover', 5, 1008, 'Tania Sultana', '01811111119', '2025-10-27', 'Approved'),
(10, 'Washing Machine', 1, 1009, 'Imran Khan', '01811111120', '2025-10-30', 'Pending');
CREATE TABLE Users1 (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL, 
    SubscriptionType NVARCHAR(50) CHECK (SubscriptionType IN ('Free', 'Premium')),
    SubscriptionExpiry DATE NULL,
    JoinDate DATETIME DEFAULT GETDATE()
);

 

SELECT * FROM Users1; 


CREATE TABLE Admins1 (
    AdminID INT PRIMARY KEY IDENTITY(1,1),
    AdminName NVARCHAR(100) UNIQUE NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50) DEFAULT 'Admin',
    CreatedAt DATETIME DEFAULT GETDATE()
);

SELECT * FROM Admins1; -- Fixed table name

-- Fixed Payments Table (Referenced Users1 instead of Users)
CREATE TABLE Payments (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    
    Amount DECIMAL(10,2) NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(),
    PaymentMethod VARCHAR(50) NOT NULL,
    PaymentStatus VARCHAR(20) CHECK (PaymentStatus IN ('Pending', 'Completed', 'Failed', 'Refunded')),
    TransactionID VARCHAR(100) UNIQUE,
    FOREIGN KEY (UserID) REFERENCES Users1(UserID) ON DELETE CASCADE
);

SELECT * FROM Payments;

-- Fixed PremiumUsers Table
CREATE TABLE PremiumUsers (
    PremiumID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT UNIQUE NOT NULL,
    SubscriptionStart DATE NOT NULL,
    SubscriptionExpiry DATE NOT NULL,
    PaymentStatus NVARCHAR(50) CHECK (PaymentStatus IN ('Active', 'Expired', 'Pending')),
    FOREIGN KEY (UserID) REFERENCES Users1(UserID) ON DELETE CASCADE
);

SELECT * FROM PremiumUsers;

-- Fixed Subscriptions Table
CREATE TABLE Subscriptions (
    SubscriptionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    PlanType VARCHAR(50) NOT NULL,
    SubscriptionDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES Users1(UserID) ON DELETE CASCADE
);

SELECT * FROM Subscriptions;

-- Fixed MusicLibrary Table
CREATE TABLE MusicLibrary (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255),
    Artist NVARCHAR(255),
    FilePath NVARCHAR(500)  -- Path to the music file
);

SELECT * FROM MusicLibrary;

-- Fixing Insert Statement
INSERT INTO MusicLibrary (Title, Artist, FilePath)
VALUES ('Since I Have Been Loving You', 'Led Zeppelin', 'C:/Music/song1.mp3');


SELECT name, schema_id 
FROM sys.tables 
WHERE name = 'Profile';

SELECT name, schema_id 
FROM sys.tables;

USE [New Database];
GO
SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME = 'Profile';

USE [New Database];
GO
SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES;

CREATE TABLE dbo.Profile (
    UserID INT PRIMARY KEY,
    Username NVARCHAR(100),
    SubscriptionType NVARCHAR(50),
    JoinDate DATE
);
select * from dbo.Profile;
-- Insert sample data
INSERT INTO dbo.Profile (UserID, Username, SubscriptionType, JoinDate)
VALUES (2, 'zaman', 'Premium', '2025-01-01');


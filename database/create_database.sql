-- Create Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(255),
    UserType NVARCHAR(50),
    Name NVARCHAR(100),
    ContactDetails NVARCHAR(255)
);

-- Create Books table
CREATE TABLE Books (
    ISBN VARCHAR(13) PRIMARY KEY,
    Title NVARCHAR(255),
    Author NVARCHAR(255),
    YearOfPublication INT,
    Publisher NVARCHAR(255),
    ImageURLSmall NVARCHAR(255),
    ImageURLMedium NVARCHAR(255),
    ImageURLLarge NVARCHAR(255),
    Available BIT
);

-- Create Transactions table
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY,
    UserID INT,
    BookISBN VARCHAR(13),
    TransactionType NVARCHAR(50),
    TransactionDate DATETIME,
    DueDate DATETIME,
    ReturnDate DATETIME,
    Status NVARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BookISBN) REFERENCES Books(ISBN)
);

-- Create Categories table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(50) UNIQUE
);

-- Create BookCategories table (Many-to-Many relationship between Books and Categories)
CREATE TABLE BookCategories (
    BookISBN VARCHAR(13),
    CategoryID INT,
    PRIMARY KEY (BookISBN, CategoryID),
    FOREIGN KEY (BookISBN) REFERENCES Books(ISBN),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Create Fines table
CREATE TABLE Fines (
    FineID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Amount DECIMAL(10, 2),
    FineDate DATETIME,
    Paid BIT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Create UserFines table (Associative table between Users and Fines)
CREATE TABLE UserFines (
    UserFineID INT PRIMARY KEY IDENTITY,
    UserID INT,
    FineID INT,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (FineID) REFERENCES Fines(FineID)
);

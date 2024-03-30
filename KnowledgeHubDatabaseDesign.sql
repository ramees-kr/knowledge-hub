CREATE TABLE [Users] (
  [UserID] int PRIMARY KEY IDENTITY(1, 1),
  [Username] varchar(255),
  [Password] varchar(255),
  [UserTypeID] int,
  [Name] varchar(255),
  [Email] varchar(255),
  [PhoneNumber] varchar(20)
)
GO

CREATE TABLE [UserType] (
  [TypeId] int PRIMARY KEY,
  [TypeName] varchar(50)
)
GO

CREATE TABLE [Books] (
  [BookID] int PRIMARY KEY IDENTITY(1, 1),
  [Title] varchar(255),
  [Author] varchar(255),
  [Genre] varchar(100),
  [Audience] varchar(50)
)
GO

CREATE TABLE [BookAvailability] (
  [BookID] int PRIMARY KEY,
  [AvailableQty] int
)
GO

CREATE TABLE [BorrowingTransactions] (
  [TransactionID] int PRIMARY KEY IDENTITY(1, 1),
  [UserID] int,
  [BookID] int,
  [BorrowDate] datetime,
  [ReturnDate] datetime,
  [DueDate] datetime,
  [FineAmount] decimal(10,2)
)
GO

CREATE TABLE [Fines] (
  [FineID] int PRIMARY KEY IDENTITY(1, 1),
  [TransactionID] int,
  [FineAmount] decimal(10,2),
  [Paid] boolean,
  [PaymentDate] datetime
)
GO

EXEC sp_addextendedproperty
@name = N'Column_Description',
@value = 'Stored using bcrypt hashing function',
@level0type = N'Schema', @level0name = 'dbo',
@level1type = N'Table',  @level1name = 'Users',
@level2type = N'Column', @level2name = 'Password';
GO

ALTER TABLE [Users] ADD FOREIGN KEY ([UserTypeID]) REFERENCES [UserType] ([TypeId])
GO

ALTER TABLE [BookAvailability] ADD FOREIGN KEY ([BookID]) REFERENCES [Books] ([BookID])
GO

ALTER TABLE [BorrowingTransactions] ADD FOREIGN KEY ([UserID]) REFERENCES [Users] ([UserID])
GO

ALTER TABLE [BorrowingTransactions] ADD FOREIGN KEY ([BookID]) REFERENCES [Books] ([BookID])
GO

ALTER TABLE [Fines] ADD FOREIGN KEY ([TransactionID]) REFERENCES [BorrowingTransactions] ([TransactionID])
GO

--CREATE DATABASE MiniBankBCMFH20NC
--GO

--USE MiniBankBCMFH20NC
--GO
--CREATE TABLE Customers
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	[Name] NVARCHAR(50) NOT NULL,
--	IdentityNumber CHAR(11) CHECK(LEN(IdentityNumber)=11) NOT NULL,
--	PhoneNumber CHAR(25) NOT NULL,
--	Email VARCHAR(50) NOT NULL,
--	CustomerType TINYINT CHECK(CustomerType = 0 OR CustomerType = 1)  NOT NULL
--)


--CREATE TABLE Accounts
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Iban CHAR(22) CHECK(LEN(Iban)=22) NOT NULL,
--	Currency CHAR(3) CHECK(LEN(Currency)=3) NOT NULL,
--	Balance MONEY NOT NULL,
--	[Name] NVARCHAR(MAX) NULL,
--	CustomerId INT FOREIGN KEY REFERENCES Customers(Id)
--)

--CREATE TABLE Operations
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	OperationType TINYINT CHECK(OperationType = 0 OR OperationType = 1 OR OperationType = 2)  NOT NULL,
--	Currency CHAR(3) CHECK(LEN(Currency)=3) NOT NULL,
--	Amount MONEY NOT NULL,
--	HappendAt DATETIME NOT NULL,
--	AccountId INT FOREIGN KEY REFERENCES Accounts(Id)
--)


--CREATE PROCEDURE spGetAllCustomers
--AS
--BEGIN
--	SELECT*FROM Customers
--END


--CREATE PROCEDURE spGetSingleCustomer
--@customerId INT
--AS
--BEGIN
--	SELECT*FROM Customers
--	WHERE Id = @customerId
--END




--CREATE PROCEDURE spUpdateCustomer
--@customerId INT,
--@name NVARCHAR(50),
--@identityNumber CHAR(11),
--@phoneNumber CHAR(25),
--@email VARCHAR(50),
--@customerType TINYINT
--AS
--BEGIN
--	UPDATE Customers
--	SET
--		[Name] = @name,
--		IdentityNumber = @identityNumber,
--		PhoneNumber = @phoneNumber,
--		Email = @email,
--		CustomerType = @customerType
--	WHERE Id = @customerId
--END



--CREATE PROCEDURE spCreateCustomer
--@name NVARCHAR(50),
--@identityNumber CHAR(11),
--@phoneNumber CHAR(25),
--@email VARCHAR(50),
--@customerType TINYINT
--AS
--BEGIN

--	INSERT INTO Customers([Name],IdentityNumber,PhoneNumber,Email,CustomerType)
--	VALUES(@name,@identityNumber,@phoneNumber,@email,@customerType)
--END


--CREATE PROCEDURE spDeleteCustomer
--@customerId INT
--AS
--BEGIN
--	DELETE FROM Customers
--	WHERE Id = @customerId
--END


--CREATE PROCEDURE spGetAccounts
--AS
--BEGIN
--	SELECT*FROM Accounts
--END


--CREATE PROCEDURE spGetAccount
--@accountId INT
--AS
--BEGIN
--	SELECT*FROM Accounts
--	WHERE Id = @accountId 
--END


--CREATE PROCEDURE spGetAccountsOfCustomer
--@customerId INT
--AS
--BEGIN
--	SELECT*FROM Accounts
--	WHERE CustomerId = @customerId
--END



--CREATE PROCEDURE spCreateAccount
--@iban CHAR(22),
--@currency CHAR(3),
--@balance MONEY,
--@name NVARCHAR(MAX),
--@customerId INT
--AS
--BEGIN
--	INSERT INTO Accounts(Iban,Currency,Balance,[Name],CustomerId)
--	VALUES(@iban,@currency,@balance,@name,@customerId)
--END


--CREATE PROCEDURE spUpdateAccount
--@accountId INT,
--@iban CHAR(22),
--@currency CHAR(3),
--@balance MONEY,
--@name NVARCHAR(MAX),
--@customerId INT
--AS
--BEGIN
--	UPDATE Accounts
--	SET
--		Iban = @iban,
--		Currency = @currency,
--		Balance = @balance,
--		[Name] = @name
--	WHERE CustomerId = @customerId
--END


--CREATE PROCEDURE spDeleteAccount
--@accountId INT
--AS
--BEGIN
--	DELETE FROM Accounts
--	WHERE Id = @accountId
--END


--CREATE PROCEDURE spGetOperationsOfAccount
--@accountId INT
--AS
--BEGIN
--	SELECT*
--	FROM Operations
--	WHERE AccountId = @accountId
--END


--CREATE PROCEDURE spCreateOperation
--@operationType TINYINT,
--@currency CHAR(3),
--@amount MONEY,
--@happendAt DATETIME,
--@accountId INT
--AS
--BEGIN
--	INSERT INTO Operations (OperationType,Currency,Amount,HappendAt,AccountId)
--	VALUES(@operationType,@currency,@amount,@happendAt,@accountId)
--END


--CREATE PROCEDURE spGetAccountWithIban
--@iban INT
--AS
--BEGIN
--	SELECT*FROM Accounts
--	WHERE Iban = @iban
--END
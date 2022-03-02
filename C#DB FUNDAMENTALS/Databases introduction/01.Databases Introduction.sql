--1.Create Database 
CREATE DATABASE Minions
--1

--2.Create Tables
CREATE TABLE Minions (
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	Age INT
)

CREATE TABLE Towns(
 Id INT PRIMARY KEY,
 [Name] NVARCHAR(50) NOT NULL,
)
--2

--3.Alter Minions Table
ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD CONSTRAINT FK_Towns_Minions FOREIGN KEY(TownId) 
REFERENCES Towns(Id)
--3

--4.Insert Records in Both Tables
INSERT INTO Towns(Id, [Name]) VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO Minions(Id, [Name], Age, TownId) VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)
--4

--5.Truncate Table Minions
TRUNCATE TABLE Minions
--5

--6.Drop All Tables
DROP TABLE Minions
DROP TABLE Towns
--6

--7.Create Table People
CREATE TABLE People(
	Id INT PRIMARY KEY NOT NULL IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY,
	Height DECIMAL(3,2),
	[Weight] DECIMAL(5,2),
	Gender CHAR(1) NOT NULL,
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People ([Name], Picture, Height, [Weight], Gender, Birthdate, Biography)
VALUES ('Aleksander', NULL, 0.85, 13, 'm', '2018-11-09', 'Sashko'),
('Aleksander', NULL, 0.85, 13, 'm', '2018-11-09', 'Sashko'),
('Aleksander', NULL, 0.85, 13, 'm', '2018-11-09', 'Sashko'),
('Aleksander', NULL, 0.85, 13, 'm', '2018-11-09', 'Sashko'),
('Aleksander', NULL, 0.85, 13, 'm', '2018-11-09', 'Sashko');
--7

--8.Create Table Users


CREATE TABLE Users(
	Id BIGINT PRIMARY KEY IDENTITY,
	UserName VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX),
	CHECK (DATALENGTH(ProfilePicture) <= 926600),
	LastLoginTime DATETIME2,
	IsDeleted BIT NOT NULL
)

INSERT INTO Users (UserName, [Password], ProfilePicture, LastLoginTime, IsDeleted) VALUES
('Pesho', '1234215', NULL, NULL, 0),
('PETUR', '1234215', NULL, NULL, 0),
('KIRO', '1234215', NULL, NULL, 0),
('roKI', '1234215', NULL, NULL, 0),
('Petko', '1234215', NULL, NULL, 0)
--8

--9.Change Primary Key
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC07B3A48BEC

ALTER TABLE Users
ADD CONSTRAINT PK_Id_UserName PRIMARY KEY(Id, UserName)
--9

--10.Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT CH_Password
CHECK (LEN([Password]) >= 5)
--10

--11.Set Default Value of a Field

ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime
--11

--12.Set Unique Field
ALTER TABLE Users
DROP CONSTRAINT PK_Id_UserName

ALTER TABLE Users
ADD CONSTRAINT PK_Id PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT UQ_UserName UNIQUE(UserName)

ALTER TABLE Users
ADD CONSTRAINT CHK_UserName
CHECK (LEN(UserName) >= 3)
--12

--13.Movies Database
CREATE TABLE Directors(
	Id INT PRIMARY KEY IDENTITY,
	DirectorName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX) 
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(30) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Movies(
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(50) NOT NULL,
	DirectorId INT FOREIGN KEY REFERENCES Directors(Id),
	CopyrightYear DATE NOT NULL,
	[Length] INT NOT NULL,
	GenreId INT FOREIGN KEY REFERENCES Genres(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Raitings DECIMAL(2,1),
	Notes NVARCHAR(MAX)
)

INSERT INTO Directors (DirectorName, Notes) VALUES
('Pesho1', NULL),
('Pesho2', NULL),
('Pesho3', NULL),
('Pesho4', NULL),
('Pesho5', NULL)

INSERT INTO Genres (GenreName, Notes) VALUES
('Fantastic', NULL),
('Comedy', NULL),
('Action', NULL),
('Psycho', NULL),
('Anime', NULL)

INSERT INTO Categories (CategoryName, Notes) VALUES
('Fun', NULL),
('Fun', NULL),
('Fun', NULL),
('Creepy', NULL),
('Fun', NULL)



INSERT INTO Movies (Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Raitings, Notes) VALUES
('POCHIVKA', 1, '2011-11-04', 123, 1, 1, 5.9, NULL),
('POCHIVKA1', 2, '2011-11-04', 123, 2, 2, 5.9, NULL),
('POCHIVKA2', 3, '2011-11-04', 123, 3, 3, 5.9, NULL),
('POCHIVKA3', 4, '2011-11-04', 123, 4, 4, 5.9, NULL),
('POCHIVKA4', 5, '2011-11-04', 123, 5, 5, 5.9, NULL)
--13

--14.Car Rental Database
CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(30) NOT NULL,
	DailyRate Decimal(2,1),
	WeeklyRate Decimal(2,1),
	MonthlyRate Decimal(2,1),
	WeekendRate Decimal(2,1)
)

CREATE TABLE Cars(
	Id INT PRIMARY KEY IDENTITY,
	PlateNumber NVARCHAR(10) NOT NULL,
	Manufacturer NVARCHAR(10) NOT NULL,
	Model NVARCHAR(10) NOT NULL,
	CarYear INT NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	Doors INT NOT NULL,
	Picture VARBINARY,
	Condition NVARCHAR(10),
	Available BIT NOT NULL
)

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Title NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Customers(
	Id INT PRIMARY KEY IDENTITY,
	DriverLicenceNumber NVARCHAR(20) NOT NULL,
	FullName NVARCHAR(60) NOT NULL,
	[Address] NVARCHAR(50) NOT NULL,
	City NVARCHAR(15) NOT NULL,
	ZIPCode INT,
	Notes NVARCHAR(MAX)
)

CREATE TABLE RentalOrders (
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	CustomerId INT FOREIGN KEY REFERENCES Customers(Id),
	CarId INT FOREIGN KEY REFERENCES Cars(Id),
	TankLevel Decimal(5, 2) NOT NULL,
	KilometrageStart Decimal(5, 2) NOT NULL,
	KilometrageEnd Decimal (5, 2) NOT NULL,
	TotalKilometrage DECIMAL(5, 2) NOT NULL,
	StartDate DATE NOT NULL, 
	EndDate DATE NOT NULL,
	TotalDays INT NOT NULL,
	RateApplied DECIMAL(2, 1),
	TaxRate DECIMAL(2,1),
	OrderStatus NVARCHAR(10) NOT NULL,
	Notes NVARCHAR(MAX)
)

INSERT INTO Categories (CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) VALUES
('Sedan', NULL, NULL, NULL, NULL),
('Combi', NULL, NULL, NULL, NULL),
('Sedan', NULL, NULL, NULL, NULL)



INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) VALUES
('CA1234KC', 'MERCEDES', 'BENZ', 2014, 1, 4, NULL, NULL, 1),
('CB1444KC', 'MERCEDES', 'BENZ', 2018, 2, 4, NULL, NULL, 1),
('CA5555KC', 'AUDI', 'A4', 2020, 3, 4, NULL, NULL, 1)



INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES
('GOSHO', 'GESHEV', 'CHEF', NULL),
('PESHO', 'GESHEV', 'RABOTNIK', NULL),
('DANCHO', 'PENEV', 'CHISTACH', NULL)

INSERT INTO Customers(DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes) VALUES
('32781361276', 'PETUR PETROV', 'JK MLADOST', 'SOFIA', NULL, NULL),
('32421612786', 'PETUR GEORGIEV', 'JK MLADOST', 'SOFIA', NULL, NULL),
('34212112786', 'GEORGI PETROV', 'JK MLADOST', 'SOFIA', NULL, NULL)



INSERT INTO RentalOrders(EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, TotalKilometrage, StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1, 1,1, 55.0, 0.0, 25.0, 25.0, '2020-10-1', '2020-10-3', 2, NULL, NULL, 'TAKEN', NULL),
(2, 2,2, 55.0, 0.0, 25.0, 25.0, '2020-10-1', '2020-10-3', 2, NULL, NULL, 'TAKEN', NULL),
(3, 3,3, 55.0, 0.0, 25.0, 25.0, '2020-10-1', '2020-10-3', 2, NULL, NULL, 'TAKEN', NULL)
--14

--15.Hotel Database
CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Title NVARCHAR(15) NOT NULL,
	Notes TEXT

)

INSERT INTO Employees (FirstName, LastName, Title, Notes) VALUES
('P', 'P', 'CH', NULL),
('G', 'G', 'C', NULL),
('T', 'T', 'T', NULL)

CREATE TABLE Customers(
	AccountNumber INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	PhoneNumber NVARCHAR(15) NOT NULL,
	EmergencyName NVARCHAR(20) NOT NULL,
	EmergencyNumber NVARCHAR(15) NOT NULL,
	Notes TEXT
)

INSERT INTO Customers(FirstName, LastName, PhoneNumber, EmergencyName, EmergencyNumber, Notes) VALUES
('M', 'M', '08456454', 'SOS', '112', NULL),
('V', 'V', '08423164', 'SOS', '112', NULL),
('K', 'P', '08798512', 'SOS', '112', NULL)


CREATE TABLE RoomStatus(
	RoomStatus NVARCHAR(50) PRIMARY KEY NOT NULL,
	Notes TEXT
)



INSERT INTO RoomStatus(RoomStatus, Notes) VALUES
('CLEANED', NULL),
('NOTCLEANED', NULL),
('C', NULL)

CREATE TABLE RoomTypes(
	RoomType NVARCHAR(20) PRIMARY KEY NOT NULL,
	Notes TEXT
)


INSERT INTO RoomTypes(RoomType, Notes) VALUES
('APARTMENT', NULL),
('ROOM', NULL),
('ROOM1', NULL)

CREATE TABLE BedTypes (
	BedType NVARCHAR(15) PRIMARY KEY NOT NULL,
	Notes TEXT

)

INSERT INTO BedTypes(BedType, Notes) VALUES
('1', NULL),
('2', NULL),
('SOFA', NULL)


CREATE TABLE Rooms(
	RoomNumber INT PRIMARY KEY IDENTITY,
	RoomType NVARCHAR(20) FOREIGN KEY REFERENCES RoomTypes(RoomType),
	BedType NVARCHAR(15) FOREIGN KEY REFERENCES BedTypes(BedType),
	Rate DECIMAL,
	RoomStatus NVARCHAR(50) FOREIGN KEY REFERENCES RoomStatus(RoomStatus),
	Notes TEXT
)

INSERT INTO Rooms(RoomType, BedType, Rate, RoomStatus, Notes) VALUES
('APARTMENT', '1', 5.7, 'CLEANED', NULL),
('ROOM', '2', 5.7, 'NOTCLEANED', NULL),
('ROOM1', 'SOFA', 5.7, 'C', NULL)

CREATE TABLE Payments(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	PaymentDate DATE NOT NULL,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	FirstDateOccupied DATE NOT NULL,
	LastDateOccupied DATE NOT NULL,
	TotalDays INT NOT NULL,
	AmountCharged DECIMAL NOT NULL,
	TaxRate DECIMAL,
	TaxAmount DECIMAL NOT NULL,
	PaymentTotal DECIMAL NOT NULL,
	Notes TEXT
)

INSERT INTO Payments(EmployeeId, PaymentDate, AccountNumber, FirstDateOccupied, LastDateOccupied, TotalDays, AmountCharged, TaxRate, TaxAmount, PaymentTotal, Notes) VALUES
(1, '2020-01-01', 1, '2020-01-10', '2020-01-15', 5, 523.56, NULL, 40.00, 563.56, NULL),
(2, '2020-01-01', 2, '2020-01-10', '2020-01-15', 5, 523.56, NULL, 40.00, 563.56, NULL),
(3, '2020-01-01', 3, '2020-01-10', '2020-01-15', 5, 523.56, NULL, 40.00, 563.56, NULL)

CREATE TABLE Occupancies(
	Id INT PRIMARY KEY IDENTITY,
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id),
	DateOccupied DATE,
	AccountNumber INT FOREIGN KEY REFERENCES Customers(AccountNumber),
	RoomNumber INT FOREIGN KEY REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL,
	PhoneCharge NVARCHAR(10),
	Notes TEXT

)

INSERT INTO Occupancies(EmployeeId, DateOccupied, AccountNumber, RoomNumber, RateApplied, PhoneCharge, Notes) VALUES
(1, NULL, 1, 1, NULL, NULL, NULL),
(2, NULL, 2, 2, NULL, NULL, NULL),
(3, NULL, 3, 3, NULL, NULL, NULL)
--15


--19.Basic Select All Fields
SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees
--19


--20.Basic Select All Fields and Order Them
SELECT * FROM Towns
ORDER BY [Name] ASC
SELECT * FROM Departments
ORDER BY [Name] ASC
SELECT * FROM Employees
ORDER BY Salary DESC
--20

--21.Basic Select Some Fields

SELECT [Name] FROM Towns
ORDER BY [Name] ASC
SELECT [Name] FROM Departments
ORDER BY [Name] ASC
SELECT [FirstName], [LastName], [JobTitle], [Salary] FROM Employees
ORDER BY Salary DESC
--21


--22. Increase Employees Salary
UPDATE Employees SET Salary = Salary * 1.1
SELECT Salary FROM Employees
--22

--23. Decrease Tax Rate
UPDATE Payments SET TaxRate = TaxRate * 0.97
SELECT TaxRate FROM Payments
--23

--24. Delete All Records
TRUNCATE TABLE Occupancies
--24

--1. Employees with Salary Above 35000
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT FirstName, LastName
		FROM Employees
			WHERE Salary > 35000
END

EXEC usp_GetEmployeesSalaryAbove35000
--1

--2. Employees with Salary Above Number
CREATE PROC usp_GetEmployeesSalaryAboveNumber @Number DECIMAL(18,4)
AS
BEGIN
	SELECT FirstName, LastName
		FROM Employees
			WHERE Salary >= @Number
END

EXEC usp_GetEmployeesSalaryAboveNumber 48100
--2

--3. Town Names Starting With
CREATE PROC usp_GetTownsStartingWith @StartingWith VARCHAR(50)
AS
BEGIN
	SELECT [Name] AS [Town]
		FROM Towns
			WHERE LEFT([Name], LEN(@StartingWith)) = @StartingWith
END

EXEC usp_GetTownsStartingWith 'b'
--3

--4. Employees from Town
CREATE PROC usp_GetEmployeesFromTown @Town NVARCHAR(50)
AS
BEGIN
	SELECT FirstName, LastName
		FROM Employees AS e
			JOIN Addresses AS a
			ON e.AddressID = a.AddressID
			JOIN Towns AS t
			ON t.TownID = a.TownID
				WHERE t.[Name] = @Town
END

EXEC usp_GetEmployeesFromTown 'Sofia'
--4

--5. Salary Level Function
CREATE FUNCTION ufn_GetSalaryLevel (@Salary DECIMAL(18,4))
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @SalaryLevel NVARCHAR(10)
	BEGIN
		IF( @Salary < 30000)
		BEGIN
			SET @SalaryLevel = 'Low'
		END
		ELSE IF( @Salary BETWEEN 30000 AND 50000)
		BEGIN
			SET @SalaryLevel = 'Average'
		END
		ELSE
		BEGIN
			SET @SalaryLevel = 'High'
		END
		RETURN @SalaryLevel
	END 
END 

SELECT e.Salary, dbo.ufn_GetSalaryLevel(e.Salary) AS [Salary Level]
	FROM Employees AS e
--5

--6. Employees by Salary Level
CREATE PROC usp_EmployeesBySalaryLevel @Param NVARCHAR(10)
AS
BEGIN
	SELECT FirstName AS [First Name], LastName AS [Last Name]
		FROM Employees
			WHERE @Param = dbo.ufn_GetSalaryLevel(Salary)
END

EXEC usp_EmployeesBySalaryLevel 'High'
--6

--7. Define Function
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(50), @word VARCHAR(50)) 
RETURNS BIT
AS
BEGIN
DECLARE @currentIndex int = 1;

WHILE(@currentIndex <= LEN(@word))
	BEGIN

	DECLARE @currentLetter varchar(1) = SUBSTRING(@word, @currentIndex, 1);

	IF(CHARINDEX(@currentLetter, @setOfLetters)) = 0
	BEGIN
	RETURN 0;
	END

	SET @currentIndex += 1;
	END

RETURN 1;
END
--7

--8. Delete Employees and Departments

CREATE PROC usp_DeleteEmployeesFromDepartment (@departmentId INT)
AS

DECLARE @empIDsToBeDeleted TABLE
(
Id int
)

INSERT INTO @empIDsToBeDeleted
SELECT e.EmployeeID
FROM Employees AS e
WHERE e.DepartmentID = @departmentId

ALTER TABLE Departments
ALTER COLUMN ManagerID int NULL

DELETE FROM EmployeesProjects
WHERE EmployeeID IN (SELECT Id FROM @empIDsToBeDeleted)

UPDATE Employees
SET ManagerID = NULL
WHERE ManagerID IN (SELECT Id FROM @empIDsToBeDeleted)

UPDATE Departments
SET ManagerID = NULL
WHERE ManagerID IN (SELECT Id FROM @empIDsToBeDeleted)

DELETE FROM Employees
WHERE EmployeeID IN (SELECT Id FROM @empIDsToBeDeleted)

DELETE FROM Departments
WHERE DepartmentID = @departmentId 

SELECT COUNT(*) AS [Employees Count] FROM Employees AS e
JOIN Departments AS d
ON d.DepartmentID = e.DepartmentID
WHERE e.DepartmentID = @departmentId
--8

--9. Find Full Name
CREATE PROC usp_GetHoldersFullName 
AS
BEGIN
	SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
		FROM AccountHolders
END

EXEC usp_GetHoldersFullName
--9
--10. People with Balance Higher Than
CREATE PROC usp_GetHoldersWithBalanceHigherThan @Number MONEY
AS
BEGIN
	SELECT FirstName AS [First Name], LastName AS [Last Name]
		FROM AccountHolders AS ac
			JOIN Accounts AS a
				ON a.AccountHolderId = ac.Id
					GROUP BY ac.FirstName, ac.LastName
						HAVING SUM(Balance) > @Number
							ORDER BY ac.FirstName, AC.LastName
END
--10

--11. Future Value Function
CREATE FUNCTION ufn_CalculateFutureValue(@Sum DECIMAL(15,4), @YearlyInterestRate FLOAT, @Years INT)
RETURNS DECIMAL(15,4)
AS
BEGIN
	DECLARE @Calculate DECIMAL(15,4)
	BEGIN
		SET @Calculate = @Sum * POWER((1 + @YearlyInterestRate), @Years)
	RETURN @Calculate
	END
END

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)
--11

--12. Calculating Interest
CREATE PROC usp_CalculateFutureValueForAccount @AcountId INT, @InterestRate FLOAT
AS
BEGIN
	SELECT @AcountId AS [Acount Id],
	ah.FirstName AS [First Name],
	ah.LastName AS [Last Name], 
	a.Balance AS [Current Balance],
	dbo.ufn_CalculateFutureValue(a.Balance, @InterestRate, 5) AS [Balance in 5 years]
		FROM AccountHolders AS ah
		JOIN Accounts AS a
		ON a.AccountHolderId = ah.Id
			WHERE a.Id = @AcountId
END

EXEC usp_CalculateFutureValueForAccount 1, 0.1
--12

--13. *Cash in User Games Odd Rows
CREATE FUNCTION ufn_CashInUsersGames(@Game VARCHAR(50))
RETURNS TABLE
AS
RETURN
SELECT SUM([k].[Cash]) AS [SumCash]
  FROM (
SELECT [ug].[Cash] AS [Cash],
       ROW_NUMBER() OVER (PARTITION BY [g].[Name] ORDER BY [ug].[Cash] DESC) AS [Row]
  FROM [dbo].[Games] AS g
  JOIN [dbo].[UsersGames] AS [ug] ON [g].[Id] = [ug].[GameId]
 WHERE [g].[Name] = @Game) AS k
 WHERE [k].[Row] % 2 = 1
--13

--14. Create Table Logs
CREATE TABLE Logs (
	LogId INT PRIMARY KEY IDENTITY,
	AccountId INT,
	OldSum MONEY,
	NewSum MONEY
)

CREATE TRIGGER tr_ChangeBalance ON Accounts
AFTER UPDATE
AS
BEGIN
INSERT INTO Logs(AccountID,OldSum,NewSum)
SELECT i.Id, d.Balance, i.Balance 
FROM inserted AS i
INNER JOIN deleted AS d
ON i.Id = d.Id
END
--14

--15. Create Table Emails
CREATE TABLE NotificationEmails (
	Id INT PRIMARY KEY IDENTITY,
	Recipient INT,
	[Subject] VARCHAR(500),
	Body VARCHAR(500)
)

CREATE TRIGGER tr_EmailsNotificationsAfterInsert
ON Logs AFTER INSERT 
AS
BEGIN
INSERT INTO NotificationEmails(Recipient,[Subject],Body)
SELECT i.AccountID, 
CONCAT('Balance change for account: ',i.AccountId),
CONCAT('On ',GETDATE(),' your balance was changed from ',i.NewSum,' to ',i.OldSum)
  FROM inserted AS i
END

--15

--16. Deposit Money
CREATE PROC usp_DepositMoney @AccountId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION
		UPDATE Accounts SET Balance = Balance + @MoneyAmount
		WHERE Id = @AccountId
		IF @MoneyAmount < 0 OR @MoneyAmount IS NULL
		BEGIN
			ROLLBACK
			RETURN
		END
	COMMIT
END
--16

--17. Withdraw Money Procedure
CREATE PROC usp_WithdrawMoney @AccountId INT, @MoneyAmount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION
	UPDATE Accounts SET Balance = Balance - @MoneyAmount
	WHERE Id = @AccountId
	IF @MoneyAmount < 0 OR @MoneyAmount IS NULL
	BEGIN
		ROLLBACK
		RETURN
	END
	COMMIT
END
--17

--18. Money Transfer
CREATE PROC usp_TransferMoney @SenderId INT, @ReciverId INT, @Amount DECIMAL(15,4)
AS
BEGIN
	BEGIN TRANSACTION
	EXEC usp_WithdrawMoney @SenderId, @Amount
	EXEC usp_DepositMoney @ReciverId, @Amount
	IF @Amount < 0 OR @Amount IS NULL
	BEGIN
		ROLLBACK
		RETURN
	END
	COMMIT
END
--18

--19. *Massive Shopping
DECLARE @UserName VARCHAR(50) = 'Stamat'
DECLARE @GameName VARCHAR(50) = 'Safflower'
DECLARE @UserID int = (SELECT Id FROM Users WHERE Username = @UserName)
DECLARE @GameID int = (SELECT Id FROM Games WHERE Name = @GameName)
DECLARE @UserMoney money = (SELECT Cash FROM UsersGames WHERE UserId = @UserID AND GameId = @GameID)
DECLARE @ItemsTotalPrice money
DECLARE @UserGameID int = (SELECT Id FROM UsersGames WHERE UserId = @UserID AND GameId = @GameID)

BEGIN TRANSACTION
	SET @ItemsTotalPrice = (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN 11 AND 12)

	IF(@UserMoney - @ItemsTotalPrice >= 0)
	BEGIN
		INSERT INTO UserGameItems
		SELECT i.Id, @UserGameID FROM Items AS i
		WHERE i.Id IN (SELECT Id FROM Items WHERE MinLevel BETWEEN 11 AND 12)

		UPDATE UsersGames
		SET Cash -= @ItemsTotalPrice
		WHERE GameId = @GameID AND UserId = @UserID
		COMMIT
	END
	ELSE
	BEGIN
		ROLLBACK
	END

SET @UserMoney = (SELECT Cash FROM UsersGames WHERE UserId = @UserID AND GameId = @GameID)
BEGIN TRANSACTION
	SET @ItemsTotalPrice = (SELECT SUM(Price) FROM Items WHERE MinLevel BETWEEN 19 AND 21)

	IF(@UserMoney - @ItemsTotalPrice >= 0)
	BEGIN
		INSERT INTO UserGameItems
		SELECT i.Id, @UserGameID FROM Items AS i
		WHERE i.Id IN (SELECT Id FROM Items WHERE MinLevel BETWEEN 19 AND 21)

		UPDATE UsersGames
		SET Cash -= @ItemsTotalPrice
		WHERE GameId = @GameID AND UserId = @UserID
		COMMIT
	END
	ELSE
	BEGIN
		ROLLBACK
	END

SELECT Name AS [Item Name]
FROM Items
WHERE Id IN (SELECT ItemId FROM UserGameItems WHERE UserGameId = @userGameID)
ORDER BY [Item Name]
--19

--20. Employees with Three Projects

CREATE PROC usp_AssignProject @employeeId INT, @projectId INT
AS
BEGIN
	BEGIN TRANSACTION
		INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
		VALUES
		(@employeeId, @projectId)
		

		
		IF (
			SELECT COUNT(ProjectID) AS [Count]
			FROM EmployeesProjects
				WHERE EmployeeID = @employeeId
				) > 3
		BEGIN
			ROLLBACK
			RAISERROR('The employee has too many projects!', 16, 1);
			RETURN
		END

	COMMIT
END

EXEC usp_AssignProject 1, 2
--20

--21. Delete Employee
CREATE TRIGGER tr_DeleteEmployees
  ON Employees
  AFTER DELETE
AS
  BEGIN
    INSERT INTO Deleted_Employees
      SELECT FirstName,LastName,MiddleName,JobTitle,DepartmentID,Salary
      FROM deleted
  END
--21
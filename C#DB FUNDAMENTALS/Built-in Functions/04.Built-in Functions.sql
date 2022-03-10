--1. Find Names of All Employees by First Name
SELECT FirstName, LastName
	FROM Employees
		WHERE LEFT(FirstName, 2) = 'Sa'
--1
--2.Find Names of All employees by Last Name
SELECT FirstName, LastName
	FROM Employees
		WHERE LastName LIKE '%ei%'
--2

--3. Find First Names of All Employees
SELECT FirstName
	FROM Employees
		WHERE DepartmentID IN (3, 10) AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005
--3

--4. Find All Employees Except Engineers
SELECT FirstName, LastName
	FROM Employees
		WHERE JobTitle NOT LIKE '%engineer%'
--4

--5. Find Towns with Name Length
SELECT [Name]
	FROM Towns
		WHERE LEN([Name]) BETWEEN 5 AND 6
			ORDER BY [Name]
--5

--6. Find Towns Starting With
SELECT TownID, [Name]
	FROM Towns
		WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
			ORDER BY [Name]
--6

--7. Find Towns Not Starting With
SELECT TownID, [Name]
	FROM Towns
		WHERE LEFT([Name], 1) NOT IN ('R', 'B', 'D')
			ORDER BY [Name]
--7

--8. Create View Employees Hired After 2000 Year
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
	FROM Employees
		WHERE DATEPART(YEAR, HireDate) > 2000
--8

--9. Length of Last Name
SELECT FirstName, LastName
	FROM Employees
		WHERE LEN(LastName) = 5
--9

--10. Rank Employees by Salary
SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeID ) AS [Rank]
	FROM Employees
		WHERE Salary BETWEEN 10000 AND 50000
			ORDER BY Salary DESC
--10

--11. Find All Employees with Rank 2 *
SELECT *
	FROM(
SELECT EmployeeID, FirstName, LastName, Salary, DENSE_RANK() OVER(PARTITION BY Salary ORDER BY EmployeeID ) AS [Rank]
	FROM Employees
		WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
		WHERE [Rank] = 2
			ORDER BY Salary DESC

--11

--12. Countries Holding 'A'
SELECT CountryName, IsoCode
	FROM Countries
		WHERE CountryName LIKE '%a%%a%%a%'
			ORDER BY IsoCode
--12

--13. Mix of Peak and River Names
SELECT Peaks.PeakName,
       Rivers.RiverName,
       LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName)-1), Rivers.RiverName)) AS Mix
FROM Peaks,
     Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix
--13

--14. Games From 2011 and 2012 Year
SELECT TOP(50) [Name], FORMAT(Start, 'yyyy-MM-dd', 'bg-BG') AS [Start]
	FROM Games
		WHERE DATEPART(YEAR, Start) IN (2011, 2012)
			ORDER BY [Start], [Name]
--14

--15. User Email Providers
SELECT Username,
       RIGHT(Email, LEN(Email)-CHARINDEX('@', Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider],
         Username;
--15

--16. Get Users with IPAddress Like Pattern
SELECT Username, IpAddress
	FROM Users
		WHERE IpAddress LIKE '___.1_%._%.___'
			ORDER BY Username
--16

--17. Show All Games with Duration
SELECT Name AS [Game],
	CASE
		WHEN DATEPART(HOUR, Start) BETWEEN 0 AND 11
		THEN 'Morning'
		WHEN DATEPART (HOUR, Start) BETWEEN 12 AND 17
		THEN 'Afternoon'
		WHEN DATEPART(HOUR, Start) BETWEEN 18 AND 23
		THEN 'Evening'
	END AS [Part of the Day],
	CASE 
		WHEN Duration <= 3
		THEN 'Extra Short'
		WHEN Duration BETWEEN 4 AND 6
		THEN 'Short'
		WHEN Duration > 6
		THEN 'Long'
		WHEN Duration IS NULL
		THEN 'Extra Long'
	END AS [Duration]
	FROM Games
	ORDER BY [Game] ASC, [Duration] ASC, [Part of the Day] ASC
--17

--18. Orders Table
SELECT ProductName, OrderDate, DATEADD(DAY, 3, OrderDate) AS [Pay Due], DATEADD(MONTH, 1, OrderDate) AS [Deliver Due]
	FROM Orders
--18
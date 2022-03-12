--1. Employee Address
SELECT TOP(5) e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText
	FROM Employees AS e
		JOIN Addresses AS a
			ON e.AddressID = a.AddressID
				ORDER BY AddressID
--1

--2. Addresses with Towns
SELECT TOP(50) FirstName, LastName, t.[Name] AS [Town], a.AddressText
	FROM Employees AS e
		JOIN Addresses AS a
			ON e.AddressID = a.AddressID
		JOIN Towns AS t
			ON t.TownID = a.TownID
				ORDER BY FirstName, LastName
--2

--3. Sales Employees
SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name] AS [DepartmentName]
	FROM Employees AS e
		JOIN Departments AS d
			ON d.DepartmentID = e.DepartmentID
				WHERE d.[Name] = 'Sales'
					ORDER BY EmployeeID
--3

--4. Employee Departments
SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, d.[Name] AS [DepartmentName]
	FROM Employees AS e
		JOIN Departments AS d
			ON d.DepartmentID = e.DepartmentID
				WHERE e.Salary > 15000
					ORDER BY d.DepartmentID
--4

--5. Employees Without Projects
SELECT TOP(3) e.EmployeeID, e.FirstName
	FROM Employees AS e
		FULL JOIN EmployeesProjects AS ep
			ON ep.EmployeeID = e.EmployeeID
				WHERE ep.EmployeeID IS NULL
					ORDER BY e.EmployeeID
--5

--6. Employees Hired After
SELECT e.FirstName, e.LastName, e.HireDate, d.[Name] AS [DeptName]
	FROM Employees AS e
		JOIN Departments AS d
			ON d.DepartmentID = e.DepartmentID
				WHERE e.HireDate > '01.01.1999' AND d.[Name] IN ('Sales', 'Finance')
					ORDER BY e.HireDate
--6

--7. Employees With Project
SELECT TOP(5) e.EmployeeID, e.FirstName, p.[Name] AS [ProjectName]
	FROM Employees AS e
		JOIN EmployeesProjects AS ep
			ON e.EmployeeID = ep.EmployeeID
		JOIN Projects AS p
			ON p.ProjectID = ep.ProjectID
				WHERE p.StartDate > '08.13.2002' AND p.EndDate IS NULL
					ORDER BY e.EmployeeID
--7

--8. Employee 24
SELECT e.EmployeeID, e.FirstName,
			CASE
			WHEN DATEPART(YEAR, p.StartDate) >= 2005 THEN NULL
			ELSE p.[Name]
		END AS [ProjectName]
	FROM Employees AS e
		JOIN EmployeesProjects AS ep
			ON e.EmployeeID = ep.EmployeeID
		JOIN Projects AS p
			ON p.ProjectID = ep.ProjectID
				WHERE e.EmployeeID = 24
--8

--9. Employee Manager
SELECT e.EmployeeID, e.FirstName,m.EmployeeID AS [ManagerID], m.FirstName AS [ManagerName]
	FROM Employees AS e
		JOIN Employees AS m
			ON m.EmployeeID = e.ManagerID
				WHERE e.ManagerID IN (3, 7)
					ORDER BY e.EmployeeID
--9

--10. Employees Summary
SELECT TOP(50)
	e.EmployeeID, 
	CONCAT(e.FirstName, ' ', e.LastName) AS [EmployeeName],
	CONCAT(m.FirstName, ' ', m.LastName) AS [ManagerName],
	d.[Name] AS [DepartmentName]
		FROM Employees AS e
			JOIN Employees AS m
				ON m.EmployeeID = e.ManagerID
			JOIN Departments AS d
				ON d.DepartmentID = e.DepartmentID
					ORDER BY e.EmployeeID
--10

--11. Min Average Salary
SELECT MIN(a.AverageSalary) AS [MinAverageSalary]
	FROM
	(
		SELECT e.DepartmentID, AVG(Salary) AS [AverageSalary]
			FROM Employees AS e
		GROUP BY e.DepartmentID
	) AS a
--11

--12. Highest Peaks in Bulgaria
SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
	FROM Countries AS c
		JOIN MountainsCountries AS mc
			ON c.CountryCode = mc.CountryCode
		JOIN Mountains AS m
			ON m.Id = mc.MountainId
		JOIN Peaks AS p
			ON p.MountainId = m.Id
				WHERE c.CountryCode = 'BG' AND p.Elevation > 2835
					ORDER BY p.Elevation DESC
--12

--13. Count Mountain Ranges
SELECT c.CountryCode, COUNT(m.MountainRange) AS [MountainRanges]
	FROM Countries AS c
		JOIN MountainsCountries AS mc
			ON c.CountryCode = mc.CountryCode
		JOIN Mountains AS m
			ON m.Id = mc.MountainId
				WHERE c.CountryCode IN ('BG', 'RU', 'US')
					GROUP BY c.CountryCode
--13

--14. Countries With or Without Rivers
SELECT TOP(5) c.CountryName, r.RiverName
	FROM Countries AS c
		LEFT JOIN CountriesRivers AS cr
			ON c.CountryCode = cr.CountryCode
		LEFT JOIN Rivers AS r
			ON r.Id = cr.RiverId
		LEFT JOIN Continents AS con
			ON con.ContinentCode = c.ContinentCode
				WHERE con.ContinentCode = 'AF'
				 ORDER BY c.CountryName
--14

--15. Continents and Currencies
WITH Cte_CurrenciesByContinent (ContinentCode, CurrencyCode, CurrencyUsage) AS
(
SELECT  c.ContinentCode,
        c.CurrencyCode,
        COUNT(c.CurrencyCode) AS CurrencyUsage
FROM Continents cont
LEFT JOIN Countries c ON cont.ContinentCode = c.ContinentCode 
LEFT JOIN Currencies curr ON c.CurrencyCode = curr.CurrencyCode
GROUP BY c.CurrencyCode, c.ContinentCode
)
SELECT
       ContinentCode,
       CurrencyCode,
       CurrencyUsage
FROM Cte_CurrenciesByContinent c
WHERE CurrencyUsage IN (SELECT MAX(CurrencyUsage) FROM Cte_CurrenciesByContinent c2 WHERE c.ContinentCode = c2.ContinentCode) 
      AND CurrencyUsage != 1
ORDER BY ContinentCode
--15

--16. Countries Without any Mountains
SELECT COUNT(c.CountryCode) AS [Count]
	FROM Countries AS c
		LEFT JOIN MountainsCountries AS mc
			ON c.CountryCode = mc.CountryCode
				WHERE mc.MountainId IS NULL
--16

--17. Highest Peak and Longest River by Country
SELECT TOP(5) c.CountryName, MAX(p.Elevation) AS [HighestPeakElevation], MAX(r.Length) AS [LongestRiverLength]
FROM Countries AS c
LEFT OUTER JOIN MountainsCountries AS mc ON c.CountryCode = mc.CountryCode
LEFT OUTER JOIN Peaks AS p ON p.MountainId = mc.MountainId
LEFT OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
LEFT OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC, c.CountryName
--17

--18. Highest Peak Name and Elevation by Country
WITH chp AS
(SELECT
   c.CountryName,
   p.PeakName,
   p.Elevation,
   m.MountainRange,
   ROW_NUMBER()
   OVER ( PARTITION BY c.CountryName
     ORDER BY p.Elevation DESC ) AS rn
 FROM Countries AS c
   LEFT JOIN CountriesRivers AS cr
     ON c.CountryCode = cr.CountryCode
   LEFT JOIN MountainsCountries AS mc
     ON mc.CountryCode = c.CountryCode
   LEFT JOIN Mountains AS m
     ON mc.MountainId = m.Id
   LEFT JOIN Peaks p
     ON p.MountainId = m.Id)

SELECT TOP 5
  chp.CountryName                           AS [Country],
  ISNULL(chp.PeakName, '(no highest peak)') AS [Highest Peak Name],
  ISNULL(chp.Elevation, 0)                  AS [Highest Peak Elevation],
  CASE WHEN chp.PeakName IS NOT NULL
    THEN chp.MountainRange
  ELSE '(no mountain)' END                  AS [Mountain]
FROM chp
WHERE rn = 1
ORDER BY chp.CountryName ASC, chp.PeakName ASC
--18
--1.Records Count
SELECT COUNT(Id) AS [Count]
FROM WizzardDeposits
--1

--2.Longest Magic Wand
SELECT MAX(MagicWandSize) AS [LongestMagicWand]
	FROM WizzardDeposits
--2

--3.Longest Magic Wand per Deposit Groups
SELECT DepositGroup, MAX(MagicWandSize) AS [LongestMagicWand]
	FROM WizzardDeposits
		GROUP BY DepositGroup
--3

--4.Smallest Deposit Group per Magic Wand Size
SELECT TOP(2) DepositGroup
	FROM WizzardDeposits
		GROUP BY DepositGroup
			ORDER BY AVG(MagicWandSize)
--4

--05.Deposits Sum
SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
	FROM WizzardDeposits
		GROUP BY DepositGroup
--5

--6.Deposits Sum for Ollivander Family
SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
	FROM WizzardDeposits
		WHERE MagicWandCreator = 'Ollivander family'
			GROUP BY DepositGroup
--6

--7.Deposits Filter
SELECT DepositGroup, SUM(DepositAmount) AS [TotalSum]
	FROM WizzardDeposits
		WHERE MagicWandCreator = 'Ollivander family'
			GROUP BY DepositGroup
				HAVING SUM(DepositAmount) < 150000
					ORDER BY TotalSum DESC
--7

--8.Deposit Charge
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS [MinDepositCharge]
	FROM WizzardDeposits
		GROUP BY DepositGroup, MagicWandCreator
			ORDER BY MagicWandCreator, DepositGroup
--8

--9.Age Groups
SELECT 
	CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END AS [AgeGroup],
COUNT(*) AS [WizardCount]
	FROM WizzardDeposits AS w
GROUP BY CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END
--9

--10.First Letter
SELECT LEFT(FirstName,1) AS [FirstLetter]
	FROM WizzardDeposits
		WHERE DepositGroup = 'Troll Chest'
			GROUP BY LEFT(FirstName,1)
				ORDER BY FirstLetter 
		
--10

--11.Average Interest
SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS [AverageInterest]
	FROM WizzardDeposits
		WHERE DepositStartDate > '01/01/1985'
			GROUP BY DepositGroup, IsDepositExpired
				ORDER BY DepositGroup DESC, IsDepositExpired ASC
--11

--12.Rich Wizard, Poor Wizard
SELECT SUM(ResultTable.[Difference]) AS SumDifference
	FROM (SELECT DepositAmount - (SELECT DepositAmount FROM WizzardDeposits WHERE Id = WizDeposits.Id + 1) 
	AS [Difference] FROM WizzardDeposits WizDeposits) AS ResultTable
--12

--13.Departments Total Salaries
SELECT DepartmentID, SUM(Salary) AS [TotalSalary]
	FROM Employees
		GROUP BY DepartmentID
			ORDER BY DepartmentID
--13

--14.Employees Minimum Salaries
SELECT DepartmentID, MIN(Salary) AS [MinimumSalary]
	FROM Employees
		WHERE HireDate > '01/01/2000'
			GROUP BY DepartmentID
				HAVING DepartmentID IN(2, 5, 7)
--14

--15.Employees Average Salaries
SELECT * INTO[Empl] FROM Employees
WHERE Salary > 30000

DELETE FROM Empl
WHERE ManagerID = 42

UPDATE Empl
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID,AVG(Salary) AS [AverageSalary]
	FROM Empl
		GROUP BY DepartmentID
--15

--16.Employees Maximum Salaries
SELECT DepartmentID, MAX(Salary) AS [MaxSalary]
	FROM Employees
		GROUP BY DepartmentID
			HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000
--16

--17.Employees Count Salaries
SELECT COUNT(Salary) AS [Count]
	FROM Employees
		WHERE ManagerID IS NULL
		GROUP BY ManagerID
--17

--18. 3rd Highest Salary
  WITH SalaryRank 
       AS(SELECT DepartmentID,
                 Salary,
                 DENSE_RANK() OVER(PARTITION BY DepartmentID ORDER BY Salary DESC) AS [Rank]
            FROM Employees)
SELECT DISTINCT DepartmentID,
       Salary AS ThirdHighestSalary
  FROM SalaryRank
 WHERE [Rank] = 3
--18

--19.Salary Challenge
SELECT TOP(10) e.FirstName, e.LastName, e.DepartmentID
FROM Employees AS e
WHERE e.Salary >(SELECT AVG(e2.Salary)
				FROM Employees AS e2
				WHERE e.DepartmentID = e2.DepartmentID)
ORDER BY e.DepartmentID
--19
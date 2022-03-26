use northwind

CREATE TABLE FoodTypes(
FoodTypeID SMALLINT PRIMARY KEY,
FoodTypeName NVARCHAR(40) NOT NULL
)

CREATE TABLE Foods(
FoodID INT PRIMARY KEY,
FoodTypeID SMALLINT FOREIGN KEY REFERENCES FoodTypes(FoodTypeID) ON DELETE CASCADE,
FoodName NVARCHAR(40) NOT NULL
)

ALTER TABLE Foods
ADD Calories INT DEFAULT 0
CHECK (Calories BETWEEN 0 AND 1000)

INSERT INTO FoodTypes VALUES
(1, 'Foods from plant sources'),
(2, 'Foods from animal sources')

INSERT INTO Foods VALUES
(1, 1, 'Broccoli', 301),
(2, 2, 'Butter', 726),
(3, 2, 'Cheese', 396)

UPDATE Foods
SET Calories = 31
WHERE FoodID = 1

DELETE FROM Foods
WHERE Calories > 100


DROP TABLE Foods
DROP TABLE FoodTypes

SELECT CompanyName, Country, City, [Address]
	FROM Customers
		ORDER BY CompanyName asc

SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS Quantity, AVG(od.UnitPrice) AS UnitPrice
	FROM Products AS p
	JOIN [Order Details] AS od
	ON od.ProductID = p.ProductID
		WHERE CategoryID = 1
	GROUP BY p.ProductID, p.ProductName

SELECT c.CustomerID, c.CompanyName, c.City, c.[Address], COUNT(o.CustomerID) AS Orders
	FROM Customers AS c
	FULL JOIN Orders AS o
	ON o.CustomerID = c.CustomerID
	GROUP BY c.CustomerID, c.CompanyName, c.City, c.[Address]
	ORDER BY Orders ASC

SELECT ProductID, ProductName
	FROM Products
		WHERE EXISTS
			(SELECT OrderDate
				FROM Orders
					WHERE OrderDate BETWEEN '20071001' AND '20071231')



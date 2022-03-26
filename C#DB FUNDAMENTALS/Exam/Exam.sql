CREATE TABLE Sizes (
	Id INT PRIMARY KEY IDENTITY,
	Length INT NOT NULL CHECK(Length BETWEEN 10 AND 25),
	RingRange DECIMAL(3, 2) NOT NULL CHECK(RingRange BETWEEN 1.5 AND 7.5)
	
)

CREATE TABLE Tastes(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20) NOT NULL,
	TasteStrength VARCHAR (15) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Brands(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(MAX)
)

CREATE TABLE Cigars(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT FOREIGN KEY REFERENCES Brands(Id) NOT NULL,
	TastId INT FOREIGN KEY REFERENCES Tastes(Id) NOT NULL,
	SizeId INT FOREIGN KEY REFERENCES Sizes(Id) NOT NULL,
	PriceForSingleCigar DECIMAL(18, 2) NOT NULL,
	ImageURL NVARCHAR(100) NOT NULL
)

CREATE TABLE Addresses(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
)

CREATE TABLE Clients(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT FOREIGN KEY REFERENCES Addresses(Id) NOT NULL
)

CREATE TABLE ClientsCigars(
	ClientId INT FOREIGN KEY REFERENCES Clients(Id) NOT NULL,
	CigarId INT FOREIGN KEY REFERENCES Cigars(Id) NOT NULL,
	PRIMARY KEY (ClientId, CigarId)
)

UPDATE Cigars
SET PriceForSingleCigar = PriceForSingleCigar * 1.2
WHERE TastId = 1

UPDATE Brands
SET BrandDescription = 'New description'
WHERE BrandDescription IS NULL


DELETE FROM Clients
WHERE AddressId IN (7, 8, 10, 23)

DELETE FROM Addresses
WHERE LEFT (Country, 1) = 'C'


SELECT CigarName, PriceForSingleCigar, ImageURL
	FROM Cigars
		ORDER BY PriceForSingleCigar, CigarName DESC


SELECT c.Id, c.CigarName, c.PriceForSingleCigar, t.TasteType, t.TasteStrength
	FROM Cigars AS c
	JOIN Tastes AS t
	ON t.Id = c.TastId
	WHERE t.TasteType IN ('Earthy', 'Woody')
	ORDER BY c.PriceForSingleCigar DESC


SELECT Id, CONCAT(FirstName, ' ', LastName) AS [ClientName], Email
	FROM Clients
		WHERE Id NOT IN (
			SELECT ClientId
				FROM ClientsCigars
					GROUP BY ClientId
		)
			ORDER BY [ClientName]

SELECT TOP(5)c.CigarName, c.PriceForSingleCigar, c.ImageURL
	FROM Sizes AS s
	JOIN Cigars AS c
	ON s.Id = c.SizeId AND s.Length >= 12 AND s.RingRange > 2.55
	WHERE c.CigarName LIKE '%ci%' OR c.PriceForSingleCigar > 50
	ORDER BY c.CigarName, c.PriceForSingleCigar DESC


SELECT CONCAT(c.FirstName, ' ', c.LastName) AS [FullName], a.Country, a.ZIP, CONCAT('$',MAX(ci.PriceForSingleCigar))AS CigarPrice
	FROM Addresses AS a
	JOIN Clients AS c
	ON c.AddressId = a.Id
	JOIN ClientsCigars AS cc
	ON c.Id = cc.ClientId
	JOIN Cigars AS ci
	ON ci.Id = cc.CigarId
		WHERE a.ZIP NOT LIKE '%[^0-9]%'
			GROUP BY c.FirstName, c.LastName, a.Country, a.ZIP
				ORDER BY [FullName]
			
SELECT c.LastName, AVG(s.Length) AS CiagrLength,CEILING(AVG(s.RingRange)) AS CiagrRingRange
	FROM Clients AS c
	JOIN ClientsCigars AS cc
	ON cc.ClientId = c.Id
	JOIN Cigars AS ci
	ON ci.Id = cc.CigarId
	JOIN Sizes AS s
	ON s.Id = ci.SizeId
		WHERE c.Id IN (
			SELECT ClientId
				FROM ClientsCigars
					GROUP BY ClientId
		)
			GROUP BY c.LastName
				ORDER BY CiagrLength DESC


CREATE FUNCTION udf_ClientWithCigars(@name NVARCHAR(30))
RETURNS INT
BEGIN

	DECLARE @ClientId INT
	DECLARE @Count INT
	SET @ClientId = (
		SELECT Id
			FROM Clients
				WHERE FirstName = @name
	)
	SET @Count = (SELECT COUNT(CigarId) AS [Count]
		FROM ClientsCigars
			WHERE ClientId = @ClientId)
		
		RETURN @Count
END

SELECT dbo.udf_ClientWithCigars('Betty')


CREATE PROC usp_SearchByTaste @taste VARCHAR(20)
AS
BEGIN
	SELECT c.CigarName, CONCAT('$',c.PriceForSingleCigar) AS [Price], t.TasteType, b.BrandName, CONCAT(s.Length,' cm') AS [CigarLength], CONCAT(s.RingRange,' cm') AS [CigarRingRange]
		FROM Tastes AS t
		JOIN Cigars AS c
		ON t.Id = c.TastId
		JOIN Sizes AS s
		ON s.Id = c.SizeId
		JOIN Brands AS b
		ON b.Id = c.BrandId
		WHERE t.TasteType = @taste
			ORDER BY [CigarLength], CigarRingRange DESC
END

EXEC usp_SearchByTaste 'Woody'
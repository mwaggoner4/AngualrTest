--Phoenix Theatre Database with some defalut values

----------------------------------------
--The Database with defalut values can--
--be crated by running Execute----------
----------------------------------------

----------------------------------------
--The following drop statements will----
--drop all tables, when run in order----
----------------------------------------
--DROP TABLE InvoiceLineItem;
--DROP TABLE Tickets;
--DROP TABLE CustomerOrder;
--DROP TABLE Customer;
--DROP TABLE Employee;
--DROP TABLE FilmShowings;
--DROP TABLE Theatre;
--DROP TABLE TheatreFilms;
--DROP SCHEMA PhoenixTheatre;

CREATE SCHEMA PhoenixTheatre;
GO
 
CREATE TABLE Customer
(
	CustomerId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL UNIQUE,
	UserPassword NVARCHAR(200) NOT NULL
);

CREATE TABLE TheatreFilms
(
	FilmId INT IDENTITY(1,1) PRIMARY KEY,
	FilmName NVARCHAR(200) NOT NULL,
	FilmRating NVARCHAR(5) NOT NULL,
	Genre NVARCHAR(100) NOT NULL,
	FilmDescription NVARCHAR(300) NOT NULL,
	FilmDuration INT NOT NULL,
	ImageUrl VARCHAR(300) NOT NULL
);

CREATE TABLE Theatre
(
	TheatreId INT IDENTITY(1,1) PRIMARY KEY,
	TheatreLocation NVARCHAR(100) NOT NULL,
);

CREATE TABLE Employee
(
	EmployeeId UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	FirstName NVARCHAR(100) NOT NULL,
	LastName NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL UNIQUE,
	UserPassword NVARCHAR(200) NOT NULL,
	IsManager NVARCHAR(3) NOT NULL,
	TheatreId INT FOREIGN KEY REFERENCES Theatre(TheatreId) NOT NULL
);

CREATE TABLE CustomerOrder
(
	OrderId UNIQUEIDENTIFIER PRIMARY KEY,
	CustomerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Customer(CustomerId) NOT NULL,
	TheatreId INT FOREIGN KEY REFERENCES Theatre(TheatreId) NOT NULL,
	TotalPrice MONEY NOT NULL
);

CREATE TABLE Tickets
(
	TicketType NVARCHAR(100) PRIMARY KEY,
	TicketPrice MONEY NOT NULL
);

CREATE TABLE InvoiceLineItem
(
	InvoiceId INT IDENTITY(1,1) PRIMARY KEY,
	OrderId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES CustomerOrder(OrderId) NOT NULL,
	TicketType NVARCHAR(100) FOREIGN KEY REFERENCES Tickets(TicketType) NOT NULL,
	Quantity INT NOT NULL
);

CREATE TABLE FilmShowings
(
	FilmShowingsId INT IDENTITY(1,1) PRIMARY KEY,
	TheatreId INT FOREIGN KEY REFERENCES Theatre(TheatreId) NOT NULL,
	FilmId INT FOREIGN KEY REFERENCES TheatreFilms(FilmId) NOT NULL,
	ShowDate DATETIME NOT NULL,
	Showtime DATETIME NOT NULL,
	TicketsAvailable INT NOT NULL
);



--A default customer
INSERT INTO Customer
(
	FirstName,
	LastName,
	Username,
	UserPassword
)
VALUES
	('John', 'Doe', 'jdoe','P@ssword!'),
	('Melinda', 'Waggoner', 'mwaggoner', 'P@ssword!');

INSERT INTO TheatreFilms
(
	FilmName,
	FilmRating,
	Genre,
	FilmDescription,
	FilmDuration,
	ImageUrl
)
VALUES
	('Assassin With Wings', 'PG-13', 'Adventure', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 101, 'https://images.unsplash.com/photo-1643123237307-fbbc66a1a37d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=928&q=80'),
	('Castle Without Hope', 'PG-13', 'Drama', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 120, 'https://images.unsplash.com/photo-1643123237307-fbbc66a1a37d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=928&q=80'),
	('Paladins and Mages', 'PG', 'Fantasy', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 96, 'https://images.unsplash.com/photo-1639485420052-dc3dfe222959?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8OXx8Y2FzbHRlfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60');

INSERT INTO Theatre
(
	TheatreLocation
)
VALUES
	('Phoenix Theatre');

INSERT INTO Employee
(
	FirstName,
	LastName,
	Username,
	UserPassword,
	IsManager,
	TheatreId
)
VALUES
	('Jane', 'Doe', 'janed', 'p@ssword1', 'yes', 1),
	('Tim', 'Johnson', 'tjohnson', 'p@ssword1', 'no', 1),
	('Sam', 'Hall', 'shall', 'p@ssword1', 'no', 1);

INSERT INTO Tickets
(
	TicketType,
	TicketPrice
)
VALUES
	('Children(ages 3-11)', 7.00),
	('Adults (ages 12 & up)', 12.00),
	('Seniors (ages 60+)', 7.00),
	('Military Discount (with valid ID)', 7.75),
	('Student Discount (with valid ID)', 9.75);


INSERT INTO FilmShowings
(
	TheatreId,
	FilmId,
	ShowDate,
	Showtime,
	TicketsAvailable
)
VALUES
	(1, 1, '2021-01-22', '12:00:00', 40),
	(1, 2, '2021-01-22', '12:00:00', 40),
	(1, 3, '2021-01-22', '12:00:00', 40);



SELECT * FROM Customer;
SELECT * FROM TheatreFilms;
SELECT * FROM Theatre;
SELECT * FROM Employee;
SELECT * FROM CustomerOrder;
SELECT * FROM Tickets;
SELECT * FROM InvoiceLineItem;
SELECT * FROM FilmShowings;

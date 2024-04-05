Create database CarCompanyDatabase;
use CarCompanyDatabase;
Create Table EmployeeInfo(
EmployeeId int identity(1,1) Primary key,
EmployeeName varchar(30),
EmployeeSurname varchar(30),
EmployeeBirthDate varchar(20),
EmployeeStartDate varchar(20),
EmployeePosition varchar(30)
);
delete EmployeeInfo;
Create Table EmployeePositions(
PositionId int identity(1,1) Primary key,
PositionName varchar(20),
EmployeeId int Foreign key references EmployeeInfo(EmployeeId),
PositionSalary int,
PositionWorkHours varchar
);
Create Table CustomerInfo(
CustomerId int identity(1,1) Primary Key,
CustomerName varchar(20),
CustomerSurname varchar(20),
CustomerPersonalNum int,
CustomerPurchaseNum int,
CustomerAddress varchar(50)
);
Create Table CarProduct(
CarProductId int identity(1,1) Primary Key,
CarProductrName varchar(40),
CarProductPrice int,
CarProductSoldNumber int,
CarProductCount int,
CarProductSelfWorth int
);
Create Table CompaniesBranches(
BranchId int identity(1,1) Primary Key,
BranchAddress varchar(50),
BranchArea int,
BranchRentPrice int
);
Create Table TransactionInfo(
TransactionId int identity(1,1) Primary key,
TransactionCount int,
TransactionExecutor int Foreign key references EmployeeInfo(EmployeeId)
);

INSERT INTO EmployeeInfo (EmployeeName, EmployeeSurname, EmployeeBirthDate, EmployeeStartDate, EmployeePosition)
VALUES 
('Michael', 'Anderson', '1991-04-05', '2018-09-10', 'Manager'),
('Jessica', 'Wilson', '1990-10-15', '2019-05-20', 'Salesperson'),
('Ryan', 'Taylor', '1994-02-28', '2020-08-12', 'Mechanic'),
('Sophia', 'Garcia', '1993-07-20', '2021-03-05', 'Salesperson'),
('Matthew', 'Lopez', '1988-12-10', '2017-06-15', 'Manager');

INSERT INTO EmployeePositions (PositionName, EmployeeId, PositionSalary, PositionWorkHours)
VALUES 
('Manager', 8, 62000, '40 hours/week'),
('Salesperson', 9, 42000, '45 hours/week'),
('Mechanic', 10, 46000, '40 hours/week'),
('Manager', 11, 61000, '40 hours/week'),
('Salesperson', 12, 40000, '45 hours/week');

INSERT INTO CustomerInfo (CustomerName, CustomerSurname, CustomerPersonalNum, CustomerPurchaseNum, CustomerAddress)
VALUES 
('Emily', 'Wilson', 123456789, 3, '123 Main St'),
('Daniel', 'Thomas', 987654321, 2, '456 Oak Ave'),
('Olivia', 'Robinson', 234567890, 1, '789 Elm St'),
('William', 'Clark', 345678901, 2, '890 Pine Ave'),
('Sophia', 'Walker', 456789012, 3, '567 Maple Ln');

INSERT INTO CarProduct (CarProductrName, CarProductPrice, CarProductSoldNumber, CarProductCount, CarProductSelfWorth)
VALUES 
('Toyota Corolla', 20000, 12, 25, 17000),
('Honda Accord', 23000, 9, 20, 19000),
('Chevrolet Impala', 25000, 7, 15, 21000),
('Ford Fusion', 22000, 8, 18, 18000),
('Hyundai Sonata', 21000, 10, 22, 17500);

INSERT INTO CompaniesBranches (BranchAddress, BranchArea, BranchRentPrice)
VALUES 
('100 Elm St', 500, 2000),
('200 Pine Ave', 700, 2500),
('300 Maple Ln', 600, 2300),
('400 Oak St', 550, 2200),
('500 Cedar Ave', 650, 2700);

INSERT INTO TransactionInfo (TransactionCount, TransactionExecutor)
VALUES 
(5, 8),
(3, 9),
(2, 10),
(4, 11),
(1, 12);

Create database CarDb;
Use CarDb;
CREATE TABLE CarTable(
carName varchar(20),
carId int,
carColour varchar(20),
carCountry varchar(20)
);
Alter Table CarTable Add Age int;
Alter Table CarTable Drop Column Age;
Alter Table CarTable Alter Column carName varchar(30);
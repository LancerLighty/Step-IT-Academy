Create database Cars;
Use Cars;
Create Table CarsTable(
CarId int Identity(1,1) Primary Key, 
CarName varchar(20) Not Null,
Age int Check(Age <= 3) Not Null,
Country varchar(15) Not Null,
Colour varchar(5) Check(Colour = 'Black')
);


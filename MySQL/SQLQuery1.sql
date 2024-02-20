Create database SportDb;
Use SportDb;
Create Table Footballers(
FootBallerId int Identity(1,1) Primary key,
FootBallerName varchar(30) Not Null,
FootBallerAge int check(FootBallerAge > 18),
FootBallerTeam varchar(7) Constraint DF_FootBallerTeam Default 'Default',
FootBallerCountry varchar(20) Not Null,
FootBallerNumber int check(FootBallerNumber > 1)
);
Insert Into Footballers(
FootBallerName,
FootBallerAge,
FootBallerTeam,
FootBallerCountry,
FootBallerNumber) values (
'nika',
32,
'dhsrtj',
'Georgia',
12
);
Select FootBallerName, FootBallerAge from Footballers;
Select Distinct FootBallerNumber from FootBallers;
Select FootballerAge From Footballers
where FootballerAge > 22;
Select * From Footballers
where FootballerAge > 22 and FootBallerNumber > 10;
Select * from Footballers
Order By FootballerAge;
Select top 50 Percent FootBallerNumber from FootBallers;
Select Max(FootballerAge) from Footballers;
Select Avg(FootBallerNumber) from Footballers;

Create Table Basketballers(
BasketballerId int Identity(1,1) Primary key,
BasketballerName varchar(30) Not Null,
FootballerId int Foreign key references Footballers(FootBallerId),
BasketballerAge int check(BasketballerAge > 20),
BasketballerLeague varchar(3) check(BasketballerLeague = 'NBA'),
BasketballerRank int check(BasketballerRank < 100),
BasketballerCountry varchar(20) Not Null
);
Select BasketballerAge, BasketballerCountry from Basketballers;
Select BasketballerRank From Basketballers
where BasketballerRank > 10;
Select * From Basketballers
where BasketballerRank > 5 or BasketballerAge > 23;
Select BasketballerAge from Basketballers
Order by BasketballerAge Desc;

Update Basketballers 
Set BasketballerName = 'nika'
Where BasketballerName = 'gio';

Select Top 3 * From Basketballers;
Select Min(BasketballerAge) from Basketballers;
Select * From Basketballers
where BasketballerName like 'n%';
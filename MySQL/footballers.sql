Create Database FootballerTeam;
Use FootballerTeam;
Create Table Footballers(
FootballerId int Identity(1,1) primary key,
FootballerName varchar(30),
FootballerCountry varchar(30)
);
Create Table Teams(
TeamId int identity(1,1) primary key,
TeamName varchar(30),
TeamAge int
);

SELECT * FROM Footballers
INNER JOIN Teams
ON Footballers.FootballerId = Teams.TeamId;
SELECT * FROM Footballers
Left Join Teams
ON Footballers.FootballerId = Teams.TeamId;
SELECT * FROM Footballers
Right Join Teams
ON Footballers.FootballerId = Teams.TeamId;
SELECT * FROM Footballers
Full Join Teams
ON Footballers.FootballerId = Teams.TeamId;

Select * From Footballers
Select Count(FootballerId) FootballerCountry From Footballers
Group By FootballerCountry;
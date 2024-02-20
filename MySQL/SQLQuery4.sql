Create Table Movies(
MovieId int Primary Key Identity(1,1),
MovieName varchar(100) Not Null,
MovieDirector varchar(100),
RecordDate int Check(RecordDate > 2000),
MovieGanre varchar(6) Check(MovieGanre = 'Comedy'),
MovieCountry varchar(100) Default 'Georgia',
);
Create Table MovieWebSite(
WebsiteName varchar(100) Not Null,
MovieId int Foreign Key References Movies(MovieId)
);

Insert Into Movies Values(
'name1234',
'bergman',
2012,
'Comedy',
'Germany'
);
select * from Movies;
select * From Movies
Where RecordDate > 2010;
select * From Movies
Where MovieDirector = 'bergman';
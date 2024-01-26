Create database database1;
USE database1;
CREATE TABLE db1Table (City varchar(50), PostalCode bigint, Country varchar(50));
INSERT INTO db1Table (City, PostalCode, Country)
VALUES ('Tom B. Erichsen', 4006, 'Norway');
SELECT * FROM db1Table;
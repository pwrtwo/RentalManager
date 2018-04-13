select * from Occupancies;

SET IDENTITY_INSERT Occupancies ON;
insert into Occupancies(ID, StartDate, EndDate)	values(4, SYSDATETIME(), SYSDATETIME());
SET IDENTITY_INSERT Occupancies OFF;

select * from Occupancies;

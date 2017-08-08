create table Departments
(
ID int primary key identity,
Name nvarchar(50),
Location nvarchar(50)
)

create table Employees
(
ID int primary key identity,
FirstName nvarchar(50),
LastName nvarchar(50),
Gender nvarchar(50),
Salary int,
DepartmentId int foreign key references Departments(Id)
)

Insert into Departments values ('IT', 'New York')
Insert into Departments values ('HR', 'London')
Insert into Departments values ('Payroll', 'Sydney')

Insert into Employees values ('Mark', 'Hastings', 'Male', 60000, 1)
Insert into Employees values ('Steve', 'Pound', 'Male', 45000, 3)
Insert into Employees values ('Ben', 'Hoskins', 'Male', 70000, 1)
Insert into Employees values ('Philip', 'Hastings', 'Male', 45000, 2)
Insert into Employees values ('Mary', 'Lambeth', 'Female', 30000, 2)

select * from dbo.Departments
select * from dbo.Employees
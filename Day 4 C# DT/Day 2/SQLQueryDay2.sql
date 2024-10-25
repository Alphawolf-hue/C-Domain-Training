use DomainTrainingHexaware

create table Employee(
ID int,
Name varchar(200),
Salary int,
Gender varchar(10),
City varchar(50),
Dept varchar(50))

INSERT INTO Employee (ID, Name, Salary, Gender, City, Dept)
VALUES
(7, 'John Doe', 60000, 'Male', 'New York', 'IT'),
(3, 'Jane Smith', 75000, 'Female', 'Los Angeles', 'HR'),
(10, 'Robert Johnson', 50000, 'Male', 'Chicago', 'Finance'),
(1, 'Emily Davis', 90000, 'Female', 'San Francisco', 'Marketing'),
(5, 'Michael Brown', 55000, 'Male', 'Houston', 'Operations'),
(8, 'Sophia Wilson', 80000, 'Female', 'Boston', 'IT'),
(2, 'David Miller', 62000, 'Male', 'Seattle', 'HR'),
(9, 'Olivia Jones', 70000, 'Female', 'Miami', 'Finance'),
(4, 'James Garcia', 45000, 'Male', 'Denver', 'Operations'),
(6, 'Mia Martinez', 65000, 'Female', 'Austin', 'Marketing');

INSERT INTO Employee (ID, Name, Salary, Gender, City, Dept)
VALUES
(15, 'Liam White', 67000, 'Male', 'San Diego', 'IT'),
(27, 'Emma Clark', 71000, 'Female', 'Las Vegas', 'HR'),
(19, 'Noah King', 54000, 'Male', 'Orlando', 'Finance'),
(30, 'Ava Walker', 92000, 'Female', 'Phoenix', 'Marketing'),
(14, 'Elijah Scott', 58000, 'Male', 'Dallas', 'Operations'),
(22, 'Isabella Harris', 81000, 'Female', 'Philadelphia', 'IT'),
(31, 'Lucas Adams', 63000, 'Male', 'San Antonio', 'HR'),
(13, 'Mason Lewis', 72000, 'Male', 'Portland', 'Finance'),
(18, 'Sophia Baker', 66000, 'Female', 'Charlotte', 'Operations'),
(21, 'Charlotte Nelson', 68000, 'Female', 'Atlanta', 'Marketing'),

(42, 'Oliver Brooks', 74000, 'Male', 'Las Vegas', 'IT'),
(25, 'Amelia Hall', 79000, 'Female', 'Orlando', 'HR'),
(36, 'Benjamin Allen', 60000, 'Male', 'San Diego', 'Finance'),
(16, 'Mia Young', 89000, 'Female', 'Phoenix', 'Marketing'),
(24, 'Henry Hernandez', 54000, 'Male', 'Dallas', 'Operations'),
(34, 'Evelyn Moore', 91000, 'Female', 'Philadelphia', 'IT'),
(29, 'Alexander Green', 69000, 'Male', 'San Antonio', 'HR'),
(41, 'Avery Perez', 71000, 'Female', 'Portland', 'Finance'),
(20, 'James Ward', 62000, 'Male', 'Charlotte', 'Operations'),
(35, 'Harper Wright', 70000, 'Female', 'Atlanta', 'Marketing'),

(58, 'Ella Stewart', 76000, 'Female', 'Miami', 'Finance'),
(53, 'Jack Long', 57000, 'Male', 'Houston', 'Operations'),
(47, 'Grace Thompson', 88000, 'Female', 'Denver', 'Marketing'),
(40, 'William Lee', 94000, 'Male', 'New York', 'IT'),
(17, 'Victoria White', 83000, 'Female', 'Los Angeles', 'HR'),
(61, 'Logan Martinez', 56000, 'Male', 'Chicago', 'Finance'),
(48, 'Lily Clark', 77000, 'Female', 'San Francisco', 'Operations'),
(63, 'Samuel Baker', 84000, 'Male', 'Boston', 'IT'),
(49, 'Zoe Young', 68000, 'Female', 'Seattle', 'HR'),
(26, 'Daniel Hill', 72000, 'Male', 'Miami', 'Finance'),

-- Continue inserting with jumbled IDs up to 110 employees
(70, 'Chloe Adams', 66000, 'Female', 'Austin', 'Marketing'),
(54, 'Matthew Hall', 58000, 'Male', 'Houston', 'Operations'),
(75, 'Aiden Johnson', 79000, 'Male', 'Boston', 'IT'),
(59, 'Aria Carter', 91000, 'Female', 'San Diego', 'HR'),
(81, 'Joseph Perez', 69000, 'Male', 'San Antonio', 'Finance'),
(65, 'Sofia Roberts', 93000, 'Female', 'Philadelphia', 'Marketing'),
(72, 'Levi Mitchell', 64000, 'Male', 'Orlando', 'Operations'),
(85, 'Scarlett Turner', 83000, 'Female', 'New York', 'IT'),
(77, 'Owen Collins', 70000, 'Male', 'Miami', 'HR'),
(90, 'Riley Torres', 88000, 'Female', 'San Francisco', 'Finance'),

-- Ending sample with 110 employees
(100, 'Gabriel Sanders', 91000, 'Male', 'Chicago', 'Operations'),
(95, 'Eleanor Ramirez', 93000, 'Female', 'Boston', 'Marketing'),
(102, 'Carter Gonzalez', 72000, 'Male', 'Denver', 'IT'),
(91, 'Abigail Scott', 82000, 'Female', 'Los Angeles', 'HR'),
(67, 'Isaac Walker', 56000, 'Male', 'Austin', 'Finance'),
(83, 'Penelope Rivera', 86000, 'Female', 'Phoenix', 'Marketing'),
(74, 'Sebastian Cooper', 67000, 'Male', 'Houston', 'Operations'),
(109, 'Hannah Morgan', 90000, 'Female', 'San Diego', 'IT'),
(97, 'David Foster', 68000, 'Male', 'Seattle', 'HR'),
(86, 'Lucy Campbell', 71000, 'Female', 'Philadelphia', 'Finance');

select * from Employee

create index IX_Employee_ID on Employee(ID ASC)
create clustered index IX_Employee_ID1 on Employee(ID ASC)  drop index IX_Employee_ID on Employee

create table Employee1(
ID int primary key,
Name varchar(200),
Salary int,
Gender varchar(10),
City varchar(50),
Dept varchar(50))

INSERT INTO Employee1(ID, Name, Salary, Gender, City, Dept)
VALUES
(7, 'John Doe', 60000, 'Male', 'New York', 'IT'),
(3, 'Jane Smith', 75000, 'Female', 'Los Angeles', 'HR'),
(10, 'Robert Johnson', 50000, 'Male', 'Chicago', 'Finance'),
(1, 'Emily Davis', 90000, 'Female', 'San Francisco', 'Marketing'),
(5, 'Michael Brown', 55000, 'Male', 'Houston', 'Operations'),
(8, 'Sophia Wilson', 80000, 'Female', 'Boston', 'IT'),
(2, 'David Miller', 62000, 'Male', 'Seattle', 'HR'),
(9, 'Olivia Jones', 70000, 'Female', 'Miami', 'Finance'),
(4, 'James Garcia', 45000, 'Male', 'Denver', 'Operations'),
(6, 'Mia Martinez', 65000, 'Female', 'Austin', 'Marketing');

create index IX_EMPLOYEE_SALARY on Employee1(Salary ASC) 

-----------------------------------------NEW OpERATION------------------------------------------------------------------------------------------------------------
CREATE TABLE tblDept (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(100) NOT NULL
);
CREATE TABLE tblEmployee (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(200) NOT NULL,
    Salary INT NOT NULL,
    Gender VARCHAR(10),
    City VARCHAR(50),
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES tblDept(DeptID)
);
INSERT INTO tblDept (DeptID, DeptName)
VALUES
(1, 'IT'),
(2, 'HR'),
(3, 'Finance'),
(4, 'Marketing'),
(5, 'Operations');

INSERT INTO tblEmployee (EmpID, EmpName, Salary, Gender, City, DeptID)
VALUES
(7, 'John Doe', 60000, 'Male', 'New York', 1),
(3, 'Jane Smith', 75000, 'Female', 'Los Angeles', 2),
(10, 'Robert Johnson', 50000, 'Male', 'Chicago', 3),
(1, 'Emily Davis', 90000, 'Female', 'San Francisco', 4),
(5, 'Michael Brown', 55000, 'Male', 'Houston', 5),
(8, 'Sophia Wilson', 80000, 'Female', 'Boston', 1),  
(6, 'David Miller', 62000, 'Male', 'Seattle', 2);

--view using joins retrieving employees by department
create view vWEmployeesByDepartment
as 
select EmpID, EmpName, Salary, Gender, City,DeptName
from tblEmployee
join tblDept
on tblEmployee.DeptID=tblDept.DeptID

select * from vWEmployeesByDepartment
select * from tblEmployee
select * from tblDept

update vWEmployeesByDepartment set EmpName='Aniket Barua' where EmpID=7
insert into vWEmployeesByDepartment values(11,'Franz Buchner',30000,'Male','Kiel')--View or function 'vWEmployeesByDepartment' is not updatable 
--because the modification affects multiple base tables.(tblEmployee and tblDept)

--Views to view employees from a particular Department
create view vWITDeptEmployee
as
select EmpID, EmpName, Salary, Gender, City,DeptName
from tblEmployee
join tblDept
on tblEmployee.DeptID=tblDept.DeptID
where DeptName='IT'

select * from vWITDeptEmployee

--view for employee count
create view vWEmployeeByCount
as 
Select DeptName,COUNT(EmpID) as EmployeeCount
from tblEmployee
join tblDept
on tblEmployee.DeptID=tblDept.DeptID
group by DeptName

select * from vWEmployeeByCount
sp_helptext vWEmployeeByCount


---creating Triggers
create table orders(
order_id int primary key,
customer_id int,
order_date date)

create table order_audit(
audit_id int identity primary key,
order_id int,
customer_id int,
order_date date,
audit_date datetime default getdate(),
audit_information varchar(max)
)

create trigger tgrAfterInsertOrder
on orders
after insert
as begin
Insert into order_audit(order_id,customer_id,order_date)
select order_id,customer_id,order_date from inserted
end

insert into orders values(1001,31,'2024-10-23')

alter trigger tgrAfterInsertOrder
on orders 
after insert
as
begin
declare @auditInfo nvarchar(1000)
set @auditInfo='Data Inserted'
Insert into order_audit(order_id,customer_id,order_date,audit_information)
select order_id,customer_id,order_date,@auditInfo
from inserted
end

select * from orders
select * from order_audit

insert into orders values(1002,41,'2024-8-8')
update orders set customer_id=32 where order_id=1

create trigger tgrAfterUpdateOrder
on orders
for update
as begin
declare @auditInfo nvarchar(1000)
set @auditInfo='Data Changed'
Insert into order_audit(order_id,customer_id,order_date,audit_information)
select order_id,customer_id,order_date,@auditInfo
from inserted
end

update orders set customer_id=35 where order_date='2024-10-23'

------Example of instead of Trigger using table employee and dept-----
create view vwEmployeeDetails
as
select EmpID,EmpName,Salary,Gender,City,DeptName from tblEmployee e
join tblDept d
on e.DeptID=d.DeptID

select * from vwEmployeeDetails
insert vwEmployeeDetails values(11,'Franz Buchner','Male','HR')

create trigger tr_vwEmployeeDetails_InsteadOfInsert
on vwEmployeeDetails
instead of insert
as begin
declare @deptId int
select @deptId=DeptID from tblDept
join inserted
on inserted.DeptName=tblDept.DeptName

if(@deptId is null)
begin
Raiserror('Invalid Department Name.Statement Terminated',16,1)
return 
end
insert into tblEmployee(EmpID,EmpName,Salary,Gender,City,DeptID)
select EmpID,EmpName,Salary,Gender,City,@deptId
from inserted
end
 insert vwEmployeeDetails values(11,'Franz Buchner',75000,'Male','Kiel','HR')
  insert vwEmployeeDetails values(12,'Robert Scultz',75000,'Male','Kiel','Engineering')

------------------------------------------TRANSACTION DEADLOCK-----------------------------------------------------------------------------------
create table customers(
customer_id int primary key,
Name varchar(100),
active bit)

CREATE TABLE orders1
(order_id int primary key, 
customer_id int foreign key references customers(customer_id),
order_status varchar(100))

insert into CUSTOMERS values
(1, 'Pam', 1),
(2, 'Kim', 1)
select * from customers
select * from orders1

insert into orders1 values
(101,1, 'Pending'),
(102,2, 'Pending')

--Transaction A
begin transaction
update customers set Name='John'
where customer_id=1

waitfor delay '00:00:05';
update orders1 set order_status='Processed'
where order_id=101
commit transaction

--Transaction B
begin transaction
update orders1 set order_status='Shipped'
where order_id=101

waitfor delay '00:00:05';
update customers set Name='Geetha'
where customer_id=1
commit transaction

--7) Create a trigger to updates the Stock (quantity) table whenever new order placed in orders tables
 CREATE TRIGGER trg_UpdateStockOnNewOrder
ON sales.order_items
AFTER INSERT
AS
BEGIN
    DECLARE @ProductID INT, @Quantity INT, @StoreID INT;

    SELECT @ProductID = i.product_id, @Quantity = i.quantity, @StoreID = o.store_id
    FROM inserted i
    INNER JOIN sales.orders o ON i.order_id = o.order_id;

    UPDATE production.stocks
    SET quantity = quantity - @Quantity
    WHERE product_id = @ProductID AND store_id = @StoreID;
    BEGIN
        PRINT 'Warning: Stock has gone negative for product ';
    END
END;


--8) Create a trigger to that prevents deletion of a customer if they have existing orders.
 CREATE TRIGGER trg_PreventCustomerDeletion
ON customers
instead of DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM orders1
        WHERE orders1.customer_id in (SELECT customer_id FROM deleted)
    )
    BEGIN
        PRINT 'Cannot delete customer with existing orders.';
        ROLLBACK TRANSACTION;
    END;
END;

select * from customers
select * from orders1
DELETE FROM customers WHERE customer_id = 1;

--9) Create Employee,Employee_Audit  insert some test data
CREATE TABLE Employee2 (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(100),
    Salary INT,
    Position VARCHAR(50)
);

CREATE TABLE Employee_Audit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    EmpID INT,
    ChangeType VARCHAR(10),  
    OldSalary INT,
    NewSalary INT,
    ChangeDate DATETIME DEFAULT GETDATE()
);

INSERT INTO Employee2 (EmpID, EmpName, Salary, Position)
VALUES 
(1, 'John Doe', 60000, 'Manager'),
(2, 'Jane Smith', 50000, 'Analyst'),
(3, 'David Brown', 45000, 'Developer');


--b) Create a Trigger that logs changes to the Employee Table into an Employee_Audit Table
CREATE TRIGGER trg_LogEmployeeChanges
ON Employee2
AFTER UPDATE
AS
BEGIN
    INSERT INTO Employee_Audit (EmpID, ChangeType, OldSalary, NewSalary)
    SELECT i.EmpID,'UPDATE',d.Salary AS OldSalary, i.Salary AS NewSalary
    FROM inserted i
    INNER JOIN deleted d ON i.EmpID = d.EmpID
    WHERE i.Salary <> d.Salary;

    PRINT 'Employee salary change logged in Employee_Audit table.';
END;

UPDATE Employee2
SET Salary = 65000
WHERE EmpID = 1;

SELECT * FROM Employee_Audit;

--10) create Room Table with below columns RoomID,RoomType,Availability create Bookings Table with below columns
--BookingID,RoomID,CustomerName,CheckInDate,CheckInDate
 CREATE TABLE Room (
    RoomID INT PRIMARY KEY,
    RoomType VARCHAR(50),
    Availability BIT  
);
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1), 
    RoomID INT,
    CustomerName VARCHAR(100),
    CheckInDate DATE,
    CheckOutDate DATE,
    FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);

--Insert some test data with both  the tables
INSERT INTO Room (RoomID, RoomType, Availability)
VALUES 
(1, 'Single', 1),  
(2, 'Double', 1),  
(3, 'Suite', 1);
--Ensure both the tables are having Entity relationship
select * from Room
select * from Bookings
--Write a transaction that books a room for a customer, ensuring the room is marked as unavailable.
BEGIN TRANSACTION
    IF EXISTS (SELECT 1 FROM Room WHERE RoomID = 1 AND Availability = 1)
    BEGIN
        INSERT INTO Bookings (RoomID, CustomerName, CheckInDate, CheckOutDate)
        VALUES (1, 'Vini Jr', '2024-10-24', '2024-10-28');
        UPDATE Room
        SET Availability = 0
        WHERE RoomID = 1;
        COMMIT TRANSACTION;
        PRINT 'Room booked successfully and marked as unavailable.';
    END
    ELSE
    BEGIN
        PRINT 'Room is already booked or unavailable.';
        ROLLBACK TRANSACTION;
END

--Testing
select * from Room
select * from Bookings


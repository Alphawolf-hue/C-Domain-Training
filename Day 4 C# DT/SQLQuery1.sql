create proc uspProductList
as begin
select Product_name,list_price from production.products
order by product_name
end
 
uspProductList

--Alter Procedure
alter proc uspProductList
as begin
select Product_name,list_price from production.products
order by product_name desc
end

exec sp_rename 'uspProductList','uspMyProductList'

--optional parameter
create proc uspFindProductbyName
(@minprice as decimal=2000,@maxprice decimal ,@name as varchar(max))
as begin
select * from production.products where list_price>=@minprice and
list_price<=@maxprice 
and product_name like '%'+@name+'%'
end

uspFindProductbyName 100,3000,'Sun'
uspFindProductbyName @maxprice=3000,@name='Trek'

--out parameter
create proc uspFindProductCountByYear
(@modelyear int,@productcount int output)
as begin
select product_name,list_price from production.products
where model_year=@modelyear
select @productcount=@@ROWCOUNT
end

declare @count int;
exec uspFindProductCountByYear @modelyear=2017,@productcount=@count out;;
select @count as 'Num of Prod Found'

create proc usp_GetAllCustomers
as begin
Select * from sales.customers
end

usp_GetAllCustomers

create proc usp_GetCustomersOrders
@customerID int
as begin
select * from sales.orders
where customer_id=@customerID
end

usp_GetCustomersOrders 1

create proc usp_GetCustomerData(@customerID int)
as begin 
exec usp_GetAllCustomers
exec usp_GetCustomersOrders @customerID;
end
usp_GetCustomerData 1

--You need to create a stored procedure that retrieves a list of all customers who have purchased a specific product.
--consider below tables Customers, Orders,Order_items and Products
--Create a stored procedure,it should return a list of all customers who have purchased the specified product, 
--including customer details like CustomerID, CustomerName, and PurchaseDate.
--The procedure should take a ProductID as an input parameter.
CREATE PROCEDURE uspGetCustomersByProductID
    @ProductID INT
AS
BEGIN
    SELECT 
        C.customer_id AS CustomerID,
        CONCAT(C.first_name, ' ', C.last_name) AS CustomerName,
        O.order_date AS PurchaseDate
    FROM 
        sales.customers C
        INNER JOIN sales.orders O ON C.customer_id = O.customer_id
        INNER JOIN sales.order_items OI ON O.order_id = OI.order_id
        INNER JOIN production.products P ON OI.product_id = P.product_id
    WHERE 
        P.product_id = @ProductID;
END;

exec uspGetCustomersByProductID 5

--CREATE TABLE Department with the below columns ID,Name populate with test data
--CREATE TABLE Employee with the below columns ID,Name,Gender,DOB,DeptId populate with test data
--a) Create a procedure to update the Employee details in the Employee table based on the Employee id.
CREATE PROCEDURE uspUpdateEmployeeDetails
    @EmployeeID INT,
    @Name VARCHAR(100),
    @Gender VARCHAR(10),
    @DOB DATE,
    @DeptID INT
AS
BEGIN
    UPDATE Employee
    SET [eName] = @Name,
        Gender = @Gender,
        DateOfBirth = @DOB,
        DeptId = @DeptID
    WHERE eID = @EmployeeID;
END;

exec uspUpdateEmployeeDetails 6,'Pablo Gavi','Male','2004-12-12',2

--b) Create a Procedure to get the employee information bypassing the employee gender and department id from the Employee table
CREATE PROCEDURE uspGetEmployeeByGenderAndDeptID
    @Gender VARCHAR(10),
    @DeptID INT
AS
BEGIN
    SELECT 
        eID,
        eName,
        Gender,
        DateOfBirth,
        DeptId
    FROM 
        Employee
    WHERE 
        Gender = @Gender AND DeptId = @DeptID;
END;
exec uspGetEmployeeByGenderAndDeptID 'Female',2

--c) Create a Procedure to get the Count of Employee based on Gender(input) has context menu
CREATE PROCEDURE uspGetEmployeeCountByGender
    @Gender VARCHAR(10)
AS
BEGIN
    SELECT 
        COUNT(*) AS EmployeeCount
    FROM 
        Employee
    WHERE 
        Gender = @Gender;
END;

exec uspGetEmployeeCountByGender 'Male'
exec uspGetEmployeeCountByGender 'Female'

--UserDefined Function
create function GetAllProducts()
returns int
as begin
return (select count(*) from production.products)
end

print dbo.GetAllProducts()

--Inline table valued function
create function GetProductByID(@productID int)
returns table
as
return (select * from production.products where product_id=@productID)

select * from GetProductByID(4)

--MultiValued Function 
create function GetEmployeewithTheirDepartments()
returns @TempTable table
(EmployeeID int, EmployeeName varchar(max),DeptId int,DeptName varchar(max))
as
begin
	insert into @TempTable 
	select e.eID,e.eName,e.DeptId,d.Name
	from dbo.Employee e
	left join
	dbo.Department d
	on e.DeptId = d.ID
	return 
end

select * from GetEmployeewithTheirDepartments()

--3)Create a user Defined function to calculate the TotalPrice based on productid and Quantity Products Table
 CREATE FUNCTION fnCalculateTotalPrice
(
    @ProductID INT,
    @Quantity INT
)
RETURNS Table
AS
return
(
     SELECT 
        list_price * @Quantity AS TotalPrice
    FROM 
        production.products
    WHERE 
        product_id = @ProductID
);

SELECT * from fnCalculateTotalPrice(56, 3) AS TotalPrice;


--4)create a function that returns all orders for a specific customer, including details such as OrderID, OrderDate, and the total amount of each order.
 CREATE FUNCTION fnGetCustomerOrders
(
    @CustomerID INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        O.order_id AS OrderID,
        O.order_date AS OrderDate,
        SUM(OI.quantity * OI.list_price) AS TotalAmount
    FROM 
        sales.orders O
        INNER JOIN sales.order_items OI ON O.order_id = OI.order_id
    WHERE 
        O.customer_id = @CustomerID
    GROUP BY 
        O.order_id, O.order_date
);


select * from fnGetCustomerOrders(48)

--create a Multistatement table valued function that calculates the total sales for each product, considering quantity and price.
CREATE FUNCTION fnCalcTotalSalesPerProduct()
RETURNS @SalesTable TABLE (ProductID INT,ProductName VARCHAR(255),TotalSales DECIMAL(10, 2))
AS
BEGIN
    INSERT INTO @SalesTable (ProductID, ProductName, TotalSales)
    SELECT 
        P.product_id,
        P.product_name,
        SUM(OI.quantity * OI.list_price) AS TotalSales
    FROM 
        sales.order_items OI
    INNER JOIN 
        production.products P ON OI.product_id = P.product_id
    GROUP BY 
        P.product_id, P.product_name;

    RETURN;
END;

select * from fnCalcTotalSalesPerProduct()

--6)create a  multi-statement table-valued function that lists all customers along with the total amount they have spent on orders.
CREATE FUNCTION fnGetCustomerTotalSpent()
RETURNS @CustomerTotalSpent TABLE (
    CustomerID INT,
    CustomerName VARCHAR(255),
    TotalSpent DECIMAL(10, 2)
)
AS
BEGIN
    INSERT INTO @CustomerTotalSpent (CustomerID, CustomerName, TotalSpent)
    SELECT 
        C.customer_id AS CustomerID,
        CONCAT(C.first_name, ' ', C.last_name) AS CustomerName,
        SUM(OI.quantity * OI.list_price) AS TotalSpent
    FROM 
        sales.customers C
    LEFT JOIN 
        sales.orders O ON C.customer_id = O.customer_id
    LEFT JOIN 
        sales.order_items OI ON O.order_id = OI.order_id
    GROUP BY 
        C.customer_id, C.first_name, C.last_name;

    RETURN;
END;

SELECT * FROM fnGetCustomerTotalSpent();

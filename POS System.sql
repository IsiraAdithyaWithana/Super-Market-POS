USE[POS System];

create table Customer(
	CustomerID int primary key identity(1,1),
	First_Name varchar(50) not null,
	Last_Name varchar(50) not null
);

alter table Customer
	add Address varchar(250) not null,
	Email varchar(100) not null,
	RegisterDate datetime not null,
	

create table Customer_Phone(
	CustomerID int foreign key references Customer(CustomerID),
	Phone_Number varchar(10) not null
);

create table Users(
	UserID int primary key identity(1,1),
	Full_Name varchar(200) not null,
	NIC varchar(30) not null,
	username varchar(100) not null,
	password varchar(20) not null,
);

create table User_Phone(
	UserID int foreign key references Users(UserID),
	Phone_Number varchar(10)
);
	

create table Sale(
	SaleID int primary key identity(1,1),
	CustomerID int foreign key references Customer(CustomerID),
	Sale_Date datetime not null,
	Total_Amount decimal(15,2) not null,
	UserID int foreign key references Users(UserID)
);

create table Stock(
	StockID int primary key identity(1,1),
	Product_Name varchar(80) not null,
	Price decimal(15,2) not null,
	Available_Quantity int not null
);

create table Discount(
	DiscountID int primary key identity(1,1),
	Discount_Value  decimal(5,2) not null,
	Start_Date datetime not null,
	End_Date datetime not null
);

create table Sales_Details (
	Sales_DetailsID int primary key identity(1,1),
	SaleID int foreign key references Sale(SaleID),
	StockID int foreign key references Stock(StockID),
	Quantity_Sold int not null,
	DiscountID int foreign key references Discount(DiscountID)
);


insert into Users (Full_Name,NIC,username,password) 
	values
	('Isira Adithya','200225902250','isiraadithya','Isira@123'),
	('Dimethma Ranaweera','200368411107','dimethmaranaweera','20030702'),
	('Mandinu Balasooriya','200329612643','Mandinu','@Bala69'),
	('Sanuda hansaja de silva','200303401096','Sanulk','Sanu@2003'),
	('Devinda Thilina Jayarathna','200135904398','dev','dev@2429'),
	('Ranudi Kariyapperuma','200452300274','Ranudi','ranu@2004'),
	('Naduni Kodikra','200332541168','Naduni','@kodikara'),
	('Denethmi Aththanayake','200435168542','Denethmi','@denethmi')
	;



create table CashDrawer (
    DrawerID int primary key identity(1,1),
    UserID int foreign key references Users(UserID),
    StartTime datetime not null,
    EndTime datetime,
    StartAmount decimal(15,2) not null,
    EndAmount decimal(15,2),
    IsMatched bit null, -- To indicate whether the start and end amounts match
    Remarks varchar(200)
);

create table StockWarnings (
    WarningID int primary key identity(1,1),
    StockID int foreign key references Stock(StockID),
    Product_Name varchar(80),
    Available_Quantity int,
    WarningMessage varchar(255),
    CreatedAt datetime default getdate()
);


create trigger trg_LowStockWarning
on Stock
after update
as
begin
    insert into StockWarnings (StockID, Product_Name, Available_Quantity, WarningMessage)
    select 
        StockID,
        Product_Name,
        Available_Quantity,
        'Stock is below 20.'
    from 
        inserted
    where 
        Available_Quantity < 20;
end

create procedure InsertCustomerDetails
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(250),
	@Email varchar(100),
	@RegisterDate datetime,
	@Phone_Number varchar(10)
as
begin
	insert into Customer (First_Name,Last_Name,Address,Email,RegisterDate)
	values (@First_Name,@Last_Name,@Address,@Email,@RegisterDate);

	declare @CustomerID int = scope_identity ();

	insert into Customer_Phone (CustomerID,Phone_Number)
	values (@CustomerID,@Phone_Number);
end;

create view ShowCustomerDetails as

select 
	c.CustomerID,
    c.First_Name,
    c.Last_Name,
    c.Address,
    c.Email,
    c.RegisterDate,
    cp.Phone_Number

from
	Customer c

join
	Customer_Phone cp

on
	c.CustomerID = cp.CustomerID;


create procedure UpdateCustomerDetails
	@CustomerID int,
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(250),
	@Email varchar(100),
	@Phone_Number varchar(10)

as
begin
	update Customer
	set
		First_Name = @First_Name,
		Last_Name = @Last_Name,
		Address = @Address,
		Email = @Email
	where
		CustomerID = @CustomerID;

	update Customer_Phone
	set
		Phone_Number = @Phone_Number
	where
		CustomerID = @CustomerID;

End;


	




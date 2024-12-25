USE[POS System];

create table Customer(
	CustomerID int primary key identity(1,1),
	First_Name varchar(50) not null,
	Last_Name varchar(50) not null
	);

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
	Pice decimal(15,2) not null,
	Available_Quantity int not null,
	);

create table Discount(
	DiscountID int primary key identity(1,1),
	Discount_Value decimal(5,2) not null,
	Start_Date datetime not null,
	End_Date datetime not null
	);

create table Sales_Details(
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





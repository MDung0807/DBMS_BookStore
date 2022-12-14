create database BOOKSTOREMANAGE
go
use BOOKSTOREMANAGE
go
CREATE TABLE [dbo].AUTHOR (
idAuthor varchar(8) NOT NULL,
nameAuthor nvarchar(30) NOT NULL unique,
phoneNumber varchar(10) NULL

CONSTRAINT pk_author PRIMARY KEY (idAuthor)
)
GO 

CREATE TABLE [dbo].PUBLISHER (
idPublisher varchar(8) NOT NULL,
namePublisher nvarchar(30) NOT NULL,
addressPublisher nvarchar(30) NULL,
phoneNumber varchar(10) NULL

CONSTRAINT pk_publisher PRIMARY KEY (idPublisher)
)
GO 

CREATE TABLE [dbo].BOOK (
idBook varchar(8) NOT NULL,
nameBook nvarchar(20) NOT NULL,
urlImage image NULL,
amount int not null default 0,
priceImport int NULL,
priceExport int NULL,
idPublisher varchar(8) NULL

CONSTRAINT pk_book PRIMARY KEY (idBook),
CONSTRAINT fk_Publisher FOREIGN KEY (idPublisher) REFERENCES PUBLISHER (idPublisher),
CONSTRAINT chk_amount CHECK (amount >= 0),
CONSTRAINT chk_price CHECK (priceImport >= 0 and priceExport >= 0)
)
GO 

CREATE TABLE [dbo].TYPECUSTOMER (
idTypeCus varchar(8) NOT NULL,
nameTypeCus nvarchar(30) NOT NULL,
pointMark int NULL,
valueTypeCus int NULL

CONSTRAINT pk_typeCus PRIMARY KEY (idTypeCus),
CONSTRAINT chk_pointMark CHECK (pointMark >= 0),
CONSTRAINT chk_valueTypeCus CHECK (valueTypeCus >= 0 and valueTypeCus < 100)
)
GO

CREATE TABLE [dbo].CUSTOMER (
idCus varchar(8) NOT NULL,
nameCus nvarchar(30) NOT NULL,
addressCus nvarchar(30) NULL,
phoneNumber varchar(20) NULL,
pointCus int NOT NULL DEFAULT 0,
idTypeCus varchar(8)NULL

CONSTRAINT pk_customer PRIMARY KEY (idCus),
CONSTRAINT fk_TypeCus FOREIGN KEY (idTypeCus) REFERENCES TYPECUSTOMER (idTypeCus),
--CONSTRAINT chk_phoneCustomer CHECK (len(phoneNumber) = 10),
CONSTRAINT chk_pointCus CHECK (pointCus >= 0)
)
GO

CREATE TABLE [dbo].EMPLOYEE (
idEmployee varchar(8) NOT NULL,
firstName nvarchar(10) NOT NULL,
middleName nvarchar(10) NULL,
lastName varchar(10) NOT NULL,
sex nvarchar(5) NOT NULL,
addEmp nvarchar(30) NULL,
phoneNumber varchar(10) NULL,
email varchar(50) NOT NULL, 
yearOfBirth date NULL,

CONSTRAINT chk_sex CHECK (upper(sex) like N'NAM' or upper(sex) like N'NỮ' or upper(sex) like N'KHÁC'),
CONSTRAINT chk_email CHECK (email like '%@gmail.com%'),
CONSTRAINT chk_yearOfBirth CHECK (DATEDIFF(YEAR,yearOfBirth,GETDATE()) >= 18 AND DATEDIFF(YEAR,yearOfBirth,GETDATE()) <= 50),

CONSTRAINT pk_employee PRIMARY KEY (idEmployee)
)
go


CREATE TABLE [dbo].VOUCHER (
idVoucher varchar(8) NOT NULL,
valueVoucher int NOT NULL,
nameOfEventVoucher nvarchar(40) NULL,
dateStart date not null,
dateEnd date not null,
amount int NULL,

CONSTRAINT pk_voucher PRIMARY KEY (idVoucher),
CONSTRAINT chk_amountVoucher CHECK (amount>=0)
)
GO

CREATE TABLE [dbo].BILLOUTPUT (
idBillOutPut varchar(8) NOT NULL,
dateOfBill date NULL,
total int NOT NULL DEFAULT 0,
idCus varchar(8)NULL,
idEmployee varchar(8) NULL,
idVoucher varchar(8) null,
stateBill bit not null default 0,

CONSTRAINT pk_billOutPut PRIMARY KEY (idBillOutPut),
CONSTRAINT fk_pay FOREIGN KEY (idCus) REFERENCES CUSTOMER (idCus),
CONSTRAINT fk_collect FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT fk_Discount FOREIGN KEY (idVoucher) REFERENCES VOUCHER (idVoucher),
)
GO 

CREATE TABLE [dbo].ACCOUNT (
idAccount varchar(8) NOT NULL,
nameAccount varchar(20) NOT NULL unique,
password varchar(30) NOT NULL,
typeOfAcc bit NOT NULL,
<<<<<<< HEAD
idEmployee varchar(8) NULL 
=======
idEmployee varchar(8) NULL unique,
>>>>>>> 3b5fdf0e8bdb2b78f47b972214a931e6803d8031

CONSTRAINT pk_account PRIMARY KEY (idAccount),
CONSTRAINT fk_acc_Of_Employee FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee),
CONSTRAINT chk_userName CHECK (len(nameAccount) > 6),
CONSTRAINT chk_passwd CHECK (len(password) > 6)
)
GO

CREATE TABLE [dbo].CATEGORY (
idCategory varchar(8) NOT NULL,
nameCategory nvarchar(20) NOT NULL unique,
describeCategory nvarchar(50) NULL,

CONSTRAINT pk_category PRIMARY KEY (idCategory)
)
GO

CREATE TABLE [dbo].BOOK_AUTHOR (
idBook varchar(8) NOT NULL,
idAuthor varchar(8) NOT NULL,

CONSTRAINT pk_book_author PRIMARY KEY (idBook,idAuthor),
CONSTRAINT fk_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_author FOREIGN KEY (idAuthor) REFERENCES AUTHOR (idAuthor)
)
GO

CREATE TABLE [dbo].BOOK_CATEGORY (
idBook varchar(8) NOT NULL,
idCategory varchar(8) NOT NULL,

CONSTRAINT pk_book_category PRIMARY KEY (idBook,idCategory),
CONSTRAINT fk_id_into_book FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT fk_id_into_categgory FOREIGN KEY (idCategory) REFERENCES CATEGORY (idCategory)
)
GO

CREATE TABLE [dbo].BILLINPUT (
idBillInput varchar(8) NOT NULL,
dateOfInput date NULL,
total int NOT NULL DEFAULT 0,
idEmployee varchar(8) NULL,
stateBill bit default 0


CONSTRAINT pk_billinput PRIMARY KEY (idBillInput),
CONSTRAINT fk_employee_checkin FOREIGN KEY (idEmployee) REFERENCES EMPLOYEE (idEmployee)
)
GO

CREATE TABLE [dbo].BOOK_BILLINPUT (
idBillInput varchar(8) NOT NULL,
idBook varchar(8) NOT NULL,
amountInput INT NOT NULL,

CONSTRAINT pk_book_billinput PRIMARY KEY (idBillInput,idBook),
CONSTRAINT fk_idBillInput FOREIGN KEY (idBillInput) REFERENCES BILLINPUT (idBillInput),
CONSTRAINT fk_idBook_into_input FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT chk_amountInput CHECK(amountInput>=0)
)
GO
CREATE TABLE [dbo].BOOK_BILLOUTPUT (
idBillOutput varchar(8) NOT NULL,
idBook varchar(8) NOT NULL,
amountOutput int NOT NULL

CONSTRAINT pk_book_billoutput PRIMARY KEY (idBillOutput,idBook),
CONSTRAINT fk_idBillOuput FOREIGN KEY (idBillOutput) REFERENCES BILLOUTPUT (idBillOutput),
CONSTRAINT fk_idBook_into_output FOREIGN KEY (idBook) REFERENCES BOOK (idBook),
CONSTRAINT chk_amountOutput CHECK(amountOutput>=0)
)
go


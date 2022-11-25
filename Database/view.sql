use BOOKSTOREMANAGE
go
------------------------------View-------------------------------------------
--View tác giả
create or alter view view_Author
as
select *
from dbo.AUTHOR
go
--View nhà xuất bản
create or alter view view_Publisher
as
select *
from dbo.PUBLISHER
go
--View thông tin Sách
create or alter view view_Book
as
select *
--BOOK.idBook, BOOK.nameBook, BOOK.amount, BOOK.priceImport, BOOK.priceExport, BOOK.idPublisher
from dbo.BOOK
go
--View thể loại
create or alter view view_Category
as
select *
from dbo.CATEGORY
go
--View tài khoản
create or alter view view_Account
as
select idaccount,nameaccount,password,case when dbo.ACCOUNT.typeOfAcc=1
												then
													'Admin'
											else
													'Nhân viên'
											end as TypeAcc,idemployee
from dbo.ACCOUNT
go

--View hóa đơn nhập
create or alter view view_ReceiptImport
as
select *
from dbo.BILLINPUT
go 

--View hóa đơn xuất
create or alter view view_ReceiptExport
as
select *
from dbo.BILLOUTPUT
go
--View lấy danh sách sách để show lên sale
create or alter view view_GetAllBookForSale
as
select BOOK.idBook as ID, BOOK.nameBook as N'Tên Sách', BOOK.amount as N'Số lượng', BOOK.priceExport as N'Giá'
from dbo.BOOK
go

--View thông tin khách hàng
create or alter view view_Customer
as
select *
from dbo.CUSTOMER
go
--View loại khách hàng
create or alter view view_TypeCustomer
as
select *
from dbo.TYPECUSTOMER
go
--View Nhân viên
create or alter view view_Employee
as
select *
from dbo.EMPLOYEE
go
--View voucher
create or alter view view_Voucher
as
select *
from dbo.VOUCHER
go

---------------------------------------------------------------------------Tân thêm
---View doanh thu
create or alter view view_top5StockMin
as select top 5 nameBook,amount from BOOK order by amount asc
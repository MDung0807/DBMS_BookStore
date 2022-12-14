use BOOKSTOREMANAGE
go
--------------------------------------------TRIGGER-----------------------------------------
--Kiểm tra trả về lỗi nếu ngày xuất hóa đơn trước ngày nhập sách về và kiểm tra số lượng sách trong hóa đơn phải còn trong kho thì mới được bán
--Kiểm tra số lượng sách thêm trong giỏ hàng phải luôn có đủ trong kho
create or alter trigger trg_checkInsertCart
on dbo.BOOK_BILLOUTPUT
for insert
as
begin	
	declare @numBookSold int, @numBookRemain int, @idBook varchar(8)
	select @numBookSold=i.amountOutput, @idBook=i.idBook
	from inserted i
	
	set @numBookRemain=(select dbo.BOOK.amount from dbo.BOOK where dbo.BOOK.idBook=@idBook)
	if (@numBookSold > @numBookRemain)
	begin
		raiserror('Số lượng sách trong kho không đáp ứng đủ !',16,1)
		rollback transaction
	end
end
go

--- Kiểm tra số lượng sách trong kho có đủ để thêm vào BOOK_BILLOUTPUT
create or alter trigger trg_checkUpdateCart
on dbo.BOOK_BILLOUTPUT
for update
as
begin	
	declare @numBookSold int, @numBookRemain int, @numBookDelete int, @idBookInsert varchar(8), @idBookDelete varchar(8)
	select @numBookSold=i.amountOutput,@numBookDelete=d.amountOutput, @idBookInsert=i.idBook,@idBookDelete=d.idBook
	from inserted i, deleted d

	if(charindex(@idBookInsert,@idBookDelete)>0)
		set @numBookRemain=((select BOOK.amount from dbo.BOOK where @idBookInsert=BOOK.idBook)+@numBookDelete)
	else
		set @numBookRemain=(select BOOK.amount from dbo.BOOK where @idBookInsert=BOOK.idBook)
	if (@numBookSold > @numBookRemain)
	begin
		raiserror('Số lượng sách trong kho không đáp ứng đủ !',16,1)
		rollback transaction
	end
end
go
--Kiểm tra điều kiện voucher được giảm không quá 50% giá trị đơn hàng và voucher phải còn hạn sử dụng thì mới áp dụng được
create or alter trigger trg_discountAndUpdateVoucher
on dbo.BILLOUTPUT
for update
as
begin
	declare @idBillDiscount varchar(8), @idVcher varchar(8), @totalAfterDiscount int, @totalBeforeDiscount int, @checkBill bit, @amountVoucher int
	select @idBillDiscount=i.idBillOutPut, @idVcher=i.idVoucher, @totalBeforeDiscount=d.total, @totalAfterDiscount=i.total
	from inserted i, deleted d
	--Kiểm tra idVoucher có tồn tại 
	if (@idVcher is not null and not exists(select * from dbo.VOUCHER where @idVcher=dbo.VOUCHER.idVoucher))
		begin
			raiserror ('Voucher không tồn tại trong kho',16,1)
			rollback transaction
		end
	if(@idVcher is not null)
	begin
		--Kiểm tra nếu thêm voucher thì có vượt quá 50% giá trị bill
		if (@totalAfterDiscount <= (0.5*@totalBeforeDiscount))
			begin
				raiserror ('Voucher không thể áp dụng cho đơn hàng này',16,1)
				rollback transaction
			end
		set @amountVoucher=(select dbo.VOUCHER.amount from dbo.VOUCHER where dbo.VOUCHER.idVoucher=@idVcher)
		--Kiểm tra số lượng voucher có còn còn trong kho 
		if(@amountVoucher<=0)
			begin
				raiserror ('Voucher không đủ số lượng trong kho',16,1)
				rollback transaction
			end
		--Kiểm tra Voucher có còn hạn sử dụng 
		select @checkBill=dbo.func_checkVoucherValidOrNot(VOUCHER.dateStart,VOUCHER.dateEnd,BILLOUTPUT.dateOfBill)
		from dbo.BILLOUTPUT, dbo.VOUCHER
		where BILLOUTPUT.idBillOutPut=@idBillDiscount and VOUCHER.idVoucher=@idVcher
		if (@checkBill=0)
			begin
				raiserror ('Voucher đã hết hạn sử dụng',16,1)
				rollback transaction
			end
	end
end
go
--Kiểm tra số điện thoại tác giả 
create or alter trigger trg_checkPhoneNumberOfAuthor
on AUTHOR
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i
	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
			rollback transaction
		end
end
go
--Kiểm tra số điện thoại của nhà xuất bản
create or alter trigger trg_checkPhoneNumberOfPublisher
on PUBLISHER
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i
	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
			rollback transaction
		end
end
go
--Kiểm tra số điện thoại của khách hàng
create or alter trigger trg_checkPhoneNumberOfCustomer
on CUSTOMER
for insert, update
as 
begin
	declare @phoneNumber varchar(20)
	select @phoneNumber=i.phoneNumber
	from inserted i

	if (dbo.func_checkPhone(@phoneNumber)=0)
		begin
			raiserror ('Số điện thoại nhập không đúng định dạng',16,1)
			rollback transaction
		end
end
go



---------------------------------------------------Dũng thêm ------------------------------------------------------------

--Điều kiện giá bán phải lớn hơn giá nhập
create or alter trigger trg_checkPriceOfBook
on BOOK
for insert, update
as
begin
	declare @priceImport int, @priceExport int
	select @priceImport=i.priceImport, @priceExport=i.priceExport
	from inserted i

	if (@priceImport > @priceExport)
	begin
		raiserror ('Giá nhập sách phải nhỏ hơn giá bán',16,1)
		rollback transaction
	end
end
go

--------------------------------Voucher--------------------------
--kiểm tra value phải nhỏ hơn hoặc = 100 và  lớn hơn 0
Create or alter trigger trg_checkTypeCustomer on TYPECUSTOMER
for insert, update
as
begin
	declare @value int
	select @value = i.valueTypeCus from inserted i

	if (@value < 0 or @value >100)
	begin
		print N'Nhập giá trị value không chính xác. Value nằm trong khoảng từ 0 -> 100'
		rollback transaction
	end
end
go
-- Kiểm tra dateStart phải < dateEnd
Create or alter trigger trg_checkDateVoucher on Voucher
for insert, update
as
begin
	declare @dateStart date, @dateEnd date
	select @dateStart = i.dateStart, @dateEnd = i.dateEnd
	from inserted i

	if (@dateStart > @dateEnd)
	begin
		print N'Ngày bắt đầu và kết thúc không hợp lệ'
		rollback transaction
	end
end
go
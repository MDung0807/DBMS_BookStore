use BOOKSTOREMANAGE
go
exec proc_addNewAuthor 'TG1',N'Nguyễn Nhật Ánh','0377092166'
exec proc_addNewAuthor 'TG2',N'Betty Eadie','0356853029'
exec proc_addNewAuthor 'TG3',N'Higashino Keigo','0987118308'
exec proc_addNewAuthor 'TG4',N'OSHO','0945802082'
exec proc_addNewAuthor 'TG5',N'Yagisawa Satoshi','0374458018'
exec proc_addNewAuthor 'TG6',N'Hae Min','0975833652'
exec proc_addNewAuthor 'TG7',N'Nguyên Phong','0978154509'
exec proc_addNewAuthor 'TG8',N'Nguyễn Vĩnh Nguyên','0902636196'
exec proc_addNewAuthor 'TG9',N'Hồ Anh Thái','0987079456'
exec proc_addNewAuthor 'TG10',N'Nguyễn Trương Quý','0386042429'
exec proc_addNewAuthor 'TG11',N'Đỗ Bích Thúy','0919719444'
exec proc_addNewAuthor 'TG12',N'Nguyễn Mai Chi','0358082341'
exec proc_addNewAuthor 'TG13',N'Trang Hạ','0933411752'
exec proc_addNewAuthor 'TG14',N'Anh Khang','0918433043'
go
exec proc_addNewCategory 'TL1',N'Tình cảm',N'Lãng mạn huyền bí'
exec proc_addNewCategory 'TL2',N'Bí ẩn',N'Trinh thám hấp dẫn'
exec proc_addNewCategory 'TL3',N'Giả tưởng',N'Chủ nghĩa hiện thực bí ẩn pha trộn với một trí tưởng tượng đầy phong phú'
exec proc_addNewCategory 'TL4',N'Kinh dị',N'Yếu tố ly kỳ và kinh dị tạo nên sự hồi hộp'
exec proc_addNewCategory 'TL5',N'Self help',N'Bài học thành công'
exec proc_addNewCategory 'TL6',N'Tự truyện',N'Thông tin thực tế được nhiều nguồn cung cấp'
exec proc_addNewCategory 'TL7',N'Dạy nấu ăn',N'Được viết bởi các đầu bếp chuyên nghiệp'
exec proc_addNewCategory 'TL8',N'Lịch sử',N'Ghi lại thông tin lịch sử thế giới và Việt Nam'
exec proc_addNewCategory 'TL9',N'Chính trị',N'Bàn luận về quan điểm chính trị và lịch sử'
exec proc_addNewCategory 'TL10',N'Thiếu nhi',N'Dành cho trẻ em'
go
exec proc_addNewPublisher 'NXB1',N'Nhà xuất bản trẻ',N'Hà Nội','0342293128'
exec proc_addNewPublisher 'NXB2',N'Nhà xuất bản thanh niên',N'TP.HCM','0342293128'
exec proc_addNewPublisher 'NXB3',N'Nhà xuất bản giáo dục',N'Hải Dương','0342293128'
exec proc_addNewPublisher 'NXB4',N'Nhà xuất bản quân đội',N'Phú Thọ','0342293128'
exec proc_addNewPublisher 'NXB5',N'Nhà xuất bản văn hóa',N'Hà Nội','0342293128'
go
exec proc_addNewTypeCustomer 'VIP1',N'Khách hàng mới',0,0
exec proc_addNewTypeCustomer 'VIP2',N'Khách hàng đồng',20,1
exec proc_addNewTypeCustomer 'VIP3',N'Khách hàng bạc',40,2
exec proc_addNewTypeCustomer 'VIP4',N'Khách hàng vàng',60,3
exec proc_addNewTypeCustomer 'VIP5',N'Khách hàng bạch kim',80,4
exec proc_addNewTypeCustomer 'VIP6',N'Khách hàng kim cương',100,5
exec proc_addNewTypeCustomer 'VIP7',N'Khách hàng tiềm năng',120,6
exec proc_addNewTypeCustomer 'VIP8',N'Khách hàng siêu cấp',150,8
go
exec proc_addNewCustomer 'KH1',N'Nguyễn Quang Thiện',N'An Lạc Hạnh','0342293124','VIP1'
exec proc_addNewCustomer 'KH2',N'Nguyễn Tâm Minh',N'Bình Dương','0342293124','VIP1'
exec proc_addNewCustomer 'KH3',N'Nguyễn Bình Trọng',N'Gia Lai','0342293124','VIP1'
exec proc_addNewCustomer 'KH4',N'Hà Thiên Thiên',N'Khánh Hòa','0342293124','VIP1'
exec proc_addNewCustomer 'KH5',N'Cao Nguyên Kha',N'Cà Mau','0342293124','VIP1'
exec proc_addNewCustomer 'KH6',N'Chu Nhật Minh',N'Bắc Ninh','0342293124','VIP1'
exec proc_addNewCustomer 'KH7',N'Phan Kiểu Diễm',N'An Giang','0342293124','VIP1'
exec proc_addNewCustomer 'KH8',N'Hồ Quang Hiếu',N'Cà Mau','0342293124','VIP1'
go
exec proc_addNewEmployee 'NV1',N'Nguyễn',N'Đức',N'Thành',N'Nam',N'Sài Gòn','0342293128','ducthanh@gmail.com','2002-12-23'
exec proc_addNewEmployee 'NV2',N'Nguyễn',N'Thái Ngọc',N'Tân',N'Nam',N'Ninh Thuận','0342293128','tan@gmail.com','2003-10-14'
exec proc_addNewEmployee 'NV3',N'Đỗ',N'Minh',N'Dũng',N'Nam',N'Gia Lai','0342293128','minhdung@gmail.com','2002-07-10'
exec proc_addNewEmployee 'NV4',N'Bùi',N'Tấn',N'Đạt',N'Nam',N'Phan Thiết','0342293128','tandat@gmail.com','2002-09-14'
go
exec proc_addNewAccount 'ACC1','dthanhadmin','abcd1234',1,'NV1'
exec proc_addNewAccount 'ACC3','minhdungnv','abcd1234',0,'NV3'
exec proc_addNewAccount 'ACC4','ngoctannv','abcd1234',0,'NV2'
exec proc_addNewAccount 'ACC5','tandatnv','abcd1234',0,'NV4'
go
exec proc_addNewVoucher 'VC1',50000,N'Chào mừng 20/11','2022-05-11','2022-12-11',200
exec proc_addNewVoucher 'VC2',100000,N'Tưng bừng khai trương chi nhánh mới','2021-07-12','2022-04-14',100
exec proc_addNewVoucher 'VC3',70000,N'Mừng tết Trung THU','2021-05-20','2021-10-05',150
exec proc_addNewVoucher 'VC4',150000,N'Black Friday','2022-07-11','2022-11-21',50



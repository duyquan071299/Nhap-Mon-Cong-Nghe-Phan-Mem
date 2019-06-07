USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLHS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLHS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLHS]
END
CREATE DATABASE [QLHS]
GO
USE [QLHS]
GO
CREATE TABLE [dbo].[tblHocSinh]
(	
	[MaHS] nvarchar(50) NOT NULL PRIMARY KEY,
    [Khoi] nvarchar(50) not null,
	[TenHocSinh] nvarchar(50) NOT NULL,
	[GioiTinh] nvarchar(50) not null,
	[NgaySinh] 	datetime2(7) NOT NULL,
	[NoiSinh] nvarchar(50) not null,
	[NguyenQuan] nvarchar(50) not null,
	[DanToc] nvarchar(50) not null,
	[TonGiao] nvarchar(50) not null,
	[HoKhauTT] nvarchar(50) not null,
	[TenCha] nvarchar(50),
	[NNCha] nvarchar(50),
	[TenMe] nvarchar(50),
	[NNMe] nvarchar(50),
	[UuTien] nvarchar(50) not null,
)
create table [dbo].[tblDSLop]
(
	[MaLop] nvarchar(10) not null,
	[MaHS] nvarchar(50) not null
	constraint pk_sohd_masp primary key([MaLop],[MaHS]),
	constraint fk_malop foreign key([MaLop]) references tblLop([MaLop]),
	constraint fk_mahs foreign key([MaHS]) references tblHocSinh([MaHS]) 
)


CREATE TABLE [dbo].[tblLop]
(	
	[MaLop] nvarchar(10) NOT NULL PRIMARY KEY,
	[TenLop] nvarchar(10) NOT NULL,		
	[SoHocSinh] int NOT NULL,
)

Select [TenHocSinh], [GioiTinh], [TenLop]
from [tblDSLop],[tblLop],[tblHocSinh]
where [tblDSLop].[MaLop]=[tblLop].[MaLop] and [tblDSLop].[MaHS]=[tblHocSinh].[MaHS] 

create table [dbo].[tblKhoi]
( 
[TenKhoi] nvarchar(10) not null primary key,
[SoLop] nvarchar(10) not null,
)
create table [dbo].[tblThongTinLop]
( 
[MaLop] nvarchar(10) not null,
[TenKhoi] nvarchar(10) not null,
[MaHS] nvarchar(50) not null,
Foreign key (MaLop) references tblLop(MaLop),
foreign key (TenKhoi) references tblKhoi(TenKhoi),
foreign key (MaHS) references tblHocSinh(MaHS),
)
CREATE TABLE [dbo].[tblMonHoc]
(	
	[MaMonHoc]	nvarchar(50) NOT NULL PRIMARY KEY,
	[TenMonHoc]	varchar(50) NOT NULL,
)
CREATE TABLE [dbo].[tblHocKi]
(
	[MaHK]	nvarchar(10) NOT NULL PRIMARY KEY,
	[TenHK]	int NOT NULL ,
)

CREATE TABLE [dbo].[tblDiem]
(
	[MaBangDiem] nvarchar(10) NOT NULL PRIMARY KEY,
    [MaHS] nvarchar(50) NOT NULL, 
    [MaMonHoc]	nvarchar(50) NOT NULL,
	[MaHK]	nvarchar(10) NOT NULL,
    [DiemQuaTrinh] float not null,
	[Diem15] float not null,
	[Diem45] float not null,
	[DiemCuoiKi] float not null,
	FOREIGN KEY (MaMonHoc) REFERENCES tblMonHoc(MaMonHoc),
	FOREIGN KEY (MaHS) REFERENCES tblHocSinh(MaHS),
	FOREIGN KEY (MaHK) REFERENCES tblHocKi(MaHK),
)
CREATE TABLE [dbo].[tblThamSo]
(
	[MaTS] nvarchar(10) not null primary key,
	[TenTS] nvarchar(50) not null,
	[GiaTriTS] nvarchar(10) not null,
)

--d? li?u có tru?c--

SET DATEFORMAT dmy;  
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('001', '10A1', '20');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('002', '10A2', '20');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('003', '10A3', '20');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('004', '10A4', '20');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('005', '11A1', '26');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('006', '11A2', '27');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('007', '11A3', '27');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('008', '12A1', '40');
Insert into tblLop (MaLop, TenLop, SoHocSinh)
values ('009', '12A2', '40');



Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('001', 'Toan');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('002', 'Ly');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('003', 'Hoa');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('004', 'Van');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('005', 'Su');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('006', 'Dia');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('007', 'Ngoai Ngu');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('008', 'GDCD');
Insert into tblMonHoc(MaMonHoc, TenMonHoc)
values ('009', 'GDQP');


Insert into tblKhoi(TenKhoi, SoLop)
values ('10', '4');
Insert into tblKhoi(TenKhoi, SoLop)
values ('11','3');
Insert into tblKhoi(TenKhoi, SoLop)
values ('12','2');


Insert into tblHocKi(TenHK)
values ('HK1');
Insert into tblHocKi(TenHK)
values ('HK2');


Insert Into tblDiem(MaHS, MaMonHoc, TenHK, DiemQuaTrinh, Diem15, Diem45, DiemGiuaKi, DiemCuoiKi)
values ('17520792', '001', 'HK1', '10', '10', '10', '10', '10');
Insert Into tblDiem(MaHS, MaMonHoc, TenHK, DiemQuaTrinh, Diem15, Diem45, DiemGiuaKi, DiemCuoiKi)
values ('17520793', '005', 'HK1', '9.5', '8', '6.5', '5', '10');
Insert Into tblDiem(MaHS, MaMonHoc, TenHK, DiemQuaTrinh, Diem15, Diem45, DiemGiuaKi, DiemCuoiKi)
values ('17520794', '003', 'HK2', '8.5', '10', '10', '7.5', '7');
Insert Into tblDiem(MaHS, MaMonHoc, TenHK, DiemQuaTrinh, Diem15, Diem45, DiemGiuaKi, DiemCuoiKi)
values ('17520795', '004', 'HK1', '6', '4.5', '6', '8.5', '9');
Insert Into tblDiem(MaHS, MaMonHoc, TenHK, DiemQuaTrinh, Diem15, Diem45, DiemGiuaKi, DiemCuoiKi)
values ('17520796', '001', 'HK2', '8', '4', '3.5', '7', '10');


Insert into tblHocSinh(MaHS,TenHocSinh,NgaySinh,Khoi, HoKhauTT,NguyenQuan,DanToc,TonGiao,TenCha,NNCha,TenMe,NNMe,UuTien)
values('17520792', 'Nguyen Du Phuc Ngan', '30/11/1999','12','tph Bien Hoa, Dong Nai','Thanh Hoa','Kinh','Phat Giao','Ngyen Ten Cha', 'Cong Nhan','Tran Thi Ten Me','Noi Tro','Uu tien loai 1');
Insert into tblHocSinh(MaHS,TenHocSinh,NgaySinh,Khoi, HoKhauTT,NguyenQuan,DanToc,TonGiao,TenCha,NNCha,TenMe,NNMe,UuTien)
values('17520793', 'Luong Van Song', '9/9/1999','12','Long Khanh, Dong Nai','Dong Nai','Kinh','Phat Giao','Luong Van Tai', 'Dao Dien','Tran Thi Ten Me','Dien Vien','Uu tien loai 2');
Insert into tblHocSinh(MaHS,TenHocSinh,NgaySinh,Khoi, HoKhauTT,NguyenQuan,DanToc,TonGiao,TenCha,NNCha,TenMe,NNMe,UuTien)
values('17520794', 'Nguyen Nguyen', '3/11/1999','12','Quan 1, thp HCM','Thanh Hoa','Kinh','Thien Chua Giao','Ngyen Ai Quoc', 'Phu bep','Tran Lam Ngoc','Noi Tro','Uu tien loai 1');
Insert into tblHocSinh(MaHS,TenHocSinh,NgaySinh,Khoi, HoKhauTT,NguyenQuan,DanToc,TonGiao,TenCha,NNCha,TenMe,NNMe,UuTien)
values('17520795', 'Phan Thanh Thanh', '31/1/1999','12','Quan 5, thp HCM','Da Nang','Kinh','Phat Giao','Phan Anh Tai', 'Cong Nhan','Phuong Thi My Linh','Cong Nhan','Uu tien loai 1');
Insert into tblHocSinh(MaHS,TenHocSinh,NgaySinh,Khoi, HoKhauTT,NguyenQuan,DanToc,TonGiao,TenCha,NNCha,TenMe,NNMe,UuTien)
values('17520796', 'Vo Van Ni Ga', '3/1/1999','12','Quan 9, thp HCM','Thanh Hoa','Kinh','Khong','Ngyen Ten Cha', 'Cong Nhan','Tran Thi Ten Me','Noi Tro','Uu tien loai 1');


insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('01','So hoc sinh toi da trong lop','40');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('02','So diem toi thieu de qua mon','5');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('03','So diem toi da','10');
insert into tblThamSo(MaTS,TenTS, GiaTriTS)
values ('04','So diem toi thieu','0');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('05','So tuoi toi thieu','16');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('06','So tuoi toi da','18');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('07','So mon hoc','9');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('08','Ten mon hoc','Toan');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('09','Ten mon hoc','Ly');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('10','Ten mon hoc','Hoa');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('11','Ten mon hoc','Sinh');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('12','Ten mon hoc','Ngu Van');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('13','Ten mon hoc','Su');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('14','Ten mon hoc','Dia');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('15','Ten mon hoc','Ngoai Ngu');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('16','Ten mon hoc','GDCD');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('17','Ten mon hoc','GDQP');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('18','So lop hoc','9');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('19','Ten lop hoc','10A1');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('20','Ten lop hoc','10A2');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('21','Ten lop hoc','10A3');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('22','Ten lop hoc','10A4');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('23','Ten lop hoc','11A1');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('24','Ten lop hoc','11A2');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('25','Ten lop hoc','11A3');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('26','Ten lop hoc','12A1');
insert into tblThamSo(MaTS, TenTS, GiaTriTS)
values ('27','Ten lop hoc','12A2');


Insert into tblThongTinLop(MaHS, MaLop, TenKhoi)
values ('17520792', '008', '12');
Insert into tblThongTinLop(MaHS, MaLop, TenKhoi)
values ('17520793', '006', '12');
Insert into tblThongTinLop(MaHS, MaLop, TenKhoi)
values ('17520794', '009', '12');
Insert into tblThongTinLop(MaHS, MaLop, TenKhoi)
values ('17520795', '009', '12');
Insert into tblThongTinLop(MaHS, MaLop, TenKhoi)
values ('17520796', '008', '12');

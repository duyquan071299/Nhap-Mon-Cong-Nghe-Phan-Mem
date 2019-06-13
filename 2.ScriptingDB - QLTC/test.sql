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

create table [dbo].[tblKhoi]
( 
	[MaKhoi] nvarchar(5) not null primary key,
	[TenKhoi] nvarchar(10) not null
)

CREATE TABLE [dbo].[tblLop]
(	
	[MaLop] nvarchar(10) NOT NULL PRIMARY KEY,
	[TenLop] nvarchar(10) NOT NULL,		
	[MaKhoi] nvarchar(5) not null, 
	foreign key ([MaKhoi]) references [tblKhoi]([MaKhoi])
)

CREATE TABLE [dbo].[tblHocSinh]
(	
	[MaHS] nvarchar(50) NOT NULL PRIMARY KEY,
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
	[MaLop] nvarchar(10),
	foreign key ([MaLop]) references [tblLop]([MaLop])
)


CREATE TABLE [dbo].[tblMonHoc]
(	
	[MaMonHoc]	nvarchar(50) NOT NULL PRIMARY KEY,
	[TenMonHoc]	nvarchar(50) NOT NULL,
)
CREATE TABLE [dbo].[tblHocKi]
(
	[MaHK]	nvarchar(10) NOT NULL PRIMARY KEY,
	[TenHK]	varchar(10) NOT NULL ,
)

CREATE TABLE [dbo].[tblDiem]
(
	[MaBangDiem] nvarchar(10) NOT NULL PRIMARY KEY,
    [MaHS] nvarchar(50) NOT NULL, 
    [MaMonHoc]	nvarchar(50) NOT NULL,
	[MaHK]	nvarchar(10) NOT NULL,
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

insert into tblKhoi values ('001','K10')
insert into tblKhoi values ('002','K11')
insert into tblKhoi values ('003','K12')

insert into tblLop values('L101','10A1','001')
insert into tblLop values('L102','10A2','001')
insert into tblLop values('L103','10A3','001')
insert into tblLop values('L104','10A4','001')
insert into tblLop values('L111','11A1','002')
insert into tblLop values('L112','11A2','002')
insert into tblLop values('L113','11A3','002')
insert into tblLop values('L121','12A1','003')
insert into tblLop values('L122','12A2','003')

insert into tblHocKi values('1','HK1')
insert into tblHocKi values('2','HK2')

insert into tblMonHoc values('MH1',N'Toán')
insert into tblMonHoc values('MH2',N'Lý')
insert into tblMonHoc values('MH3',N'Hóa')
insert into tblMonHoc values('MH4',N'Sinh')
insert into tblMonHoc values('MH5',N'Sử')
insert into tblMonHoc values('MH6',N'Địa')
insert into tblMonHoc values('MH7',N'Văn')
insert into tblMonHoc values('MH8',N'Đạo Đức')
insert into tblMonHoc values('MH9',N'Thể Dục')

insert into tblThamSo values('1',N'Số tuổi tối thiểu','14')
insert into tblThamSo values('2',N'Số tuổi tối đa','18')
insert into tblThamSo values('3',N'Sỉ số lớp tối đa','40')
insert into tblThamSo values('4',N'Điểm đạt môn','5')
insert into tblThamSo values('K101',N'Tên lớp K10','10A1')
insert into tblThamSo values('K102',N'Tên lớp K10','10A2')
insert into tblThamSo values('K103',N'Tên lớp K10','10A3')
insert into tblThamSo values('K104',N'Tên lớp K10','10A4')
insert into tblThamSo values('K111',N'Tên lớp K11','11A1')
insert into tblThamSo values('K112',N'Tên lớp K11','11A2')
insert into tblThamSo values('K113',N'Tên lớp K11','11A3')
insert into tblThamSo values('K121',N'Tên lớp K12','12A1')
insert into tblThamSo values('K122',N'Tên lớp K12','12A2')
insert into tblThamSo values('MH1',N'Tên môn học',N'Toán')
insert into tblThamSo values('MH2',N'Tên môn học',N'Lý')
insert into tblThamSo values('MH3',N'Tên môn học',N'Hóa')
insert into tblThamSo values('MH4',N'Tên môn học',N'Sinh')
insert into tblThamSo values('MH5',N'Tên môn học',N'Sử')
insert into tblThamSo values('MH6',N'Tên môn học',N'Địa')
insert into tblThamSo values('MH7',N'Tên môn học',N'Văn')
insert into tblThamSo values('MH8',N'Tên môn học',N'Đạo Đức')
insert into tblThamSo values('MH9',N'Tên môn học',N'Thể Dục')



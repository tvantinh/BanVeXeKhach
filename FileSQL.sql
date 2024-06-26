USE [master]
GO
/****** Object:  Database [BANVEXEKHACH]    Script Date: 25/11/2023 6:50:21 PM ******/
CREATE DATABASE [BANVEXEKHACH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BANVEXEKHACH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BANVEXEKHACH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BANVEXEKHACH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BANVEXEKHACH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BANVEXEKHACH] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BANVEXEKHACH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BANVEXEKHACH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET ARITHABORT OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BANVEXEKHACH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BANVEXEKHACH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BANVEXEKHACH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BANVEXEKHACH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET RECOVERY FULL 
GO
ALTER DATABASE [BANVEXEKHACH] SET  MULTI_USER 
GO
ALTER DATABASE [BANVEXEKHACH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BANVEXEKHACH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BANVEXEKHACH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BANVEXEKHACH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BANVEXEKHACH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BANVEXEKHACH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BANVEXEKHACH', N'ON'
GO
ALTER DATABASE [BANVEXEKHACH] SET QUERY_STORE = ON
GO
ALTER DATABASE [BANVEXEKHACH] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BANVEXEKHACH]
GO
/****** Object:  Table [dbo].[CHUYENXE]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENXE](
	[IDChuyenXe] [nchar](10) NOT NULL,
	[noidi] [nvarchar](50) NULL,
	[noiden] [nvarchar](50) NULL,
	[thoigiankhoihanh] [datetime] NULL,
	[thoigianden] [datetime] NULL,
	[giave] [nchar](10) NULL,
	[IDTuyenXe] [char](10) NULL,
	[IDXe] [nchar](10) NULL,
	[maTaiXe] [char](5) NOT NULL,
	[LuongKhach] [int] NOT NULL,
 CONSTRAINT [PK_CHUYENXE] PRIMARY KEY CLUSTERED 
(
	[IDChuyenXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKhachHang] [char](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[CCCD] [varchar](20) NULL,
	[numberPhone] [varchar](20) NULL,
 CONSTRAINT [PK_IDKhachHang] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDNhanVien] [char](10) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[gioiTinh] [varchar](3) NULL,
	[ngaySinh] [date] NULL,
	[cccd] [varchar](12) NULL,
	[diaChi] [nvarchar](40) NULL,
	[numberPhone] [char](11) NULL,
	[email] [varchar](40) NULL,
	[userName] [varchar](40) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[chucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_IDNhanVien] PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIXE]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIXE](
	[maTaiXe] [char](5) NOT NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[numberPhone] [char](10) NULL,
	[email] [varchar](50) NULL,
	[gioiTinh] [nchar](4) NULL,
 CONSTRAINT [PK_TaiXe] PRIMARY KEY CLUSTERED 
(
	[maTaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUYENXE]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUYENXE](
	[IDTuyenXe] [char](10) NOT NULL,
	[noidi] [nvarchar](50) NULL,
	[noiden] [nvarchar](50) NULL,
	[tenTuyenXe] [nvarchar](100) NULL,
 CONSTRAINT [PK_IDTuyenXe] PRIMARY KEY CLUSTERED 
(
	[IDTuyenXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VEXE]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VEXE](
	[IDVeXe] [char](10) NOT NULL,
	[IDKhachHang] [char](10) NOT NULL,
	[IDNhanVien] [char](10) NOT NULL,
	[GheNgoi] [nvarchar](1000) NULL,
	[IDChuyenXe] [nchar](10) NULL,
	[thoigianmua] [datetime] NULL,
 CONSTRAINT [PK_IDVeXe] PRIMARY KEY CLUSTERED 
(
	[IDVeXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XE]    Script Date: 25/11/2023 6:50:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE](
	[IDXe] [nchar](10) NOT NULL,
	[soGhe] [nchar](10) NULL,
	[bienKiemSoat] [nchar](10) NULL,
	[ghe1] [bit] NULL,
	[ghe2] [bit] NULL,
	[ghe3] [bit] NULL,
	[ghe4] [bit] NULL,
	[ghe5] [bit] NULL,
	[ghe6] [bit] NULL,
	[ghe7] [bit] NULL,
	[ghe8] [bit] NULL,
	[ghe9] [bit] NULL,
	[ghe10] [bit] NULL,
	[ghe11] [bit] NULL,
	[ghe12] [bit] NULL,
	[ghe13] [bit] NULL,
	[ghe14] [bit] NULL,
	[ghe15] [bit] NULL,
	[ghe16] [bit] NULL,
	[ghe17] [bit] NULL,
	[ghe18] [bit] NULL,
	[ghe19] [bit] NULL,
	[ghe20] [bit] NULL,
	[ghe21] [bit] NULL,
	[ghe22] [bit] NULL,
	[ghe23] [bit] NULL,
	[ghe24] [bit] NULL,
	[ghe25] [bit] NULL,
	[ghe26] [bit] NULL,
 CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[IDXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUYENXE] ([IDChuyenXe], [noidi], [noiden], [thoigiankhoihanh], [thoigianden], [giave], [IDTuyenXe], [IDXe], [maTaiXe], [LuongKhach]) VALUES (N'CX01      ', N'Bình Thuận', N'TPHCM     ', CAST(N'2023-02-05T08:00:00.000' AS DateTime), CAST(N'2023-02-05T13:15:00.000' AS DateTime), N'250000    ', N'TX01      ', N'X01       ', N'TAX01', 0)
INSERT [dbo].[CHUYENXE] ([IDChuyenXe], [noidi], [noiden], [thoigiankhoihanh], [thoigianden], [giave], [IDTuyenXe], [IDXe], [maTaiXe], [LuongKhach]) VALUES (N'CX02      ', N'TPHCM     ', N'Bình Thuận', CAST(N'2023-02-05T14:00:00.000' AS DateTime), CAST(N'2023-02-05T19:30:00.000' AS DateTime), N'300000    ', N'TX03      ', N'X03       ', N'TAX01', 0)
INSERT [dbo].[CHUYENXE] ([IDChuyenXe], [noidi], [noiden], [thoigiankhoihanh], [thoigianden], [giave], [IDTuyenXe], [IDXe], [maTaiXe], [LuongKhach]) VALUES (N'CX03      ', N'Gia Lai   ', N'TPHCM     ', CAST(N'2023-02-05T19:00:00.000' AS DateTime), CAST(N'2023-02-06T06:00:00.000' AS DateTime), N'650000    ', N'TX02      ', N'X02       ', N'TAX01', 0)
INSERT [dbo].[CHUYENXE] ([IDChuyenXe], [noidi], [noiden], [thoigiankhoihanh], [thoigianden], [giave], [IDTuyenXe], [IDXe], [maTaiXe], [LuongKhach]) VALUES (N'CX04      ', N'TPHCM     ', N'Gia Lai   ', CAST(N'2023-02-06T08:00:00.000' AS DateTime), CAST(N'2023-02-06T15:00:00.000' AS DateTime), N'600000    ', N'TX04      ', N'X04       ', N'TAX01', 0)
GO
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH01      ', N'Trần Hoàng Mỹ', N'hoangmy@gmail.com', N'097372463646', N'0876556781')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH010     ', N'Trần Gia Khanh', N'khanh@gmail.com', N'027384773467', N'0919738282')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH02      ', N'Trần Hào', N'hao@gmail.com', N'087433456271', N'0127674367')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH03      ', N'Nguyễn Đạt', N'dat@gmail.com', N'018374748755', N'0916781627')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH04      ', N'Lữ Tiến Hoa', N'hoalu@gmail.com', N'018745785478', N'0918782374')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH05      ', N'Hứa Văn Quyết', N'quyet@gmail.com', N'053873878575', N'0198748758')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH06      ', N'Tô Thị Dung', N'dung@gmail.com', N'035787382737', N'0628738774')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH07      ', N'Nguyễn Huy Hà', N'ha@gmail.com', N'098374823723', N'0274387382')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH08      ', N'Nguyễn Nhật An', N'an@gmail.com', N'02832198938', N'0128738742')
INSERT [dbo].[KHACHHANG] ([IDKhachHang], [name], [email], [CCCD], [numberPhone]) VALUES (N'KH09      ', N'Trần Vân Anh', N'anh@gmail.com', N'040202024131', N'0987126747')
GO
INSERT [dbo].[NHANVIEN] ([IDNhanVien], [name], [gioiTinh], [ngaySinh], [cccd], [diaChi], [numberPhone], [email], [userName], [password], [chucVu]) VALUES (N'NV001     ', N'Nguyễn Văn Huy', N'Nam', CAST(N'2003-10-16' AS Date), N'060203003912', N'Bình Thuận', N'0335700945 ', N'huyhuy@gmail.ccom', N'huyhuy', N'huy123', N'Quản lí')
INSERT [dbo].[NHANVIEN] ([IDNhanVien], [name], [gioiTinh], [ngaySinh], [cccd], [diaChi], [numberPhone], [email], [userName], [password], [chucVu]) VALUES (N'NV002     ', N'Trần Văn Tình', N'Nam', CAST(N'2003-10-13' AS Date), N'063247637267', N'Gia Lai', N'0273878274 ', N'vantjnk@gmail.com', N'tinhtinh', N'tinh456', N'Nhân viên')
INSERT [dbo].[NHANVIEN] ([IDNhanVien], [name], [gioiTinh], [ngaySinh], [cccd], [diaChi], [numberPhone], [email], [userName], [password], [chucVu]) VALUES (N'NV003     ', N'Hứa Hùng Hưng', N'Nam', CAST(N'2003-07-31' AS Date), N'032748273274', N'TPHCM', N'0127837832 ', N'hunghua@gmail.com', N'hunghua', N'hung789', N'Nhân viên')
GO
INSERT [dbo].[TAIXE] ([maTaiXe], [NgaySinh], [DiaChi], [numberPhone], [email], [gioiTinh]) VALUES (N'TAX01', CAST(N'2000-02-12' AS Date), N'Gia Lai', N'0989765863', N'Batran@gmail.com', N'Nam ')
GO
INSERT [dbo].[TUYENXE] ([IDTuyenXe], [noidi], [noiden], [tenTuyenXe]) VALUES (N'TX01      ', N'Bình Thuận', N'TPHCM', N'Bình Thuận - TPHCM')
INSERT [dbo].[TUYENXE] ([IDTuyenXe], [noidi], [noiden], [tenTuyenXe]) VALUES (N'TX02      ', N'Gia Lai', N'TPHCM', N'Gia Lai - TPHCM')
INSERT [dbo].[TUYENXE] ([IDTuyenXe], [noidi], [noiden], [tenTuyenXe]) VALUES (N'TX03      ', N'TPHCM', N'Cà Mau', N'TPHCM - Cà Mau')
INSERT [dbo].[TUYENXE] ([IDTuyenXe], [noidi], [noiden], [tenTuyenXe]) VALUES (N'TX04      ', N'TPHCM', N'Hà Nội', N'TPHCM - Hà Nội')
INSERT [dbo].[TUYENXE] ([IDTuyenXe], [noidi], [noiden], [tenTuyenXe]) VALUES (N'TX05      ', N'Đắk Lắk', N'TPHCM', N'Đắk Lắk - TPHCM')
GO
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX01      ', N'KH01      ', N'NV001     ', N'0', N'CX01      ', CAST(N'2023-01-02T08:45:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX010     ', N'KH09      ', N'NV002     ', N'0', N'CX02      ', CAST(N'2023-01-04T14:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX011     ', N'KH010     ', N'NV003     ', N'0', N'CX02      ', CAST(N'2023-01-03T05:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX02      ', N'KH01      ', N'NV001     ', N'0', N'CX01      ', CAST(N'2023-01-02T08:45:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX03      ', N'KH02      ', N'NV001     ', N'0', N'CX01      ', CAST(N'2023-01-03T20:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX04      ', N'KH03      ', N'NV002     ', N'0', N'CX02      ', CAST(N'2023-01-04T10:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX05      ', N'KH04      ', N'NV002     ', N'0', N'CX02      ', CAST(N'2023-01-02T10:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX06      ', N'KH05      ', N'NV003     ', N'0', N'CX02      ', CAST(N'2023-01-01T09:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX07      ', N'KH06      ', N'NV003     ', N'0', N'CX03      ', CAST(N'2023-01-01T20:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX08      ', N'KH07      ', N'NV001     ', N'0', N'CX03      ', CAST(N'2023-01-04T22:00:00.000' AS DateTime))
INSERT [dbo].[VEXE] ([IDVeXe], [IDKhachHang], [IDNhanVien], [GheNgoi], [IDChuyenXe], [thoigianmua]) VALUES (N'VX09      ', N'KH08      ', N'NV002     ', N'0', N'CX03      ', CAST(N'2023-01-03T06:00:00.000' AS DateTime))
GO
INSERT [dbo].[XE] ([IDXe], [soGhe], [bienKiemSoat], [ghe1], [ghe2], [ghe3], [ghe4], [ghe5], [ghe6], [ghe7], [ghe8], [ghe9], [ghe10], [ghe11], [ghe12], [ghe13], [ghe14], [ghe15], [ghe16], [ghe17], [ghe18], [ghe19], [ghe20], [ghe21], [ghe22], [ghe23], [ghe24], [ghe25], [ghe26]) VALUES (N'X01       ', N'16        ', N'86C-99999 ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[XE] ([IDXe], [soGhe], [bienKiemSoat], [ghe1], [ghe2], [ghe3], [ghe4], [ghe5], [ghe6], [ghe7], [ghe8], [ghe9], [ghe10], [ghe11], [ghe12], [ghe13], [ghe14], [ghe15], [ghe16], [ghe17], [ghe18], [ghe19], [ghe20], [ghe21], [ghe22], [ghe23], [ghe24], [ghe25], [ghe26]) VALUES (N'X02       ', N'26        ', N'81C-12345 ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[XE] ([IDXe], [soGhe], [bienKiemSoat], [ghe1], [ghe2], [ghe3], [ghe4], [ghe5], [ghe6], [ghe7], [ghe8], [ghe9], [ghe10], [ghe11], [ghe12], [ghe13], [ghe14], [ghe15], [ghe16], [ghe17], [ghe18], [ghe19], [ghe20], [ghe21], [ghe22], [ghe23], [ghe24], [ghe25], [ghe26]) VALUES (N'X03       ', N'16        ', N'50H-98765 ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[XE] ([IDXe], [soGhe], [bienKiemSoat], [ghe1], [ghe2], [ghe3], [ghe4], [ghe5], [ghe6], [ghe7], [ghe8], [ghe9], [ghe10], [ghe11], [ghe12], [ghe13], [ghe14], [ghe15], [ghe16], [ghe17], [ghe18], [ghe19], [ghe20], [ghe21], [ghe22], [ghe23], [ghe24], [ghe25], [ghe26]) VALUES (N'X04       ', N'26        ', N'00J-49053 ', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
GO
ALTER TABLE [dbo].[CHUYENXE]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENXE_TUYENXE] FOREIGN KEY([IDTuyenXe])
REFERENCES [dbo].[TUYENXE] ([IDTuyenXe])
GO
ALTER TABLE [dbo].[CHUYENXE] CHECK CONSTRAINT [FK_CHUYENXE_TUYENXE]
GO
ALTER TABLE [dbo].[CHUYENXE]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENXE_XE] FOREIGN KEY([IDXe])
REFERENCES [dbo].[XE] ([IDXe])
GO
ALTER TABLE [dbo].[CHUYENXE] CHECK CONSTRAINT [FK_CHUYENXE_XE]
GO
ALTER TABLE [dbo].[CHUYENXE]  WITH CHECK ADD  CONSTRAINT [fk_TaiXeXe] FOREIGN KEY([maTaiXe])
REFERENCES [dbo].[TAIXE] ([maTaiXe])
GO
ALTER TABLE [dbo].[CHUYENXE] CHECK CONSTRAINT [fk_TaiXeXe]
GO
ALTER TABLE [dbo].[VEXE]  WITH CHECK ADD  CONSTRAINT [FK_IDKhachHang] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KHACHHANG] ([IDKhachHang])
GO
ALTER TABLE [dbo].[VEXE] CHECK CONSTRAINT [FK_IDKhachHang]
GO
ALTER TABLE [dbo].[VEXE]  WITH CHECK ADD  CONSTRAINT [FK_IDNhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NHANVIEN] ([IDNhanVien])
GO
ALTER TABLE [dbo].[VEXE] CHECK CONSTRAINT [FK_IDNhanVien]
GO
ALTER TABLE [dbo].[VEXE]  WITH CHECK ADD  CONSTRAINT [FK_VEXE_CHUYENXE] FOREIGN KEY([IDChuyenXe])
REFERENCES [dbo].[CHUYENXE] ([IDChuyenXe])
GO
ALTER TABLE [dbo].[VEXE] CHECK CONSTRAINT [FK_VEXE_CHUYENXE]
GO
USE [master]
GO
ALTER DATABASE [BANVEXEKHACH] SET  READ_WRITE 
GO

USE [QLShopGiayDep]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[ID_TypeAccount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Phone] [varchar](11) NULL,
	[Gender] [nvarchar](10) NULL,
	[Score] [int] NULL,
	[CreaDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetails]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Invoice] [int] NULL,
	[ID_Product] [int] NULL,
	[BuyQuantity] [int] NULL,
	[Size] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CreaDate] [datetime] NULL,
	[ID_Customer] [int] NULL,
	[ID_Staff] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [bigint] NULL,
	[Size] [int] NULL,
	[ID_Product] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Price] [bigint] NULL,
	[Discount] [int] NULL,
	[ID_Brand] [int] NULL,
	[ID_Type] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Phone] [varchar](11) NULL,
	[BirthDate] [date] NULL,
	[Gender] [nvarchar](10) NULL,
	[ID_Account] [int] NULL,
	[Salary] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeAccount]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeProducts]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeProducts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (2, N'duydang', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (3, N'dang1', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (4, N'dang2', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (5, N'dang3', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (6, N'dang4', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (7, N'dang5', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (8, N'dang6', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (1002, N'ddd', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (1004, N'dang7', N'1', 2)
INSERT [dbo].[Accounts] ([ID], [Username], [Password], [ID_TypeAccount]) VALUES (1005, N'huy123', N'123', 2)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([ID], [Name]) VALUES (1, N'Nike')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (2, N'Adidas')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (3, N'MLB')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (4, N'Puma')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (5, N'Vans')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (6, N'Converse')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1, N'Nguyễn Kiều Hoa', N'0123456789', N'Nữ', 4, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (2, N'Lê Bảo Anh 1', N'0123456790', N'Nữ', 2, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (3, N'Phan Tuấn Trung', N'0123456791', N'Nam', 1, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (4, N'Lê Thị Nguyệt Thảo', N'0123456792', N'Nữ', 6, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (5, N'Trần Anh Công', N'0123456793', N'Nam', 1, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (6, N'Lê Thị Kim An', N'0123456794', N'Nữ', 1, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (7, N'Phạm Lê Thiên Triệu', N'0123456795', N'Nam', 1, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (8, N'Phan Tuyết Trinh', N'0123456796', N'Nữ', 1, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (9, N'Trần Anh Tú', N'0123456797', N'Nam', 1, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (10, N'Nguyễn Thị Thanh Trúc', N'0123456798', N'Nữ', 1, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1003, N'Nguyễn Thị Nhật Anh', N'0868337747', N'Nữ', 17, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1004, N'fkdsalfs', N'0868337744', N'Nam', 2, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1005, N'ttttt', N'01206884510', N'Nam', 0, CAST(N'2024-01-22' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1006, N'dddd', N'0375295838', N'Nam', 0, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1011, N'kkkkk', N'0868337747', N'Nam', 2, CAST(N'2024-04-10' AS Date))
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1012, N'Đăng Khoa 1', N'0120688433', N'Nam', 5, NULL)
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1013, N'Đăng Khoa', N'0975543977', N'Nam', 0, NULL)
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1014, N'Đăng Khoa', N'0120688433', N'Nam', 7, NULL)
INSERT [dbo].[Customers] ([ID], [Name], [Phone], [Gender], [Score], [CreaDate]) VALUES (1016, N'Đăng nè', N'0868337747', N'Nam', 0, CAST(N'2024-04-30' AS Date))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[InvoiceDetails] ON 

INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (1, 1, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (2, 1, 3, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (3, 1, 4, 2, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (4, 1, 5, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (5, 2, 3, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (6, 2, 4, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (7, 2, 7, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (8, 4, 6, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (9, 4, 9, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (10, 5, 5, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (11, 1003, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (12, 1004, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (13, 1004, 3, 2, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (14, 1004, 7, 3, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (15, 1005, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (16, 1007, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (17, 1008, 2, 1, NULL)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (22, 1015, 2, 1, 37)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (23, 1015, 2, 1, 38)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (31, 1023, 2, 1, 38)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (32, 1024, 2, 1, 38)
INSERT [dbo].[InvoiceDetails] ([ID], [ID_Invoice], [ID_Product], [BuyQuantity], [Size]) VALUES (41, 1033, 2, 1, 38)
SET IDENTITY_INSERT [dbo].[InvoiceDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoices] ON 

INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1, CAST(N'2022-01-01T12:30:00.000' AS DateTime), 1, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (2, CAST(N'2022-01-02T15:45:00.000' AS DateTime), 2, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (4, CAST(N'2022-01-04T18:20:00.000' AS DateTime), 4, 20)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (5, CAST(N'2022-01-05T14:10:00.000' AS DateTime), 5, 21)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1003, CAST(N'2024-04-19T17:04:25.623' AS DateTime), NULL, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1004, CAST(N'2024-04-19T17:06:41.270' AS DateTime), 1003, 19)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1005, CAST(N'2024-04-19T17:09:35.340' AS DateTime), 1, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1007, CAST(N'2024-04-19T17:20:38.090' AS DateTime), 1004, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1008, CAST(N'2024-04-19T21:14:43.580' AS DateTime), 1011, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1010, CAST(N'2024-04-20T18:14:30.327' AS DateTime), NULL, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1015, CAST(N'2024-04-20T22:24:34.633' AS DateTime), NULL, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1023, CAST(N'2024-04-29T23:47:42.963' AS DateTime), 1012, 1025)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1024, CAST(N'2024-04-30T20:06:59.643' AS DateTime), 1016, 17)
INSERT [dbo].[Invoices] ([ID], [CreaDate], [ID_Customer], [ID_Staff]) VALUES (1033, CAST(N'2024-04-30T21:11:06.560' AS DateTime), NULL, 17)
SET IDENTITY_INSERT [dbo].[Invoices] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductDetails] ON 

INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (7, 0, 37, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (8, 30, 38, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (9, 70, 39, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (10, 30, 40, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (11, 10, 41, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (12, 90, 42, 2)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (13, 50, NULL, 3)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (18, 50, 38, 4)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (19, 70, 39, 4)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (20, 30, 40, 4)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (21, 10, 41, 4)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (22, 90, 42, 4)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (23, 50, 38, 5)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (24, 70, 39, 5)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (25, 30, 40, 5)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (26, 10, 41, 5)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (27, 90, 42, 5)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (28, 50, 38, 6)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (29, 70, 39, 6)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (30, 30, 40, 6)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (31, 10, 41, 6)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (32, 90, 42, 6)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (33, 50, 38, 7)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (34, 70, 39, 7)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (35, 30, 40, 7)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (36, 10, 41, 7)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (37, 90, 42, 7)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (38, 50, NULL, 8)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (43, 50, 38, 9)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (44, 70, 39, 9)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (45, 30, 40, 9)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (46, 10, 41, 9)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (47, 90, 42, 9)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (48, 50, 38, 10)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (49, 70, 39, 10)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (50, 30, 40, 10)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (51, 10, 41, 10)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (52, 90, 42, 10)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1003, 1, 33, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1004, 1, 34, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1005, 1, 35, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1006, 1, 36, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1007, 1, 38, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1008, 1, 42, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1009, 1, 33, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1010, 1, 36, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1011, 1, 39, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1012, 1, 41, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1013, 1, 44, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1018, 11, 34, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1019, 22, 39, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1020, 55, 41, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1021, 423, 42, NULL)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1038, 50, 33, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1039, 10, 34, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1040, 40, 35, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1041, 20, 36, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1042, 15, 37, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1043, 65, 38, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1044, 60, 40, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1045, 40, 41, 60)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1046, 1, 33, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1047, 1, 35, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1048, 1, 36, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1049, 1, 38, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1050, 1, 40, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1051, 1, 41, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1052, 1, 42, 12)
INSERT [dbo].[ProductDetails] ([ID], [Quantity], [Size], [ID_Product]) VALUES (1053, 1, 43, 12)
SET IDENTITY_INSERT [dbo].[ProductDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (2, N'Product 2', 240000, 0, 1, 2, 206)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (3, N'Product 3', 150000, 20, 2, 3, 49)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (4, N'Product 4', 350000, 25, 2, 1, 11)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (5, N'Product 5', 200000, 0, 3, 1, 234)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (6, N'Product 8', 300000, 5, 3, 2, 546)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (7, N'Product 11', 400000, 40, 4, 2, 2424)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (8, N'Product 8', 1500000, 0, 4, 3, 2342)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (9, N'Product 10', 2500000, 0, 5, 1, 231)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (10, N'Product 11', 250000, 0, 5, 2, 643)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (12, N'Giày Vans 11', 120000, 10, 3, 1, 8)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (13, N'Giày Vans 12', 210000, 20, 5, 1, 34)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (14, N'Giày Vans 13', 110000, 0, 1, 1, 88)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (15, N'Dép Puma 1', 155000, 0, 4, 2, 345)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (16, N'Product 11', 150000, 24, 4, 1, 111)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (51, N'Product 12', 120400, 24, 5, 2, 257)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Discount], [ID_Brand], [ID_Type], [Quantity]) VALUES (60, N'Giày', 250000, 0, 1, 1, 300)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (17, N'Trần Duy Đăng', N'0868337747', CAST(N'2003-08-20' AS Date), N'Nam', 1, 10000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (18, N'Phan Tuấn Nghĩa', N'0868337748', CAST(N'2001-07-19' AS Date), N'Nam', 2, 5000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (19, N'Lê Thị Ngân', N'0123456678', CAST(N'2002-02-11' AS Date), N'Nữ', 3, 6000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (20, N'Phan Thị Mỹ Kim', N'0846244324', CAST(N'1992-01-20' AS Date), N'Nữ', 4, 5500000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (21, N'Trần Hoài Anh', N'0868337742', CAST(N'2001-04-22' AS Date), N'Nam', 5, 5000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (22, N'Phạm Thành Trung', N'01206884510', CAST(N'2000-05-30' AS Date), N'Nam', 6, 5000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (23, N'Lê Phan Bội Châu', N'01206884511', CAST(N'1999-06-11' AS Date), N'Nữ', 7, 3000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (24, N'Trần Hồng Phúc', N'01206884512', CAST(N'2000-05-12' AS Date), N'Nữ', 8, 4000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (1019, N'Thành Danh', N'0939616194', CAST(N'2023-01-16' AS Date), N'Nam', 1002, 3000000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (1024, N'Bảo An', N'0923129710', CAST(N'2024-04-21' AS Date), N'Nam', 1004, 1000)
INSERT [dbo].[Staffs] ([ID], [Name], [Phone], [BirthDate], [Gender], [ID_Account], [Salary]) VALUES (1025, N'Huy Bùi', N'0120688451', CAST(N'2024-04-29' AS Date), N'Khác', 1005, 123434432)
SET IDENTITY_INSERT [dbo].[Staffs] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeAccount] ON 

INSERT [dbo].[TypeAccount] ([ID], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[TypeAccount] ([ID], [Name]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[TypeAccount] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeProducts] ON 

INSERT [dbo].[TypeProducts] ([ID], [Name]) VALUES (1, N'Giày')
INSERT [dbo].[TypeProducts] ([ID], [Name]) VALUES (2, N'Dép')
INSERT [dbo].[TypeProducts] ([ID], [Name]) VALUES (3, N'Phụ Kiện')
SET IDENTITY_INSERT [dbo].[TypeProducts] OFF
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_TypeAccount] FOREIGN KEY([ID_TypeAccount])
REFERENCES [dbo].[TypeAccount] ([ID])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_TypeAccount]
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([ID_Invoice])
REFERENCES [dbo].[Invoices] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetails]  WITH CHECK ADD FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Products] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD FOREIGN KEY([ID_Customer])
REFERENCES [dbo].[Customers] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD FOREIGN KEY([ID_Staff])
REFERENCES [dbo].[Staffs] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD FOREIGN KEY([ID_Product])
REFERENCES [dbo].[Products] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([ID_Brand])
REFERENCES [dbo].[Brands] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_TypeProducts] FOREIGN KEY([ID_Type])
REFERENCES [dbo].[TypeProducts] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_TypeProducts]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD FOREIGN KEY([ID_Account])
REFERENCES [dbo].[Accounts] ([ID])
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[AddCustomer]
@name nvarchar(200), @phone varchar(11), @gender nvarchar(10), @score int, @creadate datetime
as
begin
	insert into customers values(@name, @phone, @gender, @score, @creadate)
end
GO
/****** Object:  StoredProcedure [dbo].[AddDetailProduct]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[AddDetailProduct]
@quantity int, @size int, @idproduct int
as
begin 
	INSERT into ProductDetails values(@quantity, @size, @idproduct);
end
GO
/****** Object:  StoredProcedure [dbo].[AddInvoice]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddInvoice]
@creaDate datetime, @idcustomer int, @idStaff int
as
begin
	if @idcustomer = -1
	begin
		insert into invoices(CreaDate, ID_Staff) values(@creaDate, @idStaff)
	end
	else 
	begin
		insert into invoices values(@creaDate, @idcustomer, @idStaff)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[AddInvoiceDetail]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddInvoiceDetail]
@idInvoice int, @idProduct int, @buyquantity int, @size int
as 
begin 
	insert into invoicedetails values(@idInvoice, @idProduct, @buyquantity, @size)
	update products set Quantity -= @buyquantity where ID = @idProduct
	if @size != -1
	begin
		update productdetails set Quantity -= @buyquantity where ID_Product = @idProduct and size = @size
	end
end



GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddProduct]
(@name nvarchar(200), @price bigint, @discount int, @id_brand int, @id_type int, @quantity int)
as
begin
	insert into products values(@name, @price, @discount, @id_brand, @id_type, @quantity);
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductDetailByIDProduct]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteProductDetailByIDProduct]
@idProduct int
as
begin 
	delete ProductDetails where ID_Product = @idProduct
end
GO
/****** Object:  StoredProcedure [dbo].[GetDataBySDT]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDataBySDT]
@sdt varchar(11)
as
begin
	Select * from Customers where phone like '%'+@sdt+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[insertTK]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertTK]
@tentk varchar(50), @mk varchar(50), @role int
as
begin
	insert into Accounts values(@tentk, @mk, @role)
end
GO
/****** Object:  StoredProcedure [dbo].[SearchProductsByType]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SearchProductsByType]
(@type varchar(50), @searchInput nvarchar(200))
as
begin
	if @type = 'Thương hiệu'
	begin
		select Products.ID, Products.Name, Price, Discount, Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where brands.[Name] like N'%'+@searchInput+'%';
	end
	else if @type = 'Loại'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where TypeProducts.[Name] like N'%'+@searchInput+'%';
	end
	else if @type = 'ID'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where Products.ID like '%'+@searchInput+'%';
	end
	else if @type = 'Tên Sản Phẩm'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where Products.[Name] like N'%'+@searchInput+'%';
	end
	else if @type = 'Đơn Giá'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where Products.Price like '%'+@searchInput+'%';
	end
	else if @type = 'Khuyến Mãi'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where Products.Discount like '%'+@searchInput+'%';
	end
	else if @type = 'Số lượng'
	begin
		select Products.ID, Products.Name, Price, Discount,Quantity, TypeProducts.Name as Type, Brands.Name as 'BrandName' from products inner join Brands on Products.ID_Brand = Brands.ID inner join TypeProducts on Products.ID_Type = TypeProducts.ID
		where Products.Quantity like '%'+@searchInput+'%';
	end
end
GO
/****** Object:  StoredProcedure [dbo].[updateproduct]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[updateproduct]
@id int, @name nvarchar(400), @price bigint, @discount int, @id_brand int, @id_type int, @quantity int
as
begin 
	update products set [Name] = @name, Price = @price, Discount = @discount, ID_Brand = @id_brand, ID_Type = @id_type, Quantity = @quantity 
	where ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateScoreCustomer]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateScoreCustomer]
@id int, @score int, @type varchar(10)
as
begin
	if @type = 'C'
	begin
		update customers set score += @score where id = @id;
	end
	else 
	begin
		update customers set score = @score where id = @id;
	end
end
GO
/****** Object:  StoredProcedure [dbo].[updateTK]    Script Date: 30/04/2024 21:13:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateTK]
@matk int, @tentk varchar(50), @mk varchar(50), @role int
as
begin
	update Accounts set Username = @tentk, Password = @mk, ID_TypeAccount = @role where ID = @matk
end
GO

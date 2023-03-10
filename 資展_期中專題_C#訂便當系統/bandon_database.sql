USE [bandon]
GO
/****** Object:  Table [dbo].[orderList]    Script Date: 2022/11/4 上午 01:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderId] [int] NULL,
	[userId] [nvarchar](50) NULL,
	[訂購人姓名] [nvarchar](50) NULL,
	[電話] [nvarchar](50) NULL,
	[訂購時間] [datetime] NULL,
	[外送地址] [nvarchar](500) NULL,
	[訂單總金額] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2022/11/4 上午 01:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](50) NULL,
	[price] [int] NULL,
	[pdesc] [nvarchar](500) NULL,
	[pimage] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopCartDtails]    Script Date: 2022/11/4 上午 01:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopCartDtails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderId] [int] NULL,
	[訂購時間] [datetime] NULL,
	[品項] [nvarchar](50) NULL,
	[單價] [int] NULL,
	[訂購數量] [int] NULL,
	[加蛋] [nvarchar](10) NULL,
	[加菜脯] [nvarchar](10) NULL,
	[加飯] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userData]    Script Date: 2022/11/4 上午 01:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userData](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[權限] [int] NULL,
	[userId] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[姓名] [nvarchar](50) NULL,
	[性別] [nvarchar](10) NULL,
	[婚姻狀態] [bit] NULL,
	[電話] [nvarchar](50) NULL,
	[地址] [nvarchar](500) NULL,
	[Email] [nvarchar](50) NULL,
	[生日] [date] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[orderList] ON 

INSERT [dbo].[orderList] ([id], [orderId], [userId], [訂購人姓名], [電話], [訂購時間], [外送地址], [訂單總金額]) VALUES (3, 4064, N'test', N'test', N'0912345678', CAST(N'2022-11-01T22:08:29.220' AS DateTime), N'高雄市天龍區', 195)
INSERT [dbo].[orderList] ([id], [orderId], [userId], [訂購人姓名], [電話], [訂購時間], [外送地址], [訂單總金額]) VALUES (4, 9330, N'Manager', N'Manager', N'0912345678', CAST(N'2022-11-01T22:09:14.170' AS DateTime), N'台東市天龍區', 220)
INSERT [dbo].[orderList] ([id], [orderId], [userId], [訂購人姓名], [電話], [訂購時間], [外送地址], [訂單總金額]) VALUES (8, 8530, N'guest2', N'guest2', N'0912345678', CAST(N'2022-11-03T00:05:44.930' AS DateTime), N'高雄市苓雅區', 535)
INSERT [dbo].[orderList] ([id], [orderId], [userId], [訂購人姓名], [電話], [訂購時間], [外送地址], [訂單總金額]) VALUES (5, 4703, N'Staff', N'Staff', N'0912345678', CAST(N'2022-11-01T22:09:51.253' AS DateTime), N'新北市天龍區', 385)
INSERT [dbo].[orderList] ([id], [orderId], [userId], [訂購人姓名], [電話], [訂購時間], [外送地址], [訂單總金額]) VALUES (7, 3998, N'guest1', N'guest1', N'0912345678', CAST(N'2022-11-02T23:52:03.343' AS DateTime), N'高雄市仁武區', 185)
SET IDENTITY_INSERT [dbo].[orderList] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (1, N'蔥燒排骨飯', 95, NULL, N'1.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (2, N'特製雞腿飯', 100, NULL, N'2.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (3, N'蔥油雞腿飯', 100, NULL, N'3.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (4, N'鱈香魚片飯', 85, NULL, N'4.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (5, N'宮保雞丁飯', 85, N'123', N'5.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (6, N'椒鹽雞排飯', 85, NULL, N'6.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (7, N'香脆腿排飯', 80, NULL, N'7.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (8, N'特製排骨飯', 80, NULL, N'8.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (9, N'虱目魚肚飯', 80, NULL, N'9.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (10, N'三杯雞塊飯', 75, NULL, N'10.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (11, N'醬汁雞柳飯', 80, NULL, N'11.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (12, N'蔥爆豬柳飯', 70, N'456', N'12.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (13, N'糖醋魚柳飯', 65, N'', N'13.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (14, N'特製鯖魚飯', 70, NULL, N'14.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (15, N'香酥蝦排飯', 70, NULL, N'15.png')
INSERT [dbo].[products] ([id], [pname], [price], [pdesc], [pimage]) VALUES (16, N'五配菜便當', 65, NULL, N'16.png')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[ShopCartDtails] ON 

INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (7, 4064, CAST(N'2022-11-01T22:08:29.220' AS DateTime), N'特製雞腿飯', 100, 1, N'10元', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (9, 9330, CAST(N'2022-11-01T22:09:14.167' AS DateTime), N'蔥爆豬柳飯', 70, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (10, 9330, CAST(N'2022-11-01T22:09:14.170' AS DateTime), N'特製鯖魚飯', 70, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (11, 9330, CAST(N'2022-11-01T22:09:14.170' AS DateTime), N'香脆腿排飯', 80, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (20, 8530, CAST(N'2022-11-03T00:05:44.930' AS DateTime), N'椒鹽雞排飯', 85, 5, N'無', N'無', N'20元')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (21, 8530, CAST(N'2022-11-03T00:05:44.930' AS DateTime), N'香脆腿排飯', 80, 1, N'10元', N'要', N'20元')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (8, 4064, CAST(N'2022-11-01T22:08:29.220' AS DateTime), N'鱈香魚片飯', 85, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (12, 4703, CAST(N'2022-11-01T22:09:51.247' AS DateTime), N'蔥燒排骨飯', 95, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (13, 4703, CAST(N'2022-11-01T22:09:51.253' AS DateTime), N'特製雞腿飯', 100, 1, N'無', N'要', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (14, 4703, CAST(N'2022-11-01T22:09:51.253' AS DateTime), N'鱈香魚片飯', 85, 2, N'10元', N'無', N'無')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (18, 3998, CAST(N'2022-11-02T23:52:03.337' AS DateTime), N'糖醋魚柳飯', 65, 1, N'無', N'無', N'30元')
INSERT [dbo].[ShopCartDtails] ([id], [orderId], [訂購時間], [品項], [單價], [訂購數量], [加蛋], [加菜脯], [加飯]) VALUES (19, 3998, CAST(N'2022-11-02T23:52:03.340' AS DateTime), N'醬汁雞柳飯', 80, 1, N'10元', N'要', N'30元')
SET IDENTITY_INSERT [dbo].[ShopCartDtails] OFF
GO
SET IDENTITY_INSERT [dbo].[userData] ON 

INSERT [dbo].[userData] ([id], [權限], [userId], [password], [姓名], [性別], [婚姻狀態], [電話], [地址], [Email], [生日]) VALUES (1, 3, N'test', N'123', N'test', N'男', 0, N'0912345678', N'高雄市天龍區', N'test@gmail.com', CAST(N'1988-01-01' AS Date))
INSERT [dbo].[userData] ([id], [權限], [userId], [password], [姓名], [性別], [婚姻狀態], [電話], [地址], [Email], [生日]) VALUES (2, 2, N'Staff', N'123', N'Staff', N'男', 1, N'0912345678', N'新北市天龍區', N'Staff@yahoo.com.tw', CAST(N'1988-11-01' AS Date))
INSERT [dbo].[userData] ([id], [權限], [userId], [password], [姓名], [性別], [婚姻狀態], [電話], [地址], [Email], [生日]) VALUES (3, 3, N'Manager', N'123', N'Manager', N'女', 1, N'0912345678', N'台東市天龍區', N'Manager@gmail.com', CAST(N'1988-11-01' AS Date))
INSERT [dbo].[userData] ([id], [權限], [userId], [password], [姓名], [性別], [婚姻狀態], [電話], [地址], [Email], [生日]) VALUES (6, 1, N'guest1', N'123456', N'guest', N'男', 1, N'0912345678', N'天龍市仁武區', N'guest@gmail.com', CAST(N'1988-09-01' AS Date))
INSERT [dbo].[userData] ([id], [權限], [userId], [password], [姓名], [性別], [婚姻狀態], [電話], [地址], [Email], [生日]) VALUES (8, 2, N'Staff2', N'123', N'Staff2', N'女', 0, N'0912345678', N'台南市天龍區', N'Staff2@yahoo.com.tw', CAST(N'1977-09-03' AS Date))
SET IDENTITY_INSERT [dbo].[userData] OFF
GO

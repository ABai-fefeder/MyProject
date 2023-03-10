/****** Object:  Table [dbo].[Blog]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blog](
	[Title] [nvarchar](100) NULL,
	[SubTitle] [nvarchar](100) NULL,
	[ArticleID] [int] NOT NULL,
	[Floor] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[Article] [nvarchar](1000) NULL,
	[Time] [datetime] NULL,
	[ImageName] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC,
	[Floor] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CusCake]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CusCake](
	[CusCakeID] [int] IDENTITY(5001,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[ForWho] [nvarchar](50) NULL,
	[Purpose] [nvarchar](1000) NULL,
	[Like] [nvarchar](50) NULL,
	[Hate] [nvarchar](50) NULL,
	[DueDate] [date] NOT NULL,
	[Note] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[CusCakeID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountCode] [varchar](100) NOT NULL,
	[Discount] [float] NULL,
	[DueDate] [date] NULL,
	[LeftAmount] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DiscountCode] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberID] [int] IDENTITY(99001,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[NickName] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](200) NULL,
	[Permission] [bit] NULL,
	[FavoriteProduct] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(19001,1) NOT NULL,
	[MemberID] [int] NOT NULL,
	[ProductID] [int] NULL,
	[DiscountCode] [varchar](100) NULL,
	[Income] [float] NULL,
	[Delivary] [nvarchar](50) NULL,
	[Amount] [int] NOT NULL,
	[DateTime] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(10001,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Size] [nvarchar](200) NOT NULL,
	[Flavor] [nvarchar](200) NULL,
	[Price] [varchar](50) NOT NULL,
	[ImageName] [nvarchar](1000) NULL,
	[Avalible] [bit] NULL,
	[Tag] [nvarchar](200) NULL,
	[Category] [nvarchar](200) NULL,
	[Description] [nvarchar](3000) NULL,
 CONSTRAINT [PK__Product__B40CC6ED2BCE4EBC] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[Date] [date] NOT NULL,
	[MemberID] [int] NULL,
	[ProductID] [int] NULL,
	[ClassName] [nvarchar](50) NULL,
	[PeopleNumber] [int] NULL,
	[Note] [nvarchar](800) NULL,
PRIMARY KEY CLUSTERED 
(
	[Date] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignUp]    Script Date: 2023/2/10 下午 04:55:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignUp](
	[Date] [date] NOT NULL,
	[MemberID] [int] NOT NULL,
	[IsJoin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Date] ASC,
	[MemberID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 0, 1, 99008, NULL, N'cheese餅餅好吃~', CAST(N'2023-02-03T05:46:25.387' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'在家自已做提拉米蘇', N'材料準備', 5002, 0, 99003, NULL, N'在這種困難的抉擇下，本人思來想去，寢食難安。培根說過一句經典的名言，要追求真理，認識真理，更要依賴真理，這是人性中的最高品德。這句話讓我們得到了一個全新的觀點去思考這個問題。從這個角度來看，朱熹曾提出，百學須先立志。這句話讓我們得到了一個全新的觀點去思考這個問題。在人類的歷史中，我們總是盡了一切努力想搞懂提拉米蘇。', CAST(N'2023-02-01T10:40:50.000' AS DateTime), N'blog-1.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5002, 1, 99004, NULL, N'布朗尼可以說是有著成為常識的趨勢。羅斯金在過去曾經講過，聰明人常從萬物中有所感悟，因為他所得到的才能本是從一切事物中汲取的精華。希望各位能用心體會這段話。布朗尼的存在，令我無法停止對他的思考。由於，我們要從本質思考，從根本解決問題。', CAST(N'2023-01-04T10:42:35.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5002, 2, 99007, NULL, N'Fr曾說過ncis B曾說過con曾說過，愛令智昏。希望大家能從這段話中有所收穫。可可的發生，到底需要如何實現，不可可的發生，又會如何產生。不難發現，問題在於該用什麼標準來做決定呢？一般來講，我們都必須務必慎重的考慮考慮。馬克思說過，消費資料的任何一種分配，都不過是生產條件本身分配的結果，而生產的條件的分配，則表現生產方式本身的性質。這句話反映了問題的急切性', CAST(N'2023-01-05T09:54:36.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5002, 3, 99002, NULL, N'儘管可可看似不顯眼，卻佔據了我的腦海。李遠哲講過，要有追根究底、毫不妥協的精神，無論生活或研究工作都必須非常認真，要打破沙鍋問到底。希望大家實際感受一下這段話。當你搞懂後就會明白了。一般來說，木蘭詩曾經認為，兵在精而不在多，將在謀不在勇。這段話看似複雜，其中的邏輯思路卻清晰可見。', CAST(N'2023-01-05T09:55:58.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5002, 4, 99009, NULL, N'提拉米蘇豪ㄘ', CAST(N'2023-01-18T08:04:40.960' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'關於當季商品...', N'fdss', 5003, 0, 99007, NULL, N'對檸檬進行深入研究，在現今時代已經無法避免了。吳晗講過一段耐人尋思的話，在學習上做一眼勤、手勤、腦勤，就可以成為有學問的人。這句話看似簡單，卻埋藏了深遠的意義。朱舜水講過一段耐人尋思的話，滿盈者，不損何為？慎之！慎之！ 這句話看似簡單，但其中的陰鬱不禁讓人深思。', CAST(N'2023-02-01T10:48:55.000' AS DateTime), N'blog-2.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5003, 1, 99006, NULL, N'需要考慮周詳檸檬的影響及因應對策。謹慎地來說，我們必須考慮到所有可能。儘管如此，我們仍然需要對檸檬保持懷疑的態度。錢三強曾講過，科學不是為了個人榮譽，不是為了私利，而是為人類謀幸福。他會這麼說是有理由的。老舊的想法已經過時了。', CAST(N'2023-01-05T08:32:34.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5003, 2, 99009, NULL, N'咖啡好喝', CAST(N'2023-01-18T08:05:58.963' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'本月課程問題', NULL, 5004, 0, 99005, NULL, N'做好檸檬這件事，可以說已經成為了全民運動。要想清楚，檸檬，到底是一種怎麼樣的存在。若能夠欣賞到檸檬的美，相信我們一定會對檸檬改觀。謹慎地來說，我們必須考慮到所有可能。既然如此，若能夠洞悉檸檬各種層面的含義，勢必能讓思維再提高一個層級。', CAST(N'2023-02-01T18:12:03.000' AS DateTime), N'blog-3.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5004, 1, 99006, NULL, N'什麼時侯開課?', CAST(N'2023-01-06T19:00:54.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'請問分店的商品', NULL, 5005, 0, 99008, NULL, N'我是11月文章', CAST(N'2022-12-25T09:26:30.683' AS DateTime), N'newPostblog.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'當季商品什麼時侯可以預定?', NULL, 5006, 0, 99008, NULL, N'我是12月文章', CAST(N'2022-02-25T09:27:32.930' AS DateTime), N'newPostblog.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'酒漬櫻桃黑森林心得', NULL, 5007, 0, 99005, 10024, N'超好吃', CAST(N'2023-02-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'巧克力莓果塔很好吃!!', NULL, 5008, 0, 99009, 10022, N'巧克力巧克力巧克力莓果塔', CAST(N'2023-02-02T10:41:11.027' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'cheese餅餅心得分享', NULL, 5009, 0, 99008, 10001, N'Cheese餅餅可以給狗狗吃真的很不錯', CAST(N'2023-02-02T07:14:53.927' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5009, 1, 99010, NULL, N'我家狗狗也喜歡吃cheese餅餅，好吃推薦', CAST(N'2023-01-31T16:56:33.900' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'請問課程教室要怎麼租?', NULL, 5010, 0, 99008, NULL, N'有打算出租賃教學嗎', CAST(N'2023-01-29T07:18:58.363' AS DateTime), N'newPostblog.jpg')
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'蔓越莓司康 製作材料問題', NULL, 5011, 0, 99004, 10004, N'蔓越莓口味有點偏酸', CAST(N'2023-02-03T02:03:21.807' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5011, 1, 99018, NULL, N'越酸我越愛，就像人生一樣~', CAST(N'2023-02-06T12:02:57.440' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5011, 2, 99011, NULL, N'上面酒喝不夠多歐?', CAST(N'2023-02-06T12:05:07.703' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 5011, 3, 99010, NULL, N'我覺得給過~', CAST(N'2023-02-06T12:09:43.273' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'請問波卡米餅有賣材料包嗎?', NULL, 5012, 0, 99001, 10002, N'如題~', CAST(N'2023-02-01T02:16:33.177' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10001, 1, 99003, NULL, N'cheese餅餅我家狗狗也喜歡吃!!!', CAST(N'2023-02-03T05:47:18.177' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10001, 2, 99012, NULL, N'cheese餅餅好吃好吃回購推薦', CAST(N'2023-02-03T05:47:28.670' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10001, 3, 99008, NULL, N'感覺大家都滿推薦cheese餅餅，我也來吃吃看!', CAST(N'2023-02-05T16:16:10.730' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10002, 1, 99010, 10002, N'店狗tutti愛吃，感覺也可以給我家狗狗試試看', CAST(N'2023-01-31T17:36:46.400' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10002, 2, 99008, NULL, N'我覺得米餅滿好吃的，推薦', CAST(N'2023-02-01T13:31:35.670' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (NULL, NULL, 10006, 1, 99010, NULL, N'這個巧克力球超好吃!!!!', CAST(N'2023-02-01T14:03:13.873' AS DateTime), NULL)
INSERT [dbo].[Blog] ([Title], [SubTitle], [ArticleID], [Floor], [MemberID], [ProductID], [Article], [Time], [ImageName]) VALUES (N'新文章標題', N'哈囉你好我是次標題呦!', 10007, 0, 99008, 10006, N'感謝各位蒞臨我們結業專題的發表現場，酒鬼芭娜娜很好吃喔', CAST(N'2023-02-07T02:37:33.417' AS DateTime), N'blackChocolate.jpg')
GO
INSERT [dbo].[Discount] ([DiscountCode], [Discount], [DueDate], [LeftAmount]) VALUES (N'doxocl9s6', 0.75, NULL, NULL)
INSERT [dbo].[Discount] ([DiscountCode], [Discount], [DueDate], [LeftAmount]) VALUES (N'skdd5ss2', 0.8, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99001, N'張育剛', N'Peter', N'FERvddfr@gmail.com', N'0912100522', N'a00044', CAST(N'1954-05-12' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99002, N'賴惠悅', N'Julia', N'LwxffoPPgmq@gmail.com', N'0952153625', N'a002', CAST(N'1957-10-09' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99003, N'王大富', N'Wang', N'qk2rcmWv1a@gmail.com', N'0945126369', N'a003', CAST(N'2000-07-01' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99004, N'林雅婷', N'採青', N'rDlIDrL385EdE@gmail.com', N'0987456123', N'a004', CAST(N'1999-03-21' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99005, N'蔡志文', N'夏山', N'Kr5zt1eyD6JJ@gmail.com', N'0914521652', N'a005', CAST(N'1993-01-02' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99006, N'張育南', N'逍遙', N'cLxjgOtlQ5@gmail.com', N'0988522147', N'a006', CAST(N'1966-12-23' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99007, N'王欣儀', N'靈兒', N'rri5Ijko0k5eC@gmail.com', N'0966321581', N'a007', CAST(N'2002-06-02' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99008, N'ABai2', N'ABai', N'777', N'0977666554', N'777', CAST(N'1977-07-07' AS Date), N'7777', 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99009, N'測試人員', N'冊冊冊', N'123', N'123', N'123', CAST(N'1995-05-25' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99010, N'黃正銘', N'小銘', N'ming0208@gmail.com', N'000', N'000', CAST(N'1987-02-08' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99011, N'阮玉0', N'阿五', N'nothreeeye@gmail.com', N'0913870601', N'123123', NULL, NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99012, N'Mario', N'Mario', N'worm1114@hotmail.com', N'0912345578', N'12345678', NULL, NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99014, N'張牧之', N'張麻子', N'abc@gmail.com', N'0918000000', N'123456', NULL, NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99018, N'黃久銘', N'酒名', N'ming@gmail.com', N'094793264385', N'999', CAST(N'1999-09-09' AS Date), NULL, 0, NULL)
INSERT [dbo].[Member] ([MemberID], [Name], [NickName], [Email], [PhoneNumber], [Password], [Birthday], [Address], [Permission], [FavoriteProduct]) VALUES (99024, N'你好我是測試人員', N'小測', N'ThisIsTest@gmail.com', N'0955555555', N'18000000', NULL, NULL, 0, NULL)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19001, 99005, 10009, N'skdd5ss2', 450, NULL, 6, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19002, 99007, 10006, N'skdd5ss2', 200, NULL, 5, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19003, 99003, 10003, N'skdd5ss2', 300, NULL, 2, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19004, 99002, 10020, N'doxocl9s6', 520, NULL, 1, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19005, 99002, 10005, N'doxocl9s6', 350, NULL, 4, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19006, 99009, 10005, NULL, 400, NULL, 1, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19007, 99009, 10009, NULL, 500, NULL, 1, NULL)
INSERT [dbo].[Order] ([OrderID], [MemberID], [ProductID], [DiscountCode], [Income], [Delivary], [Amount], [DateTime]) VALUES (19008, 99010, 10001, NULL, NULL, NULL, 2, NULL)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10001, N'cheese餅餅', N'小罐|大罐', NULL, N'120|220', N'CheeseStick.jpg', 1, N'cheeese|起司|餅乾|狗狗可食', N'常備品項', N'甜嘴MO的開元老甜甜，大人解牙祭，小孩的磨牙棒，狗狗的潔牙骨 ，一罐3吃多方便阿吃餅餅吃CHEESE 補鈣鈣~~')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10002, N'波卡米餅', N'1罐', NULL, N'200', N'BokaRiceCookie.jpg', 1, N'寶寶|米餅|餅乾|狗狗可食', N'常備品項', N'🍑波卡米餅（寶寶米餅）
     $200/罐--口味隨機出貨
為了姪子-波卡-研發的，純天然寶寶米餅，因此稱「波卡米餅」。不使用市售蔬果粉，而是全以🍎🍍蔬果的原型，及米製作。
🍒「越簡單越困難」這句話我想是最能體現波卡米餅的製程了吧。
這是目前所有的甜甜中，成份最簡單，也無須調味，卻是最難製作且繁瑣又難控制的甜甜😱每種蔬果的質地含水量都不同，配方比例也得因此更動，且光烤焙就得花上3小時😱低溫烘烤，雖說是寶寶米餅，也意外成為朋友們嘴饞愛吃的零食。
❤️這純粹的味道也養了一群，「大寶寶」🤣
❤️每罐會有兩款口味喔~讓寶寶能接觸更多元的食材
🍓🥝🍠且每款口味都是混了至少2種蔬果製作。
舉例：A:草莓+蔓越莓+山藥
            B:蘋果+鳳梨+山藥
🍒貼心小提醒：訂購時，如有寶寶會過敏的食材，可私訊告知')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10003, N'舔嘴杏仁餅', N'11入', NULL, N'300', N'almondCookie.jpg', 1, N'杏仁|餅乾', N'常備品項', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10004, N'蔓越莓司康', N'6入', NULL, N'350', N'scone.jpg', 1, N'蔓越莓|司康', N'常備品項', N'經典熱賣產品，口口都能吃到蔓越莓果乾的酸甜，以及入口後純蜂蜜的天然香，朋友都說吃到會吮指舔嘴（甜嘴）')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10005, N'百香可可旅人蛋糕', N'5入', NULL, N'350', N'passionCocoCupCake2.jpg', 1, N'巧克力|可可|百香果|杯子蛋糕', N'常備品項', N'選用法國頂級巧克力，那帶點霸氣的濃郁可可入口後，接著新鮮百香果的特殊香起果酸微微圍繞在嘴裡❤如果說香蕉與巧克力是樸實的老夫老妻，那我覺得百香果與巧克力就是一對浪漫派的新婚小夫妻')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10006, N'巧克力球', N'10入', N'金光閃閃', N'250', N'blackChocolate.jpg', 1, N'可可|脆片|巧克力|黑巧克力|杏仁角', N'常備品項', N'
採用　
🐽比利時進口純黑巧及白巧混合
🐽特製焦糖脆片與杏仁角
食材　很簡單　不複雜
就如一段好的情感
💓最簡單純粹的　最濃郁美好💓')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10007, N'巧克力球', N'10入', N'粉紅泡泡', N'300', N'redChocolate.jpg', 1, N'可可|脆片|巧克力|莓果乾|紅寶石巧克力', N'常備品項', N'少女心噴發吧~~~
特別隆重介紹一下，粉紅泡泡的主角!是選用目前世上第四種巧克力-紅寶石巧克力(RUBY Chocolate)，前三種分別為黑巧克力、牛奶巧克力、以及白巧克力。
而紅寶石巧克力，實如其名!!是無添加色素香料!那夢幻的粉紅色澤，全來自於其獨特的天然原料-紅寶石可可豆，是大自然浪漫的顏色呀。吃起來帶著莓果香氣，微酸帶甜。但這些都是巧克力本身的味道喔。而非添加草莓莓果味的白巧。
粉紅泡泡，除了主角紅寶石巧克力外，另外搭配了乾燥莓果乾，及脆球餅乾，就像一顆顆的小泡泡一樣，視覺與味覺絕對讓你少女心大噴發')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10008, N'天使之鈴可麗露', N'6入', N'櫻桃可可', N'450', N'canele.jpg', 1, N'可可|櫻桃|可麗露', N'常備品項', N'麻煩又難烤的法式甜點之一，甜度降低又要維持表層的酥脆及擁有Q軟的內在，這是朋友給我的難題~~~這款意外蠻多男生喜歡的(大家原以為會甜膩膩)')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10009, N'天使之鈴可麗露', N'6入', N'經典原味', N'450', N'canele1.jpg', 1, N'香草|可麗露', N'常備品項', N'麻煩又難烤的法式甜點之一，甜度降低又要維持表層的酥脆及擁有Q軟的內在，這是朋友給我的難題~~~這款意外蠻多男生喜歡的(大家原以為會甜膩膩)')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10010, N'天使之鈴可麗露', N'6入', N'綜合', N'450', N'canele2.jpg', 1, N'可可|櫻桃|香草|可麗露', N'常備品項', N'麻煩又難烤的法式甜點之一，甜度降低又要維持表層的酥脆及擁有Q軟的內在，這是朋友給我的難題~~~這款意外蠻多男生喜歡的(大家原以為會甜膩膩)')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10011, N'泡芙', N'6入', N'草莓起司', N'450', N'puffstrawberrycheese.jpg', 1, N'起司|草莓|泡芙', N'泡芙', N'少女心如我，怎能不出個草莓口味的呢，但這次也來點微醺 ，是貝禮詩草莓奶酒🍷🍷，在灑上些許綜合乾燥莓果丁，及新鮮草莓~微酸又微甜，怎能不愛😝')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10012, N'泡芙', N'6入', N'伯爵茶', N'450', N'puffearlgrey.jpg', 1, N'伯爵|含酒|泡芙', N'泡芙', N'這款屬於大人的味道，醬是初鹿牛奶與伯爵茶葉去熬的~特別的是茶葉我跳了好久，最終就來自斯里蘭卡的緹莉亞伯爵茶，另外甜度稍微降低 咬下去瞬間伯爵茶特有的佛手柑味兒，直衝鼻腔😂（絕不是香精味喔）另外特別把甜味降低，微苦的味道搭上法國伊思尼海鹽焦糖丁，他們就是如此的~絕配😘')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10013, N'泡芙', N'6入', N'香草奶油', N'450', N'puffvanilla.jpg', 1, N'香草|泡芙', N'泡芙', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10014, N'泡芙', N'6入', N'香濃可可', N'450', N'puffchocolate.jpg', 1, N'可可|巧克力|泡芙', N'泡芙', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10015, N'檸檬瑪德蓮', N'6入', NULL, N'270', N'lemonMadeleine1.jpg', 1, N'檸檬|瑪德蓮', N'常備品項', N'顛覆一般對瑪德蓮乾柴的印象，不誇張，這款特別加了義大利西西里島杏仁粉，入口後的堅果香夾帶天然蜂蜜的香甜，及檸檬的清香圍繞在口中，新鮮刨的檸檬皮加上純天然蜂蜜（絕非調和蜜）及日本上白糖，濕潤不乾柴。不論是簡單的當早餐或下午茶，搭著咖啡或奶茶都超絕配呀~~
❤貼心小提醒，稍微加熱後，蜂蜜及檸檬的香氣會更濃郁喔')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10016, N'檸夏檸檬塔', N'1顆', NULL, N'90', N'lemonTart2.jpg', 1, N'檸檬|塔', N'常備品項', N'一口咬下，清爽卻帶著濃郁檸檬香與酸，緊接著是帶著微蛋糕口感的杏仁奶餡，調和了酸度，最後再來自製酥脆塔殼收尾，檸檬塔已經偷跑好久囉，不嗜酸的小朋友及喜好酸的朋友都喜歡優')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10017, N'酒鬼芭娜娜', N'小杯|大盒', NULL, N'140|520', N'Tiramisu3.jpg', 1, N'含酒|香蕉|提拉米蘇', N'常備品項', N'如果說巧克力搭香蕉是百年好合的老夫妻,那提拉米蘇搭香蕉就是充滿激情的新婚夫妻,自製添加了義大利西西里島杏仁粉的杏香蛋糕體,加上咖啡酒及精心挑選過的櫻桃酒及酒漬櫻桃點綴,可是為這對新婚夫妻添加不少情趣呢🤣（另會附上巧克力脆片及巴瑞脆片添加口感）')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10019, N'酒鬼先生', N'小杯|大盒', NULL, N'140|520', N'Tiramisu1.jpg', 1, N'含酒|提拉米蘇', N'常備品項', N'不喝酒的我最近很愛用酒入甜點，這次特別推出成人版的提拉米蘇，選用🗽墨西哥卡魯哇咖啡酒➕法國杏桃甜酒，帶給大家微醺的甜點
且捨棄了現成的手指餅乾，而是選用🌻比利時嘉麗寶頂級巧克力及杏仁糕自製的杏仁巧克力蛋糕體，害怕杏仁味的朋友別擔心，我沒說你一定吃不出來😜
PS.要買給小朋友吃的另外跟我說，會特製💞《幼幼版提拉米蘇》💞')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10020, N'酒鬼先生', N'大盒', NULL, N'520', N'TiramisuL.jpg', 0, N'含酒|提拉米蘇', N'常備品項', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10021, N'裝熟乳酪', N'5入', NULL, N'350', N'cheeseCake.jpg', 1, N'乳酪|乳酪蛋糕', N'常備品項', N'N🍭乳酪嬌軀：使用「日本十勝北海道乳酪」+「初鹿鮮奶」製作而成
🍭乳酪胖屁屁：「臺灣純蜂蜜🍯」
+「日本三溫糖」+「日本鳥越麵粉」的特製蜂蜜蛋糕')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10022, N'巧克力莓果塔', N'1顆', NULL, N'150', N'chocoberryTart.jpg', 1, N'巧克力|莓果|塔', N'常備品項', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10023, N'酒漬櫻桃黑森林', N'小杯|大盒', NULL, N'140|520', N'cherryChocoCake.jpg', 0, N'櫻桃|酒漬|黑森林|巧克力|提拉米蘇', N'常備品項', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10024, N'酒漬櫻桃黑森林', N'大盒', NULL, N'520', N'cherryChocoCake.jpg', 0, N'櫻桃|酒漬|黑森林|巧克力|提拉米蘇', N'常備品項', NULL)
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10029, N'草莓奶酪', N'4入', NULL, N'300', N'strawberryPutting.jpg', 1, N'草莓|布丁|奶酪', N'季節限定', N'台東初鹿鮮乳與法國鮮奶油及德國香草籽製成的奶酪本體 ,搭上草莓提拉米蘇自製草莓果醬,及新鮮草莓藍莓,簡單的甜甜就如我們的生活一樣,要吃的過的很有態度與精彩')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10038, N'嬌貴小姐', N'小杯|大盒', NULL, N'140|250', N'strawberryTiramisu.jpg', 1, N'草莓|提拉米蘇', N'季節限定', N'甜如其名，處理草莓時，一切都得輕柔對待，一顆顆清洗再一顆顆擦拭
*蛋香濃郁的蛋糕體搭上自製香草卡士達，伴隨著酸甜草莓提拉米蘇與自製草莓果醬，再加上雙層滿滿的新鮮草莓，多層次的口感，讓你一口吃進滿滿幸福感❤')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10039, N'香芒柚YO', N'小杯|大盒', NULL, N'130|480', N'mangograpepudding.jpg', 0, N'芒果|蛋糕', N'季節限定', N'🍑香芒柚YO
夏天到了.芒果的季節也到了
🥭蜂蜜柚香蛋糕體
🥭罰站熬製百香芒果醬
🥭甜嘴mo招牌之一-伯爵卡士達
🥭百香芒果提拉米蘇
🥭新鮮芒果、奇異果、蘋果
一個主角的誕生，背後是由許多配角相互搭配而成，而「香芒柚yo」就像一個team的成果發表，讓大家一口挖到底吃的到層次感，更吃的到每個環節，我堅持天然的用心❣️')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Size], [Flavor], [Price], [ImageName], [Avalible], [Tag], [Category], [Description]) VALUES (10053, N'酷玩青凍塔', N'3入', N'檸檬口味', N'400', N'lemonwinetart.jpg', 1, N'檸檬|含酒', N'常備品項', NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-04' AS Date), 99007, 10023, N'酒漬櫻桃黑森林', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-05' AS Date), 99006, 10015, N'檸檬瑪德蓮', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-06' AS Date), 99005, 10021, N'裝熟乳酪', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-07' AS Date), 99004, 10022, N'巧克力莓果塔', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-09' AS Date), 99003, 10023, N'酒漬櫻桃黑森林', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-10' AS Date), 99002, 10005, N'百香可可旅人蛋糕', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-01-18' AS Date), 99008, 10001, N'777', 5, N'77777')
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-02-01' AS Date), 99002, NULL, NULL, 2, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-02-09' AS Date), 99001, 10005, N'百香可可旅人蛋糕', 1, NULL)
INSERT [dbo].[Schedule] ([Date], [MemberID], [ProductID], [ClassName], [PeopleNumber], [Note]) VALUES (CAST(N'2023-03-05' AS Date), 99008, NULL, N'檸檬瑪德蓮', 1, NULL)
GO
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-04' AS Date), 99009, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-18' AS Date), 99001, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-18' AS Date), 99002, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-18' AS Date), 99003, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-18' AS Date), 99005, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-01-18' AS Date), 99006, 1)
INSERT [dbo].[SignUp] ([Date], [MemberID], [IsJoin]) VALUES (CAST(N'2023-02-01' AS Date), 99006, 1)
GO
ALTER TABLE [dbo].[Member] ADD  DEFAULT ((0)) FOR [Permission]
GO
ALTER TABLE [dbo].[Order] ADD  DEFAULT ((1)) FOR [Amount]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF__Product__Avalibl__5FB337D6]  DEFAULT ((1)) FOR [Avalible]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF__Product__Categor__60A75C0F]  DEFAULT ('????') FOR [Category]
GO
ALTER TABLE [dbo].[Schedule] ADD  DEFAULT (NULL) FOR [ClassName]
GO
ALTER TABLE [dbo].[Schedule] ADD  DEFAULT ((1)) FOR [PeopleNumber]
GO
ALTER TABLE [dbo].[SignUp] ADD  DEFAULT ((0)) FOR [IsJoin]
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[Blog]  WITH CHECK ADD  CONSTRAINT [FK__Blog__ProductID__6477ECF3] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Blog] CHECK CONSTRAINT [FK__Blog__ProductID__6477ECF3]
GO
ALTER TABLE [dbo].[CusCake]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([DiscountCode])
REFERENCES [dbo].[Discount] ([DiscountCode])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK__Order__ProductID__02084FDA] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK__Order__ProductID__02084FDA]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK__Schedule__Produc__68487DD7] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK__Schedule__Produc__68487DD7]
GO
ALTER TABLE [dbo].[SignUp]  WITH CHECK ADD FOREIGN KEY([Date])
REFERENCES [dbo].[Schedule] ([Date])
GO
ALTER TABLE [dbo].[SignUp]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Member] ([MemberID])
GO

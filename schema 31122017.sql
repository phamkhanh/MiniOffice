USE [MOffice]
GO
/****** Object:  Table [dbo].[CanBo]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[DonVi] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_CanBo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CoQuan]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoQuan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Huyen] [int] NULL,
	[Tinh] [int] NULL,
	[Xa] [int] NULL,
	[Khac] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiTrichYeu]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTrichYeu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrichYeu] [ntext] NOT NULL,
 CONSTRAINT [PK_LoaiTrichYeu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiVanBan]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiVanBan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[KyHieu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [varchar](50) NULL,
	[UserType] [varchar](50) NULL,
	[CheckIn] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLog]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserRef] [int] NOT NULL,
	[LogContent] [ntext] NULL,
	[LogDate] [datetime] NULL,
 CONSTRAINT [PK__UserLog__3214EC07FB32D8AE] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VanBanDenHuyen]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanBanDenHuyen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiVanBanId] [int] NOT NULL,
	[NgayDen] [date] NULL,
	[SoDen] [int] NULL,
	[CoQuanId] [int] NOT NULL,
	[SoKyHieu] [nvarchar](50) NULL,
	[NgayBanHanh] [date] NULL,
	[TrichYeu] [ntext] NULL,
	[NguoiNhan] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[UpdateDate] [datetime] NULL,
	[UserId] [int] NOT NULL,
	[Path] [nvarchar](250) NULL,
 CONSTRAINT [PK_VanBanDenHuyen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VanBanDenTinh]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanBanDenTinh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiVanBanId] [int] NOT NULL,
	[NgayDen] [date] NULL,
	[SoDen] [int] NULL,
	[CoQuanId] [int] NOT NULL,
	[SoKyHieu] [nvarchar](50) NULL,
	[NgayBanHanh] [date] NULL,
	[TrichYeu] [ntext] NULL,
	[NguoiNhan] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[UpdateDate] [datetime] NULL,
	[UserId] [int] NOT NULL,
	[Path] [nvarchar](250) NULL,
 CONSTRAINT [PK_VanBanDenTinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VanBanDi]    Script Date: 12/31/2017 6:44:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VanBanDi](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiVanBanId] [int] NULL,
	[UserId] [int] NULL,
	[CoQuanId] [int] NULL,
	[SoDi] [int] NULL,
	[SoKyHieu] [nvarchar](50) NULL,
	[NgayBanHanh] [date] NULL,
	[TrichYeu] [ntext] NULL,
	[NguoiKy] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](250) NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF__VanBanDi__Update__1BFD2C07]  DEFAULT (getdate()),
	[Path] [nvarchar](250) NULL,
	[Mix] [nvarchar](5) NULL,
 CONSTRAINT [PK__VanBanDi__3214EC079D9677B0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[UserLog] ADD  CONSTRAINT [DF__UserLog__LogDate__17F790F9]  DEFAULT (getdate()) FOR [LogDate]
GO
ALTER TABLE [dbo].[UserLog]  WITH CHECK ADD  CONSTRAINT [FK_UserLog_User] FOREIGN KEY([UserRef])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserLog] CHECK CONSTRAINT [FK_UserLog_User]
GO
ALTER TABLE [dbo].[VanBanDenHuyen]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenHuyen_CoQuan] FOREIGN KEY([CoQuanId])
REFERENCES [dbo].[CoQuan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenHuyen] CHECK CONSTRAINT [FK_VanBanDenHuyen_CoQuan]
GO
ALTER TABLE [dbo].[VanBanDenHuyen]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenHuyen_LoaiVanBan] FOREIGN KEY([LoaiVanBanId])
REFERENCES [dbo].[LoaiVanBan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenHuyen] CHECK CONSTRAINT [FK_VanBanDenHuyen_LoaiVanBan]
GO
ALTER TABLE [dbo].[VanBanDenHuyen]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenHuyen_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenHuyen] CHECK CONSTRAINT [FK_VanBanDenHuyen_User]
GO
ALTER TABLE [dbo].[VanBanDenTinh]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenTinh_CoQuan] FOREIGN KEY([CoQuanId])
REFERENCES [dbo].[CoQuan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenTinh] CHECK CONSTRAINT [FK_VanBanDenTinh_CoQuan]
GO
ALTER TABLE [dbo].[VanBanDenTinh]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenTinh_LoaiVanBan] FOREIGN KEY([LoaiVanBanId])
REFERENCES [dbo].[LoaiVanBan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenTinh] CHECK CONSTRAINT [FK_VanBanDenTinh_LoaiVanBan]
GO
ALTER TABLE [dbo].[VanBanDenTinh]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDenTinh_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[VanBanDenTinh] CHECK CONSTRAINT [FK_VanBanDenTinh_User]
GO
ALTER TABLE [dbo].[VanBanDi]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDi_CoQuan] FOREIGN KEY([CoQuanId])
REFERENCES [dbo].[CoQuan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDi] CHECK CONSTRAINT [FK_VanBanDi_CoQuan]
GO
ALTER TABLE [dbo].[VanBanDi]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDi_LoaiVanBan] FOREIGN KEY([LoaiVanBanId])
REFERENCES [dbo].[LoaiVanBan] ([Id])
GO
ALTER TABLE [dbo].[VanBanDi] CHECK CONSTRAINT [FK_VanBanDi_LoaiVanBan]
GO
ALTER TABLE [dbo].[VanBanDi]  WITH CHECK ADD  CONSTRAINT [FK_VanBanDi_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[VanBanDi] CHECK CONSTRAINT [FK_VanBanDi_User]
GO
USE [master]
GO
ALTER DATABASE [MOffice] SET  READ_WRITE 
GO

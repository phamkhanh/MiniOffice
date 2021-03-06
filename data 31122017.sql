USE [MOffice]
GO
SET IDENTITY_INSERT [dbo].[CoQuan] ON 

GO
INSERT [dbo].[CoQuan] ([Id], [Ten], [Huyen], [Tinh], [Xa], [Khac]) VALUES (1, N'UBND thị trấn Gò Dầu', 0, 0, 1, 0)
GO
INSERT [dbo].[CoQuan] ([Id], [Ten], [Huyen], [Tinh], [Xa], [Khac]) VALUES (2, N'UBND huyện Gò Dầu', 1, 0, 0, 0)
GO
INSERT [dbo].[CoQuan] ([Id], [Ten], [Huyen], [Tinh], [Xa], [Khac]) VALUES (3, N'UBND tỉnh Tây Ninh', 0, 1, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[CoQuan] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiVanBan] ON 

GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (1, N'Công văn', N'/UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (2, N'Kế hoạch', N'/KH-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (3, N'Báo cáo', N'/BC-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (4, N'Quyết định', N'/QĐ-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (5, N'Tờ trình', N'/TTr-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (6, N'Biên bản', N'/BB-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (7, N'Thông báo', N'/TB-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (8, N'Thư mời', N'/TM-UBND')
GO
INSERT [dbo].[LoaiVanBan] ([Id], [Ten], [KyHieu]) VALUES (9, N'Chương trình', N'/CTr-UBND')
GO
SET IDENTITY_INSERT [dbo].[LoaiVanBan] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType], [CheckIn]) VALUES (1, N'khanhpd', N'123', N'1', NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType], [CheckIn]) VALUES (2, N'huongla', N'1', N'2', NULL)
GO
INSERT [dbo].[User] ([Id], [UserName], [Password], [UserType], [CheckIn]) VALUES (3, N'khuongnth', N'1', N'2', NULL)
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[CanBo] ON 

GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (1, N'Phạm Duy Khánh', N'VP UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (2, N'Lê Ánh Hương', N'VP - TK UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (3, N'Nguyễn Trần Huy Khương', N'VP - TK UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (4, N'Lê Văn Khôi', N'UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (5, N'Trần Văn Thương', N'UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (6, N'Đặng Văn Thương', N'UBND')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (7, N'Huỳnh Hữu Thành', N'VHTT')
GO
INSERT [dbo].[CanBo] ([Id], [HoTen], [DonVi]) VALUES (8, N'Dư Thị Hồng Chương', N'Tư Pháp')
GO
SET IDENTITY_INSERT [dbo].[CanBo] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiTrichYeu] ON 

GO
INSERT [dbo].[LoaiTrichYeu] ([Id], [TrichYeu]) VALUES (1, N'Quyết định kết nạp đảng')
GO
INSERT [dbo].[LoaiTrichYeu] ([Id], [TrichYeu]) VALUES (2, N'Quyết định kết nạp đảng cho đồng chí ')
GO
SET IDENTITY_INSERT [dbo].[LoaiTrichYeu] OFF
GO

# RestMan
```
USE [RestManDb]
GO
SET IDENTITY_INSERT [dbo].[Shifts] ON 

INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (1, CAST(N'2024-05-18T21:51:46.210' AS DateTime), CAST(N'2024-05-18T22:00:37.320' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (2, CAST(N'2024-05-18T22:01:35.483' AS DateTime), CAST(N'2024-05-18T22:01:37.810' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (3, CAST(N'2024-05-18T22:01:39.703' AS DateTime), CAST(N'2024-05-18T22:28:43.870' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (4, CAST(N'2024-05-18T22:50:55.447' AS DateTime), CAST(N'2024-05-19T19:01:01.587' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (5, CAST(N'2024-05-19T19:01:11.450' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Shifts] OFF
GO
SET IDENTITY_INSERT [dbo].[Halls] ON 

INSERT [dbo].[Halls] ([Id], [Title]) VALUES (1, N'Веранда')
INSERT [dbo].[Halls] ([Id], [Title]) VALUES (2, N'Детский')
INSERT [dbo].[Halls] ([Id], [Title]) VALUES (3, N'Основной')
INSERT [dbo].[Halls] ([Id], [Title]) VALUES (4, N'Банкетный')
SET IDENTITY_INSERT [dbo].[Halls] OFF
GO
SET IDENTITY_INSERT [dbo].[Tables] ON 

INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (1, N'В1', 1)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (2, N'В2', 1)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (3, N'В3', 1)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (4, N'Д1', 2)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (5, N'Д2', 2)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (6, N'О1', 3)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (7, N'О2', 3)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (8, N'О3', 3)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (9, N'О4', 3)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (10, N'Б1', 4)
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (11, N'Б2', 4)
SET IDENTITY_INSERT [dbo].[Tables] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Title]) VALUES (1, N'Официант')
INSERT [dbo].[Roles] ([Id], [Title]) VALUES (2, N'Кассир')
INSERT [dbo].[Roles] ([Id], [Title]) VALUES (3, N'Менеджер')
INSERT [dbo].[Roles] ([Id], [Title]) VALUES (4, N'Администратор')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId]) VALUES (1, N'Конев Ефим Викторович', N'admin', N'admin', 4)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId]) VALUES (2, N'Официант', N'waiter', N'waiter', 1)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId]) VALUES (3, N'Кассир', N'cashier', N'cashier', 2)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId]) VALUES (4, N'Менеджер', N'manager', N'manager', 3)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [WaiterId], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR]) VALUES (1, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 2, 1, NULL, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [WaiterId], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR]) VALUES (2, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 2, 2, CAST(N'2024-05-18T23:51:46.210' AS DateTime), 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [WaiterId], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR]) VALUES (3, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 2, 1, NULL, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [WaiterId], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR]) VALUES (5, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 3, 2, CAST(N'2024-05-18T23:51:46.210' AS DateTime), 5, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Shops] ON 

INSERT [dbo].[Shops] ([Id], [Title]) VALUES (1, N'Горячий цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (2, N'Холодный цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (3, N'Кондитерский цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (4, N'Бар')
SET IDENTITY_INSERT [dbo].[Shops] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (1, N'Алкоголь', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (2, N'Алкогольные напитки', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (3, N'Безалкогольные напитки', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (4, N'Кофе', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (5, N'Супы', 1)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (6, N'Десерты', 3)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (7, N'Соусы', 2)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (8, N'Горячие закуски', 1)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (9, N'Салаты', 2)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (10, N'Холодные закуски', 2)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuItems] ON 

INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (1, N'Виски 200г', 500, 1, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (2, N'Маргарита', 450, 2, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (3, N'Грушевый лимонад', 250, 3, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (4, N'Капучино 200мл', 180, 4, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (5, N'Солянка', 250, 5, 1)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (6, N'Тирамису', 300, 6, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (7, N'Ткемали', 80, 7, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (8, N'Долма 6 шт.', 520, 8, 1)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (9, N'Оливье с цыпленком', 350, 9, 0)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [CategoryId], [IsStopListed]) VALUES (10, N'Битые огурцы', 290, 10, 0)
SET IDENTITY_INSERT [dbo].[MenuItems] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderMenuItems] ON 

INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [MenuItemId], [Count]) VALUES (1, 3, 5, 2)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [MenuItemId], [Count]) VALUES (2, 3, 6, 1)
SET IDENTITY_INSERT [dbo].[OrderMenuItems] OFF
```

# Приложение для работы с заказами ресторана "RestMan"
```
USE [RestManDb]
GO
SET IDENTITY_INSERT [dbo].[Shops] ON 

INSERT [dbo].[Shops] ([Id], [Title]) VALUES (1, N'Горячий цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (2, N'Холодный цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (3, N'Кондитерский цех')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (4, N'Бар')
INSERT [dbo].[Shops] ([Id], [Title]) VALUES (5, N'Мангал')
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
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (11, N'Салаты', 1)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (12, N'Гарниры', 1)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (13, N'Гриль', 5)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (14, N'Соусы', 5)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (15, N'Лимонады', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (16, N'Вода', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (17, N'Соки', 4)
INSERT [dbo].[Categories] ([Id], [Title], [ShopId]) VALUES (18, N'Плов', 5)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuItems] ON 

INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (1, N'Виски 200г', 500, 0, 1)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (2, N'Маргарита', 450, 0, 2)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (3, N'Грушевый лимонад 0,5 л', 250, 0, 15)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (4, N'Капучино 200 мл', 180, 0, 4)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (5, N'Сборная солянка на углях', 480, 1, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (6, N'Тирамису', 300, 0, 6)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (7, N'Ткемали', 80, 0, 7)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (8, N'Долма 6 шт.', 520, 1, 8)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (9, N'Оливье с цыпленком', 350, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (10, N'Битые огурцы', 290, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (12, N'Тыквенный крем-суп с сырными чипсами', 320, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (13, N'Домашний суп', 290, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (14, N'Борщ с говядиной', 450, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (15, N'Харчо', 470, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (16, N'Лагман', 550, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (17, N'Том ям с морепродуктами', 690, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (18, N'Грибной крем-суп', 390, 0, 5)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (19, N'Оливье с лососем холодного копчения', 580, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (20, N'Яхна-тил', 490, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (21, N'Аджапсандал', 320, 0, 11)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (22, N'Тёплый салат с угрём и огурцами кимчи', 590, 0, 11)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (23, N'Газапхули с цыплёнком', 390, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (24, N'Рис с овощами', 160, 0, 12)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (25, N'Овощи на гриле', 290, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (26, N'Дзадзики', 60, 0, 7)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (27, N'Цукини на гриле с чесноком', 290, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (28, N'Картофель фри', 160, 0, 12)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (29, N'Сацебели', 60, 0, 14)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (30, N'Аджика', 60, 0, 14)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (31, N'Картофель айдахо', 160, 0, 12)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (32, N'Картофельное пюре', 160, 0, 12)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (33, N'Жареная стручковая фасоль', 160, 0, 12)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (34, N'Латте 200 мл', 215, 0, 4)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (35, N'Лимонад черешня 0,5 л', 150, 0, 15)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (36, N'Крон Бланш Бир Б/А', 120, 0, 3)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (37, N'Пиво Горьковская пивоварня IPA 0,0', 150, 0, 3)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (38, N'Вода "Спортик"', 60, 0, 16)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (39, N'J7 Ананас 1 л.', 220, 0, 17)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (40, N'J7 Томат 1 л.', 220, 0, 17)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (41, N'Я Апельсин 1 л.', 220, 0, 17)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (42, N'Я Вишня 1 л.', 220, 0, 17)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (43, N'Я Яблоко 1 л.', 220, 0, 17)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (44, N'Боржоми Тархун 0,33 л', 190, 0, 15)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (45, N'Боржоми Груша 0,33 л', 190, 0, 15)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (46, N'Боржоми Аджарский мандарин 0,33 л', 190, 0, 15)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (47, N'Эвервесс Кола 0,25 л', 120, 0, 3)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (48, N'Эвервесс Кола 1 л', 130, 0, 3)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (49, N'Узбекский плов', 220, 0, 18)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (50, N'Бухарский плов', 250, 0, 18)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (51, N'Анна Павлова', 350, 0, 6)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (52, N'Мангал-кюфта из баранины', 620, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (53, N'Люля-кебаб из цыплёнка', 510, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (54, N'Грудка, фарш. сыром и шпинатом', 550, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (55, N'Шашлык из ягнёнка по-кавказски', 1050, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (56, N'Шашлык из свинины', 690, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (57, N'Шашлык из бедра цыплёнка', 590, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (58, N'Шашлык из бедра индейки', 650, 0, 13)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (59, N'Сырники со сметаной и сливочной карамелью', 310, 0, 6)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (60, N'Рулетики из баклажанов ассорти', 590, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (61, N'Салат из свёклы с говядиной и копчёным сыром', 410, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (62, N'Салат с тунцом татаки и ореховой заправкой', 550, 0, 9)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (63, N'Буженина по-домашнему', 310, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (64, N'Тёплый салат с индейкой', 410, 0, 11)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (65, N'Сельдь с картофелем', 310, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (66, N'Рулетики из баклажанов с сырной начинкой', 310, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (67, N'Рулетики из баклажанов с ореховой начинкой', 310, 0, 10)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (68, N'Сметана', 60, 0, 7)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (69, N'Мацони', 60, 0, 7)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (70, N'Майонез', 60, 0, 7)
INSERT [dbo].[MenuItems] ([Id], [Title], [Cost], [IsStopListed], [CategoryId]) VALUES (71, N'Кетчуп', 60, 0, 7)
SET IDENTITY_INSERT [dbo].[MenuItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Halls] ON 

INSERT [dbo].[Halls] ([Id], [Title], [Acronym]) VALUES (1, N'Веранда', N'В')
INSERT [dbo].[Halls] ([Id], [Title], [Acronym]) VALUES (2, N'Детский', N'Д')
INSERT [dbo].[Halls] ([Id], [Title], [Acronym]) VALUES (3, N'Основной', N'О')
INSERT [dbo].[Halls] ([Id], [Title], [Acronym]) VALUES (4, N'Банкетный', N'Б')
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
INSERT [dbo].[Tables] ([Id], [Title], [HallId]) VALUES (12, N'О5', 3)
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

INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (1, N'Конев Ефим Викторович', N'admin', N'dJ59JsjBOAGT6Zmo5hoEOOZcCIPsnLpGv5nfN4IY610=', 4, N'BMuJNR1X9/J4j48SuPUiWw==', 1)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (2, N'Кисель Александр Игоревич', N'waiter', N'PjIp9feBIQFrEvzBtPQLg8GijWxVgYGvdNZwBimcT6o=', 1, N'yswSxsYVX0FMkXzB8w6Gxw==', 1)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (3, N'Николаев Вячеслав Алексеевич', N'cashier', N'2jfjFsvXvrsfCXfYiC/pjYfzNY6CUiEvmbgl/+Q3aL4=', 2, N'jlPBGPcw31Sfht04M8LNyA==', 1)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (4, N'Прохоренко Владимир Сергеевич', N'manager', N'yAbtRl2WD09AyRNEtDXd8daXfRMq1toJ0LZfMCO96WE=', 3, N'WsBvKzImYBRZ1jdnnk0fyg==', 1)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (5, N'Кочетков Денис Александрович', N'kdacash', N'TMTbWZXR2gXw6bbo/ghc8hRpJRjc8YV4jFcS5MMTxis=', 2, N'Ul0BmrCbBmy4CNakiFiEpA==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (6, N'Никифорова Юлия Сергеевна', N'nysman', N'LAiY+TaL2vLl/P8qkpVVA7uo1b+3mJGXSW+6XbWS+co=', 3, N'tRdPNK78FPDBNqjVZN3R1Q==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (7, N'Иванов Антон Петрович', N'iapman', N'EO8YyWr4+i/TcVJo/mP8qITzHkHp3xarHFIZ5aDFjHY=', 3, N'YBEEnOTWSlLBIPLpl4tXLQ==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (8, N'Баринов Виктор Петрович', N'bvpman', N'mOYCZQeaN573m4zKV6/NA6ua0kKNH8nuijhGzdIqpZo=', 3, N'i+XUjxTs8r+1I8PW3+23kQ==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (9, N'Коршикова Эльвина Павловна', N'kepwait', N'QbFCYbGvsSchzvVXsG2nOJ3Njbs6qIARcS06igW96LA=', 1, N'oE95MKm5DRA1u6LtyQHaPg==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (10, N'Меньшиков Данила Александрович', N'mdawait', N'1/ClEZ+2gBIc8u6FIg96xEdiYxUqyXxxKB+RcEEctQM=', 1, N'FNcqQ++a0U48oCM67irQ/Q==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (11, N'Корнев Виктор Павлович', N'kvpwait', N'DKm/KSg+gPjbYDSnZMbyZqED33B4xWbK/mM31eGgGOo=', 1, N'EGpY7BYmqy9YNX2O0uxqyA==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (12, N'Пегушин Григорий Степанович', N'pgswait', N'hvJsqYRq37NBrrbF1yhACfV/Jga7fnKKys9ud2+qG0w=', 1, N'CuwUL4blBxGxvzvMiGSqfQ==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (13, N'Ким Егор Сергеевич', N'keswait', N'rylXeA8S9yugtzM62swAdMC9hzhflP6j5M/q5G9ftT0=', 1, N'6XavJT/UStf9BoG1io3cAA==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (14, N'Бельский Михаил Сергеевич', N'bmswait', N'etnQQHrBD4AoeuZgAl4TZyGYWwdfW6+kFg7VpsDioA8=', 1, N'580slc6j8BBWRnu3M6Z2og==', 0)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift]) VALUES (15, N'Юнусов Петр Степанович', N'ypswait', N'KFEGCCkrrcSZtxCB7lxFZPJtWaEx41JDMHUd8N9w6uA=', 1, N'ddcvzVvVUHbLVemZN6fx8g==', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Shifts] ON 

INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (1, CAST(N'2024-05-18T21:51:46.210' AS DateTime), CAST(N'2024-05-18T22:00:37.320' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (2, CAST(N'2024-05-18T22:01:35.483' AS DateTime), CAST(N'2024-05-18T22:01:37.810' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (3, CAST(N'2024-05-18T22:01:39.703' AS DateTime), CAST(N'2024-05-18T22:28:43.870' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (4, CAST(N'2024-05-18T22:50:55.447' AS DateTime), CAST(N'2024-05-19T19:01:01.587' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (5, CAST(N'2024-05-19T19:01:11.450' AS DateTime), CAST(N'2024-05-24T11:28:52.120' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (6, CAST(N'2024-05-24T11:28:58.630' AS DateTime), CAST(N'2024-05-25T20:14:43.227' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (7, CAST(N'2024-05-25T20:15:05.597' AS DateTime), CAST(N'2024-05-26T20:14:44.227' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (8, CAST(N'2024-05-26T20:14:51.640' AS DateTime), CAST(N'2024-05-27T18:16:34.793' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (9, CAST(N'2024-05-27T18:16:40.577' AS DateTime), CAST(N'2024-05-30T10:21:04.737' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (10, CAST(N'2024-05-30T10:21:09.417' AS DateTime), CAST(N'2024-06-03T18:36:34.863' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (11, CAST(N'2024-06-03T18:36:38.113' AS DateTime), CAST(N'2024-06-05T18:16:18.050' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (12, CAST(N'2024-06-05T18:16:31.330' AS DateTime), CAST(N'2024-06-06T20:26:10.837' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (13, CAST(N'2024-06-06T20:26:14.573' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Shifts] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (1, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 1, NULL, 4, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (2, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 2, CAST(N'2024-05-18T23:51:46.210' AS DateTime), 4, NULL, NULL, NULL, NULL, 2, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (3, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 1, NULL, 10, 0, 0, 0, 0, 3, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (5, CAST(N'2024-05-18T21:51:46.210' AS DateTime), 2, CAST(N'2024-05-30T11:00:00.963' AS DateTime), 10, 0, 0, 0, 500, 3, NULL)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (8, CAST(N'2024-05-30T12:29:51.130' AS DateTime), 4, NULL, 10, 0, 0, 0, 0, 3, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (16, CAST(N'2024-05-30T21:00:34.377' AS DateTime), 3, NULL, 10, 0, 0, 0, 0, 4, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (27, CAST(N'2024-05-30T22:52:13.480' AS DateTime), 2, NULL, 10, 0, 0, 0, 0, 4, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (28, CAST(N'2024-05-30T22:52:21.170' AS DateTime), 10, NULL, 10, 0, 0, 0, 0, 4, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (29, CAST(N'2024-05-30T22:52:24.130' AS DateTime), 5, NULL, 10, 0, 0, 0, 0, 4, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (30, CAST(N'2024-05-30T22:52:28.610' AS DateTime), 11, NULL, 10, 0, 0, 0, 0, 4, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (31, CAST(N'2024-06-06T21:30:22.737' AS DateTime), 6, NULL, 13, 0, 0, 0, 0, 2, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (32, CAST(N'2024-06-07T02:48:48.393' AS DateTime), 7, CAST(N'2024-06-07T03:20:03.703' AS DateTime), 13, 0, 0, 1440, 0, 2, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderMenuItems] ON 

INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (44, 3, 2, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (45, 5, 1, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (50, 8, 3, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (61, 8, 1, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (66, 8, 1, 3)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (86, 8, 3, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (87, 8, 1, 2)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (88, 8, 1, 3)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (89, 8, 1, 4)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (90, 8, 1, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (91, 8, 1, 7)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (92, 8, 1, 10)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (93, 8, 1, 9)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (94, 8, 2, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (95, 8, 1, 2)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (96, 8, 2, 3)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (97, 8, 1, 4)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (99, 8, 3, 8)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (124, 8, 1, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (125, 8, 1, 1)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (126, 8, 1, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (127, 16, 1, 8)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (128, 31, 3, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (129, 32, 1, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (130, 32, 1, 9)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (131, 32, 1, 3)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (132, 32, 3, 4)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (133, 31, 1, 7)
SET IDENTITY_INSERT [dbo].[OrderMenuItems] OFF
GO

```

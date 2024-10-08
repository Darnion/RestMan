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

INSERT [dbo].[Halls] ([Id], [Title], [Acronym], [DisplayColor]) VALUES (1, N'Веранда', N'В', -15426304)
INSERT [dbo].[Halls] ([Id], [Title], [Acronym], [DisplayColor]) VALUES (2, N'Детский', N'Д', -32704)
INSERT [dbo].[Halls] ([Id], [Title], [Acronym], [DisplayColor]) VALUES (3, N'Основной', N'О', -16776961)
INSERT [dbo].[Halls] ([Id], [Title], [Acronym], [DisplayColor]) VALUES (4, N'Банкетный', N'Б', -65536)
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

INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (1, N'Конев Ефим Викторович', N'admin', N'dJ59JsjBOAGT6Zmo5hoEOOZcCIPsnLpGv5nfN4IY610=', 4, N'BMuJNR1X9/J4j48SuPUiWw==', 1, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (2, N'Кисель Александр Игоревич', N'waiter', N'PjIp9feBIQFrEvzBtPQLg8GijWxVgYGvdNZwBimcT6o=', 1, N'yswSxsYVX0FMkXzB8w6Gxw==', 1, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (3, N'Николаев Вячеслав Алексеевич', N'cashier', N'2jfjFsvXvrsfCXfYiC/pjYfzNY6CUiEvmbgl/+Q3aL4=', 2, N'jlPBGPcw31Sfht04M8LNyA==', 0, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (4, N'Прохоренко Владимир Сергеевич', N'manager', N'yAbtRl2WD09AyRNEtDXd8daXfRMq1toJ0LZfMCO96WE=', 3, N'WsBvKzImYBRZ1jdnnk0fyg==', 1, -8355648)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (5, N'Кочетков Денис Александрович', N'kdacash', N'TMTbWZXR2gXw6bbo/ghc8hRpJRjc8YV4jFcS5MMTxis=', 2, N'Ul0BmrCbBmy4CNakiFiEpA==', 1, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (6, N'Никифорова Юлия Сергеевна', N'nysman', N'LAiY+TaL2vLl/P8qkpVVA7uo1b+3mJGXSW+6XbWS+co=', 3, N'tRdPNK78FPDBNqjVZN3R1Q==', 1, -8388544)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (7, N'Иванов Антон Петрович', N'iapman', N'EO8YyWr4+i/TcVJo/mP8qITzHkHp3xarHFIZ5aDFjHY=', 3, N'YBEEnOTWSlLBIPLpl4tXLQ==', 0, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (8, N'Баринов Виктор Петрович', N'bvpman', N'mOYCZQeaN573m4zKV6/NA6ua0kKNH8nuijhGzdIqpZo=', 3, N'i+XUjxTs8r+1I8PW3+23kQ==', 1, -16760832)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (9, N'Коршикова Эльвина Павловна', N'kepwait', N'QbFCYbGvsSchzvVXsG2nOJ3Njbs6qIARcS06igW96LA=', 1, N'oE95MKm5DRA1u6LtyQHaPg==', 0, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (10, N'Меньшиков Данила Александрович', N'mdawait', N'1/ClEZ+2gBIc8u6FIg96xEdiYxUqyXxxKB+RcEEctQM=', 1, N'FNcqQ++a0U48oCM67irQ/Q==', 0, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (11, N'Корнев Виктор Павлович', N'kvpwait', N'DKm/KSg+gPjbYDSnZMbyZqED33B4xWbK/mM31eGgGOo=', 1, N'EGpY7BYmqy9YNX2O0uxqyA==', 0, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (12, N'Пегушин Григорий Степанович', N'pgswait', N'hvJsqYRq37NBrrbF1yhACfV/Jga7fnKKys9ud2+qG0w=', 1, N'CuwUL4blBxGxvzvMiGSqfQ==', 1, NULL)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (13, N'Ким Егор Сергеевич', N'keswait', N'rylXeA8S9yugtzM62swAdMC9hzhflP6j5M/q5G9ftT0=', 1, N'6XavJT/UStf9BoG1io3cAA==', 1, -16744193)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (14, N'Бельский Михаил Сергеевич', N'bmswait', N'etnQQHrBD4AoeuZgAl4TZyGYWwdfW6+kFg7VpsDioA8=', 1, N'580slc6j8BBWRnu3M6Z2og==', 1, -16777088)
INSERT [dbo].[Users] ([Id], [Fullname], [Login], [Password], [RoleId], [Salt], [IsOnShift], [DisplayColor]) VALUES (15, N'Юнусов Петр Степанович', N'ypswait', N'KFEGCCkrrcSZtxCB7lxFZPJtWaEx41JDMHUd8N9w6uA=', 1, N'ddcvzVvVUHbLVemZN6fx8g==', 0, NULL)
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
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (13, CAST(N'2024-06-06T20:26:14.573' AS DateTime), CAST(N'2024-06-07T16:46:08.917' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (14, CAST(N'2024-06-07T16:46:12.853' AS DateTime), CAST(N'2024-06-08T14:14:53.700' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (15, CAST(N'2024-06-08T14:14:57.200' AS DateTime), CAST(N'2024-06-09T17:32:05.380' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (16, CAST(N'2024-06-09T17:32:10.660' AS DateTime), CAST(N'2024-06-12T21:50:08.750' AS DateTime))
INSERT [dbo].[Shifts] ([Id], [OpenedAt], [ClosedAt]) VALUES (17, CAST(N'2024-06-12T21:50:23.760' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Shifts] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (49, CAST(N'2024-06-12T21:59:22.517' AS DateTime), 1, CAST(N'2024-06-12T22:04:37.270' AS DateTime), 17, 0, 340, 300, 0, 8, 60)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (50, CAST(N'2024-06-12T21:59:38.573' AS DateTime), 2, CAST(N'2024-06-12T22:04:42.377' AS DateTime), 17, 0, 0, 1640, 0, 8, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (51, CAST(N'2024-06-12T21:59:46.583' AS DateTime), 3, NULL, 17, 0, 0, 0, 0, 8, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (52, CAST(N'2024-06-12T21:59:57.867' AS DateTime), 4, NULL, 17, 0, 0, 0, 0, 2, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (53, CAST(N'2024-06-12T22:00:04.883' AS DateTime), 5, CAST(N'2024-06-12T22:04:49.030' AS DateTime), 17, 0, 2530, 0, 0, 5, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (54, CAST(N'2024-06-12T22:00:19.343' AS DateTime), 6, NULL, 17, 0, 0, 0, 0, 12, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (55, CAST(N'2024-06-12T22:00:24.697' AS DateTime), 7, CAST(N'2024-06-12T22:05:20.233' AS DateTime), 17, 0, 930, 0, 0, 14, 1070)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (56, CAST(N'2024-06-12T22:00:31.987' AS DateTime), 10, NULL, 17, 0, 0, 0, 0, 13, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (57, CAST(N'2024-06-12T22:00:59.547' AS DateTime), 8, NULL, 17, 0, 0, 0, 0, 12, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (58, CAST(N'2024-06-12T22:01:09.523' AS DateTime), 9, CAST(N'2024-06-12T22:05:08.890' AS DateTime), 17, 0, 0, 0, 1960, 13, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (59, CAST(N'2024-06-12T22:01:17.290' AS DateTime), 12, NULL, 17, 0, 0, 0, 0, 6, 0)
INSERT [dbo].[Orders] ([Id], [CreatedAt], [TableId], [DeletedAt], [ShiftId], [PaidByGiftCard], [PaidByCash], [PaidByCredit], [PaidByQR], [WaiterId], [ChangeGiven]) VALUES (60, CAST(N'2024-06-12T22:01:25.587' AS DateTime), 11, NULL, 17, 0, 0, 0, 0, 12, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderMenuItems] ON 

INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (159, 49, 1, 33)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (160, 49, 1, 31)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (161, 49, 1, 28)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (162, 49, 1, 24)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (163, 50, 1, 64)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (164, 50, 1, 22)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (165, 50, 2, 21)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (166, 51, 1, 63)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (167, 51, 1, 60)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (168, 51, 1, 67)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (169, 51, 2, 23)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (170, 52, 1, 59)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (171, 52, 1, 51)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (172, 52, 2, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (173, 53, 1, 51)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (174, 53, 1, 64)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (175, 53, 3, 22)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (176, 54, 1, 33)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (177, 54, 1, 24)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (178, 54, 1, 31)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (179, 55, 1, 63)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (180, 55, 1, 65)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (181, 55, 1, 67)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (182, 56, 1, 51)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (183, 56, 1, 59)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (184, 56, 1, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (185, 56, 1, 49)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (186, 56, 1, 50)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (187, 56, 2, 29)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (188, 56, 2, 30)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (189, 56, 1, 54)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (190, 56, 1, 58)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (191, 56, 1, 57)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (192, 56, 1, 56)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (193, 57, 2, 31)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (194, 57, 1, 33)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (195, 57, 2, 28)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (196, 57, 1, 24)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (197, 57, 1, 32)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (198, 58, 2, 33)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (199, 58, 1, 31)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (200, 58, 1, 24)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (201, 58, 1, 64)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (202, 58, 1, 22)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (203, 58, 1, 21)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (204, 59, 4, 29)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (205, 59, 1, 30)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (206, 59, 1, 53)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (207, 59, 1, 57)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (208, 59, 1, 52)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (209, 59, 1, 55)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (210, 59, 1, 25)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (211, 59, 1, 56)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (212, 60, 1, 6)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (213, 60, 1, 59)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (214, 60, 1, 51)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (215, 60, 1, 29)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (216, 60, 1, 30)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (217, 60, 1, 26)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (218, 60, 1, 7)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (219, 60, 1, 71)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (220, 60, 1, 70)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (221, 60, 1, 69)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (222, 60, 1, 53)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (223, 60, 1, 57)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (224, 60, 1, 55)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (225, 60, 1, 25)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (226, 60, 1, 58)
INSERT [dbo].[OrderMenuItems] ([Id], [OrderId], [Count], [MenuItemId]) VALUES (227, 60, 1, 27)
SET IDENTITY_INSERT [dbo].[OrderMenuItems] OFF
GO
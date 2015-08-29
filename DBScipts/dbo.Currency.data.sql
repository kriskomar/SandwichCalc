SET IDENTITY_INSERT [dbo].[Currency] ON
INSERT INTO [dbo].[Currency] ([Id], [CurrencyName], [CurrencyModifier]) VALUES (1, N'Dollars', CAST(0.100 AS Decimal(18, 3)))
INSERT INTO [dbo].[Currency] ([Id], [CurrencyName], [CurrencyModifier]) VALUES (2, N'Light Years', CAST(0.900 AS Decimal(18, 3)))
INSERT INTO [dbo].[Currency] ([Id], [CurrencyName], [CurrencyModifier]) VALUES (3, N'Euros', CAST(0.054 AS Decimal(18, 3)))
SET IDENTITY_INSERT [dbo].[Currency] OFF

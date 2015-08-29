CREATE TABLE [dbo].[Currency] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [CurrencyName]     NVARCHAR (255) NOT NULL,
    [CurrencyModifier] DECIMAL (18, 3)   DEFAULT ((1.0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


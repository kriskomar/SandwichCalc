CREATE TABLE [dbo].[Sandwiches] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [SandwichName]     NVARCHAR (255) NOT NULL,
    [SandwichModifier] DECIMAL (18, 3)   DEFAULT ((1.0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


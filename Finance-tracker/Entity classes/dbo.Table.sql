CREATE TABLE [dbo].[BudgetEntries] (
    [Id] [int] NOT NULL IDENTITY,
    [Category] [nvarchar](max),
    [Name] [nvarchar](max),
    [Amount] [int] NOT NULL,
    CONSTRAINT [PK_dbo.BudgetEntries] PRIMARY KEY ([Id])
)

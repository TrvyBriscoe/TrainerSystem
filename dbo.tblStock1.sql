CREATE TABLE [dbo].[tblStock] (
    [ProductID]   INT          IDENTITY (1, 4) NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Release]  DATETIME     NULL,
    [Quantity] INT          NULL,
    [Price]    MONEY        NULL,
    [Size]     DECIMAL (18) NULL,
    CONSTRAINT [PK tblStock] PRIMARY KEY CLUSTERED ([ShoeID] ASC)
);


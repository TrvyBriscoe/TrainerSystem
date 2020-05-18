CREATE TABLE [dbo].[tblStock] (
    [ShoeID]   INT          IDENTITY (1, 4) NOT NULL,
    [Name]     VARCHAR (50) NULL,
    [Release]  DATETIME     NULL,
    [Quantity] INT          NULL,
    [Price]    INT        NULL,
    [Size]     INT NULL,
    CONSTRAINT [PK tblStock] PRIMARY KEY CLUSTERED ([ShoeID] ASC)
);


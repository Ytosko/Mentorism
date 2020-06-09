CREATE TABLE [dbo].[recent_ch] (
    [Id]   INT IDENTITY (1, 1) NOT NULL DEFAULT 1,
    [Port] VARCHAR(MAX) NULL, 
    CONSTRAINT [PK_recent_ch] PRIMARY KEY ([Id]) 
);


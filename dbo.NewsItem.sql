CREATE TABLE [dbo].[NewsItem]
(
	[NewsItemID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] VARCHAR(1000) NOT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [Link] VARCHAR(1000) NULL, 
    [DateAcquired] SMALLDATETIME NOT NULL, 
    [ChannelID] INT NOT NULL
)

CREATE TABLE [dbo].[TrackedAnime]
(
	[TrackedAnimeId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserKey] INT NOT NULL, 
    [AnimeKey] INT NOT NULL, 
    [WatchStatusKey] INT NOT NULL, 
    [StartedWatching] DATETIME NULL, 
    [StoppedWatching] DATETIME NULL, 
    [LastWatched] DATETIME NULL, 
    [EpisodesWatched] INT NOT NULL DEFAULT 0, 
    [LastModified] DATETIMEOFFSET NOT NULL DEFAULT GETDATE(), 
    [IsDeleted] BIT NOT NULL DEFAULT 0, 
    [Progress] DECIMAL NOT NULL DEFAULT 0, 
    [TimeWatchedMins] INT NOT NULL DEFAULT 0
    CONSTRAINT [FK_TrackedAnime_User] FOREIGN KEY ([UserKey]) REFERENCES [User]([UserId]),
    CONSTRAINT [FK_TrackedAnime_Anime] FOREIGN KEY ([AnimeKey]) REFERENCES [Anime]([AnimeId]),
    CONSTRAINT [FK_TrackedAnime_WatchStatus] FOREIGN KEY ([WatchStatusKey]) REFERENCES [WatchStatus]([WatchStatusId]),
)

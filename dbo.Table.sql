CREATE TABLE [dbo].[oglas] (
    [OglasID]      INT    IDENTITY (1, 1) NOT NULL,
    [start]   NVARCHAR (50)  NULL,
    [cilj]    NVARCHAR (50)  NULL,
    [cas]	  TIME			 NULL,
    [strosek] INT			NULL,
    [opis]    NVARCHAR (200) NULL,
    [st_oseb] INT         NULL,
    PRIMARY KEY CLUSTERED ([OglasID] ASC), 
);


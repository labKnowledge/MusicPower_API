CREATE TABLE Artist (
    ArtistId   VARCHAR (250)  UNIQUE NOT NULL,
    ArtistName  VARCHAR (250)  NOT NULL,
    ArtistGenre NVARCHAR (250) NOT NULL,
    ArtistBio   VARCHAR (250)  NOT NULL
);
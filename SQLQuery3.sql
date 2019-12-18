CREATE TABLE Artist (
    ArtistId   VARCHAR (MAX)  UNIQUE NOT NULL,
    ArtistName  VARCHAR (MAX)  NOT NULL,
    ArtistGenre NVARCHAR (MAX) NOT NULL,
    ArtistBio   VARCHAR (MAX)  NOT NULL
);
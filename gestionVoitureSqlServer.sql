CREATE TABLE [dbo].[Conducteur] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [nom]         VARCHAR (20)  NOT NULL,
    [prenom]      VARCHAR (20)  NOT NULL,
    [motDePasse]  VARCHAR (MAX) NOT NULL,
    [mail]        VARCHAR (100) NOT NULL,
    [bonusMalus]  DECIMAL (18)  NULL,
    [identifiant] VARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([identifiant] ASC)
);

CREATE TABLE [dbo].[Assureur] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [nom]        VARCHAR (30)  NOT NULL,
    [adresse]    VARCHAR (100) NOT NULL,
    [codePostal] NCHAR (5)     NOT NULL,
    [ville]      VARCHAR (50)  NOT NULL,
    [telephone]  NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Carburant] (
    [nom] VARCHAR (15) NOT NULL,
    PRIMARY KEY CLUSTERED ([nom] ASC)
);

CREATE TABLE [dbo].[ContratAssurance] (
    [id]         INT          IDENTITY (1, 1) NOT NULL,
    [categorie]  VARCHAR (20) NOT NULL,
    [nom]        VARCHAR (20) NOT NULL,
    [prix]       DECIMAL (18) NOT NULL,
    [voiture]    NCHAR (10)   NOT NULL,
    [conducteur] INT          NOT NULL,
    [assureur]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_ContratAssurance_Voiture] FOREIGN KEY ([voiture]) REFERENCES [dbo].[Voiture] ([immatriculation]),
    CONSTRAINT [FK_ContratAssurance_Conducteur] FOREIGN KEY ([conducteur]) REFERENCES [dbo].[Conducteur] ([Id]),
    CONSTRAINT [FK_ContratAssurance_Assureur] FOREIGN KEY ([assureur]) REFERENCES [dbo].[Assureur] ([id])
);

CREATE TABLE [dbo].[EntretienAFaire] (
    [id]        INT IDENTITY (1, 1) NOT NULL,
    [entretien] INT NOT NULL,
    [modele]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EntretienAFaire_EntretienRegulier] FOREIGN KEY ([entretien]) REFERENCES [dbo].[EntretienRegulier] ([id]),
    CONSTRAINT [FK_EntretienAFaire_Modele] FOREIGN KEY ([modele]) REFERENCES [dbo].[Modele] ([id])
);

CREATE TABLE [dbo].[EntretienFait] (
    [id]                INT        IDENTITY (1, 1) NOT NULL,
    [date]              DATE       NOT NULL,
    [kilometrage]       INT        NOT NULL,
    [commentaire]       TEXT       NULL,
    [voiture]           NCHAR (10) NOT NULL,
    [entretienRegulier] INT        NULL,
    [entretienPonctuel] INT        NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_EntretienFait_Voiture] FOREIGN KEY ([voiture]) REFERENCES [dbo].[Voiture] ([immatriculation]),
    CONSTRAINT [FK_EntretienFait_EntretienPonctuel] FOREIGN KEY ([entretienPonctuel]) REFERENCES [dbo].[EntretienPonctuel] ([id]),
    CONSTRAINT [FK_EntretienFait_EntretienRegulier] FOREIGN KEY ([entretienRegulier]) REFERENCES [dbo].[EntretienRegulier] ([id])
);

CREATE TABLE [dbo].[EntretienPonctuel] (
    [id]            INT          IDENTITY (1, 1) NOT NULL,
    [nom]           VARCHAR (50) NOT NULL,
    [prix]          DECIMAL (18) NOT NULL,
    [pieceConcerne] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[EntretienRegulier] (
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [nom]         VARCHAR (50) NOT NULL,
    [prix]        DECIMAL (18) NOT NULL,
    [kilometrage] INT          NOT NULL,
    [nombreMois]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Garage] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [nom]        NCHAR (10)    NOT NULL,
    [adresse]    VARCHAR (100) NOT NULL,
    [codePostal] NCHAR (5)     NOT NULL,
    [ville]      VARCHAR (30)  NOT NULL,
    [telephone]  NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);


CREATE TABLE [dbo].[Marque] (
    [nom] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([nom] ASC)
);

CREATE TABLE [dbo].[Modele] (
    [id]     INT          IDENTITY (1, 1) NOT NULL,
    [nom]    VARCHAR (50) NOT NULL,
    [marque] VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Modele_Marque] FOREIGN KEY ([marque]) REFERENCES [dbo].[Marque] ([nom])
);

CREATE TABLE [dbo].[PleinCarburant] (
    [id]             INT          IDENTITY (1, 1) NOT NULL,
    [date]           DATE         NOT NULL,
    [kilometrage]    INT          NOT NULL,
    [nbLitre]        DECIMAL (18) NOT NULL,
    [prixLitre]      DECIMAL (18) NOT NULL,
    [voiture]        NCHAR (10)   NOT NULL,
    [carburant]      VARCHAR (15) NOT NULL,
    [stationEssence] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_PleinCarburant_StationEssence] FOREIGN KEY ([stationEssence]) REFERENCES [dbo].[StationEssence] ([id]),
    CONSTRAINT [FK_PleinCarburant_Voiture] FOREIGN KEY ([voiture]) REFERENCES [dbo].[Voiture] ([immatriculation]),
    CONSTRAINT [FK_PleinCarburant_Carburant] FOREIGN KEY ([carburant]) REFERENCES [dbo].[Carburant] ([nom])
);
CREATE TABLE [dbo].[StationEssence] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [nom]        VARCHAR (20)  NOT NULL,
    [adresse]    VARCHAR (200) NOT NULL,
    [codePostal] VARCHAR (5)   NOT NULL,
    [ville]      VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[Voiture] (
    [immatriculation]       NCHAR (10)   NOT NULL,
    [dateAchat]             DATE         NOT NULL,
    [dateMiseEnCirculation] DATE         NOT NULL,
    [dateVente]             DATE         NULL,
    [kilometrage]           INT          NOT NULL,
    [volumeReservoir]       INT          NOT NULL,
    [carburant]             VARCHAR (15) NOT NULL,
    [modele]                INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([immatriculation] ASC),
    CONSTRAINT [FK_Voiture_Carburant] FOREIGN KEY ([carburant]) REFERENCES [dbo].[Carburant] ([nom]),
    CONSTRAINT [FK_Voiture_Modele] FOREIGN KEY ([modele]) REFERENCES [dbo].[Modele] ([id])
);


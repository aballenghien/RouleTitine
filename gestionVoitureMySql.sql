CREATE TABLE Conducteur (
    id            INT           AUTO_INCREMENT NOT NULL,
    nom       	  VARCHAR (20)  NOT NULL,
    prenom        VARCHAR (20)  NOT NULL,
    motDePasse    VARCHAR (300) NOT NULL,
    mail          VARCHAR (100) NOT NULL,
    bonusMalus    DECIMAL (3,2)  NULL,
    identifiant   VARCHAR (10)  NOT NULL,
    PRIMARY KEY (id),
    UNIQUE  (identifiant)
);

CREATE TABLE Assureur (
    id         INT           AUTO_INCREMENT NOT NULL,
    nom        VARCHAR (30)  NOT NULL,
    adresse    VARCHAR (100) NOT NULL,
    codePostal NCHAR (5)     NOT NULL,
    ville      VARCHAR (50)  NOT NULL,
    telephone  NCHAR (10)    NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE Carburant (
    nom VARCHAR (15) NOT NULL,
    PRIMARY KEY (nom)
);

CREATE TABLE StationEssence (
    id         INT           AUTO_INCREMENT NOT NULL,
    nom        VARCHAR (20)  NOT NULL,
    adresse    VARCHAR (200) NOT NULL,
    codePostal VARCHAR (5)   NOT NULL,
    ville      VARCHAR (20)  NOT NULL,
    PRIMARY KEY  (id )
);

CREATE TABLE Garage (
    id         INT           AUTO_INCREMENT NOT NULL,
    nom        NCHAR (10)    NOT NULL,
    adresse    VARCHAR (100) NOT NULL,
    codePostal NCHAR (5)     NOT NULL,
    ville      VARCHAR (30)  NOT NULL,
    telephone  NCHAR (10)    NOT NULL,
    PRIMARY KEY  (id )
);

CREATE TABLE Marque (
    nom VARCHAR (30) NOT NULL,
    PRIMARY KEY  (nom )
);

CREATE TABLE Modele (
    id     INT          AUTO_INCREMENT NOT NULL,
    nom    VARCHAR (50) NOT NULL,
    marque VARCHAR (30) NOT NULL,
    PRIMARY KEY  (id ),
    CONSTRAINT FK_Modele_Marque FOREIGN KEY (marque) REFERENCES Marque (nom)
);

CREATE TABLE Voiture (
    immatriculation       NCHAR (10)   NOT NULL,
    dateAchat             DATE         NOT NULL,
    dateMiseEnCirculation DATE         NOT NULL,
    dateVente             DATE         NULL,
    kilometrage           INT          NOT NULL,
    volumeReservoir       INT          NOT NULL,
    carburant             VARCHAR (15) NOT NULL,
    modele                INT          NOT NULL,
    PRIMARY KEY  (immatriculation ),
    CONSTRAINT FK_Voiture_Carburant FOREIGN KEY (carburant) REFERENCES Carburant (nom),
    CONSTRAINT FK_Voiture_Modele FOREIGN KEY (modele) REFERENCES Modele (id)
);

CREATE TABLE EntretienPonctuel (
    id            INT          AUTO_INCREMENT NOT NULL,
    nom           VARCHAR (50) NOT NULL,
    prix          DECIMAL (18) NOT NULL,
    pieceConcerne VARCHAR (50) NOT NULL,
    PRIMARY KEY  (id )
);

CREATE TABLE EntretienRegulier (
    id          INT          AUTO_INCREMENT NOT NULL,
    nom         VARCHAR (50) NOT NULL,
    prix        DECIMAL (7,2) NOT NULL,
    kilometrage INT          NOT NULL,
    nombreMois  INT          NOT NULL,
    PRIMARY KEY  (id )
);

CREATE TABLE ContratAssurance (
    id         INT          AUTO_INCREMENT NOT NULL,
    categorie  VARCHAR (20) NOT NULL,
    nom        VARCHAR (20) NOT NULL,
    prix       DECIMAL (7,2) NOT NULL,
    voiture    NCHAR (10)   NOT NULL,
    conducteur INT          NOT NULL,
    assureur   INT          NOT NULL,
    PRIMARY KEY  (id ),
    CONSTRAINT FK_ContratAssurance_Voiture FOREIGN KEY (voiture) REFERENCES Voiture (immatriculation),
    CONSTRAINT FK_ContratAssurance_Conducteur FOREIGN KEY (conducteur) REFERENCES Conducteur (id),
    CONSTRAINT FK_ContratAssurance_Assureur FOREIGN KEY (assureur) REFERENCES Assureur (id)
);

CREATE TABLE EntretienAFaire (
    id        INT AUTO_INCREMENT NOT NULL,
    entretien INT NOT NULL,
    modele    INT NOT NULL,
    PRIMARY KEY (id),
    CONSTRAINT FK_EntretienAFaire_EntretienRegulier FOREIGN KEY (entretien) REFERENCES EntretienRegulier (id),
    CONSTRAINT FK_EntretienAFaire_Modele FOREIGN KEY (modele) REFERENCES Modele (id)
);

CREATE TABLE EntretienFait (
    id                INT        AUTO_INCREMENT NOT NULL,
    date              DATE       NOT NULL,
    kilometrage       INT        NOT NULL,
    commentaire       TEXT       NULL,
    voiture           NCHAR (10) NOT NULL,
    entretienRegulier INT        NULL,
    entretienPonctuel INT        NULL,
    PRIMARY KEY  (id ),
    CONSTRAINT FK_EntretienFait_Voiture FOREIGN KEY (voiture) REFERENCES Voiture (immatriculation),
    CONSTRAINT FK_EntretienFait_EntretienPonctuel FOREIGN KEY (entretienPonctuel) REFERENCES EntretienPonctuel (id),
    CONSTRAINT FK_EntretienFait_EntretienRegulier FOREIGN KEY (entretienRegulier) REFERENCES EntretienRegulier (id)
);

CREATE TABLE PleinCarburant (
    id             INT          AUTO_INCREMENT NOT NULL,
    date           DATE         NOT NULL,
    kilometrage    INT          NOT NULL,
    nbLitre        DECIMAL (3,2) NOT NULL,
    prixLitre      DECIMAL (2,2) NOT NULL,
    voiture        NCHAR (10)   NOT NULL,
    carburant      VARCHAR (15) NOT NULL,
    stationEssence INT          NOT NULL,
    PRIMARY KEY  (id ),
    CONSTRAINT FK_PleinCarburant_StationEssence FOREIGN KEY (stationEssence) REFERENCES StationEssence (id),
    CONSTRAINT FK_PleinCarburant_Voiture FOREIGN KEY (voiture) REFERENCES Voiture (immatriculation),
    CONSTRAINT FK_PleinCarburant_Carburant FOREIGN KEY (carburant) REFERENCES Carburant (nom)
);





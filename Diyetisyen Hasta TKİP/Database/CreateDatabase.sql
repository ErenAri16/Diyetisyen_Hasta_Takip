CREATE DATABASE DiyetisyenDB;
GO

USE DiyetisyenDB;
GO

CREATE TABLE Kullanicilar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    KullaniciAdi NVARCHAR(50) NOT NULL UNIQUE,
    Sifre NVARCHAR(256) NOT NULL,
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    Telefon NVARCHAR(20),
    Rol NVARCHAR(20) NOT NULL DEFAULT 'Kullanici',
    KayitTarihi DATETIME NOT NULL DEFAULT GETDATE(),
    Aktif BIT NOT NULL DEFAULT 1
);
GO

INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Ad, Soyad, Email, Rol)
VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Admin', 'User', 'admin@example.com', 'Admin');
GO

CREATE TABLE Hastalar (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NOT NULL,
    Telefon NVARCHAR(20),
    Email NVARCHAR(100),
    Cinsiyet NVARCHAR(10),
    Boy FLOAT NOT NULL,
    Kilo FLOAT NOT NULL,
    HedefKilo FLOAT,
    KayitTarihi DATETIME NOT NULL,
    Notlar NVARCHAR(MAX)
);
GO

CREATE TABLE DiyetProgramlari (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HastaId INT NOT NULL,
    BaslangicTarihi DATE NOT NULL,
    BitisTarihi DATE,
    HedefKilo FLOAT,
    Notlar NVARCHAR(MAX),
    FOREIGN KEY (HastaId) REFERENCES Hastalar(Id)
);
GO

CREATE TABLE Ogunler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DiyetProgramiId INT NOT NULL,
    OgunAdi NVARCHAR(50) NOT NULL,
    Kalori INT,
    Notlar NVARCHAR(MAX),
    FOREIGN KEY (DiyetProgramiId) REFERENCES DiyetProgramlari(Id)
);
GO

CREATE TABLE Besinler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Ad NVARCHAR(100) NOT NULL,
    Kalori INT NOT NULL,
    Protein FLOAT,
    Karbonhidrat FLOAT,
    Yag FLOAT,
    Birim NVARCHAR(20) NOT NULL
);
GO

CREATE TABLE OgunBesinler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OgunId INT NOT NULL,
    BesinId INT NOT NULL,
    Miktar FLOAT NOT NULL,
    FOREIGN KEY (OgunId) REFERENCES Ogunler(Id),
    FOREIGN KEY (BesinId) REFERENCES Besinler(Id)
);
GO

CREATE TABLE Olcumler (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    HastaId INT NOT NULL,
    OlcumTarihi DATETIME NOT NULL,
    Kilo FLOAT NOT NULL,
    Boy FLOAT,
    VucutYagOrani FLOAT,
    KasOrani FLOAT,
    Notlar NVARCHAR(MAX),
    FOREIGN KEY (HastaId) REFERENCES Hastalar(Id)
);
GO 
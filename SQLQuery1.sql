CREATE TABLE Kullanici (
    KullaniciKodu nvarchar(50) PRIMARY KEY,
    Sifre nvarchar(50) NOT NULL,
    Yetki nvarchar(50) -- İleride admin/kullanıcı ayrımı yapmak isterseniz diye ekledim.
);

CREATE TABLE Doktorlar (
    DoktorID int IDENTITY(1,1) PRIMARY KEY,
    AdSoyad nvarchar(50),
    TCNo nvarchar(11),
    Telefon nvarchar(20),
    PoliklinikAdi nvarchar(50)
);

CREATE TABLE Poliklinikler (
    PoliklinikID int IDENTITY(1,1) PRIMARY KEY,
    PoliklinikAdi nvarchar(50),
    UzmanlikAlani nvarchar(MAX),
    Durum bit -- C# tarafındaki Checkbox (True/False) değeri buraya kaydedilir.
); 

-- Sisteme ilk girişi yapabilmeniz için örnek bir kayıt:
INSERT INTO Kullanici (KullaniciKodu, Sifre, Yetki) VALUES ('Seyit', '1234', 'Yönetici');
INSERT INTO Doktorlar (DoktorID , AdSoyad , TCNo , Telefon, PoliklinikAdi) VALUES ('77','mahmut','99','05319','Göz');
INSERT INTO Poliklinikler (PoliklinikID , PoliklinikAdi , UzmanlikAlani , Durum) VALUES ('01','Göz','p',True)
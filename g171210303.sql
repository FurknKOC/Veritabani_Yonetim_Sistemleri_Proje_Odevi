USE [eTicaret]
GO
/****** Object:  UserDefinedFunction [dbo].[tukenmekteOlanKitaplar]    Script Date: 17.12.2019 12:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tukenmekteOlanKitaplar](@ilk int,@son int)
returns @values table
(
kitapAdi nvarchar(50),
stok int
)
as
begin
insert @values
select u.kitapAdi,m.stok from Urunler u INNER JOIN Macera m ON u.urunID=m.urunID where stok>@ilk and stok<@son
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[tukenmekteOlanKitaplarRoman]    Script Date: 17.12.2019 12:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tukenmekteOlanKitaplarRoman](@ilk int,@son int)
returns @values table
(
kitapAdi nvarchar(50),
stok int
)
as
begin
insert @values
select u.kitapAdi,r.stok from Urunler u INNER JOIN Roman r ON u.urunID=r.urunID where stok>@ilk and stok<@son
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[tukenmekteOlanKitaplarTarih]    Script Date: 17.12.2019 12:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tukenmekteOlanKitaplarTarih](@ilk int,@son int)
returns @values table
(
kitapAdi nvarchar(50),
stok int
)
as
begin
insert @values
select u.kitapAdi,t.stok from Urunler u INNER JOIN Tarih t ON u.urunID=t.urunID where stok>@ilk and stok<@son
return
end
GO
/****** Object:  UserDefinedFunction [dbo].[uye_kitap_sayisi]    Script Date: 17.12.2019 12:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[uye_kitap_sayisi](@kisiID int)
returns int
as
Begin
return (select count(*) from Siparisler where @kisiID=kisiID)
End
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17.12.2019 12:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[kisiID] [int] NOT NULL,
	[rol] [nvarchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Il]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Il](
	[ilNo] [int] NOT NULL,
	[ilAdi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Il] PRIMARY KEY CLUSTERED 
(
	[ilNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilce]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilce](
	[IlceNo] [int] IDENTITY(1,1) NOT NULL,
	[ilceAdi] [nvarchar](50) NULL,
	[ilNo] [int] NULL,
 CONSTRAINT [PK_Ilce] PRIMARY KEY CLUSTERED 
(
	[IlceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iletisim]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iletisim](
	[iletisimNo] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NOT NULL,
	[ilceNo] [int] NOT NULL,
	[adres] [nvarchar](max) NULL,
	[tel] [nvarchar](20) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Iletisim] PRIMARY KEY CLUSTERED 
(
	[iletisimNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KargoFirmasi]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KargoFirmasi](
	[kargoNo] [int] IDENTITY(1,1) NOT NULL,
	[kargoAdi] [nvarchar](50) NULL,
	[kargoFiyati] [float] NULL,
 CONSTRAINT [PK_KargoFirmasi] PRIMARY KEY CLUSTERED 
(
	[kargoNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kisi]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisi](
	[kisiID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NULL,
	[silindimi] [bit] NULL,
 CONSTRAINT [PK_Kisi] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Macera]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Macera](
	[urunID] [int] NOT NULL,
	[fiyat] [float] NULL,
	[stok] [int] NULL,
	[basimEvi] [nvarchar](50) NULL,
	[kitapOzeti] [nvarchar](max) NULL,
	[resim] [nvarchar](max) NULL,
 CONSTRAINT [PK_Anakartlar] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roman]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roman](
	[urunID] [int] NOT NULL,
	[fiyat] [float] NULL,
	[stok] [int] NULL,
	[basimEvi] [nvarchar](50) NULL,
	[kitapOzeti] [nvarchar](max) NULL,
	[resim] [nvarchar](max) NULL,
 CONSTRAINT [PK_EkranKartlari] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[silinenKisi]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[silinenKisi](
	[silinmeNo] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NULL,
	[silinmeNedeni] [nvarchar](max) NULL,
 CONSTRAINT [PK_silinenKisi] PRIMARY KEY CLUSTERED 
(
	[silinmeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[siparisID] [int] IDENTITY(1,1) NOT NULL,
	[kisiID] [int] NOT NULL,
	[kargoNo] [int] NOT NULL,
	[fiyat] [int] NULL,
	[urunID] [int] NULL,
 CONSTRAINT [PK_Siparisler] PRIMARY KEY CLUSTERED 
(
	[siparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarih]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarih](
	[urunID] [int] NOT NULL,
	[fiyat] [float] NULL,
	[stok] [int] NULL,
	[basimEvi] [nvarchar](50) NULL,
	[kitapOzeti] [nvarchar](max) NULL,
	[resim] [nvarchar](max) NULL,
 CONSTRAINT [PK_Islemciler] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[urunID] [int] IDENTITY(1,1) NOT NULL,
	[kitapAdi] [nvarchar](100) NULL,
	[kitapTuru] [nvarchar](50) NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[urunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunSiparis]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunSiparis](
	[urunSiparisNo] [int] IDENTITY(1,1) NOT NULL,
	[siparisID] [int] NULL,
	[urunID] [int] NULL,
	[birimFiyati] [float] NULL,
 CONSTRAINT [PK_UrunSiparis] PRIMARY KEY CLUSTERED 
(
	[urunSiparisNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 17.12.2019 12:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[kisiID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[cinsiyet] [nvarchar](10) NULL,
	[dogumTarihi] [datetime] NULL,
 CONSTRAINT [PK_Uye] PRIMARY KEY CLUSTERED 
(
	[kisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (1, N'M')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (2, N'E         ')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (4, N'E')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (7, N'M')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (8, N'M')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (9, N'E')
INSERT [dbo].[Admin] ([kisiID], [rol]) VALUES (10, N'M')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (0, N'Bos')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (26, N'Eskisehir')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (34, N'Istanbul')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (41, N'Kocaeli')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (52, N'Ordu')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (54, N'Sakarya')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (58, N'Sivas')
INSERT [dbo].[Il] ([ilNo], [ilAdi]) VALUES (59, N'Tekirdag')
SET IDENTITY_INSERT [dbo].[Ilce] ON 

INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (1, N'Tepebasi', 26)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (2, N'Serdivan', 54)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (3, N'Besiktas', 34)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (4, N'Uskudar', 34)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (5, N'Fatsa', 52)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (6, N'Adapazari', 54)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (7, N'Malkara', 59)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (8, N'Susehri', 58)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (9, N'Kadikoy', 34)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (10, N'Kabaduz', 52)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (11, N'OdunPazari', 26)
INSERT [dbo].[Ilce] ([IlceNo], [ilceAdi], [ilNo]) VALUES (13, N'Bos', 0)
SET IDENTITY_INSERT [dbo].[Ilce] OFF
SET IDENTITY_INSERT [dbo].[Iletisim] ON 

INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (2, 1, 4, N'Bu bir adrestir', N'555555321', N'furkankocc52@gmail.com')
INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (4, 2, 6, N'ohiasdasdasdo', N'123', N'ljmail')
INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (8, 18, 13, N'Bos', N'0', N'Bos')
INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (9, 20, 13, N'eee', N'123123', N'Bos')
INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (10, 21, 13, N'yok', N'0', N'Bos')
INSERT [dbo].[Iletisim] ([iletisimNo], [kisiID], [ilceNo], [adres], [tel], [email]) VALUES (11, 22, 13, N'Bos', N'0', N'Bos')
SET IDENTITY_INSERT [dbo].[Iletisim] OFF
SET IDENTITY_INSERT [dbo].[KargoFirmasi] ON 

INSERT [dbo].[KargoFirmasi] ([kargoNo], [kargoAdi], [kargoFiyati]) VALUES (1, N'Aras', 5)
INSERT [dbo].[KargoFirmasi] ([kargoNo], [kargoAdi], [kargoFiyati]) VALUES (2, N'PttKargo', 5)
INSERT [dbo].[KargoFirmasi] ([kargoNo], [kargoAdi], [kargoFiyati]) VALUES (5, N'UpsKargo', 5)
SET IDENTITY_INSERT [dbo].[KargoFirmasi] OFF
SET IDENTITY_INSERT [dbo].[Kisi] ON 

INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (1, N'furkan', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (2, N'melih', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (3, N'deneme', NULL, 1)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (4, N'mert', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (5, N'asdasd', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (6, N'asdasd', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (7, N'CrazyBoy', N'1', 0)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (8, N'kubi', N'1', 1)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (9, N'huso', N'123', 1)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (10, N'erpeks', N'1', 1)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (11, N'Melih', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (12, N'lebron', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (13, N'MagicTurtle', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (14, N'sonDeneme', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (15, N'ensondeneme', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (16, N'hocambuson', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (17, N'insallahsondur', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (18, N'hadibahalim', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (19, N'artikyeter', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (20, N'eee', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (21, N'selam', N'1', NULL)
INSERT [dbo].[Kisi] ([kisiID], [kullaniciAdi], [sifre], [silindimi]) VALUES (22, N'yineburadayiz', N'1', 0)
SET IDENTITY_INSERT [dbo].[Kisi] OFF
INSERT [dbo].[Macera] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (1, 25, 99, N'Herhangi birisi', N'Gozluklu bir cocugun buyu yapmayi ogrenmesi', NULL)
INSERT [dbo].[Macera] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (13, 20, 10, N'asd', N'asd', N'C:\Users\FURKAN\Documents\System.Windows.Forms.TextBox, Text: asd')
INSERT [dbo].[Macera] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (14, 10, 98, N'ogrenci evi', N'melihin kucukken yasadigi sikintili zamanlar', NULL)
INSERT [dbo].[Macera] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (22, 20, 48, N'Herhangi birisi', N'Gozluklu bir cocugun buyu yapmayi ogrenmesi', NULL)
INSERT [dbo].[Roman] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (19, 14, 99, N'Can Yayinlari', N'Ozet', NULL)
INSERT [dbo].[Roman] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (20, 22, 99, N'Can Yayinlari', N'Ozet', NULL)
INSERT [dbo].[Roman] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (21, 26, 100, N'Remzi Kitabevi', N'Ozet', NULL)
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (2, 1, 1, 30, 1)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (3, 1, 5, 15, 14)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (4, 1, 2, 25, 22)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (5, 1, 5, 15, 14)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (6, 1, 5, 15, 14)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (7, 1, 1, 25, 13)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (8, 1, 5, 15, 14)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (9, 1, 1, 30, 1)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (10, 1, 2, 25, 22)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (11, 1, 5, 27, 20)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (12, 9, 1, 35, 17)
INSERT [dbo].[Siparisler] ([siparisID], [kisiID], [kargoNo], [fiyat], [urunID]) VALUES (13, 12, 5, 19, 19)
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
INSERT [dbo].[Tarih] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (15, 13, 110, N'İs Bankasi Kultur Yayinlari', N'Ozet', NULL)
INSERT [dbo].[Tarih] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (16, 72, 100, N'Kronik Kitap', N'“Türkiye gibi önemli bir coğrafyayı ve tarih alanını öğrenmek için onun kuzeyindeki Güney Rusya ve Kafkasya, doğusundaki İran ve Hindistan, güneyindeki Suriye, Filistin ve Mezopotamya''nın yanı sıra Balkanları ve Akdeniz ülkelerini anlamak da kaçınılmazdır”', NULL)
INSERT [dbo].[Tarih] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (17, 30, 99, N'Kolektif Kitap', N'Ozet', NULL)
INSERT [dbo].[Tarih] ([urunID], [fiyat], [stok], [basimEvi], [kitapOzeti], [resim]) VALUES (18, 22, 100, N'Kronik Kitap', N'Ozet', NULL)
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (1, N'Harry Potter', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (2, N'Sol Ayagim', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (3, N'Nutuk', N'Tarih')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (4, N'Korluk', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (5, N'Donusum', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (6, N'Yuzuklerin Efendisi', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (7, N'asdasd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (8, N'asdasd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (9, N'asd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (10, N'melihin maceralari', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (11, N'asd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (12, N'asd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (13, N'asd', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (14, N'melihin maceralari', N'Macera')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (15, N'Nutuk', N'Tarih')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (16, N'Ilber Ortayli Seti', N'Tarih')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (17, N'Yuval Noah Harari', N'Tarih')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (18, N'Gazi Mustafa Kemal Ataturk', N'Tarih')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (19, N'Hayvan Ciftligi', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (20, N'1984', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (21, N'Kral Kaybederse', N'Roman')
INSERT [dbo].[Urunler] ([urunID], [kitapAdi], [kitapTuru]) VALUES (22, N'Harry Potter 2', N'Macera')
SET IDENTITY_INSERT [dbo].[Urunler] OFF
SET IDENTITY_INSERT [dbo].[Uye] ON 

INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (1, N'furkan', N'koc', N'erkek', NULL)
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (2, N'melih', N'erpek', N'erkek', NULL)
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (3, N'deneme', N'deneme', N'kadin', NULL)
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (4, N'mert', N'baskaya', N'erkek', NULL)
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (5, N'asd', N'dsa', N'Kadin', CAST(N'2019-12-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (6, N'asd', N'asd', N'Erkek', NULL)
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (7, N'Semih', N'Kahya', N'Kadin', CAST(N'2019-12-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (8, N'Kubilay', N'Kaynan', N'Erkek', CAST(N'1998-06-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (10, N'Melih', N'Erpek', N'Erkek', CAST(N'2019-12-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (11, N'melih', N'erpek', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (12, N'Lebron', N'James', N'Erkek', CAST(N'2019-12-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (13, N'Anonim', N'AnonimDegil', N'Kadin', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (14, N'son', N'deneme', N'Kadin', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (15, N'en', N'son', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (16, N'hocam', N'bu', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (17, N'insallah', N'sondur', N'Kadin', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (18, N'hadi', N'bahalim', N'Kadin', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (19, N'artik', N'yeter', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (20, N'eee', N'eeeee', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (21, N'selam', N'veas', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Uye] ([kisiID], [ad], [soyad], [cinsiyet], [dogumTarihi]) VALUES (22, N'yine', N'buradayiz', N'Erkek', CAST(N'2019-12-17T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Uye] OFF
ALTER TABLE [dbo].[Iletisim] ADD  CONSTRAINT [DF_Iletisim_ilceNo]  DEFAULT ((0)) FOR [ilceNo]
GO
ALTER TABLE [dbo].[Iletisim] ADD  CONSTRAINT [DF_Iletisim_adres]  DEFAULT (N'Bos') FOR [adres]
GO
ALTER TABLE [dbo].[Iletisim] ADD  CONSTRAINT [DF_Iletisim_tel]  DEFAULT ((0)) FOR [tel]
GO
ALTER TABLE [dbo].[Iletisim] ADD  CONSTRAINT [DF_Iletisim_email]  DEFAULT (N'Bos') FOR [email]
GO
ALTER TABLE [dbo].[Kisi] ADD  CONSTRAINT [DF_Kisi_silindimi]  DEFAULT ((0)) FOR [silindimi]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Kisi]
GO
ALTER TABLE [dbo].[Ilce]  WITH CHECK ADD  CONSTRAINT [FK_Ilce_Il] FOREIGN KEY([ilNo])
REFERENCES [dbo].[Il] ([ilNo])
GO
ALTER TABLE [dbo].[Ilce] CHECK CONSTRAINT [FK_Ilce_Il]
GO
ALTER TABLE [dbo].[Iletisim]  WITH CHECK ADD  CONSTRAINT [FK_Iletisim_Ilce] FOREIGN KEY([ilceNo])
REFERENCES [dbo].[Ilce] ([IlceNo])
GO
ALTER TABLE [dbo].[Iletisim] CHECK CONSTRAINT [FK_Iletisim_Ilce]
GO
ALTER TABLE [dbo].[Iletisim]  WITH CHECK ADD  CONSTRAINT [FK_Iletisim_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Iletisim] CHECK CONSTRAINT [FK_Iletisim_Kisi]
GO
ALTER TABLE [dbo].[Macera]  WITH CHECK ADD  CONSTRAINT [FK_Macera_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([urunID])
GO
ALTER TABLE [dbo].[Macera] CHECK CONSTRAINT [FK_Macera_Urunler]
GO
ALTER TABLE [dbo].[Roman]  WITH CHECK ADD  CONSTRAINT [FK_Roman_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([urunID])
GO
ALTER TABLE [dbo].[Roman] CHECK CONSTRAINT [FK_Roman_Urunler]
GO
ALTER TABLE [dbo].[silinenKisi]  WITH CHECK ADD  CONSTRAINT [FK_silinenKisi_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[silinenKisi] CHECK CONSTRAINT [FK_silinenKisi_Kisi]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_KargoFirmasi] FOREIGN KEY([kargoNo])
REFERENCES [dbo].[KargoFirmasi] ([kargoNo])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_KargoFirmasi]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Kisi]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([urunID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Urunler]
GO
ALTER TABLE [dbo].[Tarih]  WITH CHECK ADD  CONSTRAINT [FK_Tarih_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([urunID])
GO
ALTER TABLE [dbo].[Tarih] CHECK CONSTRAINT [FK_Tarih_Urunler]
GO
ALTER TABLE [dbo].[UrunSiparis]  WITH CHECK ADD  CONSTRAINT [FK_UrunSiparis_Siparisler] FOREIGN KEY([siparisID])
REFERENCES [dbo].[Siparisler] ([siparisID])
GO
ALTER TABLE [dbo].[UrunSiparis] CHECK CONSTRAINT [FK_UrunSiparis_Siparisler]
GO
ALTER TABLE [dbo].[UrunSiparis]  WITH CHECK ADD  CONSTRAINT [FK_UrunSiparis_Urunler] FOREIGN KEY([urunID])
REFERENCES [dbo].[Urunler] ([urunID])
GO
ALTER TABLE [dbo].[UrunSiparis] CHECK CONSTRAINT [FK_UrunSiparis_Urunler]
GO
ALTER TABLE [dbo].[Uye]  WITH CHECK ADD  CONSTRAINT [FK_Uye_Kisi] FOREIGN KEY([kisiID])
REFERENCES [dbo].[Kisi] ([kisiID])
GO
ALTER TABLE [dbo].[Uye] CHECK CONSTRAINT [FK_Uye_Kisi]
GO

USE [obs]
GO
/****** Object:  Table [dbo].[tbl_Ders]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Ders](
	[Fakulte] [nchar](50) NULL,
	[Bolum] [nvarchar](50) NULL,
	[Yarıyıl] [int] NULL,
	[Ders_Kodu] [nchar](50) NULL,
	[Ders_Adı] [nchar](50) NULL,
	[AKTS] [int] NULL,
	[ÖğretimGörevlisi] [nchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_giris]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_giris](
	[Tc] [int] NULL,
	[Sifre] [int] NULL,
	[Ad] [nchar](20) NULL,
	[Soyad] [nchar](30) NULL,
	[Yetki] [nchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_harc]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_harc](
	[Tc] [int] NULL,
	[Harç] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kayitOl]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kayitOl](
	[Uyruk] [nchar](20) NULL,
	[Tc] [int] NULL,
	[Ad] [nchar](50) NULL,
	[Soyad] [nchar](50) NULL,
	[Anne_ad] [nchar](50) NULL,
	[Baba_ad] [nchar](50) NULL,
	[Dogum_tarihi] [datetime] NULL,
	[cinsiyet] [nchar](10) NULL,
	[cep_no] [int] NULL,
	[sehir] [nchar](50) NULL,
	[sifre] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ogretimGorevlisi]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ogretimGorevlisi](
	[Tc] [int] NULL,
	[ÖğretimGörevlisi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[cep_no] [int] NULL,
	[Unvan] [nvarchar](50) NULL,
	[Fakulte] [nvarchar](50) NULL,
	[Bolum] [nvarchar](50) NULL,
	[sifre] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ozlukBilgisi]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ozlukBilgisi](
	[Tc] [int] NULL,
	[Yetki] [nchar](20) NULL,
	[ÖğrenciNumarasi] [int] NULL,
	[Fakulte] [nchar](50) NULL,
	[Bolum] [nchar](50) NULL,
	[Öğretim] [nchar](10) NULL,
	[Ad] [nchar](20) NULL,
	[Soyad] [nchar](20) NULL,
	[BursBigisi] [nchar](10) NULL,
	[Yarıyıl] [int] NULL,
	[GecişŞekli] [nchar](10) NULL,
	[KayıtYılı] [nchar](10) NULL,
	[Ortalama] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Sınavlar]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Sınavlar](
	[Tc] [int] NULL,
	[Ders_Kodu] [nchar](50) NULL,
	[Sınav_Adı] [nchar](10) NULL,
	[Etki_Oranı] [nchar](10) NULL,
	[Sınav_Tarihi] [nchar](10) NULL,
	[Sınav_Notu] [nchar](10) NULL,
	[Harf_Notu] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Yoklama]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Yoklama](
	[Tc] [int] NULL,
	[Ders_Kodu] [nchar](50) NULL,
	[Ders_Adı] [nchar](50) NULL,
	[Yarıyıl] [int] NULL,
	[ÖğretimGörevlisi] [nchar](50) NULL,
	[Ders_Yoklama_Durumu] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 6, N'BMF103                                            ', N'Kabuk Programlama                                 ', 4, N'Emre YAYLALI                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 3, N'FMT162                                            ', N'Lineer Cebir                                      ', 5, N'İrem AKTAŞ                                        ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 2, N'FMT170                                            ', N'Ayrık Matematik                                   ', 6, N'Cengiz YERLİKAYA                                  ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 4, N'FST102                                            ', N'Olasılık ve İstatistik                            ', 4, N'Emre YAYLALI                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Hukuk                                             ', N'Hukuk', 1, N'HKM102                                            ', N'Hukuka Giriş                                      ', 4, N'Menekşe BUDAK                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Hukuk                                             ', N'Hukuk', 2, N'HKM103                                            ', N'Anayasa Hukukku                                   ', 5, N'Menekşe BUDAK                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Hukuk                                             ', N'Hukuk', 2, N'HKM104                                            ', N'İdari Hukuk                                       ', 5, N'İlknur ATAŞ                                       ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 1, N'MBM103                                            ', N'Programlamaya Giriş                               ', 7, N'Cengiz YERLİKAYA                                  ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 2, N'MBM104                                            ', N'Nesneye Yönelik Programlama                       ', 8, N'Emre YAYLALI                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 4, N'MBM202                                            ', N'Bilgisayar Organizasyonu ve Tasarımı              ', 5, N'Aysima AYDIN                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 3, N'MBM203                                            ', N'Veri Yapıları Ve Alg.                             ', 6, N'Emre GÜLER                                        ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 3, N'MBM205                                            ', N'Görsel Programlama                                ', 6, N'Emre YAYLALI                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 3, N'MBM207                                            ', N'Programlama Dilleri                               ', 5, N'Cengiz YERLİKAYA                                  ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 4, N'MBM210                                            ', N'Sinyaller ve Sistemler                            ', 5, N'İrem AKTAŞ                                        ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 5, N'MBM303                                            ', N'Yazılım Mühendisliği                              ', 5, N'Cengiz YERLİKAYA                                  ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 5, N'MBM305                                            ', N'Mikrdodenetleyiciler                              ', 6, N'Aysima AYDIN                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 5, N'MBM307                                            ', N'Veri Tabanı Yönetim Sistemleri                    ', 5, N'Emre YAYLALI                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 5, N'MBM309                                            ', N'Web Tasarım                                       ', 6, N'Cengiz YERLİKAYA                                  ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 6, N'MBM402                                            ', N'Paralel Programlamaya Giriş                       ', 6, N'Levent Cengiz                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 6, N'MBM403                                            ', N'Kontrol Sistemleri                                ', 6, N'Levent Cengiz                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 6, N'MBM404                                            ', N'Makine Öğrenmesine Giriş                          ', 6, N'Levent Cengiz                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 7, N'MBM405                                            ', N'Bilgisayar Grafiği                                ', 4, N'Enes ÖZTÜRK                                       ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 7, N'MBM406                                            ', N'Mobil Programlama                                 ', 4, N'Enes ÖZTÜRK                                       ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 7, N'MBM407                                            ', N'İş Sağlığı ve Güvenliği I                         ', 4, N'Enes ÖZTÜRK                                       ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 8, N'MBM408                                            ', N'Bilgisayar Mühendisliği Laboratuvarı              ', 4, N'Ömer ERDEMİR                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 8, N'MBM409                                            ', N'İşletmede Mesleki Eğitim                          ', 4, N'Ömer ERDEMİR                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 8, N'MBM410                                            ', N'Bilgisayar Mühendisliği Uygulamaları              ', 4, N'Ömer ERDEMİR                                      ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Vetirenerlik                                      ', N'Vetirenerlik                                      ', 1, N'VTM101                                            ', N'Kuzu                                              ', 4, N'Salih BABACAN                                     ')
INSERT [dbo].[tbl_Ders] ([Fakulte], [Bolum], [Yarıyıl], [Ders_Kodu], [Ders_Adı], [AKTS], [ÖğretimGörevlisi]) VALUES (N'Vetirenerlik                                      ', N'Vetirenerlik                                      ', 2, N'VTM109                                            ', N'Kuzu Anatomisi                                    ', 5, N'Salih BABACAN                                     ')
GO
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (1, 321, N'İlknur              ', N'ATAŞ                          ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (3, 123, N'İrem                ', N'AKTAŞ                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (4, 123, N'Aysima              ', N'AYDIN                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (5, 123, N'Halil               ', N'ŞAHİN                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (6, 123, N'Cengiz              ', N'YERLİKAYA                     ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (7, 123, N'Menekşe             ', N'BUDAK                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (8, 123, N'Fulya               ', N'ÇİMEN                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (10, 123, N'Emre                ', N'GÜLER                         ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (77, 123, N'Pelin               ', N'Taş                           ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (333, 123, N'Hazal               ', N'Budak                         ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (1111, 123, NULL, NULL, N'ADMİN               ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (1234, 123, N'Emre                ', N'YAYLALI                       ', N'ÖĞRETİM GÖREVLİSİ   ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (2222, 321, N'Aysenur             ', N'Öztürk                        ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (4444, 123, N'Fatma               ', N'Sayan                         ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (5555, 123, N'Beyzanur            ', N'TAnınmış                      ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (6666, 123, N'Yaren               ', N'Karadeniz                     ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (7777, 123, N'Boğaç               ', N'Kaman                         ', N'ÖĞRENCİ             ')
INSERT [dbo].[tbl_giris] ([Tc], [Sifre], [Ad], [Soyad], [Yetki]) VALUES (8888, 123, N'Aytaç               ', N'Kara                          ', N'ÖĞRENCİ             ')
GO
INSERT [dbo].[tbl_harc] ([Tc], [Harç]) VALUES (5555, 300)
INSERT [dbo].[tbl_harc] ([Tc], [Harç]) VALUES (6666, 300)
INSERT [dbo].[tbl_harc] ([Tc], [Harç]) VALUES (7777, 300)
GO
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 77, N'Pelin                                             ', N'Taş                                               ', N'Ayşe                                              ', N'Cengiz                                            ', CAST(N'2002-12-31T00:00:00.000' AS DateTime), N'KIZ       ', 25648, N'ERZURUM                                           ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 333, N'Hazal                                             ', N'Budak                                             ', N'Ayşe                                              ', N'Davut                                             ', CAST(N'2000-02-07T00:00:00.000' AS DateTime), N'KIZ       ', 564982, N'ERZURUM                                           ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 2222, N'Ayşenur                                           ', N'Öztürk                                            ', N'Öznur                                             ', N'Serdar                                            ', CAST(N'2000-02-18T00:00:00.000' AS DateTime), N'KIZ       ', 56485, N'İSTANBUL                                          ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 4444, N'Fatma                                             ', N'Sayan                                             ', N'Hamide                                            ', N'Zeki                                              ', CAST(N'2001-11-16T00:00:00.000' AS DateTime), N'KIZ       ', 25485, N'İSTANBUL                                          ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 5555, N'Beyzanur                                          ', N'Tanınmış                                          ', N'Pelin                                             ', N'Cenk                                              ', CAST(N'2000-10-04T00:00:00.000' AS DateTime), N'KIZ       ', 255556, N'BURSA                                             ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 6666, N'Yaren                                             ', N'Karadeniz                                         ', N'Meryem                                            ', N'Ali                                               ', CAST(N'1999-07-14T00:00:00.000' AS DateTime), N'KIZ       ', 2245626, N'BURSA                                             ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 7777, N'Boğaç                                             ', N'Kaman                                             ', N'Fatma                                             ', N'Ahmet                                             ', CAST(N'2000-10-04T00:00:00.000' AS DateTime), N'ERKEK     ', 2255555, N'BURSA                                             ', 321)
INSERT [dbo].[tbl_kayitOl] ([Uyruk], [Tc], [Ad], [Soyad], [Anne_ad], [Baba_ad], [Dogum_tarihi], [cinsiyet], [cep_no], [sehir], [sifre]) VALUES (N'TÜRKİYE             ', 8888, N'Aytaç                                             ', N'Kara                                              ', N'Selin                                             ', N'Selim                                             ', CAST(N'2001-03-24T00:00:00.000' AS DateTime), N'ERKEK     ', 2555656, N'BURSA                                             ', 321)
GO
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (1, N'İlknur ATAŞ', N'KIZ', 2555, N'DR.', N'Hukuk                                             ', N'Hukuk                                             ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (2, N'Salih BABACAN', N'ERKEK', 2455225, N'DR.', N'Vetirenerlik                                      ', N'Vetirenerlik                                      ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (3, N'İrem AKTAŞ                                        ', N'KIZ', 54852, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (4, N'Aysima AYDIN', N'KIZ', 5545522, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (5, N'Halil ŞAHİN                                       ', N'ERKEK', 55152, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (6, N'Cengiz YERLİKAYA                                  ', N'ERKEK', 55156, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (7, N'Menekşe BUDAK                                     ', N'KIZ', 56555, N'DR.', N'Hukuk', N'Hukuk', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (8, N'Fulya ÇİMEN                                       ', N'KIZ', 2255, N'DR.', N'Vetirenerlik                                      ', N'Vetirenerlik                                      ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (9, N'Fazlı Saman                            ', N'ERKEK', 256558, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (10, N'Emre GÜLER                      ', N'ERKEK', 534693, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
INSERT [dbo].[tbl_ogretimGorevlisi] ([Tc], [ÖğretimGörevlisi], [Cinsiyet], [cep_no], [Unvan], [Fakulte], [Bolum], [sifre]) VALUES (12345, N'Emre YAYLALI                                      ', N'ERKEK', 256854, N'DR.', N'Mühendislik                                       ', N'Bilgisayar Mühendisliği                           ', 321)
GO
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (77, N'ÖĞRENCİ             ', 220707030, N'HUKUK                                             ', N'HUKUK                                             ', N'ÖRGÜN     ', N'Pelin               ', N'Taş                 ', N'Yok       ', 2, N'ÖSS       ', N'2022      ', 0)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (333, N'ÖĞRENCİ             ', 220707030, N'MÜHENDİSLİK                                       ', N'Bilgisayar Mühendisliği                           ', N'ÖRGÜN     ', N'Hazal               ', N'Budak               ', N'Var       ', 3, N'ÖSS       ', N'2022      ', 0)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (2222, N'ÖĞRENCİ             ', 200707037, N'MÜHENDİSLİK                                       ', N'Bilgisayar Mühendisliği                           ', N'ÖRGÜN     ', N'Ayşenur             ', N'Öztürk              ', N'yok       ', 5, N'ÖSS       ', N'2020      ', 3)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (4444, N'ÖĞRENCİ             ', 220707030, N'MÜHENDİSLİK                                       ', N'Bilgisayar Mühendisliği                           ', N'ÖRGÜN     ', N'Fatma               ', N'Sayan               ', N'Yok       ', 4, N'ÖSS       ', N'2022      ', 0)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (5555, N'ÖĞRENCİ             ', 200707055, N'MÜHENDİSLİK                                       ', N'Bilgisayar Mühendisliği                           ', N'İKİNCİ    ', N'Beyzanur            ', N'Tanınmış            ', N'var       ', 6, N'ÖSS       ', N'2020      ', 3)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (6666, N'ÖĞRENCİ             ', 220707030, N'HUKUK                                             ', N'Hukuk                                             ', N'İKİNCİ    ', N'Yaren               ', N'Karadeniz           ', N'Var       ', 7, N'ÖSS       ', N'2022      ', 0)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (7777, N'ÖĞRENCİ             ', 220707030, N'HUKUK                                             ', N'Hukuk                                             ', N'İKİNCİ    ', N'Boğaç               ', N'Kaman               ', N'Yok       ', 8, N'ÖSS       ', N'2022      ', 0)
INSERT [dbo].[tbl_ozlukBilgisi] ([Tc], [Yetki], [ÖğrenciNumarasi], [Fakulte], [Bolum], [Öğretim], [Ad], [Soyad], [BursBigisi], [Yarıyıl], [GecişŞekli], [KayıtYılı], [Ortalama]) VALUES (8888, N'ÖĞRENCİ             ', 220707030, N'MÜHENDİSLİK                                       ', N'Bilgisyar Mühendisliği                            ', N'ÖRGÜN     ', N'Aytaç               ', N'Kara                ', N'Var       ', 1, N'ÖSS       ', N'2022      ', 0)
GO
INSERT [dbo].[tbl_Sınavlar] ([Tc], [Ders_Kodu], [Sınav_Adı], [Etki_Oranı], [Sınav_Tarihi], [Sınav_Notu], [Harf_Notu]) VALUES (2222, N'MBM103                                            ', N'vize      ', N'50        ', N'18.02.2022', N'100       ', N'          ')
INSERT [dbo].[tbl_Sınavlar] ([Tc], [Ders_Kodu], [Sınav_Adı], [Etki_Oranı], [Sınav_Tarihi], [Sınav_Notu], [Harf_Notu]) VALUES (333, N'FMT170                                            ', N'vize      ', N'50        ', N'19.02.2022', N'90        ', N'          ')
INSERT [dbo].[tbl_Sınavlar] ([Tc], [Ders_Kodu], [Sınav_Adı], [Etki_Oranı], [Sınav_Tarihi], [Sınav_Notu], [Harf_Notu]) VALUES (2222, N'FMT170                                            ', N'vize      ', N'50        ', N'19.02.2002', N'45        ', N'          ')
INSERT [dbo].[tbl_Sınavlar] ([Tc], [Ders_Kodu], [Sınav_Adı], [Etki_Oranı], [Sınav_Tarihi], [Sınav_Notu], [Harf_Notu]) VALUES (2222, N'MBM309                                            ', N'vize      ', N'25        ', N'20.02.2022', N'15        ', N'          ')
GO
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (77, N'HKM102                                            ', N'Hukuka Giriş                                      ', 1, N'Menekşe BUDAK                                     ', N'%49       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (5555, N'MBM303                                            ', N'Yazılım Mühendisliği                              ', 5, N'Cengiz YERLİKAYA                                  ', N'%51       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (5555, N'MBM307                                            ', N'Veri Tabanı Yönetim Sistemleri                    ', 5, N'Aysima AYDIN                                      ', N'%89       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (5555, N'MBM305                                            ', N'Mikrdodenetleyiciler                              ', 5, N'Aysima AYDIN                                      ', N'%100      ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (2222, N'MBM303                                            ', N'Yazılım Mühendisliği                              ', 5, N'Cengiz YERLİKAYA                                  ', N'%10       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (2222, N'MBM307                                            ', N'Veri Tabanı Yönetim Sistemleri                    ', 5, N'Emre YAYLALI                                      ', N'%10       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (2222, N'MBM305                                            ', N'Mikrdodenetleyiciler                              ', 5, N'Aysima AYDIN                                      ', N'%10       ')
INSERT [dbo].[tbl_Yoklama] ([Tc], [Ders_Kodu], [Ders_Adı], [Yarıyıl], [ÖğretimGörevlisi], [Ders_Yoklama_Durumu]) VALUES (77, N'HKM104                                            ', N'İdare Hukuku                                      ', 1, N'İlknur ATAŞ                                       ', N'%100      ')
GO
/****** Object:  StoredProcedure [dbo].[up_spdersDuzenle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spdersDuzenle]
@Fakulte nchar(50),@Bolum nchar(50),@Yarıyıl int,
@Ders_Kodu nchar(50),@Ders_Adı nchar(50),@AKTS int,@ÖğretimGörevlisi nchar(50)
AS
BEGIN
Update tbl_Ders Set Fakulte=@Fakulte ,Bolum=@Bolum,
Yarıyıl=@Yarıyıl,Ders_Kodu=@Ders_Kodu,Ders_Adı=@Ders_Adı,
AKTS=@AKTS,ÖğretimGörevlisi=@ÖğretimGörevlisi where Ders_Kodu=@Ders_Kodu
END
GO
/****** Object:  StoredProcedure [dbo].[up_spdersEkle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spdersEkle]
@Fakulte nchar(50),@Bolum nvarchar(50),
@Yarıyıl int,@Ders_Kodu nchar(50),
@Ders_Adı nchar(50),@AKTS int
AS
BEGIN
 
INSERT INTO tbl_Ders(Fakulte, Bolum, Yarıyıl, Ders_Kodu, Ders_Adı,AKTS) 
values (@Fakulte,@Bolum,@Yarıyıl,@Ders_Kodu,@Ders_Adı,@AKTS);
END
GO
/****** Object:  StoredProcedure [dbo].[up_spderstSil]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spderstSil]
@Ders_Kodu nchar(50)
AS
BEGIN

Delete from tbl_Ders where Ders_Kodu=@Ders_Kodu
END
GO
/****** Object:  StoredProcedure [dbo].[up_spgirisEkle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spgirisEkle]
@Tc int ,@Sifre int ,@Ad nchar(20),
@Soyad nchar(30),@Yetki nchar(20)
AS
BEGIN
 insert into tbl_giris (Tc,Sifre,Ad,Soyad,Yetki) 
 values(@Tc,@Sifre,@Ad,@Soyad,@Yetki)
END
GO
/****** Object:  StoredProcedure [dbo].[up_spkayitDuzenle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC  [dbo].[up_spkayitDuzenle]
@Uyruk varchar(20),@Tc int, @Ad varchar(50),@Soyad varchar(50),@Anne_ad varchar(50),@Baba_ad varchar(50) ,
@Dogum_tarihi datetime, @cinsiyet varchar(10),@cep_no int,@sehir varchar(50),@sifre int
AS
BEGIN

Update tbl_kayitOl set Uyruk=@Uyruk,Tc=@Tc,Ad=@Ad,Soyad=@Soyad,Anne_ad=@Anne_ad,Baba_ad=@Baba_ad,
Dogum_tarihi=@Dogum_tarihi ,cinsiyet=@cinsiyet,
cep_no=@cep_no,sehir=@sehir,sifre=@sifre where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spkayitOl]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spkayitOl]
@Uyruk varchar(20),@Tc int, @Ad varchar(50),@Soyad varchar(50),@Anne_ad varchar(50),@Baba_ad varchar(50) ,
@Dogum_tarihi datetime, @cinsiyet varchar(10),@cep_no int,@sehir varchar(50),@sifre int
AS
BEGIN
 
INSERT INTO tbl_kayitOl(Uyruk,Tc,Ad,Soyad,Anne_ad,Baba_ad, Dogum_tarihi ,cinsiyet,cep_no,sehir,sifre) 
VALUES(@Uyruk,@Tc,@Ad,@Soyad,@Anne_ad,@Baba_ad,@Dogum_tarihi ,@cinsiyet,@cep_no,@sehir,@sifre);
END
GO
/****** Object:  StoredProcedure [dbo].[up_spkayitSil]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spkayitSil]
--@Uyruk varchar(20),@Tc int, @Ad varchar(50),@Soyad varchar(50),@Anne_ad varchar(50),@Baba_ad varchar(50) ,
--@Dogum_tarihi datetime, @cinsiyet varchar(10),@cep_no int,@sehir varchar(50),@sifre int
@Tc int
AS
BEGIN

Delete from tbl_kayitOl where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spOgretimDuzenle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spOgretimDuzenle]
@Tc int ,@ÖğretimGörevlisi nvarchar(50),@Cinsiyet nvarchar(50),
@cep_no int,@Unvan nvarchar(50),@Fakulte nvarchar(50),
@Bolum nvarchar(50),@sifre int
AS
BEGIN
Update tbl_ogretimGorevlisi Set Tc=@Tc,ÖğretimGörevlisi=@ÖğretimGörevlisi,Cinsiyet=@Cinsiyet,cep_no=@cep_no,
Unvan=@Unvan,Fakulte=@Fakulte,Bolum=@Bolum,sifre=@sifre 
where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spOgretimEkle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spOgretimEkle]
@Tc int ,@ÖğretimGörevlisi nvarchar(50),@Cinsiyet nvarchar(50),
@cep_no int,@Unvan nvarchar(50),@Fakulte nvarchar(50),
@Bolum nvarchar(50),@sifre int
AS
BEGIN
INSERT INTO tbl_ogretimGorevlisi(Tc,ÖğretimGörevlisi,Cinsiyet,cep_no,Unvan,Fakulte,Bolum,sifre) 
VALUES(@Tc,@ÖğretimGörevlisi,@Cinsiyet,@cep_no,@Unvan,@Fakulte,@Bolum,@sifre);
END
GO
/****** Object:  StoredProcedure [dbo].[up_spogretimSil]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC  [dbo].[up_spogretimSil]
@Tc int
AS
BEGIN

Delete from tbl_ogretimGorevlisi where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spozlukDuzenle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spozlukDuzenle]
@Tc int,@Yetki nchar(20),@ÖğrenciNumarasi int,@Fakulte nchar(50),@Bolum nchar(50),@Öğretim nchar(10),
@Ad nchar(20),@Soyad nchar(20),@BursBigisi nchar(10),@Yarıyıl int,@GecişŞekli nchar(10),
@KayıtYılı nchar(10),@Ortalama float
AS
BEGIN

Update tbl_ozlukBilgisi Set Tc=@Tc, Yetki=@Yetki, ÖğrenciNumarasi=@ÖğrenciNumarasi, Fakulte=@Fakulte,
Bolum=@Bolum,Öğretim=@Öğretim,Ad=@Ad,Soyad=@Soyad,
BursBigisi=@BursBigisi,Yarıyıl=@Yarıyıl,GecişŞekli=@GecişŞekli,KayıtYılı=@KayıtYılı,Ortalama=@Ortalama 
where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spozlukekle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spozlukekle]
@Tc int,@Yetki nchar(20),@ÖğrenciNumarasi int,@Fakulte nchar(50),@Bolum nchar(50),@Öğretim nchar(10),
@Ad nchar(20),@Soyad nchar(20),@BursBigisi nchar(10),@Yarıyıl int,@GecişŞekli nchar(10),
@KayıtYılı nchar(10),@Ortalama float
AS
BEGIN
INSERT INTO tbl_ozlukBilgisi(Tc,Yetki,ÖğrenciNumarasi,Fakulte,
Bolum,Öğretim, Ad ,Soyad,BursBigisi,
Yarıyıl,GecişŞekli,KayıtYılı,Ortalama) 
VALUES(@Tc,@Yetki,@ÖğrenciNumarasi,@Fakulte,
@Bolum,@Öğretim,@Ad,@Soyad,@BursBigisi,@Yarıyıl,@GecişŞekli,
@KayıtYılı,@Ortalama);
END
GO
/****** Object:  StoredProcedure [dbo].[up_spozlukSil]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spozlukSil]
@Tc int
AS
BEGIN

Delete from tbl_ozlukBilgisi where Tc=@Tc
END
GO
/****** Object:  StoredProcedure [dbo].[up_spSınavlarEkle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spSınavlarEkle]
@Tc int,@Ders_Kodu nchar(50),@Sınav_Adı nchar(10),@Etki_Oranı nchar(10)
,@Sınav_Tarihi nchar(10),@Sınav_Notu nchar(10),@Harf_Notu nchar(10)
AS
BEGIN
INSERT INTO tbl_Sınavlar(Tc,Ders_Kodu,Sınav_Adı,Etki_Oranı,Sınav_Tarihi,Sınav_Notu,Harf_Notu) 
VALUES(@Tc,@Ders_Kodu,@Sınav_Adı,@Etki_Oranı,@Sınav_Tarihi,@Sınav_Notu,@Harf_Notu);
END
GO
/****** Object:  StoredProcedure [dbo].[up_spsifreDuzenle]    Script Date: 8.01.2023 20:40:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC  [dbo].[up_spsifreDuzenle]
@Tc int,@Sifre int
AS
BEGIN
Update tbl_kayitOl Set Tc=@Tc, Sifre=@Sifre
END
GO

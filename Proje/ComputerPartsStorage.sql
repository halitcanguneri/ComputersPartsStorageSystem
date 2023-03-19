create database ComputerPartsStorage

create table Islemci (
UrunID int primary key not null,
Uretici nvarchar (50),
Model nvarchar (50),
UyumluSoket nvarchar(50),
MaxFrekansHizi float,
CekirdekSayisi int,
ThreadSayisi int,
TuketimDegeri int,
Fiyat float,
Stok int)

select * from Islemci
--insert into Islemci values ('AMD','Ryzen 3 4100','AM4',4.0,4,8,65,1760.50)

--drop table Anakart
create table Anakart(
UrunID int primary key not null,
Marka nvarchar (50),
UrunAdi nvarchar (50),
UyumluIslemciMarkasi nvarchar(50),
UyumluSoketTipi nvarchar(50),
RamSlotuSayisi int,
Bluetooth char(3),
M2SSD int,
Fiyat float,
Stok int)
select * from Anakart
insert into Anakart values (1,'ASUS','PRIME B650M-A','AMD','AM5',4,'Yok',2,5733.17,54)
insert into Anakart values (2,'GIGABYTE','B660M GAMING X AX','INTEL','Soket 1700',4,'Yok',2,3748.25,17)
insert into Anakart values (3,'ASUS','TUF GAMING B650-PLUS','AMD','AM5',4,'Yok',3,7395.88,4)
insert into Anakart values (4,'GIGABYTE ','B650M AORUS ELITE AX','AMD','AM5',4,'Var',2,6364.48,29)
insert into Anakart values (5,'ASUS','ROG STRIX Z790-A GAMING','INTEL','Soket 1700',4,'Var',4,10600.76,2)
insert into Anakart values (6,'GIGABYTE ','B650 AORUS PRO AX','AMD','AM5',4,'Var',3,8100.24,13)
insert into Anakart values (7,'MSI','MEG Z590 ACE GOLD EDITION','INTEL','Soket 1200',4,'Var',4,13936.45,8)
insert into Anakart values (8,'ASUS','ROG CROSSHAIR X670E GENE','AMD','AM5',4,'Var',3,15205.37,32)
insert into Anakart values (9,'ASUS','ROG MAXIMUS Z790 APEX','INTEL','Soket 1700',2,'Var',5,18489.69,22)
insert into Anakart values (10,'ASUS','ROG CROSSHAIR X670E EXTREME','AMD','AM5',4,'Var',5,24926.84,54)

create table EkranKarti(
UrunID int primary key not null,
Marka nvarchar (50),
UrunSerisi int,
UrunModeli nvarchar(50),
CekirdekHizi int,
BellekTipi varchar(15),
BellekKapasitesi int,
CudaSayisi int,
Fiyat float,
Stok int)
select * from EkranKarti
--insert into EkranKarti values (1,'ASUS',3000,'GeForce RTX 3070 Ti',1815,'GDDR6X',8,6144,18982,75)

--drop table RAM
create table RAM(
UrunID int primary key not null,
Marka nvarchar (50),
RamTipi nvarchar(50),
RamKapasitesi int,
FrekansHizi int,
VoltajDegeri float,
KanalTipi nvarchar(15),
Uyumluluk nvarchar(30),
Fiyat float,
Stok int)
select * from RAM
--insert into RAM values(1,'CORSAIR','DDR5',64,7000,1.35,'Dual Kanal','Masaüstü Ram',10148,79)

--drop table PSU
create table PSU(
UrunID int primary key not null,
Marka nvarchar (50),
Model nvarchar(50),
Guc int,
GucVerimliligi nvarchar(50),
Moduler nvarchar(50),
AnaKonnektor nvarchar(15),
FanSayisi int,
Fiyat float,
Stok int)
select * from PSU
--insert into PSU values('CORSAIR','HX1500i',1500,'80 PLUS PLATINUM','Full Modüler','24Pin',1,9599.03)


--drop table Monitor
create table Monitor(
UrunID int primary key not null,
Marka nvarchar (50),
Model nvarchar(50),
EkranBoyutu int,
TazelemeHizi int,
GecikmeSuresi float,
Panel char(15),
Hoparlor char(3),
Fiyat float,
Stok int)
select * from Monitor
--insert into Monitor values('BenQ','Mobiuz EX270M',27,240,1,'IPS','Var',21851.46)

--drop table Mouse
create table Mouse(
UrunID int primary key not null,
Marka nvarchar (50),
BaglantiTipi nvarchar(15),
IzlemeTipi nvarchar(15),
TusSayisi int,
KullanimSekli nvarchar(15),
MaxDPI int,
KablosuzBaglantiTürü nvarchar(30),
Fiyat float,
Stok int)
select * from Mouse
--insert into Mouse values('SteelSeries Aerox 9','Kablosuz','Optik',18,'Sað El',18000,'Wireless, Bluetooth',2999,0)

--drop table Klavye
create table Klavye(
UrunID int primary key not null,
MarkaModel nvarchar (50),
BaglantiTipi nvarchar(15),
Mekanik nvarchar(5),
KlavyeTusDizilimi nvarchar(50),
SwitchTipi nvarchar(30),
KlavyeAydinlatmasi nvarchar(10),
Numpad nvarchar(30),
Fiyat float,
Stok int)
select * from Klavye
--insert into Klavye values('','SteelSeries Apex Pro','Kablolu','Evet','Ýngilizce Q (UK)','Optical-Mech','RGB','Yok',5499.0,5)

--drop table Users
create table Users(
username nvarchar(50) primary key,
password nvarchar(50),
user_type nvarchar(50))
insert into Users values('can','123','admin')
insert into Users values('bardari','123','user')
select * from Users
select * from Anakart

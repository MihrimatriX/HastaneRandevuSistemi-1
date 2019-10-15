insert into Departman values('ÇOCUK SAĞLIĞI VE HASTALIKLARI')
insert into Departman values('GÖZ HASTALIKLARI')
insert into Departman values('NÖROLOJİ')
insert into Departman values('GENEL CERRAHİ')
insert into Departman values('KULAK-BURUN-BOĞAZ HASTALIKLARI')
insert into Departman values('KARDİYOLOJİ')
insert into Departman values('DİŞ HASTALIKLARI')
insert into Departman values('DAHİLİYE')


insert into Hastane values('Bakırköy Dr. Sadi Konuk Eğitim ve Araştırma Hastanesi')
insert into Hastane values('Erenköy Ruh ve Sinir Hastalıkları Eğitim ve Araştırma Hastanesi')
insert into Hastane values('Okmeydanı Eğitim ve Araştırma Hastanesi')
insert into Hastane values('Bahçelievler Devlet Hastanesi')
insert into Hastane values('Sancaktepe Ağız ve Diş Sağlığı Merkezi')

insert into Poliklinik values('Poliklinik Yok',1)
insert into Poliklinik values('Poliklinik-1',2)
insert into Poliklinik values('Poliklinik-2',2)
insert into Poliklinik values('Poliklinik-3',3)

insert into Doktor values('Ahmet Yılmaz',1,1,1,1,'doktor','123')
insert into Doktor values('Yeşim Avcı',2,2,2,1,'drYesim','123')
insert into Doktor values('Ramazan ﻿Acar',3,4,3,1,'drRamazan','123')
insert into Doktor values('Irem Çakır',4,1,4,1,'drIrem','123')
insert into Doktor values('Recep Can',5,4,3,1,'drRecep','123')
insert into Doktor values('Ramazan Keskin',6,1,4,1,'drRamazan','123')
insert into Doktor values('Salih Koç',7,1,5,1,'drSalih','123')
insert into Doktor values('Cemal Şimşek',7,1,5,1,'drCemal','123')
insert into Doktor values('Abuzer Kadayıf',8,1,2,1,'drabuzer','123')
insert into Doktor values('Ahmet Mehmet',4,1,1,1,'drahmet','123')





insert into Hasta values('Adem','Çelik',12312344242,'İstanbul Bahçelievler','1996','222 22 222','a',1,'sa',123)

insert into Eczaci values(1,'e',123)

select * from Doktor
select * from Poliklinik
select * from Hastane
select * from Departman
select * from Hasta
select * from Recete
select * from Eczaci
select * from HastaneDepartman
select * from Poliklinik
select * from Randevu




select Ilaclar from Recete where HastaID=(select HastaID from Hasta where Ad='Adem')

insert into Recete values(1,4,'Aspirin')


select * from Doktor where DepartmanID=(select DepartmanID from Departman where DepartmanAdi='NÖROLOJİ')
insert into Randevu values(1,1,1,1,1,0,'2019-10-15 16:00')

select getdate()

insert into HastaneDepartman values (1,1)
insert into HastaneDepartman values (1,2)
insert into HastaneDepartman values (1,3)
insert into HastaneDepartman values (1,4)
insert into HastaneDepartman values (1,5)
insert into HastaneDepartman values (2,3)
insert into HastaneDepartman values (2,4)
insert into HastaneDepartman values (2,5)
insert into HastaneDepartman values (2,6)
insert into HastaneDepartman values (2,7)
insert into HastaneDepartman values (3,4)
insert into HastaneDepartman values (3,5)
insert into HastaneDepartman values (3,6)
insert into HastaneDepartman values (3,7)
insert into HastaneDepartman values (3,8)
insert into HastaneDepartman values (4,1)
insert into HastaneDepartman values (4,3)
insert into HastaneDepartman values (4,5)
insert into HastaneDepartman values (4,7)
insert into HastaneDepartman values (5,7)
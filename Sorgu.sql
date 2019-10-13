
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

insert into Doktor values('Ahmet Yılmaz',1,1,'doktor','123',1)
insert into Doktor values('Yeşim Avcı',2,1,'drYesim','123',1)
insert into Doktor values('	Ramazan ﻿Acar',3,1,'drRamazan','123',2)
insert into Doktor values('Irem Çakır',4,1,'drIrem','123',3)
insert into Doktor values('Recep Can',5,1,'drRecep','123',4)
insert into Doktor values('Ramazan Keskin',6,1,'drRamazan','123',4)
insert into Doktor values('Salih Koç',7,1,'drSalih','123',4)
insert into Doktor values('Cemal Şimşek',7,1,'drCemal','123',5)

insert into Hasta values('Adem','Çelik',12312344242,'İstanbul Bahçelievler','1996','222 22 222','ademcelik@mail.com',1,'sa',123)



select * from Doktor
select * from Departman
select * from Hastane
select * from Hasta
select * from Poliklinik


select * from Doktor where DepartmanID=(select DepartmanID from Departman where DepartmanAdi='Dahiliye')


insert into Poliklinik values('Poliklinik-1',1)
insert into Poliklinik values('Poliklinik-2',1)
insert into Poliklinik values('Poliklinik-3',3)






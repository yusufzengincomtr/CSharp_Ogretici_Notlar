create database milyoner
use milyoner
create table soru(s_no int primary key identity (1,1),
s1 varchar(150),
asýk varchar(50),
bsýk varchar(50),
csýk varchar(50),
dsýk varchar(50),
cevap varchar(50))

insert into soru values('Aþagýdakilerden Hangisi Atatürkün Doðum Tarihidir','1881','1938','1947','1981','1881')
insert into soru values('Gezmek, tanýmak, görmek dinlenmek amacýyla geziye çýkan kimselere ne ad verilir?','Cerrah','Meddah','Seyyah','Cinnah','Seyyah')
insert into soru values('Aþagýdakilerden Hangisi Atatürkün Ölüm Tarihidir','1988','1938','1947','1981','1938')
insert into soru values('Her yýl "Sivrisinek Festivali" düzenlenen þehir hangisidir?','Türkiye','Polonya','Rusya','Yeni Zelanda','Rusya')
insert into soru values('Osmanlý Devletinin ilk altýn sikkesi olan "sultani" hangi padiþah zamanýnda basýlmýþtýr?','Yavuz Sultan Selim','II.Bayezid','Kanuni Sultan Süleyman','II.Mehmed','II.Mehmed')
insert into soru values('Hangi dizi karakteri insanlarýn anlayacaðý dilde konuþabilmektedir','"Alf" dizisinde Alf','"Çarli dizisinde Çarli"','"Tatlý Kaçaklar dizisinde Cango"','"Lassie" dizisinde Lassie','"Alf" dizisinde Alf')
drop table soru
select*from soru
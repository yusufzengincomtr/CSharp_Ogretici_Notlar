create database milyoner
use milyoner
create table soru(s_no int primary key identity (1,1),
s1 varchar(150),
as�k varchar(50),
bs�k varchar(50),
cs�k varchar(50),
ds�k varchar(50),
cevap varchar(50))

insert into soru values('A�ag�dakilerden Hangisi Atat�rk�n Do�um Tarihidir','1881','1938','1947','1981','1881')
insert into soru values('Gezmek, tan�mak, g�rmek dinlenmek amac�yla geziye ��kan kimselere ne ad verilir?','Cerrah','Meddah','Seyyah','Cinnah','Seyyah')
insert into soru values('A�ag�dakilerden Hangisi Atat�rk�n �l�m Tarihidir','1988','1938','1947','1981','1938')
insert into soru values('Her y�l "Sivrisinek Festivali" d�zenlenen �ehir hangisidir?','T�rkiye','Polonya','Rusya','Yeni Zelanda','Rusya')
insert into soru values('Osmanl� Devletinin ilk alt�n sikkesi olan "sultani" hangi padi�ah zaman�nda bas�lm��t�r?','Yavuz Sultan Selim','II.Bayezid','Kanuni Sultan S�leyman','II.Mehmed','II.Mehmed')
insert into soru values('Hangi dizi karakteri insanlar�n anlayaca�� dilde konu�abilmektedir','"Alf" dizisinde Alf','"�arli dizisinde �arli"','"Tatl� Ka�aklar dizisinde Cango"','"Lassie" dizisinde Lassie','"Alf" dizisinde Alf')
drop table soru
select*from soru
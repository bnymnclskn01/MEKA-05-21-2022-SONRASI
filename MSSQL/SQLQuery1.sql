/*
Character(n) = Metin tipinde n ile belirtilen sayı kadar karekter depolar. n ile belirtilenden az karekter girilse bile n kadar değer yer kullanır.
VARCHAR(n) or (CHARACTER VARYING(n)) En fazla n ile belirtilen kadar karekter kadar yer toplar en az karakter girilse bile n kadar yer kullanır
BINARY(n)= Metinsel olarak Binary değerleri n ile belirtilen kadar deopolar ve aynı şekilde belirtilenden az n bile olsa n kadar yer kaplar.
BOOLEAN = TRUE FALSE ya var ya yok
VARBINARY(n) or BINARY VARYING(n) = Metinsel olarak Binary değerleri n ile belirtilen kadar deopolar ve aynı şekilde belirtilenden az n bile olsa n kadar yer kaplar.
INTEGER = Tam sayı verileri tutmak için kullanılır.
SMALLINT = Küçük tam sayılar için
TINYINT = Mini Tam sayılar için kullanılır.
BIGINT = Büyük tam sayılar için kullanılır (Genellikle SGK NO TCKN) verileri bu veri tipinde tutulur.
DECIMAL(p,s) = Virgüllü sayılar için kullanılır (Genellikle Para) verisi olarak kullanılır.
NUMERIC(p,s) = Decimal ile aynı görevleri üstlenir.
FLOAT = Genellikle (Harita Koordinatları için kullanılır.) Virgüllü sayılar içinde tercih edilir.
DATE = 14/02/2022
TIME = 06:15:231
XML= XML tipinde veri tutar.
DATETIME= 14/02/2022 05:15:202


VERITABANI MODELLERI = MSSQL MYSQL POSTSQL ORACLE MARIADB IBMDB
*/
use Deneme
/*Select * From UserMember
Select Name, Surname From UserMember
Select DISTINCT Name, Surname From UserMember
Select Name, Surname From UserMember Where Name='Bünyamin'
Select Name, Surname From UserMember Where ID=7
SELECT * FROM UserMember WHERE UserAddress='Beykoz' AND Name='Metin'
SELECT * FROM UserMember WHERE UserAddress='Beykoz' OR Name='Metin'
SELECT * FROM UserMember ORDER BY ID DESC
SELECT * FROM UserMember ORDER BY ID ASC
Create Table Books(
ID int primary key identity(1,1),
Name nvarchar(110),
BooksDescription nvarchar(500),
PageNumber int,
CreateDate Date,
AuthorName nvarchar(70),
Publisher nvarchar(70),
BookType nvarchar(70)
)
insert into UserMember (Name,Surname,Email,UPassword,UserAddress) values('Ömer','Polat','omer.polat@gmail.com','123456','Gaziosmanpaşa')
Update UserMember Set UserAddress='Beyoğlu' where UserAddress='Gaziosmanpaşa'
Delete From UserMember Where UserAddress='Bahçelievler'*/

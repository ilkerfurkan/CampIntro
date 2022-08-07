
select ContactName,CompanyName,City from Customers
-- Customers tablosundan contact,company,city bilgilerini gösterir.

Select * from Customers where City='Berlin'
-- şehri berlin olanları getirir.

-- case insensitive: büyük küçük harf duyarsızdır.

select * from Products where CategoryID=1 or CategoryID=3
-- kategorisi 1 veya 3 olanları getirir.

select * from Products where CategoryID=1 and UnitPrice>10
-- kategorisi 1 olan ve fiyatı 10'dan yüksek olan ürünleri getirir.

select * from Products order by ProductName
-- ada göre sıralar

select * from Products order by CategoryID,ProductName
-- kategoriye ve ada göre sıralar.

select * from Products order by UnitPrice -- asc: ascending: artan sıralama
select * from Products order by UnitPrice desc -- descending: azalan sıralama 

select * from Products where CategoryID=1 order by UnitPrice desc 
-- kategorisi 1 olanları azalan fiyata göre sıralar.

select count(*) from Products
-- tablodaki data sayısını verir. (satır sayısı)

select count(*) Adet from Products where CategoryID=2
-- kategori 2'deki veri sayısını verir. -- adet adı altında gösterir.

select CategoryID,count(*) adet from Products group by CategoryID
-- hangi kategoride kaç adet ürün olduğunu sorgular.
-- group by kullanıldığında select ettiğimiz kolon sadece group by'da ki alan olabilir. Veya kümülatif datalar olabilir "count (*)" gibi..

select CategoryID,count(*) adet from Products group by CategoryID having count(*)<10
-- 10 taneden az ürün çeşidi olanları verir.
-- kümülatif datayı sorgulayacağımız zaman "having" kullanırız.

select CategoryID,count(*) adet from Products where UnitsInStock>20 group by CategoryID having count(*)<10
-- stoğu 20den fazla olan ürünleri CategoryId'ye göre grupla ve sayısı 10dan az olanları göster.

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
-- products tablosundaki categoryId ile categories tablosundaki categoryId'yi eşleştirerek kategorinin adına ulaşırız.
-- DTO: Data Transformation Object

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


-- inner join: sadece iki tabloda eşleşenleri bir araya getirir. Eşleşmeyen datayı getirmez.
-- left join: solda olup sağda olmayanları da getir.
-- right join: sağda olup solda olmayanları getirir.
select * 
from Products p left join [Order Details] od -- tablo adı ayrı olduğu için köşeli parantez kullanıldı.
on p.ProductID = od.ProductID


select * 
from Customers C left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null 
-- hiç ürün almayan müşterileri bulur. (örneğin bir e-ticaret sitesinde "ilk siparişimize özel kampanya vb olması")

select * 
from Orders o right join Customers C
on o.CustomerID = c.CustomerID
where o.CustomerID is null 



select * 
from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
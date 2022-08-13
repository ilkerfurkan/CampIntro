
select distinct Country from Customers
-- Country sütunundaki farklı değerleri getirir.

SELECT COUNT(DISTINCT Country) FROM Customers;
-- Country sütununda kaç farklı değer olduğunu gösterir.

SELECT * FROM Customers WHERE Country='Germany' AND (City='Berlin' OR City='München');
-- Ülkenin Almanya olduğu ve şehrin Berlin veya Münih olduğu kayıtları getirir.

SELECT * FROM Customers WHERE NOT Country='Germany' AND NOT Country='USA';
-- Ülkesi Almanya ve USA olmayan kayıtları getirir.

INSERT INTO Customers (CompanyName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');
-- müşteriler tablosuna yeni bir kayıt ekler

SELECT CompanyName, ContactName, Address FROM Customers WHERE Address IS NOT NULL;
-- Müşteriler tablosunda Adresi boş olmayanları getirir.

UPDATE Customers SET ContactName='Juan' WHERE Country='Mexico';
-- Ülkesi Meksika olanların iletişim adını Juan olarak değiştirir.

DELETE FROM table_name;
-- Tablodaki verileri siler.

SELECT TOP 3 * FROM Customers;
-- Müşteriler tablosunun ilk 3 kaydını getirir.
SELECT TOP 50 PERCENT * FROM Customers;
-- Müşteriler tablosundaki kayıtların ilk %50'sini getirir.

SELECT MIN(UnitPrice) AS SmallestPrice FROM Products;
SELECT MAX(UnitPrice) AS LargestPrice FROM Products;
-- MSütunun en küçük ve en büyük değerleri.

SELECT COUNT(UnitPrice) FROM Products;
SELECT AVG(UnitPrice) FROM Products;
SELECT SUM(UnitPrice) FROM Products;
-- kayıt sayısı, ortalama, toplama formülleri.

SELECT * FROM Customers WHERE CompanyName LIKE 'a%';
-- Adı "A" ile başlayan kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName LIKE '%a';
-- Adı "A" ile biten kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName LIKE '%ar%';
-- Adının herhangi bir yerinde "ar" bulunan kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName LIKE '_r%';
-- Adının ikinci harfi "r" olan kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName LIKE 'a__%';
-- Adı "A" ile başlayan ve en az 3 karakter uzunluğunda olan kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName LIKE 'a%e';
-- Adı "A" ile başlayıp "E" ile biten kayıtları getirir.
SELECT * FROM Customers WHERE CompanyName NOT LIKE 'a%';
-- Adı "A" ile başlamayan kayıtları getirir.
SELECT * FROM Customers WHERE City LIKE 'L_n_on';
-- L ile başlayan, ardından herhangi bir karakter gelen, N ile devam eden, ardından herhangi bir karakter gelen, ardından ON gelen kayıtları getirir.
SELECT * FROM Customers WHERE City LIKE '[bsp]%';
-- B, S, P ile başlayan şehirleri seçer.
SELECT * FROM Customers WHERE City LIKE '[a-o]%';
-- A ve O aralığındaki harflerler başlayan şehirleri seçer.
SELECT * FROM Customers WHERE City NOT LIKE '[bsp]%';
-- B, S, P ile başlamayan şehirleri seçer.

SELECT * FROM Customers WHERE Country IN ('Germany', 'France', 'UK');
-- Almanya, Fransa ve UK'de bulunanları seçer.
SELECT * FROM Customers WHERE Country NOT IN ('Germany', 'France', 'UK');
-- Almanya, Fransa ve UK'de bulunmayanları seçer.
SELECT * FROM Customers WHERE Country IN (SELECT Country FROM Suppliers);
-- Tedarikçilerle aynı ülkeden gelen müşterileri seçer.

SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 20;
-- Fiyatı 10 ile 20 arasında olanları seçer.
SELECT * FROM Products WHERE UnitPrice NOT BETWEEN 10 AND 20;
-- Fiyatı 10 ile 20 arasında olmayanları seçer.
SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 20 AND CategoryID NOT IN (1,2,3);
-- Fiyatı 10 ile 20 arasında olanları ve Kategori ID'si 1,2,3 olmayanları seçer.
SELECT * FROM Orders WHERE OrderDate BETWEEN '1996-07-01' AND '1996-07-31';
-- Belirtilen tarih aralığındakileri seçer.

SELECT CustomerID AS ID, CompanyName AS Company FROM Customers;
-- CustomerID yerine ID, CompanyName yerine Company takma adını verir.
SELECT CompanyName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address FROM Customers;
-- Dört sütunu birleştiren "Address" adlı bir alias oluşturur.



-- PRACTICE
select p.ProductName [Ürün Adı], sum(od.UnitPrice * od.Quantity) [Kazanılan Toplam Miktar]
from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
group by p.ProductName

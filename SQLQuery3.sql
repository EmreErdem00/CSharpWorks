--Select
--SELECT * FROM Customers

SELECT ContactName Adi,CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers where City = 'London'

select count(*) hey from Products

select CategoryId, count(*) UrunSayisi from Products
group by CategoryID having count(*) <10

select products.ProductID, products.ProductName,
Products.UnitPrice, Categories.CategoryName
from products  inner join Categories 
on products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10 

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderId = od.OrderID


select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null



-- DTO Data Transformation object
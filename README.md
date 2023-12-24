1.
SELECT *
 FROM Manager
 WHERE Manager.Phone IS NULL
2.
SELECT SUM(CASE WHEN Sells.Date = '20/06/2021' THEN Sells.Count END) AS Count_SUM
  FROM [dbo].[Sells]
3.
SELECT AVG(Sells.Sum ) AS AVG_SUM
  FROM [dbo].[Sells]
  WHERE (SELECT Products.id FROM Products WHERE Products.Name = 'Фанера') = Sells.Id_Prod
4.
SELECT Manager.Fio,  SUM(Sells.Sum) AS SUM
 FROM Manager,Sells
 WHERE (SELECT Products.id FROM Products WHERE Products.Name = 'ОСБ') = Sells.Id_Prod AND
 (SELECT id_Manager FROM Products WHERE Products.Name = 'ОСБ') = Manager.id
 GROUP BY Manager.Fio
5.
SELECT Manager.Fio, Products.Name
 FROM Manager, Products
 WHERE (SELECT Sells.Id_Prod FROM Sells WHERE Sells.Date = '22/04/2021') = Products.id AND
 (SELECT Sells.id_Manager FROM Sells WHERE Sells.Date = '22/04/2021') = Manager.id
6.
SELECT * FROM Products
 WHERE Products.Name like '%Фанера%' AND 
 Products.Cost >= 1750
7.
SELECT *
FROM Sells,Products
WHERE Sells.Id_Prod = Products.id
GROUP BY dateadd(month, datediff(month, 0, Sells.Date),0) , Products.Name
8.
SELECT Products.Name,  COUNT(*)as order_count
FROM Products
GROUP BY Products.Name HAVING COUNT(*)> 1


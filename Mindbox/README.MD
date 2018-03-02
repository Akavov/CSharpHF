Test task for Mindbox

here is SQL part:

select a.Name 
from table1 a 
where 
exists (select * from table 2 where CustomerId = a.CustomerId and ProductName = 'Milk') 
and not exists( select * from table 2 where CustomerId = a.CustomerId and ProductName = 'Yogurt' and month(`PurchaseDateTime`) = month(now()) 
and year(`PurchaseDateTime`) = year(now()))
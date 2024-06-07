SELECT p.Title, c.Title from Products p
    LEFT JOIN ProductsCategories pc on pc.ProductId = p.Id
    LEFT JOIN Categories c on c.Id = pc.CategoryId
﻿using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 50, UnitsInStock = 20 };

//PascalCase      camelCase                 //Ayrıca c# büyük-küçük harf duyarlıdır, buna "case sensitive" denir.
ProductManager productManager = new ProductManager();
productManager.Add(product1);
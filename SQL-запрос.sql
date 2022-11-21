CREATE TABLE Product (
	id INT IDENTITY (1,1) NOT NULL,
	product NCHAR(100)
  PRIMARY KEY(id)
)

CREATE TABLE Category
(
	id INT IDENTITY (1,1) NOT NULL,
	category NCHAR(100)
  PRIMARY KEY(id)
)

CREATE TABLE ProductCategory
(
	prod_id INT NOT NULL FOREIGN KEY REFERENCES Product(id),
	cat_id INT NOT NULL FOREIGN KEY REFERENCES Category(id),
	PRIMARY KEY (prod_id, cat_id)
)


select p.product, c.category
from Product p
left join ProductCategory pc
on p.id = pc.prod_id
left join Category c
on pc.cat_id = c.id

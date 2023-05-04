CREATE table categories 
(
id integer,
category_name varchar(32)
);

CREATE table products (
id integer,
product_name varchar(32)
);

CREATE table relations (
product_Id integer,
category_id varchar(32)
);

INSERT into categories (id, category_name) 
VALUES(1, '�������');
INSERT into categories (id, category_name) 
VALUES(2, '����');
INSERT into categories (id, category_name) 
VALUES(3, '�����');
INSERT into categories (id, category_name) 
VALUES(4, '������');

INSERT into products (id, product_name) 
VALUES(1, '������');
INSERT into products (id, product_name) 
VALUES(2, '�����');
INSERT into products (id, product_name) 
VALUES(3, '�������');
INSERT into products (id, product_name) 
VALUES(4, '��������');
INSERT into products (id, product_name) 
VALUES(5, '������');
INSERT into products (id, product_name) 
VALUES(6, '������');
INSERT into products (id, product_name) 
VALUES(7, '�������');
INSERT into products (Id, product_name) 
VALUES(8, '������� ����');


INSERT into relations (product_Id, category_id) 
VALUES(1, 1);
INSERT into relations (product_Id, category_id) 
VALUES(2, 1);
INSERT into relations (product_Id, category_id) 
VALUES(3, 2);
INSERT into relations (product_Id, category_id) 
VALUES(4, 2);
INSERT into relations (product_Id, category_id) 
VALUES(5, 4);
INSERT into relations (product_Id, category_id) 
VALUES(6, 3);
INSERT into relations (product_Id, category_id) 
VALUES(7, 3);

select p.product_name, c.category_name
	from products p
left join relations r on r.product_Id = p.id
left join  categories c on c.id = r.category_id
order by p.product_name
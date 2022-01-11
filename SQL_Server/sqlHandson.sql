select * from salesman
select * from orders
select * from customer
--1. Write a SQL statement to display all the information of all salesmen
select * from salesman
--2. Write a SQL statement to display specific columns like name and commission for all the salesmen
select Name,Commission from salesman
--3. Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders
select ord_date, salesman_id, ord_no, purch_amt from orders
--4. write a SQL query to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city.
select Name, city from salesman where city = 'Paris'
--5. write a SQL query to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id
select * from customer where grade = 200
--6. write a SQL query to find the orders, which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt
select ord_no, ord_date, purch_amt from orders where salesman_id = 5001

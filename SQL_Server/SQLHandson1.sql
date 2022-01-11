select * from salesman
select * from orders
select * from customer 
--1.Write a SQL statement to display all the information of all salesmen

select * from Salesman

--2.Write a SQL statement to display specific columns like name and commission for all the salesmen

select name,commission from Salesman

--3.Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders

select ord_date,salesman_id,ord_no,purch_amt from Orders

--4.Write a SQL query to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city.

select name,city from Salesman where city='Paris'

--5.Write a SQL query to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id

select customer_id,cust_name,city,grade,salesman_id from Customer where grade < 200

--6.Write a SQL query to find the orders, which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt

select ord_no, ord_date, purch_amt from Orders where salesman_id = 5001

--7.Write a SQL query to calculate average purchase amount of all orders. Return average purchase amount. 

select AVG(purch_amt) as avg_purchase_amt from Orders

--8.Write a SQL query to count the number of unique salespeople. Return number of salespeople.  

select count(salesman_id) as number_of_salesman from Salesman 

--9.Write a SQL query to count the number of customers. Return number of customers.

select count(customer_id) as number_of_customers from Customer 

--10.Write a SQL query to find the maximum purchase amount

select max(purch_amt) as max_purch_amt from Orders

--11.Write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade.

select city,max(grade) as max_grade from Customer group by city

--12.Write a SQL query to find the highest purchase amount ordered by each customer. Return customer ID, maximum purchase amount

select customer_id,max(purch_amt) as max_purch_amt from Orders group by customer_id

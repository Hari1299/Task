 --1 query
select au_fname,au_lname from authors
 --2 nd query
select *from titles order by title desc
--3
select au_id,count(title_id) from titleauthor group by au_id
--4
select  * from authors
select au_fname,au_lname,title from authors,titles
--5
select *from titles
select pub_name,avg(advance) Average from titles,publishers group by pub_name
--6
select pub_name,au_fname,au_lname,title,qty*price as SaleAmount from authors,publishers p join titles t on
p.pub_id=t.pub_id 
join sales s on
t.title_id=s.title_id
--7
select price,title from titles where title like '%s'
--8
select title from titles where title like'%and%'
--9
select fname,lname,pub_name from employee join publishers
on 
employee.pub_id=publishers.pub_id
--10
select pub_name,count(fname) As No_of_Emp from publishers p join employee e on
p.pub_id=e.pub_id group by pub_name having count(fname)>2
--11
select au_fname from authors ,publishers where pub_name='Algodata Infosystems'
--12
select fname from publishers join employee on
publishers.pub_id=employee.pub_id where pub_name='Algodata Infosystems'





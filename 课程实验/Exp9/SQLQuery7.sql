create procedure exlt_sc 
as 
select a.st_id ,a.st_name,b.c_name,c.score
from st_info a,c_info b,s_c_info c 
where a.st_id=c.st_id and b.c_no=c.c_no and c.score>80
order by c.score desc

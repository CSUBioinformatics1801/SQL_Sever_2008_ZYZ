create procedure selectscore as  select a.st_id,a.st_name,b.C_name,c.score
from St_Info as a, c_info b,s_c_info c
where a.st_id=c.st_id and b.c_no=c.C_no and c.score>=90
order by c.score desc

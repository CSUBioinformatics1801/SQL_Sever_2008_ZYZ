create procedure stdDname @sname char(10) , @dname char(30)
as 
select @dname = D_name
from St_Info a join D_Info b on a.d_id=b.D_ID
where St_Name=@sname
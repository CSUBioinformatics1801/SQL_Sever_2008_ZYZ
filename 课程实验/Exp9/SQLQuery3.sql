select c_info.c_no,c_info.c_name,s_c_info.c_no,s_c_info.score
from c_info full outer join s_c_info
on c_info.c_no=s_c_info.c_no
order by c_info.c_no asc
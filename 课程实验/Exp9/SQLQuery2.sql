select a.c_name as 课程名称,MAX(b.score) as 最高分
from c_info a left outer join s_c_info b on a.c_no=b.c_no
group by a.c_name
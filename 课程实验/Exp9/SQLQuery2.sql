select a.c_name as �γ�����,MAX(b.score) as ��߷�
from c_info a left outer join s_c_info b on a.c_no=b.c_no
group by a.c_name
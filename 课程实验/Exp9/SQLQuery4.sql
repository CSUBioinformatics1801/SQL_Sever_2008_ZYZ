select a.st_id as ѧ��,a.st_name as ����,AVG(b.score) as ƽ���ɼ�
from st_info a inner join s_c_info b on a.st_id=b.st_id
inner join c_info c on b.c_no = c.c_no
group by a.St_name,a.st_id
having AVG(b.score)>60
order by a.st_id
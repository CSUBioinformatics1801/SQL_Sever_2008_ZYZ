create procedure stdCCnt @cnt int
as select a.St_ID as ѧ��, a.St_Name as ����,COUNT(*) as �γ�����
from St_Info a join S_C_Info b on a.St_ID=b.St_ID 
group by a.St_ID,a.St_Name
having count(*)=@cnt
execute stdccnt @cnt=4
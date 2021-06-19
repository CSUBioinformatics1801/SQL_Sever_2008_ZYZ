select st_id ,score 
from s_c_info
where c_no='9710011'
compute avg(score)
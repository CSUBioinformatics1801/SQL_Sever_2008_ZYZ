
select distinct a.*, b.* from s_c_info a left outer join 
st_info b on (a.st_id = b.st_id or a.score between 70 and 80)

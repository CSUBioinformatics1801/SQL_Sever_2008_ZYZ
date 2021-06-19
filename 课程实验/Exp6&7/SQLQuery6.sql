select distinct st_id,score as mark from s_c_info
where score>60 and score <100
order by mark desc
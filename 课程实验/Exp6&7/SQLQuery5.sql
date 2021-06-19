select st_id,St_name,st_sex,Cl_name, YEAR(getdate())-YEAR(birthdate) as age from st_info 
where YEAR(getdate())-YEAR(birthdate)<=all(select YEAR(getdate())-YEAR(birthdate) from st_info)
or
 YEAR(getdate())-YEAR(birthdate)>=all(select YEAR(getdate())-YEAR(birthdate) from st_info)
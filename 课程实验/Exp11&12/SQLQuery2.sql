create trigger tr_CheckDeptNo on d_info
for delete as 
begin
  declare @stid  varchar(10)
  select @stid=d_id from deleted
  if exists(select * from st_info where left(st_id,2)=@stid)
    begin 
      print'不得删除此院系记录，其下还有学生'
      rollback transaction 
    end
end  

delete from d_info    --删除测试
where d_name='材料科学与工程学院'
go
--结果成功
create trigger tr_CheckDeptNo on d_info
for delete as 
begin
  declare @stid  varchar(10)
  select @stid=d_id from deleted
  if exists(select * from st_info where left(st_id,2)=@stid)
    begin 
      print'����ɾ����Ժϵ��¼�����»���ѧ��'
      rollback transaction 
    end
end  

delete from d_info    --ɾ������
where d_name='���Ͽ�ѧ�빤��ѧԺ'
go
--����ɹ�
create trigger tr_CheckStID on  st_info
with encryption
for insert, update
as 
begin
  declare @stid varchar(10)
  select @stid=st_ID from inserted
  if not exists(select * from d_info where d_id = left (@stid,2))
    BEGIN
      print'����ѧ����Ч���޴�ѧԺ!'
      rollback transaction 
    end
end    
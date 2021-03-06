USE [student_db]
GO
/****** Object:  Trigger [dbo].[tr_CheckStIDandCNo]    Script Date: 04/25/2019 14:55:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tr_CheckStIDandCNo] on [dbo].[S_C_Info]
for insert
as 
begin
  declare @cid varchar(10),@stid varchar(10)
  select @cid=c_no from inserted
  if not exists(select * from c_info  where c_no =@cid)
    begin
      print 'invalid class number in our administration system, please check your typing'
      rollback transaction
    end 
  select @stid=st_id from inserted
  if not  exists(select * from st_info where st_id = @stid)
  begin 
    print 'invalid student ID number in our records, please check your typing again'
    rollback transaction 
  end
 end 

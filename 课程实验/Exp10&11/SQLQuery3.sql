USE [student_db]
GO

create procedure studentscore @stuID varchar(20)
as select a.St_name,b.C_no,b.c_name,C.score
from St_Info a , C_Info b ,S_C_Info c
where a.St_ID=c.St_ID and b.C_No=c.C_No and a.St_ID=@stuID
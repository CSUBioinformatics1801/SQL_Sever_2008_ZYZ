USE [student_db]
GO
/****** Object:  Trigger [dbo].[tr_AutoSetType]    Script Date: 04/25/2019 13:54:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[tr_AutoSetType] on [dbo].[C_Info]
for insert as update c_info set C_type='必修'
 select St_name as 学生姓名,AVG(score) as 平均成绩 from whole_view
group by St_name
order by AVG(score) asc

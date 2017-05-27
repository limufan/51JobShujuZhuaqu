select count(1) from dbo.job_zhiwei
where zhiwei_gongzuoDidian like '%成都%'

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%成都%' and 
zhiwei_zuigaoGongzi >= 12000
--and zhiwei_zuigaoGongzi <= 20000
and zhiwei_mingxi like '%吃%'
order by zhiwei_zuigaoGongzi desc


select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%重庆%'  
--and zhiwei_zuigaoGongzi >= 12000
and zhiwei_name like '%经理%'
--and zhiwei_zuigaoGongzi <= 20000
--and zhiwei_mingxi like '%吃%'
order by zhiwei_zuigaoGongzi desc

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where datediff(DAY, zhiwei_createdTime, GETDATE()) < 1
and zhiwei_gongzuoDidian like '%重庆%'
order by zhiwei_zuigaoGongzi desc


select *from job_zhiwei


select top 100 '<div><a target="_blank" href='+zhiwei_lianjie+'>' + zhiwei_name + '</a>', 'gs===' + zhiwei_gongsiName +'gz===', zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%重庆%' and 
zhiwei_zuigaoGongzi >= 12000
--and zhiwei_zuigaoGongzi <= 20000
--and zhiwei_mingxi like '%吃%'
order by zhiwei_zuigaoGongzi desc

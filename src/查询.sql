select count(1) from dbo.job_zhiwei
where zhiwei_gongzuoDidian like '%�ɶ�%'

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%�ɶ�%' and 
zhiwei_zuigaoGongzi >= 12000
--and zhiwei_zuigaoGongzi <= 20000
and zhiwei_mingxi like '%��%'
order by zhiwei_zuigaoGongzi desc


select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%����%'  
--and zhiwei_zuigaoGongzi >= 12000
and zhiwei_name like '%����%'
--and zhiwei_zuigaoGongzi <= 20000
--and zhiwei_mingxi like '%��%'
order by zhiwei_zuigaoGongzi desc

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where datediff(DAY, zhiwei_createdTime, GETDATE()) < 1
and zhiwei_gongzuoDidian like '%����%'
order by zhiwei_zuigaoGongzi desc


select *from job_zhiwei


select top 100 '<div><a target="_blank" href='+zhiwei_lianjie+'>' + zhiwei_name + '</a>', 'gs===' + zhiwei_gongsiName +'gz===', zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%����%' and 
zhiwei_zuigaoGongzi >= 12000
--and zhiwei_zuigaoGongzi <= 20000
--and zhiwei_mingxi like '%��%'
order by zhiwei_zuigaoGongzi desc

select count(1) from dbo.job_zhiwei
where zhiwei_gongzuoDidian like '%��ɽ%'

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where 
zhiwei_gongzuoDidian like '%����%' and 
zhiwei_zuigaoGongzi >= 12000
and zhiwei_zuigaoGongzi <= 20000
--and zhiwei_mingxi like '%��%ס%'
order by zhiwei_zuigaoGongzi desc

select top 100 zhiwei_name, zhiwei_gongsiName, zhiwei_zuigaoGongzi, zhiwei_gongzuoDidian, zhiwei_lianjie 
from dbo.job_zhiwei
where day(zhiwei_createdTime) = day(GETDATE())
order by zhiwei_zuigaoGongzi desc



--使用数据库
use DormManageDB
go

--*****************************用户表*****************************--
----修改User表名
--EXEC sp_rename  'User', 'UserInfo'

--查询用户表(登录)
select * from UserInfo where Account='admin' and PassWord='123456'
--*****************************用户表*****************************--

--*****************************一级部门表*****************************--
--StairName	IsEnable

--添加一条数据
insert into Department values ('供应链中心',1)

--查询数据
select * from Department

--根据id获取一条数据
select * from Department where Id=1

--编辑一条数据
update Department set StairName='供应链中心',IsEnable=1 where Id=1

--删除一条数据
delete from Department where Id=8
--*****************************一级部门表*****************************--

--*****************************二级部门表*****************************--
--SecondName 部门名称
--ParentId 父id
--IsEnable 是否启用

select Id,StairName from Department

--添加一条数据
insert into Station values ('才艺中心',1,1)

--查询数据
select a.* ,b.StairName from Station  a join Department b on a.ParentId=b.Id

--根据id获取一条数据
select * from Station where Id=1

--编辑一条数据
update Station set SecondName='唱歌中心',ParentId=2,IsEnable=0 where Id=4

--删除一条数据
delete from Station where Id=4
--*****************************二级部门表*****************************--

--*****************************员工信息*****************************--
--Id				主键id
--Name				姓名
--Sex				性别
--TypeId			类型id
--EmpNo				工号
--DepartmentId		一级部门
--StationId			二级部门
--IDCard			是否提供身份证
--Mobile			手机号
--EmergencyName		紧急联系人
--EmergencyMobile	紧急联系人手机号
--EntryTime			入职日期
--IsResidence		居住证办理情况
--IsEnable			是否启用


--绑定一级部门
select Id,StairName from Department

--绑定二级部门
select Id,SecondName from Station

--添加一条数据
insert into Staff values ('李四',1,1,'222000',1,1,1,'15269696969','王文武','14525252525','2022-9-9',1,2)

select * from Staff
--查询数据
select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1 

--根据id获取一条数据
select a.*,b.StairName,c.SecondName  from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id=2

--编辑一条数据
update Staff set Name='李四',Sex=2,TypeId=2,EmpNo='555666',DepartmentId=2,StationId=2,IDCard=2,EmergencyName='赵六',EmergencyMobile='13232323232',EntryTime='2023-01-15',IsResidence=1,IsEnable=2  where Id=1

--删除一条数据
delete from Staff where Id=1
--*****************************员工信息*****************************--

--*****************************宿舍维护*****************************--
--DormitoryNo		宿舍号
--IsEnable			是否启用

--添加一条数据
insert into Dormitory values ('5205',1)

--查询数据
select * from Dormitory

--根据id获取一条数据
select * from Dormitory where Id=1

--编辑一条数据
update Dormitory set DormitoryNo='5202',IsEnable=0 where Id=1

--删除一条数据
delete from Dormitory where Id=6
--*****************************宿舍维护*****************************--

--*****************************床位维护*****************************--
--BunkNo			床位号		
--DormitoryId		宿舍号
--IsEnable			是否启用

--绑定宿舍
select Id,DormitoryNo from Dormitory

--添加一条数据
insert into Bunk values (5,1,1)

--查询数据
select a.*,b.DormitoryNo from Bunk a join Dormitory b on a.DormitoryId=b.Id where 1=1

--根据id获取一条数据
select * from Bunk where Id=1

--编辑一条数据
update Bunk set BunkNo=5,DormitoryId=2,IsEnable=1 where Id=1

--删除一条数据
delete from Bunk where Id=41

--*****************************床位维护*****************************--

--*****************************入住管理*****************************--
--Id			主键id
--StaffId		员工id		
--Money			住宿金额
--Treaty		是否签订宿舍安全条约
--Access		是否开通门禁权限
--TowerParent	是否楼长
--DormParent	是否宿舍长
--CheckInTime	入住时间
--DormitoryId	宿舍id
--BunkId		床位id
--IsEnable		是否入住

--根据姓名查询人员表（返添）
select * from Staff where Name='李四'

--下拉框
--员工姓名
select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1

select * from Staff
select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id in(select StaffId from StaffCheckIn where StaffCheckIn.IsEnable=1)

select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id not in(select StaffId from StaffCheckIn)

--宿舍
select Id,DormitoryNo from Dormitory

--床位
select * from Bunk where DormitoryId=1

--添加一条数据
insert into StaffCheckIn values(500,1,1,1,1,1,'2023-1-15',1,1,1)

select* from StaffCheckIn
--查询
select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.EmergencyMobile,b.EmergencyName,b.EmpNo,b.EntryTime,b.IDCard,b.IsResidence,b.Mobile,b.Name,b.Sex,b.TypeId,c.DormitoryNo,d.BunkNo from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where 1=1

--根据id获取一条数据
select * from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where a.Id=17

select t1.*,t2.Name,t2.EmpNo,t2.Sex,t2.TypeId,t2.Mobile,t2.EmergencyName,t2.EmergencyMobile,t3.StairName,t4.SecondName,t5.BunkNo from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id join Bunk t5 on t1.BunkId=t5.Id where t1.Id=18


--编辑一条数据
update StaffCheckIn set StaffId=2,Money=200,Treaty=0,Access=0,TowerParent=0,DormParent=1,CheckInTime='2023-1-11',DormitoryId=2,BunkId=2,IsEnable=0 where Id=4

--删除一条数据
delete from StaffCheckIn where Id=4


--*****************************入住管理*****************************--

--*****************************住宿扣款*****************************--
--查询显示住宿扣款信息

select ROW_NUMBER()over(order by a.Id)rowId, a.Id,a.Name,a.Sex,a.TypeId,a.EmpNo,a.EntryTime,b.StairName,c.SecondName,d.CheckInTime,d.Money from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0


select count(*) from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0

--*****************************住宿扣款*****************************--

--*****************************退宿管理*****************************--
--StaffStayOut
--Id		主键id
--StaffId	员工id
--CheckInId	入住id
--StayOutTime	退宿时间
--Deduction	扣款金额

select  ROW_Number() over(order by A.Id) as rowId,A.Id,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 

--获取员工信息
select a.*,b.StairName,c.SecondName,d.Id as CheckInId,d.Treaty,d.Access,d.TowerParent,d.DormParent from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id not in(select StaffId from StaffStayOut)

--根据姓名返添信息
select a.*,b.StairName,c.SecondName,d.CheckInTime,d.TowerParent,d.DormParent,d.Treaty,d.Access from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id='{id}'

go
----*****************************退宿管理*****************************--


----*****************************住宿统计*****************************--
alter proc p_queryroomandbed
as
begin
	--删除前次统计的宿舍明细数据
	truncate table DormitoryDetail

	--定义两个变量就收游标遍历后的结果
	declare @tmpDormitoryNo nvarchar(50)--宿舍号
	declare @tmpDormitoryType char(1)--宿舍类型

	--deallocate cursor_dormitorydetail	--删除游标
	--声明游标
	declare cursor_dormitorydetail cursor for 
		select DormitoryNo,DormitoryType from Dormitory where IsEnable=1

	-- 打开游标
	open cursor_dormitorydetail

	--执行游标 NEXT    PRIOR  FIRST   LAST
	fetch next from cursor_dormitorydetail into @tmpDormitoryNo,@tmpDormitoryType

	while(@@FETCH_STATUS=0)
		begin
			--declare 声明
			--男女生宿舍标识
			declare @flagManAndWoMen char(1)
			set @flagManAndWoMen=Null;
			select @flagManAndWoMen=DormitoryType from Dormitory where DormitoryNo=@tmpDormitoryNo
						
			-- 1号床位住宿人员姓名
			declare @tmpName1 varchar(50)
			set @tmpName1 = Null;
			select @tmpName1=(t2.Name+'/'+convert(nvarchar(20),t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo = 1 and t3.DormitoryNo = @tmpDormitoryNo

			-- 2号床位住宿人员姓名
			declare @tmpName2 varchar(50)
			set @tmpName2 = Null;
			select @tmpName2 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =2 and t3.DormitoryNo = @tmpDormitoryNo

			-- 3号床位住宿人员姓名
			declare @tmpName3 varchar(50)
			set @tmpName3 = Null;
			select @tmpName3 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =3 and t3.DormitoryNo = @tmpDormitoryNo

			-- 4号床位住宿人员姓名
			declare @tmpName4 varchar(50)
			set @tmpName4 = Null;
			select @tmpName4 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =4 and t3.DormitoryNo = @tmpDormitoryNo
			
			-- 5号床位住宿人员姓名
			declare @tmpName5 varchar(50)
			set @tmpName5 = Null;
			select @tmpName5 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =5 and t3.DormitoryNo = @tmpDormitoryNo
						
			-- 6号床位住宿人员姓名
			declare @tmpName6 varchar(50)
			set @tmpName6 = Null;
			select @tmpName6 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =6 and t3.DormitoryNo = @tmpDormitoryNo
						
			-- 7号床位住宿人员姓名
			declare @tmpName7 varchar(50)
			set @tmpName7 = Null;
			select @tmpName7 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =7 and t3.DormitoryNo = @tmpDormitoryNo
									
			-- 8号床位住宿人员姓名
			declare @tmpName8 varchar(50)
			set @tmpName8 = Null;
			select @tmpName8 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =8 and t3.DormitoryNo = @tmpDormitoryNo

			-- 9号床位住宿人员姓名
			declare @tmpName9 varchar(50)
			set @tmpName9 = Null;
			select @tmpName9 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =9 and t3.DormitoryNo = @tmpDormitoryNo
			
			-- 10号床位住宿人员姓名
			declare @tmpName10 varchar(50)
			set @tmpName10 = Null;
			select @tmpName10 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =10 and t3.DormitoryNo = @tmpDormitoryNo

			--房间总人数
			declare @tmproomcount varchar(50)
			set @tmproomcount=null;
			select @tmproomcount=COUNT( 1 )from StaffCheckIn tA 
			join Dormitory tB on tA.DormitoryId=tB.Id 
			where tA.IsEnable=1 and tB.DormitoryNo=@tmpDormitoryNo

			--本周入住人数
			declare @tmpweekcheckinnum varchar(50)
			set @tmpweekcheckinnum=Null;
			select @tmpweekcheckinnum=COUNT(1) from StaffCheckIn t1 
			join Dormitory t2 on t1.DormitoryId=t2.Id
			where  t1.IsEnable=1 
			and t2.DormitoryNo=@tmpDormitoryNo 
			and t1.CheckInTime>=CONVERT(nvarchar(10),DATEADD(wk,DATEDIFF(wk,0,DATEADD(DD,-1,getdate())),0),121) 
			and t1.CheckInTime<=(select CONVERT(nvarchar(10),DATEADD(wk, DATEDIFF(wk,0, DATEADD(dd,-1,getdate())),6),121))

			--本周退宿人数
			declare @tmpweekcheckoutnum varchar(50)
			set @tmpweekcheckoutnum =Null;
			select @tmpweekcheckoutnum=COUNT(1) from StaffStayOut t1
			join StaffCheckIn t2 on t1.CheckInId = t2.Id 
			join Dormitory t3 on t2.DormitoryId = t3.id
			where t2.isEnable=0 
			and t3.DormitoryNo = @tmpDormitoryNo 
			and t1.StayOutTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121) 
			and t1.StayOutTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) 

			--宿舍长
			declare @tmpDormParentName nvarchar(50)
			set @tmpDormParentName = Null;
			select @tmpDormParentName=t2.Name from StaffCheckIn t1
			join Staff t2 on t1.StaffId = t2.Id
			join Dormitory t3 on t1.DormitoryId = t3.id
			where t1.DormParent=1 and t1.IsEnable=1
			and t3.DormitoryNo = @tmpDormitoryNo 

			--空余床位
			declare @tmpNullBedCount nvarchar(50)
			select @tmpNullBedCount=(8-@tmproomcount);

			insert into  DormitoryDetail
			(DormitoryNum,Bed1,Bed2,Bed3,Bed4,Bed5,Bed6,Bed7,Bed8,Bed9,Bed10,TotalPerson,WeekCheckIn,WeekCheckOut,DormitoryManager,FreeBedNum,FlagManAndWoMen)
			values(@tmpDormitoryNo,@tmpName1,@tmpName2,@tmpName3,@tmpName4,
			@tmpName5,@tmpName6,@tmpName7,@tmpName8,@tmpName9,@tmpName10,@tmproomcount,@tmpweekcheckinnum,@tmpweekcheckoutnum,@tmpDormParentName,@tmpNullBedCount,@flagManAndWoMen)

			--执行游标（这里是游标遍历取值） NEXT    PRIOR  FIRST   LAST
			fetch next from cursor_dormitorydetail into @tmpDormitoryNo,@tmpDormitoryType

		end

	--关闭游标
	close cursor_dormitorydetail
	--释放游标
	deallocate cursor_dormitorydetail

	--查询宿舍明细
	 select * from DormitoryDetail

end
go

exec p_queryroomandbed
go

ALTER proc [dbo].[p_totalRoom]
as
begin
	
	select 
	-- 全部入住人数
	(select count(1) from StaffCheckIn  where IsEnable=1)  as totalperson
	--入住男生人数
	, (select count(1) from StaffCheckIn t1 join Staff t2 on t1.StaffId = t2.Id  where t1.IsEnable=1 and t2.sex=1)  as totalman
	--入住女生人数
	, (select count(1) from StaffCheckIn t1 join Staff t2 on t1.StaffId = t2.Id  where t1.IsEnable=1 and t2.sex=0 ) as totalwoman
	,('男生（501-603） 女生（604-617）共32间') as roomnum
	,('女14间（112）人  男18间（144）') as bednum

end

exec p_totalRoom
go
----*****************************住宿统计*****************************--


----*****************************汇总统计*****************************--
ALTER proc [dbo].[p_TotalBormitorys]
as 
begin
	select '男生入住(8/房间)' as dormitory  --宿舍
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id where DormitoryType='1') bed	--床位
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1')-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1') as Checkin  --入住
	,	((select count(1) from Staff where Sex = '1')-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1'))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1') as surplus  --剩余
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1'	and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) 	and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck  --入住
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1' and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121)) Stayout --退宿

	union all 
	
	select '女生入住(8/房间)' as dormitory --宿舍 
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id where DormitoryType='0') as bed  --床位
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0')-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0') as Checkin  --入住
	,((select count(1) from Staff where Sex = '0')-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0'))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0') as surplus  --剩余
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0'and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck  --入住
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0' and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))Stayout   --退宿
	
	union all 
	
	select '合计人数(人)' as dormitory --宿舍 
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id  ) as bed  --床位
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id )-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id ) as Checkin --入住
	,((select count(1) from Staff )-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id ) as surplus --剩余
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck --入住
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))Stayout --退宿

	    select CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121) ks

	SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121) js

end


exec p_TotalBormitorys

----*****************************汇总统计*****************************--

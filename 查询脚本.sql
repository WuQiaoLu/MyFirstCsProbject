--ʹ�����ݿ�
use DormManageDB
go

--*****************************�û���*****************************--
----�޸�User����
--EXEC sp_rename  'User', 'UserInfo'

--��ѯ�û���(��¼)
select * from UserInfo where Account='admin' and PassWord='123456'
--*****************************�û���*****************************--

--*****************************һ�����ű�*****************************--
--StairName	IsEnable

--���һ������
insert into Department values ('��Ӧ������',1)

--��ѯ����
select * from Department

--����id��ȡһ������
select * from Department where Id=1

--�༭һ������
update Department set StairName='��Ӧ������',IsEnable=1 where Id=1

--ɾ��һ������
delete from Department where Id=8
--*****************************һ�����ű�*****************************--

--*****************************�������ű�*****************************--
--SecondName ��������
--ParentId ��id
--IsEnable �Ƿ�����

select Id,StairName from Department

--���һ������
insert into Station values ('��������',1,1)

--��ѯ����
select a.* ,b.StairName from Station  a join Department b on a.ParentId=b.Id

--����id��ȡһ������
select * from Station where Id=1

--�༭һ������
update Station set SecondName='��������',ParentId=2,IsEnable=0 where Id=4

--ɾ��һ������
delete from Station where Id=4
--*****************************�������ű�*****************************--

--*****************************Ա����Ϣ*****************************--
--Id				����id
--Name				����
--Sex				�Ա�
--TypeId			����id
--EmpNo				����
--DepartmentId		һ������
--StationId			��������
--IDCard			�Ƿ��ṩ���֤
--Mobile			�ֻ���
--EmergencyName		������ϵ��
--EmergencyMobile	������ϵ���ֻ���
--EntryTime			��ְ����
--IsResidence		��ס֤�������
--IsEnable			�Ƿ�����


--��һ������
select Id,StairName from Department

--�󶨶�������
select Id,SecondName from Station

--���һ������
insert into Staff values ('����',1,1,'222000',1,1,1,'15269696969','������','14525252525','2022-9-9',1,2)

select * from Staff
--��ѯ����
select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1 

--����id��ȡһ������
select a.*,b.StairName,c.SecondName  from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id=2

--�༭һ������
update Staff set Name='����',Sex=2,TypeId=2,EmpNo='555666',DepartmentId=2,StationId=2,IDCard=2,EmergencyName='����',EmergencyMobile='13232323232',EntryTime='2023-01-15',IsResidence=1,IsEnable=2  where Id=1

--ɾ��һ������
delete from Staff where Id=1
--*****************************Ա����Ϣ*****************************--

--*****************************����ά��*****************************--
--DormitoryNo		�����
--IsEnable			�Ƿ�����

--���һ������
insert into Dormitory values ('5205',1)

--��ѯ����
select * from Dormitory

--����id��ȡһ������
select * from Dormitory where Id=1

--�༭һ������
update Dormitory set DormitoryNo='5202',IsEnable=0 where Id=1

--ɾ��һ������
delete from Dormitory where Id=6
--*****************************����ά��*****************************--

--*****************************��λά��*****************************--
--BunkNo			��λ��		
--DormitoryId		�����
--IsEnable			�Ƿ�����

--������
select Id,DormitoryNo from Dormitory

--���һ������
insert into Bunk values (5,1,1)

--��ѯ����
select a.*,b.DormitoryNo from Bunk a join Dormitory b on a.DormitoryId=b.Id where 1=1

--����id��ȡһ������
select * from Bunk where Id=1

--�༭һ������
update Bunk set BunkNo=5,DormitoryId=2,IsEnable=1 where Id=1

--ɾ��һ������
delete from Bunk where Id=41

--*****************************��λά��*****************************--

--*****************************��ס����*****************************--
--Id			����id
--StaffId		Ա��id		
--Money			ס�޽��
--Treaty		�Ƿ�ǩ�����ᰲȫ��Լ
--Access		�Ƿ�ͨ�Ž�Ȩ��
--TowerParent	�Ƿ�¥��
--DormParent	�Ƿ����᳤
--CheckInTime	��סʱ��
--DormitoryId	����id
--BunkId		��λid
--IsEnable		�Ƿ���ס

--����������ѯ��Ա������
select * from Staff where Name='����'

--������
--Ա������
select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where 1=1

select * from Staff
select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id in(select StaffId from StaffCheckIn where StaffCheckIn.IsEnable=1)

select a.*,b.StairName,c.SecondName from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id where a.Id not in(select StaffId from StaffCheckIn)

--����
select Id,DormitoryNo from Dormitory

--��λ
select * from Bunk where DormitoryId=1

--���һ������
insert into StaffCheckIn values(500,1,1,1,1,1,'2023-1-15',1,1,1)

select* from StaffCheckIn
--��ѯ
select ROW_NUMBER() over(order by a.Id)as rowId,a.*,b.EmergencyMobile,b.EmergencyName,b.EmpNo,b.EntryTime,b.IDCard,b.IsResidence,b.Mobile,b.Name,b.Sex,b.TypeId,c.DormitoryNo,d.BunkNo from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where 1=1

--����id��ȡһ������
select * from StaffCheckIn a join Staff b on a.StaffId=b.Id join Dormitory c on a.DormitoryId=c.Id join Bunk d on a.BunkId=d.Id where a.Id=17

select t1.*,t2.Name,t2.EmpNo,t2.Sex,t2.TypeId,t2.Mobile,t2.EmergencyName,t2.EmergencyMobile,t3.StairName,t4.SecondName,t5.BunkNo from StaffCheckIn t1 join Staff t2 on t1.StaffId=t2.Id join Department t3 on t2.DepartmentId=t3.Id join Station t4 on t2.StationId=t4.Id join Bunk t5 on t1.BunkId=t5.Id where t1.Id=18


--�༭һ������
update StaffCheckIn set StaffId=2,Money=200,Treaty=0,Access=0,TowerParent=0,DormParent=1,CheckInTime='2023-1-11',DormitoryId=2,BunkId=2,IsEnable=0 where Id=4

--ɾ��һ������
delete from StaffCheckIn where Id=4


--*****************************��ס����*****************************--

--*****************************ס�޿ۿ�*****************************--
--��ѯ��ʾס�޿ۿ���Ϣ

select ROW_NUMBER()over(order by a.Id)rowId, a.Id,a.Name,a.Sex,a.TypeId,a.EmpNo,a.EntryTime,b.StairName,c.SecondName,d.CheckInTime,d.Money from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0


select count(*) from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where d.Money>0

--*****************************ס�޿ۿ�*****************************--

--*****************************���޹���*****************************--
--StaffStayOut
--Id		����id
--StaffId	Ա��id
--CheckInId	��סid
--StayOutTime	����ʱ��
--Deduction	�ۿ���

select  ROW_Number() over(order by A.Id) as rowId,A.Id,C.Name,C.Sex,C.TypeId,C.EmpNo,F.StairName,G.SecondName,B.Treaty,B.Access,B.CheckInTime,A.StayOutTime,A.Deduction,B.TowerParent,B.DormParent,D.DormitoryNo,E.BunkNo from StaffStayOut A inner join StaffCheckIn B on A.CheckInId=B.Id inner join Staff C on A.StaffId=C.Id inner join Dormitory D on B.DormitoryId=D.Id inner join Bunk E on B.BunkId=E.Id inner join Department F on C.DepartmentId=F.Id inner join Station G on C.StationId=G.Id where 1=1 

--��ȡԱ����Ϣ
select a.*,b.StairName,c.SecondName,d.Id as CheckInId,d.Treaty,d.Access,d.TowerParent,d.DormParent from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id not in(select StaffId from StaffStayOut)

--��������������Ϣ
select a.*,b.StairName,c.SecondName,d.CheckInTime,d.TowerParent,d.DormParent,d.Treaty,d.Access from Staff a join Department b on a.DepartmentId=b.Id join Station c on a.StationId=c.Id join StaffCheckIn d on a.Id=d.StaffId where a.Id='{id}'

go
----*****************************���޹���*****************************--


----*****************************ס��ͳ��*****************************--
alter proc p_queryroomandbed
as
begin
	--ɾ��ǰ��ͳ�Ƶ�������ϸ����
	truncate table DormitoryDetail

	--�����������������α������Ľ��
	declare @tmpDormitoryNo nvarchar(50)--�����
	declare @tmpDormitoryType char(1)--��������

	--deallocate cursor_dormitorydetail	--ɾ���α�
	--�����α�
	declare cursor_dormitorydetail cursor for 
		select DormitoryNo,DormitoryType from Dormitory where IsEnable=1

	-- ���α�
	open cursor_dormitorydetail

	--ִ���α� NEXT    PRIOR  FIRST   LAST
	fetch next from cursor_dormitorydetail into @tmpDormitoryNo,@tmpDormitoryType

	while(@@FETCH_STATUS=0)
		begin
			--declare ����
			--��Ů�������ʶ
			declare @flagManAndWoMen char(1)
			set @flagManAndWoMen=Null;
			select @flagManAndWoMen=DormitoryType from Dormitory where DormitoryNo=@tmpDormitoryNo
						
			-- 1�Ŵ�λס����Ա����
			declare @tmpName1 varchar(50)
			set @tmpName1 = Null;
			select @tmpName1=(t2.Name+'/'+convert(nvarchar(20),t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo = 1 and t3.DormitoryNo = @tmpDormitoryNo

			-- 2�Ŵ�λס����Ա����
			declare @tmpName2 varchar(50)
			set @tmpName2 = Null;
			select @tmpName2 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =2 and t3.DormitoryNo = @tmpDormitoryNo

			-- 3�Ŵ�λס����Ա����
			declare @tmpName3 varchar(50)
			set @tmpName3 = Null;
			select @tmpName3 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =3 and t3.DormitoryNo = @tmpDormitoryNo

			-- 4�Ŵ�λס����Ա����
			declare @tmpName4 varchar(50)
			set @tmpName4 = Null;
			select @tmpName4 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =4 and t3.DormitoryNo = @tmpDormitoryNo
			
			-- 5�Ŵ�λס����Ա����
			declare @tmpName5 varchar(50)
			set @tmpName5 = Null;
			select @tmpName5 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =5 and t3.DormitoryNo = @tmpDormitoryNo
						
			-- 6�Ŵ�λס����Ա����
			declare @tmpName6 varchar(50)
			set @tmpName6 = Null;
			select @tmpName6 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =6 and t3.DormitoryNo = @tmpDormitoryNo
						
			-- 7�Ŵ�λס����Ա����
			declare @tmpName7 varchar(50)
			set @tmpName7 = Null;
			select @tmpName7 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =7 and t3.DormitoryNo = @tmpDormitoryNo
									
			-- 8�Ŵ�λס����Ա����
			declare @tmpName8 varchar(50)
			set @tmpName8 = Null;
			select @tmpName8 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =8 and t3.DormitoryNo = @tmpDormitoryNo

			-- 9�Ŵ�λס����Ա����
			declare @tmpName9 varchar(50)
			set @tmpName9 = Null;
			select @tmpName9 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =9 and t3.DormitoryNo = @tmpDormitoryNo
			
			-- 10�Ŵ�λס����Ա����
			declare @tmpName10 varchar(50)
			set @tmpName10 = Null;
			select @tmpName10 = (t2.Name+'/'+ convert(nvarchar(20), t1.CheckInTime)) from StaffCheckIn t1 
			join Staff  t2 on t1.StaffId=t2.Id 
			join Dormitory t3 on t1.DormitoryId = t3.id
			join Bunk t4 on t1.BunkId=t4.id
			where t1.isEnable=1 and t4.BunkNo =10 and t3.DormitoryNo = @tmpDormitoryNo

			--����������
			declare @tmproomcount varchar(50)
			set @tmproomcount=null;
			select @tmproomcount=COUNT( 1 )from StaffCheckIn tA 
			join Dormitory tB on tA.DormitoryId=tB.Id 
			where tA.IsEnable=1 and tB.DormitoryNo=@tmpDormitoryNo

			--������ס����
			declare @tmpweekcheckinnum varchar(50)
			set @tmpweekcheckinnum=Null;
			select @tmpweekcheckinnum=COUNT(1) from StaffCheckIn t1 
			join Dormitory t2 on t1.DormitoryId=t2.Id
			where  t1.IsEnable=1 
			and t2.DormitoryNo=@tmpDormitoryNo 
			and t1.CheckInTime>=CONVERT(nvarchar(10),DATEADD(wk,DATEDIFF(wk,0,DATEADD(DD,-1,getdate())),0),121) 
			and t1.CheckInTime<=(select CONVERT(nvarchar(10),DATEADD(wk, DATEDIFF(wk,0, DATEADD(dd,-1,getdate())),6),121))

			--������������
			declare @tmpweekcheckoutnum varchar(50)
			set @tmpweekcheckoutnum =Null;
			select @tmpweekcheckoutnum=COUNT(1) from StaffStayOut t1
			join StaffCheckIn t2 on t1.CheckInId = t2.Id 
			join Dormitory t3 on t2.DormitoryId = t3.id
			where t2.isEnable=0 
			and t3.DormitoryNo = @tmpDormitoryNo 
			and t1.StayOutTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121) 
			and t1.StayOutTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) 

			--���᳤
			declare @tmpDormParentName nvarchar(50)
			set @tmpDormParentName = Null;
			select @tmpDormParentName=t2.Name from StaffCheckIn t1
			join Staff t2 on t1.StaffId = t2.Id
			join Dormitory t3 on t1.DormitoryId = t3.id
			where t1.DormParent=1 and t1.IsEnable=1
			and t3.DormitoryNo = @tmpDormitoryNo 

			--���ലλ
			declare @tmpNullBedCount nvarchar(50)
			select @tmpNullBedCount=(8-@tmproomcount);

			insert into  DormitoryDetail
			(DormitoryNum,Bed1,Bed2,Bed3,Bed4,Bed5,Bed6,Bed7,Bed8,Bed9,Bed10,TotalPerson,WeekCheckIn,WeekCheckOut,DormitoryManager,FreeBedNum,FlagManAndWoMen)
			values(@tmpDormitoryNo,@tmpName1,@tmpName2,@tmpName3,@tmpName4,
			@tmpName5,@tmpName6,@tmpName7,@tmpName8,@tmpName9,@tmpName10,@tmproomcount,@tmpweekcheckinnum,@tmpweekcheckoutnum,@tmpDormParentName,@tmpNullBedCount,@flagManAndWoMen)

			--ִ���α꣨�������α����ȡֵ�� NEXT    PRIOR  FIRST   LAST
			fetch next from cursor_dormitorydetail into @tmpDormitoryNo,@tmpDormitoryType

		end

	--�ر��α�
	close cursor_dormitorydetail
	--�ͷ��α�
	deallocate cursor_dormitorydetail

	--��ѯ������ϸ
	 select * from DormitoryDetail

end
go

exec p_queryroomandbed
go

ALTER proc [dbo].[p_totalRoom]
as
begin
	
	select 
	-- ȫ����ס����
	(select count(1) from StaffCheckIn  where IsEnable=1)  as totalperson
	--��ס��������
	, (select count(1) from StaffCheckIn t1 join Staff t2 on t1.StaffId = t2.Id  where t1.IsEnable=1 and t2.sex=1)  as totalman
	--��סŮ������
	, (select count(1) from StaffCheckIn t1 join Staff t2 on t1.StaffId = t2.Id  where t1.IsEnable=1 and t2.sex=0 ) as totalwoman
	,('������501-603�� Ů����604-617����32��') as roomnum
	,('Ů14�䣨112����  ��18�䣨144��') as bednum

end

exec p_totalRoom
go
----*****************************ס��ͳ��*****************************--


----*****************************����ͳ��*****************************--
ALTER proc [dbo].[p_TotalBormitorys]
as 
begin
	select '������ס(8/����)' as dormitory  --����
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id where DormitoryType='1') bed	--��λ
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1')-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1') as Checkin  --��ס
	,	((select count(1) from Staff where Sex = '1')-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1'))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1') as surplus  --ʣ��
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '1'	and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) 	and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck  --��ס
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '1' and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121)) Stayout --����

	union all 
	
	select 'Ů����ס(8/����)' as dormitory --���� 
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id where DormitoryType='0') as bed  --��λ
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0')-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0') as Checkin  --��ס
	,((select count(1) from Staff where Sex = '0')-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0'))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0') as surplus  --ʣ��
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id where t2.DormitoryType = '0'and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck  --��ס
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id where Dormitory.DormitoryType = '0' and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))Stayout   --����
	
	union all 
	
	select '�ϼ�����(��)' as dormitory --���� 
	,(select count(1) from Bunk join  Dormitory on Bunk.DormitoryId=Dormitory.Id  ) as bed  --��λ
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id )-(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id ) as Checkin --��ס
	,((select count(1) from Staff )-(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id))+(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id ) as surplus --ʣ��
	,(select count(1) from StaffCheckIn t1 join Dormitory t2 on t1.DormitoryId = t2.Id and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))  weekCheck --��ס
	,(select count(1) from StaffStayOut join StaffCheckIn on StaffStayOut.CheckInId = StaffCheckIn.Id join Dormitory on StaffCheckIn.DormitoryId = Dormitory.Id and CheckInTime <= (SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121)) and CheckInTime >= CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121))Stayout --����

	    select CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 0), 121) ks

	SELECT CONVERT(nvarchar(10), DATEADD(wk, DATEDIFF(wk, 0, DATEADD(dd, -1, getdate())), 6), 121) js

end


exec p_TotalBormitorys

----*****************************����ͳ��*****************************--

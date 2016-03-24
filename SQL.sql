--签到/签退记录表
CREATE TABLE CHECKINOUT (               
	USERID INT NOT NULL ,                              --员工ID号     
	CHECKTIME DATETIME NOT NULL DEFAULT GETDATE(),     --签到/签退时间  
	CHECKTYPE VARCHAR (1) NULL DEFAULT 'I',            --签到/签退标志：I-签到，O-签退
	VERIFYCODE INT NULL DEFAULT 0,                     --验证方式：除256的余数表示签到的方式: 0-密码；1-指纹；2-卡。大于256表示该记录已经被确认，在于处理时不进行处理
	SENSORID VARCHAR (5) NULL,                         --采集数据的考勤终端/设备ID
        CONSTRAINT USERCHECKTIME PRIMARY KEY (USERID, CHECKTIME)
);


--部门表
CREATE TABLE DEPARTMENTS (                                 
	DEPTID INT IDENTITY(1,1) NOT NULL ,      --部门ID
	DEPTNAME VARCHAR (30) NULL ,             --部门名称
	SUPDEPTID INT NOT NULL DEFAULT 1,        --上级部门的ID              
        CONSTRAINT DEPTID PRIMARY KEY (DEPTID)
);

--管理员权限设置表
CREATE TABLE SECURITYDETAILS (                 
	SECURITYDETAILID INT IDENTITY(1,1) NOT NULL ,
	USERID SMALLINT NULL ,
	DEPTID SMALLINT NULL ,
	SCHEDULE SMALLINT NULL ,
	USERINFO SMALLINT NULL ,
	ENROLLFINGERS SMALLINT NULL ,
	REPORTVIEW SMALLINT NULL ,
	REPORT VARCHAR (10) NULL,
        CONSTRAINT NAMEID2 PRIMARY KEY (SECURITYDETAILID)
)  ;

--员工考勤例外（请假/公出）表
CREATE TABLE USER_SPEDAY (                    			
	USERID INT NOT NULL ,                                   --员工ID号
	STARTSPECDAY DATETIME NOT NULL DEFAULT '1900-1-1',      --开始日期    
	ENDSPECDAY DATETIME NULL DEFAULT '2099-12-31',          --结束日期  
	DATEID SMALLINT not NULL DEFAULT -1,                    --例外类型，999为公出，-1为注释
	YUANYING VARCHAR (200) NULL ,                           --例外的原因
	[DATE] DATETIME NULL ,                                  --登记/输入记录的时间 
        CONSTRAINT USER_SEP PRIMARY KEY (USERID, STARTSPECDAY, DATEID)
);



--员工信息表
CREATE TABLE USERINFO (                      
	USERID INT IDENTITY(1,1) NOT NULL ,     --员工ID号
	--BADGENUMBER VARCHAR (12) NOT NULL ,     --考勤号码    
	--SSN VARCHAR (20) NULL ,                 --身份证/证件号
	NAME VARCHAR (20) NULL ,                --姓名
	GENDER VARCHAR (2) NULL ,               --性别
	TITLE VARCHAR (20) NULL ,               --职务
	--PAGER VARCHAR (20) NULL ,               --移动电话
	--BIRTHDAY DATETIME NULL ,                --生日
	--HIREDDAY DATETIME NULL ,                --参加工作日期
	--STREET VARCHAR (40) NULL ,              --家庭地址
	--CITY VARCHAR (2) NULL ,                 --市代码
	--STATE VARCHAR (2) NULL ,                --省代码
	--ZIP VARCHAR (12) NULL ,                 --邮编
	--OPHONE VARCHAR (20) NULL ,              --办公电话   
	--FPHONE VARCHAR (20) NULL ,              --家庭电话
	--VERIFICATIONMETHOD SMALLINT NULL ,      --验证方式
	--DEFAULTDEPTID SMALLINT NULL  DEFAULT 1, --所属部门ID号
	SECURITYFLAGS SMALLINT NULL ,           --管理员标志
	ATT SMALLINT NOT NULL DEFAULT 1,        --考勤有效
	--INLATE SMALLINT NOT NULL DEFAULT 1,     --计迟到               
	--OUTEARLY SMALLINT NOT NULL DEFAULT 1,   --计早退                
	--OVERTIME SMALLINT NOT NULL DEFAULT 1,   --计加班                 
	--SEP SMALLINT NOT NULL DEFAULT 1,        --             
	--HOLIDAY SMALLINT NOT NULL DEFAULT 1,    --假日休息             
	--MINZU VARCHAR (8) NULL ,                --民族
	--[PASSWORD] VARCHAR (20) NULL ,          --口令
	--LUNCHDURATION SMALLINT NOT NULL DEFAULT 1, --有午休
        --MVerifyPass VARCHAR(10) NULL,           --考勤验证密码
	PHOTO Image NULL,                       --照片  
        CONSTRAINT USERIDS PRIMARY KEY (USERID)
)
;


--统计项目表
Create Table LeaveClass1(
  LeaveId INT Identity(999,1) not null primary key, --999-公出
  LeaveName VARCHAR(20) not null,
  MinUnit float not null default 1,
  Unit smallint not null default 0,
  RemaindProc smallint not null default 2,
  RemaindCount smallint not null default 1,
  ReportSymbol varchar(4) not null default '_',
  Deduct float not null default 0,
  LeaveType SMALLINT not null default 0,             --bit0-是否统计项；bit1-是否异常情况项；
  Color int not null default 0,
  Classify SMALLINT not null default 0,              --计算类别，bit0-按班次时段分类；bit1-按节假日分类
  Calc text null)                                    --计算单位
;


insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('病假', 1, 'B', 3398744);
insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('事假', 1, 'S', 8421631);
insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('探亲假', 1, 'T', 16744576);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('公出', 0.5, 3, 1, 1, 'G', 3, 'if(AttItem(LeaveType1)=999,AttItem(LeaveTime1),0)+if(AttItem(LeaveType2)=999,AttItem(LeaveTime2),0)+if(AttItem(LeaveType3)=999,AttItem(LeaveTime3),0)+if(AttItem(LeaveType4)=999,AttItem(LeaveTime4),0)+if(AttItem(LeaveType5)=999,AttItem(LeaveTime5),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('正常', 0.5, 3, 1, 0, ' ', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('迟到', 10, 2, 2, 1, '>', 3, 'AttItem(minLater)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('早退', 10, 2, 2, 1, '<', 3, 'AttItem(minEarly)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('请假', 1, 1, 1, 1, '假', 3, 
  'if((AttItem(LeaveType1)>0) and (AttItem(LeaveType1)<999),AttItem(LeaveTime1),0)+if((AttItem(LeaveType2)>0) and (AttItem(LeaveType2)<999),AttItem(LeaveTime2),0)+if((AttItem(LeaveType3)>0) and (AttItem(LeaveType3)<999),AttItem(LeaveTime3),0)+if((AttItem(LeaveType4)>0) and (AttItem(LeaveType4)<999),AttItem(LeaveTime4),0)+if((AttItem(LeaveType5)>0) and (AttItem(LeaveType5)<999),AttItem(LeaveTime5),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('旷工', 0.5, 3, 1, 0, '旷', 3, 'AttItem(MinAbsent)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('加班', 1, 1, 1, 1, '+', 3, 'AttItem(MinOverTime)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('节日加班', 1, 1, 0, 1, '=', 0, 'if(HolidayId(1)=1, AttItem(MinOverTime),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('休息日', 0.5, 3, 2, 1, '-', 2);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('未签到', 1, 4, 2, 1, '[', 2, 
  'If(AttItem(CheckIn)=null,If(AttItem(OnDuty)=null,0,if(((AttItem(LeaveStart1)=null) or (AttItem(LeaveStart1)>AttItem(OnDuty))) and AttItem(DutyOn),1,0)),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('未签退', 1, 4, 2, 1, ']', 2, 
  'If(AttItem(CheckOut)=null,If(AttItem(OffDuty)=null,0,if((AttItem(LeaveEnd1)=null) or (AttItem(LeaveEnd1)<AttItem(OffDuty)),if((AttItem(LeaveEnd2)=null) or (AttItem(LeaveEnd2)<AttItem(OffDuty)),if(((AttItem(LeaveEnd3)=null) or (AttItem(LeaveEnd3)<AttItem(OffDuty))) and AttItem(DutyOff),1,0),0),0)),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('离岗未签到', 1, 4, 2, 1, '{', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('离岗未签退', 1, 4, 2, 1, '}', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('离岗', 1, 1, 2, 1, 'L', 3);
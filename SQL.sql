--ǩ��/ǩ�˼�¼��
CREATE TABLE CHECKINOUT (               
	USERID INT NOT NULL ,                              --Ա��ID��     
	CHECKTIME DATETIME NOT NULL DEFAULT GETDATE(),     --ǩ��/ǩ��ʱ��  
	CHECKTYPE VARCHAR (1) NULL DEFAULT 'I',            --ǩ��/ǩ�˱�־��I-ǩ����O-ǩ��
	VERIFYCODE INT NULL DEFAULT 0,                     --��֤��ʽ����256��������ʾǩ���ķ�ʽ: 0-���룻1-ָ�ƣ�2-��������256��ʾ�ü�¼�Ѿ���ȷ�ϣ����ڴ���ʱ�����д���
	SENSORID VARCHAR (5) NULL,                         --�ɼ����ݵĿ����ն�/�豸ID
        CONSTRAINT USERCHECKTIME PRIMARY KEY (USERID, CHECKTIME)
);


--���ű�
CREATE TABLE DEPARTMENTS (                                 
	DEPTID INT IDENTITY(1,1) NOT NULL ,      --����ID
	DEPTNAME VARCHAR (30) NULL ,             --��������
	SUPDEPTID INT NOT NULL DEFAULT 1,        --�ϼ����ŵ�ID              
        CONSTRAINT DEPTID PRIMARY KEY (DEPTID)
);

--����ԱȨ�����ñ�
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

--Ա���������⣨���/��������
CREATE TABLE USER_SPEDAY (                    			
	USERID INT NOT NULL ,                                   --Ա��ID��
	STARTSPECDAY DATETIME NOT NULL DEFAULT '1900-1-1',      --��ʼ����    
	ENDSPECDAY DATETIME NULL DEFAULT '2099-12-31',          --��������  
	DATEID SMALLINT not NULL DEFAULT -1,                    --�������ͣ�999Ϊ������-1Ϊע��
	YUANYING VARCHAR (200) NULL ,                           --�����ԭ��
	[DATE] DATETIME NULL ,                                  --�Ǽ�/�����¼��ʱ�� 
        CONSTRAINT USER_SEP PRIMARY KEY (USERID, STARTSPECDAY, DATEID)
);



--Ա����Ϣ��
CREATE TABLE USERINFO (                      
	USERID INT IDENTITY(1,1) NOT NULL ,     --Ա��ID��
	--BADGENUMBER VARCHAR (12) NOT NULL ,     --���ں���    
	--SSN VARCHAR (20) NULL ,                 --���֤/֤����
	NAME VARCHAR (20) NULL ,                --����
	GENDER VARCHAR (2) NULL ,               --�Ա�
	TITLE VARCHAR (20) NULL ,               --ְ��
	--PAGER VARCHAR (20) NULL ,               --�ƶ��绰
	--BIRTHDAY DATETIME NULL ,                --����
	--HIREDDAY DATETIME NULL ,                --�μӹ�������
	--STREET VARCHAR (40) NULL ,              --��ͥ��ַ
	--CITY VARCHAR (2) NULL ,                 --�д���
	--STATE VARCHAR (2) NULL ,                --ʡ����
	--ZIP VARCHAR (12) NULL ,                 --�ʱ�
	--OPHONE VARCHAR (20) NULL ,              --�칫�绰   
	--FPHONE VARCHAR (20) NULL ,              --��ͥ�绰
	--VERIFICATIONMETHOD SMALLINT NULL ,      --��֤��ʽ
	--DEFAULTDEPTID SMALLINT NULL  DEFAULT 1, --��������ID��
	SECURITYFLAGS SMALLINT NULL ,           --����Ա��־
	ATT SMALLINT NOT NULL DEFAULT 1,        --������Ч
	--INLATE SMALLINT NOT NULL DEFAULT 1,     --�Ƴٵ�               
	--OUTEARLY SMALLINT NOT NULL DEFAULT 1,   --������                
	--OVERTIME SMALLINT NOT NULL DEFAULT 1,   --�ƼӰ�                 
	--SEP SMALLINT NOT NULL DEFAULT 1,        --             
	--HOLIDAY SMALLINT NOT NULL DEFAULT 1,    --������Ϣ             
	--MINZU VARCHAR (8) NULL ,                --����
	--[PASSWORD] VARCHAR (20) NULL ,          --����
	--LUNCHDURATION SMALLINT NOT NULL DEFAULT 1, --������
        --MVerifyPass VARCHAR(10) NULL,           --������֤����
	PHOTO Image NULL,                       --��Ƭ  
        CONSTRAINT USERIDS PRIMARY KEY (USERID)
)
;


--ͳ����Ŀ��
Create Table LeaveClass1(
  LeaveId INT Identity(999,1) not null primary key, --999-����
  LeaveName VARCHAR(20) not null,
  MinUnit float not null default 1,
  Unit smallint not null default 0,
  RemaindProc smallint not null default 2,
  RemaindCount smallint not null default 1,
  ReportSymbol varchar(4) not null default '_',
  Deduct float not null default 0,
  LeaveType SMALLINT not null default 0,             --bit0-�Ƿ�ͳ���bit1-�Ƿ��쳣����
  Color int not null default 0,
  Classify SMALLINT not null default 0,              --�������bit0-�����ʱ�η��ࣻbit1-���ڼ��շ���
  Calc text null)                                    --���㵥λ
;


insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('����', 1, 'B', 3398744);
insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('�¼�', 1, 'S', 8421631);
insert into LeaveClass(LeaveName, Unit, ReportSymbol, Color) 
  values('̽�׼�', 1, 'T', 16744576);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('����', 0.5, 3, 1, 1, 'G', 3, 'if(AttItem(LeaveType1)=999,AttItem(LeaveTime1),0)+if(AttItem(LeaveType2)=999,AttItem(LeaveTime2),0)+if(AttItem(LeaveType3)=999,AttItem(LeaveTime3),0)+if(AttItem(LeaveType4)=999,AttItem(LeaveTime4),0)+if(AttItem(LeaveType5)=999,AttItem(LeaveTime5),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('����', 0.5, 3, 1, 0, ' ', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('�ٵ�', 10, 2, 2, 1, '>', 3, 'AttItem(minLater)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('����', 10, 2, 2, 1, '<', 3, 'AttItem(minEarly)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('���', 1, 1, 1, 1, '��', 3, 
  'if((AttItem(LeaveType1)>0) and (AttItem(LeaveType1)<999),AttItem(LeaveTime1),0)+if((AttItem(LeaveType2)>0) and (AttItem(LeaveType2)<999),AttItem(LeaveTime2),0)+if((AttItem(LeaveType3)>0) and (AttItem(LeaveType3)<999),AttItem(LeaveTime3),0)+if((AttItem(LeaveType4)>0) and (AttItem(LeaveType4)<999),AttItem(LeaveTime4),0)+if((AttItem(LeaveType5)>0) and (AttItem(LeaveType5)<999),AttItem(LeaveTime5),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('����', 0.5, 3, 1, 0, '��', 3, 'AttItem(MinAbsent)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('�Ӱ�', 1, 1, 1, 1, '+', 3, 'AttItem(MinOverTime)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('���ռӰ�', 1, 1, 0, 1, '=', 0, 'if(HolidayId(1)=1, AttItem(MinOverTime),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('��Ϣ��', 0.5, 3, 2, 1, '-', 2);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('δǩ��', 1, 4, 2, 1, '[', 2, 
  'If(AttItem(CheckIn)=null,If(AttItem(OnDuty)=null,0,if(((AttItem(LeaveStart1)=null) or (AttItem(LeaveStart1)>AttItem(OnDuty))) and AttItem(DutyOn),1,0)),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType, Calc)
  values('δǩ��', 1, 4, 2, 1, ']', 2, 
  'If(AttItem(CheckOut)=null,If(AttItem(OffDuty)=null,0,if((AttItem(LeaveEnd1)=null) or (AttItem(LeaveEnd1)<AttItem(OffDuty)),if((AttItem(LeaveEnd2)=null) or (AttItem(LeaveEnd2)<AttItem(OffDuty)),if(((AttItem(LeaveEnd3)=null) or (AttItem(LeaveEnd3)<AttItem(OffDuty))) and AttItem(DutyOff),1,0),0),0)),0)');
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('���δǩ��', 1, 4, 2, 1, '{', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('���δǩ��', 1, 4, 2, 1, '}', 3);
insert into LeaveClass1(LeaveName, MinUnit, Unit, RemaindProc,
  RemaindCount, ReportSymbol, LeaveType)
  values('���', 1, 1, 2, 1, 'L', 3);
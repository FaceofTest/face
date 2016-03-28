--CREATE TABLE DEPARTMENT
--(
 --  DEPARTMENTNAME CHAR(20), --部门名
 --  DEPARTMENTID CHAR(10) PRIMARY KEY NOT NULL   --部门id
--);
CREATE TABLE STAFFINFORMATION
(
    STAFFID INT PRIMARY KEY NOT NULL,      --人员编号
	NAME NVARCHAR (20)NOT NULL ,                 --姓名
	GENDER BIT NOT NULL ,                       --性别
	MINZU NVARCHAR (20) NOT NULL ,                 --民族
	BIRTHDAY NVARCHAR (20) NOT NULL ,                --出生日期
    TITLE NVARCHAR (20) NOT NULL ,               --职务
	OPHONE INT  NOT NULL ,              --办公电话
	PHOTO CHAR (100) NOT NULL,                --照片路径  
	DEFAULTDEPTNAME NVARCHAR (20) NOT NULL  DEFAULT 1, --所属部门
	WORKSET SMALLINT NULL  DEFAULT 1,                  --	上班必须签到
	WORKNOTSET SMALLINT NULL DEFAULT 1,                --   上班不须签到
	LEAVESET   SMALLINT NULL DEFAULT 1,                --   下班必须签到
	LEAVENOTSET SMALLINT NULL DEFAULT 1,               --   下班不须签到

);

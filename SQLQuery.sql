--CREATE TABLE DEPARTMENT
--(
 --  DEPARTMENTNAME CHAR(20), --������
 --  DEPARTMENTID CHAR(10) PRIMARY KEY NOT NULL   --����id
--);
CREATE TABLE STAFFINFORMATION
(
    STAFFID INT PRIMARY KEY NOT NULL,      --��Ա���
	NAME NVARCHAR (20)NOT NULL ,                 --����
	GENDER BIT NOT NULL ,                       --�Ա�
	MINZU NVARCHAR (20) NOT NULL ,                 --����
	BIRTHDAY NVARCHAR (20) NOT NULL ,                --��������
    TITLE NVARCHAR (20) NOT NULL ,               --ְ��
	OPHONE NVARCHAR (20)  NOT NULL ,              --�칫�绰
	PHOTO NVARCHAR (50) NOT NULL,                --��Ƭ·��  
	DEFAULTDEPTNAME NVARCHAR (20) NOT NULL  DEFAULT 1, --��������

)
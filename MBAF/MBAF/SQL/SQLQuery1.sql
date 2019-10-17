create table Teacher
	(
		Id int primary key identity(1,1),
		Fname text not null default 'None',
		Mname text not null default 'None',
		Lname text not null default 'None',
		Phone text not null default 'None',
		Birthday Datetime 
	)
	go
create table AudienceType
	(	
		Id int primary key identity(1,1),
		TypeOf text not null default 'None',
		Capacity int not null default 0,
		ResponsibleID int foreign key references Teacher(Id)
	)
	go
create table corps
	(
		Id int primary key identity(1,1),
		CorpNumber text not null default '0A',
		NumberOfAudiences int default 0,
	)
	go


	--LOG TABLE -------------------------------------------
	create table AudienceTypeLOG
	(	
		Id int,
		TypeOf text ,
		Capacity int,
		ResponsibleID int,
		operation      VARCHAR(20), 
		operation_dt   DATETIME , 
		operation_user VARCHAR(255) 
	)
	go

	create table CorpsLOG
  ( 
		Id int ,
		CorpNumber text,
		NumberOfAudiences int,
	    operation      VARCHAR(20), 
		operation_dt   DATETIME , 
		operation_user VARCHAR(255) 
  ) 
  go


create table TeacherLOG
  ( 
		Id int ,
		Fname text,
		Mname text,
		Lname text,
		Phone text,
		Birthday Datetime, 
	    operation      VARCHAR(20), 
		operation_dt   DATETIME , 
		operation_user VARCHAR(255) 
  ) 
  go


  ---------------------TRIGERS--------------------------------------------
create trigger AudienceType_u on AudienceType
 after update 
  as 
  begin
   INSERT INTO AudienceTypeLOG 
  --LOG old string
	SELECT id, 
			TypeOf,
			Capacity,
			ResponsibleID,
			'update_old', 
			Getdate(), 
			Suser_name() 
	from deleted

	--LOG new string 
	   INSERT INTO AudienceTypeLOG 
      SELECT id, 
			TypeOf,
			Capacity,
			ResponsibleID,
			'update_new', 
			Getdate(), 
			Suser_name() 
      FROM   inserted 
  END 
go 


CREATE TRIGGER AudienceType_i ON AudienceType 
after INSERT 
AS 
  BEGIN 
      INSERT INTO AudienceTypeLOG
      SELECT id,
			TypeOf,
			Capacity,
			ResponsibleID,
			'insert', 
			Getdate(), 
			Suser_name() 
      FROM   inserted 
  END 
go 


CREATE TRIGGER Corps_d ON corps 
after DELETE 
AS 
  BEGIN 
      INSERT INTO TeacherLOG 
      SELECT id, 
			TypeOf,
			Capacity,
			ResponsibleID,
			'delete', 
			Getdate(), 
			Suser_name() 
      FROM   deleted 
  END 
go 









  ---------------CORPS--------------------------------------
create trigger Corps_u on corps
 after update 
  as 
  begin
  INSERT INTO TeacherLOG 
  --LOG old string
	SELECT id, 
		CorpNumber,
		NumberOfAudiences,
		'update_old', 
		Getdate(), 
		Suser_name() 
	from deleted

	--LOG new string 
	   INSERT INTO TeacherLOG 
      SELECT id, 
			CorpNumber,
			NumberOfAudiences,
			'update_new', 
			Getdate(), 
			Suser_name() 
      FROM   inserted 
  END 
go 



CREATE TRIGGER Corps_i ON corps 
after INSERT 
AS 
  BEGIN 
      INSERT INTO TeacherLOG
      SELECT id,
			CorpNumber,
			NumberOfAudiences,
            'insert', 
            Getdate(), 
            Suser_name() 
      FROM   inserted 
  END 
go 



CREATE TRIGGER Corps_d ON corps 
after DELETE 
AS 
  BEGIN 
      INSERT INTO TeacherLOG 
      SELECT id, 
	  		CorpNumber,
			NumberOfAudiences,
            'delete', 
            Getdate(), 
            Suser_name() 
      FROM   deleted 
  END 
go 

-----------TEACHER---------------------------
create trigger Teacher_u on Teacher
  after update 
  as 
  begin
  INSERT INTO TeacherLOG 
  --LOG old string
      SELECT id, 
             Fname,
			 Mname, 
			 Lname, 
			 Phone, 
			 Birthday,
             'update_old', 
             Getdate(), 
             Suser_name() 
      FROM   deleted
	  
	  --LOG new string 
	   INSERT INTO TeacherLOG 
      SELECT id, 
			 Fname,
			 Mname, 
			 Lname, 
			 Phone, 
			 Birthday,
             'update_new', 
             Getdate(), 
             Suser_name() 
      FROM   inserted 
  END 
go 



CREATE TRIGGER Teacher_i ON Teacher 
after INSERT 
AS 
  BEGIN 
      INSERT INTO TeacherLOG
      SELECT id, 
             Fname,
			 Mname, 
			 Lname, 
			 Phone, 
			 Birthday,
             'insert', 
             Getdate(), 
             Suser_name() 
      FROM   inserted 
  END 
go 




CREATE TRIGGER Teacher_d ON Teacher 
after DELETE 
AS 
  BEGIN 
      INSERT INTO TeacherLOG 
      SELECT id, 
			 Fname,
			 Mname, 
			 Lname, 
			 Phone, 
			 Birthday, 
 
             'delete', 
             Getdate(), 
             Suser_name() 
      FROM   deleted 
  END 
go 

SET ansi_padding OFF 
go  
CREATE DATABASE BIITSOCAIL;

GO

 USE BIITSOCAIL;


GO

CREATE TABLE [user] (
  [use_id] int,
  [firstName] nvarchar(150),
  [lastName] nvarchar(150),
  [gender] char(1),
  [phoneNo] nvarchar(150),
  [createdOn] datetime,
  PRIMARY KEY ([use_id])
);

CREATE TABLE [student] (
  [stu_id] int,
  [use_id] int FOREIGN KEY REFERENCES [user]([use_id]),
  [regNo] nvarchar(150),
  PRIMARY KEY ([stu_id]),
);


CREATE TABLE [parent] (
  [par_id] int,
  [use_id] int FOREIGN KEY REFERENCES [user]([use_id]),
  [CNIC] nvarchar(150),
  PRIMARY KEY ([par_id])
);


CREATE TABLE [teacher] (
  [tea_id] int,
  [use_id] int FOREIGN KEY REFERENCES [user]([use_id]),
  [empNo] nvarchar(150),
  PRIMARY KEY ([tea_id])
);



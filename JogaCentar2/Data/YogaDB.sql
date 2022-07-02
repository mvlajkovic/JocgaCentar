USE [master]
GO
CREATE LOGIN [appJoga] WITH PASSWORD=N'Milica', 
                 DEFAULT_DATABASE=[YogaDB], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [YogaDB]
GO
CREATE USER [appJoga] FOR LOGIN [appJoga] WITH DEFAULT_SCHEMA=[dbo]
GO

USE YogaDB
GO

/*****************
   1a 
*****************/
CREATE TABLE [dbo].[Account_Statuses] (
    [StatusId] INT PRIMARY KEY,
    [Status_Description]      NVARCHAR (25)  NOT NULL,
);
GO

INSERT INTO dbo.Account_Statuses (StatusId, Status_Description) VALUES (0, 'Pending')
INSERT INTO dbo.Account_Statuses (StatusId, Status_Description) VALUES (1, 'Active')
INSERT INTO dbo.Account_Statuses (StatusId, Status_Description) VALUES (2, 'Blocked')
INSERT INTO dbo.Account_Statuses (StatusId, Status_Description) VALUES (3, 'Closed')
GO
select * from [dbo].[Account_Statuses] 
GO

/*****************
   1b
*****************/

CREATE TABLE [dbo].[Account_Types] (
    [TypeId] INT PRIMARY KEY,
	[IsEmployee] BIT DEFAULT(0),
    [Type_Description]      NVARCHAR (25)  NOT NULL,
);
GO
INSERT INTO dbo.Account_Types(TypeId, IsEmployee, Type_Description) VALUES (0, 0, 'User')
INSERT INTO dbo.Account_Types(TypeId, IsEmployee, Type_Description) VALUES (1, 1, 'Employee')
GO
select * from [dbo].[Account_Types] 
GO


/*****************
   1c 
*****************/
CREATE TABLE [dbo].[Roles] (
    [RoleId] INT IDENTITY (1, 1) PRIMARY KEY,
	[RoleName] NVARCHAR(50) NOT NULL ,
	[Comment] NVARCHAR(500) NULL ,
);
GO
CREATE UNIQUE INDEX ui_Roles_Role on dbo.Roles([RoleName])
GO
INSERT INTO dbo.Roles(RoleName, Comment) VALUES('OWNER','')
INSERT INTO dbo.Roles(RoleName, Comment) VALUES('TRAINER','')
INSERT INTO dbo.Roles(RoleName, Comment) VALUES('ADMIN','')
INSERT INTO dbo.Roles(RoleName, Comment) VALUES('USER','')
GO
SELECT * FROM dbo.Roles
GO

/*****************
   1d 
*****************/
CREATE TABLE [dbo].[Subscription_Statuses] (
    [StatusId] INT PRIMARY KEY,
    [Status_Description]      NVARCHAR (25)  NOT NULL,
);
GO

INSERT INTO dbo.Subscription_Statuses (StatusId, Status_Description) VALUES (1, 'Active')
INSERT INTO dbo.Subscription_Statuses (StatusId, Status_Description) VALUES (2, 'Expired')
INSERT INTO dbo.Subscription_Statuses (StatusId, Status_Description) VALUES (3, 'Cancelled')
GO
select * from [dbo].[Subscription_Statuses] 
GO

/*****************
   1e 
*****************/
CREATE TABLE [dbo].[Training_Statuses] (
    [StatusId] INT PRIMARY KEY,
    [Status_Description]      NVARCHAR (25)  NOT NULL,
);
GO

INSERT INTO dbo.Training_Statuses (StatusId, Status_Description) VALUES (1, 'Scheduled')
INSERT INTO dbo.Training_Statuses (StatusId, Status_Description) VALUES (2, 'Finished')
INSERT INTO dbo.Training_Statuses (StatusId, Status_Description) VALUES (3, 'Cancelled')
GO
select * from [dbo].[Training_Statuses] 
GO

/*****************
   1f
*****************/
CREATE TABLE [dbo].[Reservation_Statuses] (
    [StatusId] INT PRIMARY KEY,
    [Status_Description]      NVARCHAR (25)  NOT NULL,
);
GO

INSERT INTO dbo.Reservation_Statuses (StatusId, Status_Description) VALUES (1, 'Booked')
INSERT INTO dbo.Reservation_Statuses (StatusId, Status_Description) VALUES (2, 'Attended')
INSERT INTO dbo.Reservation_Statuses (StatusId, Status_Description) VALUES (3, 'Cancelled')
GO
select * from [dbo].[Reservation_Statuses] 
GO


/*****************
   2 
*****************/
CREATE TABLE [dbo].[Accounts] (
    [AccountId] INT  IDENTITY (1, 1) PRIMARY KEY,
	[StatusId] INT DEFAULT(0) NOT NULL FOREIGN KEY ([StatusId]) REFERENCES [dbo].[Account_Statuses] ([StatusId]),
	[TypeId] INT DEFAULT(0) NOT NULL FOREIGN KEY ([TypeId]) REFERENCES [dbo].[Account_Types] ([TypeId]),
    [FirstName]      NVARCHAR (25)  NOT NULL,
    [LastName]       NVARCHAR (25)  NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (25) NOT NULL,
    [Username]  NVARCHAR (50)  NULL,
	[Password]  NVARCHAR (20)  NULL,    
	[ChangePassword] BIT DEFAULT(1),
   -- CONSTRAINT [FK_dbo.Accounts_dbo.Trainers_TrainerId] FOREIGN KEY ([TrainerId]) REFERENCES [dbo].[Trainers] ([TrainerId])
);
GO
CREATE UNIQUE index ui_Account_Email on dbo.Accounts(Email)
CREATE UNIQUE index ui_Account_UserName on dbo.Accounts(UserName) WHERE UserName is not null

GO
INSERT INTO dbo.Accounts(StatusId, TypeId, FirstName, LastName, Email, PhoneNumber, Username, [Password])
VALUES(1, 1, 'Bill', 'Gates', 'billy@yogadb.com','','billy@yogadb.com','yoga01')
GO
--UPDATE Accounts set PhoneNumber='', Username = Email WHERE AccountId=1

ALTER TABLE dbo.Accounts ALTER COLUMN [Email] NVARCHAR (50) NOT NULL
ALTER TABLE dbo.Accounts ALTER COLUMN [UserName] NVARCHAR (50) NULL
ALTER TABLE dbo.Accounts ALTER COLUMN [Password] NVARCHAR (20) NULL

GO

SELECT * from  [dbo].[Accounts] 
GO

/*****************
   3
*****************/
CREATE TABLE [dbo].[Users] (
    [UserId] INT  IDENTITY (1, 1)  PRIMARY KEY,
    --[SubscriptionId] INT            NULL,
	[AccountId] INT NOT NULL FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([AccountId]),
    [City]    NVARCHAR (50)   DEFAULT(''),
	[Street]    NVARCHAR (100)   DEFAULT(''),
	[Number]    NVARCHAR (10)    DEFAULT(''),
    [Info]           NVARCHAR (500)  DEFAULT(''),
    [Comment]        NVARCHAR (MAX)  DEFAULT(''),
);
GO
CREATE UNIQUE index ui_Users_Account on dbo.Users(AccountId)
GO
SELECT * from[dbo].[Users]
GO


/*****************
   4 
*****************/
CREATE  TABLE [dbo].[Employees] (
    [EmployeeId] INT IDENTITY(1,1) PRIMARY KEY,
	[AccountId] INT  NOT NULL FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([AccountId]),
	[Salary] DECIMAL(19,2) DEFAULT(0),
	[Office] NVARCHAR(500) NULL ,
	[Comment] NVARCHAR(500) NULL ,
);
GO
CREATE UNIQUE index ui_Employees_Account on dbo.Employees(AccountId)
GO
INSERT INTO dbo.Employees(AccountId, Salary, Office, Comment) VALUES(1,1000000, 'Head Office','Owner')
GO
SELECT * FROM [dbo].[Employees]
GO


/*****************
   5
*****************/
CREATE  TABLE [dbo].[Employees_Roles] (
    [EmployeeId] INT NOT NULL  FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employees] ([EmployeeId]),
	[RoleId] INT  NOT NULL  FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([RoleId]),
	[Comment] NVARCHAR(500) NULL ,
    CONSTRAINT [PK_Employees_Roles] PRIMARY KEY CLUSTERED ([EmployeeId] ASC, [RoleId] ASC)
);
GO
CREATE UNIQUE index ui_Employees_Roles_Employee_Role on dbo.Employees_Roles(EmployeeId, RoleId)
GO
INSERT INTO dbo.Employees_Roles
SELECT e.EmployeeId , r.RoleId, 'Owner must see all!'
FROM Employees e
JOIN Roles r ON 1=1 WHERE RoleName in ('OWNER','ADMIN')

GO
SELECT * FROM [dbo].[Employees_Roles]
GO

ALTER TABLE dbo.Employees_Roles ADD CONSTRAINT
	FK_Employees_Roles_Roles FOREIGN KEY
	(
	RoleId
	) REFERENCES dbo.Roles
	(
	RoleId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Employees_Roles ADD CONSTRAINT
	FK_Employees_Roles_Employees FOREIGN KEY
	(
	EmployeeId
	) REFERENCES dbo.Employees
	(
	EmployeeId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO

/*****************
   6a
*****************/
CREATE VIEW [dbo].[Trainers]
AS
 SELECT e.EmployeeId, a.AccountId, a.FirstName, a.LastName
 FROM dbo.Employees e 
 JOIN dbo.Accounts a on a.AccountId = e.AccountId
 JOIN dbo.Employees_Roles er on er.EmployeeId = a.AccountId
 JOIN dbo.Roles r on r.RoleId = er.RoleId
	WHERE r.RoleName = 'TRAINER'
	      AND
		  a.StatusId = 1; --ACTIVE
GO
select * from dbo.Trainers
GO

/*****************
   6b
*****************/
CREATE VIEW [dbo].[Admins]
AS
 SELECT e.EmployeeId, a.AccountId, a.FirstName, a.LastName
 FROM dbo.Employees e 
 JOIN dbo.Accounts a on a.AccountId = e.AccountId
 JOIN dbo.Employees_Roles er on er.EmployeeId = a.AccountId
 JOIN dbo.Roles r on r.RoleId = er.RoleId
	WHERE r.RoleName = 'ADMIN'
	      AND
		  a.StatusId = 1; --ACTIVE

GO
select * from dbo.Admins
GO

/*****************
   6c
*****************/
CREATE VIEW [dbo].[Owners]
AS
 SELECT e.EmployeeId, a.AccountId, a.FirstName, a.LastName
 FROM dbo.Employees e 
 JOIN dbo.Accounts a on a.AccountId = e.AccountId
 JOIN dbo.Employees_Roles er on er.EmployeeId = a.AccountId
 JOIN dbo.Roles r on r.RoleId = er.RoleId
	WHERE r.RoleName = 'OWNER'
	      AND
		  a.StatusId = 1; --ACTIVE

GO
select * from dbo.Owners
GO

/*****************
   6d
*****************/
CREATE VIEW [dbo].[Pending_Accounts]
AS
 SELECT a.AccountId, a.FirstName, a.LastName, a.Email
 FROM dbo.Accounts a 
 	WHERE a.StatusId = 0; --PENDING

GO
select * from dbo.Pending_Accounts
GO


/*****************
   7 
*****************/
CREATE TABLE [dbo].[Treatments] (
    [TreatmentId] INT             IDENTITY (1, 1) NOT NULL PRIMARY KEY,
    [Name]        NVARCHAR (25)   NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Description] NVARCHAR (1000)  NOT NULL,
	--[CreatedBy]  INT   NOT NULL  FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Employees] ([EmployeeId]),
);
GO
ALTER TABLE  [dbo].[Treatments]  ADD  [CreatedBy]  INT   NOT NULL 
ALTER TABLE dbo.Treatments DROP CONSTRAINT	FK_Treatments_Employees 
ALTER TABLE  [dbo].[Treatments]  DROP COLUMN  [CreatedBy] 

ALTER TABLE dbo.Treatments ADD CONSTRAINT
	FK_Treatments_Employees FOREIGN KEY
	(
	CreatedBy
	) REFERENCES dbo.Employees
	(
	EmployeeId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 

SELECT * from [dbo].[Treatments] 

GO
/*****************
   8 
*****************/
CREATE TABLE [dbo].[Subscriptions] (
    [SubscriptionId]          INT IDENTITY (1, 1) PRIMARY KEY,
	[UserId] INT NOT NULL FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
    [TreatmentId]  INT NOT NULL FOREIGN KEY ([TreatmentId]) REFERENCES [dbo].[Treatments] ([TreatmentId]),
    [Number_of_Trainings] INT NOT NULL DEFAULT(1),
	[Attended_Trainings] INT NOT NULL DEFAULT(0),
    [SubscriptionStatusId] INT NOT NULL FOREIGN KEY ([SubscriptionStatusId] ) REFERENCES [dbo].[Subscription_Statuses] ([StatusId])   ,
	[Comment] NVARCHAR (1000)  NOT NULL,
);
GO
CREATE UNIQUE INDEX ui_Sunscriptions_Treatmens ON [dbo].[Subscriptions]([UserId], [TreatmentId]) WHERE [SubscriptionStatusId]=1
GO
SELECT * from [dbo].[Subscriptions]
GO
ALTER TABLE [dbo].[Subscriptions] ALTER COLUMN 	[Comment] NVARCHAR (1000)  NULL
GO

/*****************
   9 
*****************/
CREATE TABLE [dbo].[Trainings] (
    [TrainingId]   INT IDENTITY (1, 1) PRIMARY KEY,
    [TreatmentId]  INT  NOT NULL FOREIGN KEY ([TreatmentId]) REFERENCES [dbo].[Treatments] ([TreatmentId]),
    [TrainerId]   INT   NOT NULL  FOREIGN KEY ([TrainerId]) REFERENCES [dbo].[Employees] ([EmployeeId]),
    [TrainingDate] DATE NOT NULL DEFAULT (GETDATE()),
	[TrainingTime] INT NOT NULL DEFAULT (8),
    [TrainingStatusId] INT NOT NULL FOREIGN KEY ([TrainingStatusId] ) REFERENCES [dbo].[Training_Statuses] ([StatusId])   ,
	[Comment] NVARCHAR (1000)  NOT NULL,
	[CreatedBy]  INT   NOT NULL  FOREIGN KEY ([CreatedBy]) REFERENCES [dbo].[Employees] ([EmployeeId]),
);
GO
ALTER TABLE dbo.[Trainings] DROP CONSTRAINT	FK__Trainings__Creat__76969D2E 
ALTER TABLE  [dbo].[Trainings]  DROP COLUMN  [CreatedBy] 
ALTER TABLE [dbo].[Trainings] ALTER COLUMN 	[Comment] NVARCHAR (1000)  NULL
/*****************
   10 
*****************/

/*
CREATE TABLE [dbo].[Reservations] (
    [ReservationId]       INT  IDENTITY (1, 1) PRIMARY KEY,
    [UserId] INT NOT NULL FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
	[TrainingId] INT NOT NULL FOREIGN KEY ([TrainingId]) REFERENCES [dbo].[Trainings] ([TrainingId]),
    [ReservationStatusId] INT NOT NULL FOREIGN KEY ([ReservationStatusId] ) REFERENCES [dbo].[Reservation_Statuses] ([StatusId])   ,
	[Comment] NVARCHAR (1000)  NOT NULL,
);
GO
*/
CREATE TABLE [dbo].[Reservations] (
    [ReservationId]       INT  IDENTITY (1, 1) PRIMARY KEY,
    [SubscriptionId] INT NOT NULL FOREIGN KEY ([SubscriptionId]) REFERENCES [dbo].[Subscriptions] ([SubscriptionId]),
	[TrainingId] INT NOT NULL FOREIGN KEY ([TrainingId]) REFERENCES [dbo].[Trainings] ([TrainingId]),
    [ReservationStatusId] INT NOT NULL FOREIGN KEY ([ReservationStatusId] ) REFERENCES [dbo].[Reservation_Statuses] ([StatusId])   ,
	[Comment] NVARCHAR (1000)  NOT NULL,
);
GO
ALTER TABLE [dbo].[Reservations] ALTER COLUMN 	[Comment] NVARCHAR (1000)  NULL
 

 select * from Accounts
 select * from Users
 select * from Employees
 select * from Employees_Roles

 USE YogaDB
 GO

 ALTER Procedure dbo.Approve_PendingAccount(
	 @AccountId INT,
	 @StatusId INT,
	 @TypeId INT,
	 @MSG nvarchar(1000) = NULL OUTPUT
 )
 as
 BEGIN
	SET @MSG = ''
  
	IF NOT EXISTS(SELECT 1 FROM dbo.Accounts WHERE AccountId = @AccountId)
	BEGIN
		SET @MSG = 'AccountId = '+isnull(CAST(@AccountId as varchar),'null')+'does not exist!'
		RETURN
	END

	IF NOT EXISTS(SELECT 1 FROM dbo.Accounts WHERE AccountId = @AccountId and StatusId = 0)
	BEGIN
		SET @MSG = 'Account = '+isnull(CAST(@AccountId as varchar),'null')+ ' is not in PENDING status!'
		RETURN
	END


	BEGIN TRY

		UPDATE a 
		SET a.StatusId = @StatusId,
			a.TypeId = @TypeId
		--SELECT * 
		FROM dbo.Accounts a 
		WHERE a.AccountId = @AccountId
	
		IF @TypeId = 0 --User
		BEGIN
			INSERT INTO dbo.Users(AccountId) VALUES (@AccountId)
		END

		IF @TypeId = 1 --Employee
		BEGIN
			INSERT INTO dbo.Employees(AccountId) VALUES (@AccountId)
		END   

	END TRY
	BEGIN CATCH
		SET @MSG = LEFT('SP: Approve_PendingAccount - '+ ERROR_MESSAGE(),1000)
		RAISERROR(@MSG,16,1)
	END CATCH


 END
 GO









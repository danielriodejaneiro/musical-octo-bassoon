/*
   April 16, 20186:21:48 PM
   User: 
   Server: localhost\SQLEXPRESS
   Database: WCF101
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	id int NOT NULL,
	title nchar(50) NOT NULL,
	datedue varchar(10) NULL,
	datedone varchar(10) NULL,
	tags varchar(50) NULL,
	author varchar(15) NULL,
	executor varchar(15) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

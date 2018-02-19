/****** Object:  Table [dbo].[Tasks]    Script Date: 2018-02-19 3:03:09 AM ******/
DROP TABLE [dbo].[Tasks]
GO

/****** Object:  Table [dbo].[Tasks]    Script Date: 2018-02-19 3:03:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tasks](
	[id] [int] NOT NULL,
	[title] [varchar](100) NOT NULL,
	[datedue] [varchar](10) NULL,
	[datedone] [varchar](10) NULL,
	[tags] [varchar](100) NULL,
	[author] [varchar](100) NULL,
	[executor] [varchar](100) NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


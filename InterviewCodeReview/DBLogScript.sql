USE [DBLog]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 12/29/2016 10:40:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Log]') AND type in (N'U'))
DROP TABLE [dbo].[Log]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 12/29/2016 10:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Log]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Log](
	[message] [nchar](100) NULL,
	[value] [nchar](100) NULL
) ON [PRIMARY]
END
GO

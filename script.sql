USE [onlineshopdb]
GO
/****** Object:  Table [dbo].[Catalog]    Script Date: 2/3/2021 7:27:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalog](
	[Title] [nvarchar](200) NOT NULL,
	[Color] [nvarchar](50) NOT NULL,
	[Size] [int] NOT NULL,
	[Neckline] [nvarchar](200) NOT NULL,
	[Sleeve] [nvarchar](200) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO

USE [StudentManagement]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 3/23/2022 2:40:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [nvarchar](10) NOT NULL,
	[TenSinhVien] [nvarchar](50) NOT NULL,
	[GioiTinh] [char](10) NOT NULL,
	[NgaySinh] [nvarchar](50) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[MaLop] [nvarchar](10) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[HinhAnh] [nvarchar](500) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/23/2022 2:40:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FullName] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[isAdmin] [nchar](10) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

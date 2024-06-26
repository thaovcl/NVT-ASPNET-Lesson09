create database NVT_K22CNT1Lesson07
USE [NVT_K22CNT1Lesson07]

GO
/****** Object:  Table [dbo].[nvtKhoa]    Script Date: 6/17/2024 9:14:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvtKhoa](
	[NvtID] [nchar](10) NOT NULL,
	[NvtTenKh] [nchar](10) NULL,
	[NvtTrangthai] [nchar](10) NULL,
 CONSTRAINT [PK_nvtKhoa] PRIMARY KEY CLUSTERED 
(
	[NvtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nvtSV]    Script Date: 6/17/2024 9:14:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nvtSV](
	[NvtMaSV] [nvarchar](50) NOT NULL,
	[NvtHoSV] [nvarchar](50) NULL,
	[NvtTenSV] [nvarchar](50) NULL,
	[NvtNS] [date] NULL,
	[NvtPhai] [bit] NULL,
	[NvtPhone] [nchar](10) NULL,
	[NvtEmail] [nvarchar](50) NULL,
	[NvtID] [nchar](10) NULL ,

 CONSTRAINT [PK_nvtSV] PRIMARY KEY CLUSTERED 
(
	[NvtMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[nvtKhoa] ([NvtID], [NvtTenKh], [NvtTrangthai]) VALUES (N'          ', NULL, NULL)
INSERT [dbo].[nvtKhoa] ([NvtID], [NvtTenKh], [NvtTrangthai]) VALUES (N'K22CNT1   ', N'K22CNT11  ', N'True      ')
INSERT [dbo].[nvtSV] ([NvtMaSV], [NvtHoSV], [NvtTenSV], [NvtNS], [NvtPhai], [NvtPhone], [NvtEmail], [NvtID]) VALUES (N'2210900125', N'Nguyễn Văn', N'Thạo', CAST(N'2004-05-17' AS Date), 1, N'0123456789', N'vanthao@gmail.com', N'K22CNT1   ')

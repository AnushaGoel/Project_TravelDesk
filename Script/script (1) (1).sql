USE [NST_TRAVELDESK]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] NOT NULL,
	[RequestID] [int] NULL,
	[CommentText] [varchar](200) NULL,
	[CommentDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[RequestID] [int] NOT NULL,
	[UserID] [int] NULL,
	[EmployeeName] [varchar](50) NULL,
	[ProjectName] [varchar](50) NULL,
	[DepartmentName] [varchar](50) NULL,
	[ReasonForTravel] [varchar](100) NULL,
	[TypeOfBooking] [varchar](50) NULL,
	[BookingDetails] [varchar](500) NULL,
	[RequestStatus] [varchar](50) NULL,
	[RequestDate] [datetime] NULL,
	[ManagerComments] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] NOT NULL,
	[RoleName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[TicketID] [int] NOT NULL,
	[RequestID] [int] NULL,
	[TicketType] [varchar](50) NULL,
	[AadharCard] [varbinary](max) NULL,
	[PassportNumber] [varchar](50) NULL,
	[PassportFile] [varbinary](max) NULL,
	[VisaFile] [varbinary](max) NULL,
	[TravelDate] [date] NULL,
	[DaysOfStay] [int] NULL,
	[MealRequired] [varchar](50) NULL,
	[MealPreference] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[RoleID] [int] NULL,
	[ManagerID] [int] NULL,
	[ManagerName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersTravelHistory]    Script Date: 17-05-2023 22:16:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersTravelHistory](
	[UserID] [int] NULL,
	[RequestID] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD FOREIGN KEY([RequestID])
REFERENCES [dbo].[Requests] ([RequestID])
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD FOREIGN KEY([RequestID])
REFERENCES [dbo].[Requests] ([RequestID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[UsersTravelHistory]  WITH CHECK ADD FOREIGN KEY([RequestID])
REFERENCES [dbo].[Requests] ([RequestID])
GO
ALTER TABLE [dbo].[UsersTravelHistory]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO

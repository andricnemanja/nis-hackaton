USE [NisTaxi]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 12/16/2023 5:52:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[DriverName] [nvarchar](max) NOT NULL,
	[PostalCode] [int] NOT NULL,
	[Place] [nvarchar](max) NOT NULL,
	[TaxiLicence] [nvarchar](6) NOT NULL,
	[NumberOfId] [nvarchar](9) NOT NULL,
	[DriverStatus] [int] NOT NULL,
	[SMSNotification] [bit] NOT NULL,
	[EmailNotification] [bit] NOT NULL,
	[FuelCombinationId] [int] NOT NULL,
 CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Drivers]  WITH CHECK ADD  CONSTRAINT [FK_Drivers_FuelCombinations_FuelCombinationId] FOREIGN KEY([FuelCombinationId])
REFERENCES [dbo].[FuelCombinations] ([Id])
GO
ALTER TABLE [dbo].[Drivers] CHECK CONSTRAINT [FK_Drivers_FuelCombinations_FuelCombinationId]
GO

USE [NisTaxi]
GO
/****** Object:  Table [dbo].[FuelCombinations]    Script Date: 12/16/2023 5:52:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuelCombinations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Fuel1Id] [int] NOT NULL,
	[Fuel2Id] [int] NULL,
	[LimitFirstFuel] [float] NOT NULL,
	[LimitLastFuel] [float] NULL,
 CONSTRAINT [PK_FuelCombinations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[FuelCombinations]  WITH CHECK ADD  CONSTRAINT [FK_FuelCombinations_Fuels_Fuel1Id] FOREIGN KEY([Fuel1Id])
REFERENCES [dbo].[Fuels] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FuelCombinations] CHECK CONSTRAINT [FK_FuelCombinations_Fuels_Fuel1Id]
GO
ALTER TABLE [dbo].[FuelCombinations]  WITH CHECK ADD  CONSTRAINT [FK_FuelCombinations_Fuels_Fuel2Id] FOREIGN KEY([Fuel2Id])
REFERENCES [dbo].[Fuels] ([Id])
GO
ALTER TABLE [dbo].[FuelCombinations] CHECK CONSTRAINT [FK_FuelCombinations_Fuels_Fuel2Id]
GO

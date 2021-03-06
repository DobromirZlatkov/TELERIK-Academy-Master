USE [master]
GO
/****** Object:  Database [MultilingualDictionary]    Script Date: 24/08/2014 17:12:09 ******/
CREATE DATABASE [MultilingualDictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MultilingualDictionary', FILENAME = N'E:\PROGRAMS\SQLServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\MultilingualDictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MultilingualDictionary_log', FILENAME = N'E:\PROGRAMS\SQLServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\MultilingualDictionary_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MultilingualDictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MultilingualDictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MultilingualDictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MultilingualDictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MultilingualDictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MultilingualDictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MultilingualDictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MultilingualDictionary] SET  MULTI_USER 
GO
ALTER DATABASE [MultilingualDictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MultilingualDictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MultilingualDictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MultilingualDictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MultilingualDictionary] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MultilingualDictionary]
GO
/****** Object:  Table [dbo].[Explanatons]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Explanatons](
	[ExplanationID] [int] IDENTITY(1,1) NOT NULL,
	[Explanation] [text] NOT NULL,
	[LanguageID] [int] NOT NULL,
	[WordID] [int] NOT NULL,
 CONSTRAINT [PK_Explanatons] PRIMARY KEY CLUSTERED 
(
	[ExplanationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hypernyms]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hypernyms](
	[WordID] [int] NOT NULL,
	[HypernymID] [int] NOT NULL,
 CONSTRAINT [PK_Hypernyms] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[HypernymID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PartOfSpeech]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartOfSpeech](
	[PartOfSpeechID] [int] IDENTITY(1,1) NOT NULL,
	[PartOfSpeech] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PartOfSpeech] PRIMARY KEY CLUSTERED 
(
	[PartOfSpeechID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Synonyms]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Synonyms](
	[WordID] [int] NOT NULL,
	[SynonymID] [int] NOT NULL,
 CONSTRAINT [PK_Synonyms] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[SynonymID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Translations]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translations](
	[WordID] [int] NOT NULL,
	[TranslationID] [int] NOT NULL,
 CONSTRAINT [PK_Translations] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC,
	[TranslationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Words]    Script Date: 24/08/2014 17:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Words](
	[WordID] [int] IDENTITY(1,1) NOT NULL,
	[WordText] [nvarchar](150) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[PartOfSpeechID] [int] NOT NULL,
 CONSTRAINT [PK_Words] PRIMARY KEY CLUSTERED 
(
	[WordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Explanatons]  WITH CHECK ADD  CONSTRAINT [FK_Explanatons_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Explanatons] CHECK CONSTRAINT [FK_Explanatons_Languages]
GO
ALTER TABLE [dbo].[Explanatons]  WITH CHECK ADD  CONSTRAINT [FK_Explanatons_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Explanatons] CHECK CONSTRAINT [FK_Explanatons_Words]
GO
ALTER TABLE [dbo].[Hypernyms]  WITH CHECK ADD  CONSTRAINT [FK_Hypernyms_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Hypernyms] CHECK CONSTRAINT [FK_Hypernyms_Words]
GO
ALTER TABLE [dbo].[Hypernyms]  WITH CHECK ADD  CONSTRAINT [FK_Hypernyms_Words1] FOREIGN KEY([HypernymID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Hypernyms] CHECK CONSTRAINT [FK_Hypernyms_Words1]
GO
ALTER TABLE [dbo].[Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Synonyms_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Synonyms] CHECK CONSTRAINT [FK_Synonyms_Words]
GO
ALTER TABLE [dbo].[Synonyms]  WITH CHECK ADD  CONSTRAINT [FK_Synonyms_Words1] FOREIGN KEY([SynonymID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Synonyms] CHECK CONSTRAINT [FK_Synonyms_Words1]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Words] FOREIGN KEY([WordID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Words]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Words1] FOREIGN KEY([TranslationID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Words1]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Languages] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Languages] ([LanguageID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Languages]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_PartOfSpeech] FOREIGN KEY([PartOfSpeechID])
REFERENCES [dbo].[PartOfSpeech] ([PartOfSpeechID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_PartOfSpeech]
GO
ALTER TABLE [dbo].[Words]  WITH CHECK ADD  CONSTRAINT [FK_Words_Words] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Words] ([WordID])
GO
ALTER TABLE [dbo].[Words] CHECK CONSTRAINT [FK_Words_Words]
GO
USE [master]
GO
ALTER DATABASE [MultilingualDictionary] SET  READ_WRITE 
GO

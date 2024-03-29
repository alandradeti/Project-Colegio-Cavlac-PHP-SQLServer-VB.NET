USE [master]
GO
/****** Object:  Database [BD_TCC]    Script Date: 29/11/2021 14:16:04 ******/
CREATE DATABASE [BD_TCC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_TCC', FILENAME = N'D:\Aplicativos\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_TCC.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BD_TCC_log', FILENAME = N'D:\Aplicativos\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BD_TCC_log.ldf' , SIZE = 9216KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_TCC] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_TCC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_TCC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_TCC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_TCC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_TCC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_TCC] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_TCC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_TCC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_TCC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_TCC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_TCC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_TCC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_TCC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_TCC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_TCC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_TCC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_TCC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_TCC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_TCC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_TCC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_TCC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_TCC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_TCC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_TCC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_TCC] SET  MULTI_USER 
GO
ALTER DATABASE [BD_TCC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_TCC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_TCC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_TCC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BD_TCC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_TCC] SET QUERY_STORE = OFF
GO
USE [BD_TCC]
GO
/****** Object:  UserDefinedFunction [dbo].[formatarCPF]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[formatarCPF](@cpf char(11)) returns char(14)		as		
begin			 
declare @retorno varchar(14)			
set @retorno = substring(@cpf,1,3) + '.' + substring(@cpf,4,3) + '.' + substring(@cpf,7,3) + '-' + substring(@cpf,10,2) 			
return @retorno		
end
GO
/****** Object:  UserDefinedFunction [dbo].[formatarData]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[formatarData](@data date) returns char(10)		as		
begin			 
declare @retorno varchar(10)			
set @retorno = Format(@data, 'dd/MM/yyyy', 'en-US')
return @retorno		
end
GO
/****** Object:  UserDefinedFunction [dbo].[formatarRG]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[formatarRG](@rg char(9)) returns char(12)		as		
begin			 
declare @retorno varchar(12)			
set @retorno = substring(@rg,1,2) + '.' + substring(@rg,3,3) + '.' + substring(@rg,6,3) + '-' + substring(@rg,9,1) 			
return @retorno		
end

GO
/****** Object:  Table [dbo].[TB_NOTIFICACOES]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_NOTIFICACOES](
	[id_noti] [int] IDENTITY(1,1) NOT NULL,
	[id_matricula] [int] NOT NULL,
	[notificacao] [varchar](300) NULL,
	[id_usuario] [int] NOT NULL,
	[data] [date] NOT NULL,
 CONSTRAINT [PK_TB_NOTIFICACOES] PRIMARY KEY CLUSTERED 
(
	[id_noti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ALUNO]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ALUNO](
	[id_matricula] [int] NOT NULL,
	[rg] [varchar](9) NOT NULL,
	[nome_aluno] [varchar](50) NOT NULL,
	[cep_aluno] [varchar](9) NOT NULL,
	[cpf] [varchar](11) NULL,
	[dt_nasc] [date] NOT NULL,
	[nome_responsavel] [varchar](50) NOT NULL,
	[sexo] [bit] NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[ponto_ref] [varchar](60) NULL,
	[dt_cad] [date] NOT NULL,
	[email_aluno] [varchar](60) NULL,
	[Num_Casa] [int] NOT NULL,
	[foto_aluno] [varchar](300) NULL,
 CONSTRAINT [PK_TB_ALUNO] PRIMARY KEY CLUSTERED 
(
	[id_matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_TB_ALUNO_1] UNIQUE NONCLUSTERED 
(
	[rg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_USUARIO]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_USUARIO](
	[id_usuario] [int] NOT NULL,
	[cpf_usuario] [varchar](11) NOT NULL,
	[rg_usuario] [varchar](9) NOT NULL,
	[email_usuario] [varchar](50) NULL,
	[senha_usuario] [varchar](50) NOT NULL,
	[nome_usuario] [varchar](50) NOT NULL,
	[dt_nasc] [date] NOT NULL,
	[dt_cad] [date] NOT NULL,
	[tipo_usuario] [varchar](10) NOT NULL,
	[cep] [varchar](9) NOT NULL,
	[numero_residencia] [int] NOT NULL,
	[referencia] [varchar](50) NULL,
	[sexo] [bit] NOT NULL,
	[login] [varchar](50) NULL,
	[foto_usuario] [varchar](300) NULL,
 CONSTRAINT [PK_TB_USUARIO] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_TB_USUARIO_1] UNIQUE NONCLUSTERED 
(
	[rg_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_TB_USUARIO_2] UNIQUE NONCLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[notificacao]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[notificacao]
AS

SELECT  A.id_matricula,
		N.notificacao,
		N.data, 
		USU.nome_usuario

FROM    TB_ALUNO A 
		INNER JOIN
        TB_NOTIFICACOES N ON A.id_matricula = N.id_matricula
		INNER JOIN
        TB_USUARIO USU ON N.id_usuario = USU.id_usuario
GO
/****** Object:  Table [dbo].[TB_TELEFONE_ALUNO]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TELEFONE_ALUNO](
	[id_telefone] [int] NOT NULL,
	[id_matricula] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_TELEFONE]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TELEFONE](
	[id_telefone] [int] IDENTITY(1,1) NOT NULL,
	[telefone] [varchar](14) NOT NULL,
	[contato] [varchar](50) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TB_TELEFONE] PRIMARY KEY CLUSTERED 
(
	[id_telefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewTelefone]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[viewTelefone]
As
SELECT A.id_matricula,
		TA.id_telefone,
		T.telefone
FROM TB_ALUNO   A
	 LEFT JOIN
	 TB_TELEFONE_ALUNO TA ON A.id_matricula = TA.id_matricula
	 LEFT JOIN
	 TB_TELEFONE T ON TA.id_telefone = T.id_telefone

GO
/****** Object:  Table [dbo].[TB_TURMA]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TURMA](
	[id_turma] [int] IDENTITY(1,1) NOT NULL,
	[turma] [varchar](5) NOT NULL,
	[periodo] [varchar](10) NOT NULL,
	[ano] [varchar](4) NOT NULL,
 CONSTRAINT [PK_TB_TURMA] PRIMARY KEY CLUSTERED 
(
	[id_turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_BOLETIM]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_BOLETIM](
	[nota] [float] NULL,
	[faltas] [int] NULL,
	[presenca] [int] NULL,
	[ano] [varchar](4) NOT NULL,
	[id_presenca] [int] NULL,
	[id_matricula] [int] NOT NULL,
	[bimestre] [char](1) NOT NULL,
	[id_turma] [int] NOT NULL,
	[id_discp] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ALUNO_TURMA]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ALUNO_TURMA](
	[id_matricula] [int] NOT NULL,
	[id_turma] [int] NOT NULL,
	[id_aluno_turma] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_TB_ALUNO_TURMA] PRIMARY KEY CLUSTERED 
(
	[id_aluno_turma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_DISCP]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DISCP](
	[id_discp] [int] IDENTITY(1,1) NOT NULL,
	[disciplina] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TB_DISCP] PRIMARY KEY CLUSTERED 
(
	[id_discp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viwall]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[viwall]

As



SELECT       
 TB_ALUNO.id_matricula AS Expr1, TB_ALUNO.nome_aluno, TB_BOLETIM.*, TB_TURMA.id_turma, TB_TURMA.periodo, TB_TURMA.turma, TB_USUARIO.id_usuario, 
                         TB_USUARIO.senha_usuario, TB_USUARIO.nome_usuario, TB_USUARIO.login, TB_DISCP.*, TB_ALUNO_DISCIPLINA.falta_presenca, 
                         TB_ALUNO_DISCIPLINA.date_2, TB_ALUNO_DISCIPLINA.id_aluno_discp AS Expr2, TB_ALUNO_TURMA.id_aluno_turma AS Expr3
FROM            TB_ALUNO INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula INNER JOIN
                         TB_DISCP INNER JOIN
                         TB_ALUNO_DISCIPLINA ON TB_DISCP.id_discp = TB_ALUNO_DISCIPLINA.id_discp AND TB_DISCP.id_discp = TB_ALUNO_DISCIPLINA.id_discp ON 
                         TB_BOLETIM.id_aluno_discp = TB_ALUNO_DISCIPLINA.id_aluno_discp INNER JOIN
                         TB_ALUNO_TURMA ON TB_BOLETIM.id_aluno_turma = TB_ALUNO_TURMA.id_aluno_turma INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_matricula = TB_TURMA.id_turma CROSS JOIN
                         TB_USUARIO


GO
/****** Object:  View [dbo].[viwaluno]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[viwaluno]
As
SELECT A.id_matricula,
		A.rg,
		A.nome_aluno,
		A.cep_aluno,
		A.cpf,
		A.dt_nasc,
		A.nome_responsavel,
		A.sexo,
		A.senha,
		A.ponto_ref,
		A.dt_cad,
		A.foto_aluno,
		A.email_aluno,
		A.Num_Casa,
		B.ano,
	    B.bimestre, 
		B.faltas, 
	    B.nota, 
		D.id_discp,
		D.disciplina

FROM TB_ALUNO   A
     LEFT JOIN
	 TB_BOLETIM B ON A.id_matricula = B.id_matricula 
	 LEFT JOIN
	 TB_DISCP   D ON D.id_discp = B.id_discp

GO
/****** Object:  Table [dbo].[TB_MASTER]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MASTER](
	[bimestre] [char](10) NOT NULL,
	[ano] [varchar](4) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PRESENCA]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PRESENCA](
	[id_discp] [int] NOT NULL,
	[id_matricula] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[date_2] [date] NOT NULL,
	[falta_presenca] [bit] NOT NULL,
	[id_presenca] [int] NOT NULL,
 CONSTRAINT [PK_TB_ALUNO_DISCIPLINA] PRIMARY KEY CLUSTERED 
(
	[id_presenca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PROFESSOR_DISCIPLINA]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PROFESSOR_DISCIPLINA](
	[id_prof_discp] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_discp] [int] NOT NULL,
 CONSTRAINT [PK_TB_PROFESSOR_DISCIPLINA] PRIMARY KEY CLUSTERED 
(
	[id_prof_discp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA](
	[id_prof_discp] [int] NOT NULL,
	[id_turma] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_TELEFONE_USUARIO]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TELEFONE_USUARIO](
	[id_telefone] [int] NOT NULL,
	[id_usuario] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TB_ALUNO_TURMA]  WITH CHECK ADD  CONSTRAINT [FK_TB_ALUNO_TURMA_TB_ALUNO] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[TB_ALUNO] ([id_matricula])
GO
ALTER TABLE [dbo].[TB_ALUNO_TURMA] CHECK CONSTRAINT [FK_TB_ALUNO_TURMA_TB_ALUNO]
GO
ALTER TABLE [dbo].[TB_ALUNO_TURMA]  WITH CHECK ADD  CONSTRAINT [FK_TB_ALUNO_TURMA_TB_TURMA1] FOREIGN KEY([id_turma])
REFERENCES [dbo].[TB_TURMA] ([id_turma])
GO
ALTER TABLE [dbo].[TB_ALUNO_TURMA] CHECK CONSTRAINT [FK_TB_ALUNO_TURMA_TB_TURMA1]
GO
ALTER TABLE [dbo].[TB_BOLETIM]  WITH CHECK ADD  CONSTRAINT [FK_TB_BOLETIM_TB_ALUNO] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[TB_ALUNO] ([id_matricula])
GO
ALTER TABLE [dbo].[TB_BOLETIM] CHECK CONSTRAINT [FK_TB_BOLETIM_TB_ALUNO]
GO
ALTER TABLE [dbo].[TB_BOLETIM]  WITH CHECK ADD  CONSTRAINT [FK_TB_BOLETIM_TB_ALUNO_DISCIPLINA] FOREIGN KEY([id_presenca])
REFERENCES [dbo].[TB_PRESENCA] ([id_presenca])
GO
ALTER TABLE [dbo].[TB_BOLETIM] CHECK CONSTRAINT [FK_TB_BOLETIM_TB_ALUNO_DISCIPLINA]
GO
ALTER TABLE [dbo].[TB_NOTIFICACOES]  WITH CHECK ADD  CONSTRAINT [FK_TB_NOTIFICACOES_TB_ALUNO] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[TB_ALUNO] ([id_matricula])
GO
ALTER TABLE [dbo].[TB_NOTIFICACOES] CHECK CONSTRAINT [FK_TB_NOTIFICACOES_TB_ALUNO]
GO
ALTER TABLE [dbo].[TB_NOTIFICACOES]  WITH CHECK ADD  CONSTRAINT [FK_TB_NOTIFICACOES_TB_USUARIO] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[TB_USUARIO] ([id_usuario])
GO
ALTER TABLE [dbo].[TB_NOTIFICACOES] CHECK CONSTRAINT [FK_TB_NOTIFICACOES_TB_USUARIO]
GO
ALTER TABLE [dbo].[TB_PRESENCA]  WITH CHECK ADD  CONSTRAINT [FK_TB_ALUNO_DISCIPLINA_TB_DISCP] FOREIGN KEY([id_discp])
REFERENCES [dbo].[TB_DISCP] ([id_discp])
GO
ALTER TABLE [dbo].[TB_PRESENCA] CHECK CONSTRAINT [FK_TB_ALUNO_DISCIPLINA_TB_DISCP]
GO
ALTER TABLE [dbo].[TB_PRESENCA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRESENCA_TB_ALUNO] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[TB_ALUNO] ([id_matricula])
GO
ALTER TABLE [dbo].[TB_PRESENCA] CHECK CONSTRAINT [FK_TB_PRESENCA_TB_ALUNO]
GO
ALTER TABLE [dbo].[TB_PRESENCA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRESENCA_TB_USUARIO] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[TB_USUARIO] ([id_usuario])
GO
ALTER TABLE [dbo].[TB_PRESENCA] CHECK CONSTRAINT [FK_TB_PRESENCA_TB_USUARIO]
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TB_DISCP] FOREIGN KEY([id_discp])
REFERENCES [dbo].[TB_DISCP] ([id_discp])
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA] CHECK CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TB_DISCP]
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TB_USUARIO] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[TB_USUARIO] ([id_usuario])
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA] CHECK CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TB_USUARIO]
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TURMA_TB_PROFESSOR_DISCIPLINA] FOREIGN KEY([id_prof_discp])
REFERENCES [dbo].[TB_PROFESSOR_DISCIPLINA] ([id_prof_discp])
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA] CHECK CONSTRAINT [FK_TB_PROFESSOR_DISCIPLINA_TURMA_TB_PROFESSOR_DISCIPLINA]
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA]  WITH CHECK ADD  CONSTRAINT [FK_TB_PROFESSOR_TURMA_TB_TURMA] FOREIGN KEY([id_turma])
REFERENCES [dbo].[TB_TURMA] ([id_turma])
GO
ALTER TABLE [dbo].[TB_PROFESSOR_DISCIPLINA_TURMA] CHECK CONSTRAINT [FK_TB_PROFESSOR_TURMA_TB_TURMA]
GO
ALTER TABLE [dbo].[TB_TELEFONE_ALUNO]  WITH CHECK ADD  CONSTRAINT [FK_TB_TELEFONE_ALUNO_TB_ALUNO1] FOREIGN KEY([id_matricula])
REFERENCES [dbo].[TB_ALUNO] ([id_matricula])
GO
ALTER TABLE [dbo].[TB_TELEFONE_ALUNO] CHECK CONSTRAINT [FK_TB_TELEFONE_ALUNO_TB_ALUNO1]
GO
ALTER TABLE [dbo].[TB_TELEFONE_ALUNO]  WITH CHECK ADD  CONSTRAINT [FK_TB_TELEFONE_ALUNO_TB_TELEFONE1] FOREIGN KEY([id_telefone])
REFERENCES [dbo].[TB_TELEFONE] ([id_telefone])
GO
ALTER TABLE [dbo].[TB_TELEFONE_ALUNO] CHECK CONSTRAINT [FK_TB_TELEFONE_ALUNO_TB_TELEFONE1]
GO
ALTER TABLE [dbo].[TB_TELEFONE_USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_TB_TELEFONE_USUARIO_TB_TELEFONE] FOREIGN KEY([id_telefone])
REFERENCES [dbo].[TB_TELEFONE] ([id_telefone])
GO
ALTER TABLE [dbo].[TB_TELEFONE_USUARIO] CHECK CONSTRAINT [FK_TB_TELEFONE_USUARIO_TB_TELEFONE]
GO
ALTER TABLE [dbo].[TB_TELEFONE_USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_TB_TELEFONE_USUARIO_TB_USUARIO] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[TB_USUARIO] ([id_usuario])
GO
ALTER TABLE [dbo].[TB_TELEFONE_USUARIO] CHECK CONSTRAINT [FK_TB_TELEFONE_USUARIO_TB_USUARIO]
GO
/****** Object:  StoredProcedure [dbo].[aiaeUsuario]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[aiaeUsuario]
--PARÂMETROS--

	@ACAO INT, --0= EXCLUIR 1= INSERIR 2= ALTERAR
	@id_usuario INT = NULL,
	@cpf_usuario VARCHAR(11) = NULL,
	@rg_usuario VARCHAR(9) = NULL,
	@email_usuario VARCHAR(50) = NULL,
	@senha_usuario VARCHAR(50) = NULL,
	@nome_usuario VARCHAR(50) = NULL,
	@dt_nasc DATE = NULL,
	@dt_cad DATE = NULL,
	@tipo_usuario VARCHAR(10) = NULL,
	@cep VARCHAR(9) = NULL,
	@numero_residencia INT = NULL,
	@referencia VARCHAR(50) = NULL,
	@foto_usuario VARCHAR(300) = NULL,
	@sexo BIT = NULL,
	@login VARCHAR(50) = NULL

AS
BEGIN
	--CORPO--

	IF(@ACAO = 0) -- EXCLUIR --
	BEGIN
		DELETE FROM TB_USUARIO
		WHERE id_usuario = @id_usuario
		
		SELECT @id_usuario AS RETORNO

	END
	ELSE IF(@ACAO = 1) --INSERIR--
	BEGIN
			INSERT INTO TB_USUARIO(id_usuario, cpf_usuario, rg_usuario, email_usuario,senha_usuario,nome_usuario , dt_nasc, dt_cad, tipo_usuario,cep ,numero_residencia ,referencia, foto_usuario, sexo, login)
			VALUES (@id_usuario, @cpf_usuario, @rg_usuario , @email_usuario , @senha_usuario, @nome_usuario , @dt_nasc, @dt_cad, @tipo_usuario, @cep, @numero_residencia, @referencia, @foto_usuario, @sexo, @login)

			SELECT @@IDENTITY AS RETORNO
	END
	ELSE IF(@ACAO = 2) --ALTERAR--
	BEGIN
			
			UPDATE TB_USUARIO
			SET cpf_usuario = @cpf_usuario, rg_usuario = @rg_usuario, email_usuario = @email_usuario,  senha_usuario= @senha_usuario,nome_usuario = @nome_usuario , dt_nasc = @dt_nasc, dt_cad = @dt_cad, cep = @cep, numero_residencia = @numero_residencia, referencia = @referencia, foto_usuario = @foto_usuario, sexo=@sexo, login = @login 
			WHERE id_usuario = @id_usuario

			SELECT @id_usuario AS RETORNO
	END
	ELSE
	BEGIN
		RAISERROR('Ação não implementada', 14 , 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[iaeDisciplina]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[iaeDisciplina]
--PARÂMETROS--

	@ACAO INT, --0= EXCLUIR 1= INSERIR 2= ALTERAR
	@id_discp INT = NULL,
	@disciplina VARCHAR(50) = NULL
	
AS
BEGIN
	--CORPO--

	IF(@ACAO = 0) -- EXCLUIR --
	BEGIN
		DELETE FROM TB_DISCP
		WHERE id_discp = @id_discp
		
		SELECT @id_discp AS RETORNO

	END
	ELSE IF(@ACAO = 1) --INSERIR--
	BEGIN
			INSERT INTO TB_DISCP(disciplina)
			VALUES (@disciplina)

			SELECT @@IDENTITY AS RETORNO
	END
	ELSE IF(@ACAO = 2) --ALTERAR--
	BEGIN
			
			UPDATE TB_DISCP
			SET disciplina = @disciplina
			WHERE id_discp = @id_discp

			SELECT @id_discp AS RETORNO
	END
	ELSE
	BEGIN
		RAISERROR('Ação não implementada', 14 , 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[iaeTelefone]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[iaeTelefone]
--PARÂMETROS--

	@ACAO INT, --0= EXCLUIR 1= INSERIR 2= ALTERAR
	@id_telefone INT = NULL,
	@telefone VARCHAR(14) = NULL,
	@contato VARCHAR(50) = NULL,
	@tipo VARCHAR(50) = NULL
	
AS
BEGIN
	--CORPO--

	IF(@ACAO = 0) -- EXCLUIR --
	BEGIN
		DELETE FROM TB_TELEFONE
		WHERE id_telefone = @id_telefone
		
		SELECT @id_telefone AS RETORNO

	END
	ELSE IF(@ACAO = 1) --INSERIR--
	BEGIN
			INSERT INTO TB_TELEFONE(telefone,contato,tipo)
			VALUES (@telefone,@contato,@tipo)

			SELECT @@IDENTITY AS RETORNO
	END
	ELSE IF(@ACAO = 2) --ALTERAR--
	BEGIN
			
			UPDATE TB_TELEFONE
			SET telefone = @telefone, contato = @contato , tipo = @tipo 
			WHERE id_telefone = @id_telefone

			SELECT @id_telefone AS RETORNO
	END
	ELSE
	BEGIN
		RAISERROR('Ação não implementada', 14 , 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[iaeTurma]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[iaeTurma]
--PARÂMETROS--

	@ACAO INT, --0= EXCLUIR 1= INSERIR 2= ALTERAR
	@id_turma INT = NULL,
	@turma VARCHAR(3) = NULL,
	@periodo VARCHAR (10) = NULL,
	@ano DATE = NULL
AS
BEGIN
	--CORPO--

	IF(@ACAO = 0) -- EXCLUIR --
	BEGIN
		DELETE FROM TB_TURMA
		WHERE id_turma = @id_turma
		
		SELECT @id_turma AS RETORNO

	END
	ELSE IF(@ACAO = 1) --INSERIR--
	BEGIN
			INSERT INTO TB_TURMA(turma, periodo, ano)
			VALUES (@turma, @periodo, @ano)

			SELECT @@IDENTITY AS RETORNO
	END
	ELSE IF(@ACAO = 2) --ALTERAR--
	BEGIN
			
			UPDATE TB_TURMA
			SET turma = @turma
			WHERE id_turma = @id_turma

			SELECT @id_turma AS RETORNO
	END
	ELSE
	BEGIN
		RAISERROR('Ação não implementada', 14 , 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[inserir_Telefone_Usuario]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inserir_Telefone_Usuario]
@id_telefone INT = NULL,
@id_usuario INT = NULL
AS
BEGIN


INSERT INTO TB_TELEFONE_USUARIO(id_telefone,id_usuario)
			VALUES (@id_telefone,@id_usuario)

			SELECT @@IDENTITY AS RETORNO


END
GO
/****** Object:  StoredProcedure [dbo].[InserirTB_aluno_telefone]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirTB_aluno_telefone]

@id_matricula INT = NULL,
@id_telefone INT = NULL

AS
BEGIN
INSERT INTO TB_TELEFONE_ALUNO(id_matricula,id_telefone)
			VALUES (@id_matricula,@id_telefone)

			SELECT @@IDENTITY AS RETORNO

END
GO
/****** Object:  StoredProcedure [dbo].[Pr_AlunoTurma]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio Alunos com a sua turma no respectivo ano
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_AlunoTurma]
(
@ANO AS VARCHAR(4) = '',
@TURMA AS VARCHAR(5) = ''
)
as
BEGIN
IF @TURMA = ''
BEGIN
SELECT        TB_ALUNO.id_matricula, TB_ALUNO.nome_aluno, CASE WHEN TB_ALUNO.sexo = 1 THEN 'FEMININO' ELSE 'MASCULINO' END AS sexo, dbo.formatarData(TB_ALUNO.dt_nasc) AS dt_nasc, 
                         dbo.formatarRG(TB_ALUNO.rg) AS rg, dbo.formatarCPF(TB_ALUNO.cpf) AS cpf, TB_ALUNO.nome_responsavel, TB_TURMA.turma, TB_TURMA.ano
FROM            TB_ALUNO INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_TURMA.ano = @ANO
						 ORDER BY TB_ALUNO.nome_aluno
END
ELSE
SELECT        TB_ALUNO.id_matricula, TB_ALUNO.nome_aluno, CASE WHEN TB_ALUNO.sexo = 1 THEN 'FEMININO' ELSE 'MASCULINO' END AS sexo, dbo.formatarData(TB_ALUNO.dt_nasc) AS dt_nasc, 
                         dbo.formatarRG(TB_ALUNO.rg) AS rg, dbo.formatarCPF(TB_ALUNO.cpf) AS cpf, TB_ALUNO.nome_responsavel, TB_TURMA.turma, TB_TURMA.ano
FROM            TB_ALUNO INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_TURMA.ano = @ANO AND TB_TURMA.turma LIKE '%'+@TURMA+'%'
						 ORDER BY TB_ALUNO.nome_aluno
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_Boletim]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio Boletim
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_Boletim]
(
	@RA AS INT = 0,
	@ANO AS VARCHAR(4) = ''
)
AS
BEGIN
SELECT        TB_ALUNO.id_matricula, TB_ALUNO.nome_aluno, TB_DISCP.disciplina, TB_BOLETIM.nota, TB_BOLETIM.faltas , TB_BOLETIM.bimestre, TB_TURMA.turma, TB_BOLETIM.ano
FROM            TB_BOLETIM INNER JOIN
                         TB_ALUNO ON TB_BOLETIM.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_ALUNO.id_matricula = @RA AND TB_BOLETIM.ano LIKE '%'+@ANO+'%'
	GROUP BY TB_ALUNO.id_matricula, TB_ALUNO.nome_aluno, TB_DISCP.disciplina, TB_BOLETIM.nota, TB_BOLETIM.faltas , TB_BOLETIM.bimestre, TB_TURMA.turma, TB_BOLETIM.ano
	ORDER BY TB_ALUNO.id_matricula
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_DesemAluno]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio desempenho do Aluno nas disciplinas
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE[dbo].[Pr_DesemAluno]
(
	@RA AS INT = 0,
	@BIM AS CHAR(1) = '',
	@ANO AS VARCHAR(4) = ''
)
AS
BEGIN
IF @RA = 0 OR @BIM = '' OR @ANO = ''
BEGIN
SELECT        TB_ALUNO.nome_aluno, TB_BOLETIM.nota, TB_DISCP.disciplina, TB_BOLETIM.faltas
FROM            TB_BOLETIM INNER JOIN
                         TB_ALUNO ON TB_BOLETIM.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp
						 WHERE TB_ALUNO.id_matricula = 0 and TB_BOLETIM.bimestre = '' and TB_BOLETIM.ano = ''
END
ELSE
SELECT        TB_ALUNO.nome_aluno, TB_BOLETIM.nota, TB_DISCP.disciplina, TB_BOLETIM.faltas
FROM            TB_BOLETIM INNER JOIN
                         TB_ALUNO ON TB_BOLETIM.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp
						 WHERE TB_ALUNO.id_matricula = @RA and TB_BOLETIM.bimestre = @BIM and TB_BOLETIM.ano = @ANO
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_DesemEscola]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio desempenho de todas as turmas [Desempenho Escolar]
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE[dbo].[Pr_DesemEscola]
(
	@ANO AS VARCHAR(4) = '',
	@DISCP AS VARCHAR(50) = '',
	@BIM AS CHAR(1) = ''
)
AS
BEGIN
IF @ANO = '' OR @BIM = ''
BEGIN
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre 
FROM            TB_TURMA LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM
							  WHERE bimestre = ''
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma INNER JOIN
                         TB_ALUNO_TURMA ON TB_TURMA.id_turma = TB_ALUNO_TURMA.id_turma INNER JOIN
                         TB_ALUNO ON TB_ALUNO_TURMA.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula
						 WHERE TB_BOLETIM.bimestre = '' AND TB_BOLETIM.ano = ''
						 GROUP BY ME.MEDIA, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre
END
ELSE IF @DISCP = ''
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre 
FROM            TB_TURMA LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM
							  WHERE bimestre = @BIM
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma INNER JOIN
                         TB_ALUNO_TURMA ON TB_TURMA.id_turma = TB_ALUNO_TURMA.id_turma INNER JOIN
                         TB_ALUNO ON TB_ALUNO_TURMA.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula
						 WHERE TB_BOLETIM.bimestre = @BIM AND TB_BOLETIM.ano = @ANO
						 GROUP BY ME.MEDIA, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre
ELSE IF @DISCP <> '' AND @ANO <> '' AND @BIM <> ''
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre 
FROM            TB_TURMA LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM INNER JOIN
							  TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp
							  WHERE bimestre = @BIM and TB_DISCP.disciplina = @DISCP
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma INNER JOIN
                         TB_ALUNO_TURMA ON TB_TURMA.id_turma = TB_ALUNO_TURMA.id_turma INNER JOIN	
                         TB_ALUNO ON TB_ALUNO_TURMA.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula					  
						 WHERE TB_BOLETIM.bimestre = @BIM AND TB_BOLETIM.ano = @ANO 
						 GROUP BY ME.MEDIA, TB_TURMA.id_turma, TB_TURMA.turma, TB_BOLETIM.bimestre 
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_DesemProf]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio desempenho do professor em relação as turmas
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE[dbo].[Pr_DesemProf]
(
	@ANO AS VARCHAR(4) = '',
	@CODIGO AS INT = 0,
	@BIM AS CHAR(1) = '',
	@DISCP AS VARCHAR(50) = ''
)
AS
BEGIN
IF @ANO = '' OR @CODIGO = 0 OR @BIM = ''
BEGIN
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.turma,TB_USUARIO.nome_usuario
FROM            TB_USUARIO  INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_BOLETIM ON TB_DISCP.id_discp = TB_BOLETIM.id_discp INNER JOIN
                         TB_TURMA ON TB_BOLETIM.id_turma = TB_TURMA.id_turma LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM INNER JOIN
							  TB_PROFESSOR_DISCIPLINA ON TB_BOLETIM.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp 
							  WHERE bimestre = '' and TB_PROFESSOR_DISCIPLINA.id_usuario = '' AND TB_BOLETIM.ano = ''
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma
						WHERE TB_USUARIO.id_usuario = ''
						GROUP BY ME.media , TB_TURMA.turma, TB_USUARIO.nome_usuario
END
ELSE IF @DISCP = ''
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.turma,TB_USUARIO.nome_usuario
FROM            TB_USUARIO  INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_BOLETIM ON TB_DISCP.id_discp = TB_BOLETIM.id_discp INNER JOIN
                         TB_TURMA ON TB_BOLETIM.id_turma = TB_TURMA.id_turma LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM INNER JOIN
							  TB_PROFESSOR_DISCIPLINA ON TB_BOLETIM.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp INNER JOIN
							  TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp 
							  WHERE bimestre = @BIM and TB_PROFESSOR_DISCIPLINA.id_usuario = @CODIGO
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma
						WHERE TB_USUARIO.id_usuario = @CODIGO  AND TB_BOLETIM.ano = @ANO
						GROUP BY ME.media , TB_TURMA.turma, TB_USUARIO.nome_usuario
ELSE
SELECT        Cast(ME.media AS NUMERIC(4,1)) as media, TB_TURMA.turma,TB_USUARIO.nome_usuario,TB_DISCP.disciplina
FROM            TB_USUARIO  INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_BOLETIM ON TB_DISCP.id_discp = TB_BOLETIM.id_discp INNER JOIN
                         TB_TURMA ON TB_BOLETIM.id_turma = TB_TURMA.id_turma LEFT JOIN
						(
							SELECT id_turma, AVG(nota) as media 
							  FROM dbo.TB_BOLETIM INNER JOIN
							  TB_PROFESSOR_DISCIPLINA ON TB_BOLETIM.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp INNER JOIN
							  TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp 
							  WHERE bimestre = @BIM and TB_PROFESSOR_DISCIPLINA.id_usuario = @CODIGO and TB_DISCP.disciplina = @DISCP
							Group by id_turma 
						) ME on ME.id_turma = TB_TURMA.id_turma
						WHERE TB_USUARIO.id_usuario = @CODIGO and TB_DISCP.disciplina = @DISCP AND TB_BOLETIM.ano = @ANO
						GROUP BY ME.media , TB_TURMA.turma, TB_USUARIO.nome_usuario,TB_DISCP.disciplina
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_MaiorNota]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio Aluno com a maior nota em uma disciplina
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE[dbo].[Pr_MaiorNota]
(
	@TURMA AS VARCHAR(5) = '',
	@DISCP AS VARCHAR(50) = '',
	@BIM AS CHAR(1) = '',
	@ANO AS VARCHAR(4) = ''
)
AS
BEGIN
IF @TURMA = '' AND @DISCP = '' OR @BIM = '' OR @ANO = ''
BEGIN
SELECT        TB_BOLETIM.nota, TB_ALUNO.nome_aluno, TB_DISCP.disciplina, TB_TURMA.turma, TB_BOLETIM.faltas
FROM            TB_ALUNO INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_TURMA.TURMA = '' AND TB_DISCP.disciplina = '' AND TB_BOLETIM.bimestre = '' AND TB_TURMA.ano = ''
						 GROUP BY TB_ALUNO.nome_aluno, TB_BOLETIM.NOTA, TB_DISCP.disciplina, TB_TURMA.turma, TB_BOLETIM.faltas
						 ORDER BY TB_ALUNO.nome_aluno
END
ELSE IF @DISCP = ''
SELECT        TB_ALUNO.nome_aluno, CAST(ME.NOTA AS numeric(4,1)) AS NOTA, TB_TURMA.turma, TB_BOLETIM.bimestre, TB_BOLETIM.faltas 
FROM            TB_ALUNO LEFT JOIN
					(
		SELECT id_matricula, AVG(nota) as NOTA 
		  FROM dbo.TB_BOLETIM
		  WHERE bimestre = @BIM
		Group by id_MATRICULA
	) ME on ME.id_matricula = TB_ALUNO.id_matricula INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_BOLETIM.bimestre = @BIM AND TB_TURMA.turma = @TURMA AND TB_TURMA.ano = @ANO 
						 GROUP BY TB_ALUNO.nome_aluno, TB_TURMA.turma, TB_BOLETIM.bimestre, ME.NOTA, TB_BOLETIM.faltas
ELSE
SELECT        TB_BOLETIM.nota, TB_ALUNO.nome_aluno, TB_DISCP.disciplina, TB_TURMA.turma, TB_BOLETIM.faltas
FROM            TB_ALUNO INNER JOIN
                         TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN
                         TB_BOLETIM ON TB_ALUNO.id_matricula = TB_BOLETIM.id_matricula INNER JOIN
                         TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp INNER JOIN
                         TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma
						 WHERE TB_TURMA.TURMA = @TURMA AND TB_DISCP.disciplina = @DISCP AND TB_BOLETIM.bimestre = @BIM AND TB_TURMA.ano = @ANO
						 GROUP BY TB_ALUNO.nome_aluno, TB_BOLETIM.NOTA, TB_DISCP.disciplina, TB_TURMA.turma, TB_BOLETIM.faltas
						 ORDER BY TB_ALUNO.nome_aluno
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_Obs]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio Observações
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_Obs]
(
@RA AS INT = 0,
@DATAI AS VARCHAR(10) = '',
@DATAF AS VARCHAR(10) = ''
)
as
BEGIN
IF @DATAI = '' AND @DATAF = ''
BEGIN
SELECT        dbo.formatarData(N.data) as data, A.nome_aluno, N.notificacao, USU.nome_usuario
FROM            dbo.TB_ALUNO AS A INNER JOIN
                         dbo.TB_NOTIFICACOES AS N ON A.id_matricula = N.id_matricula INNER JOIN
                         dbo.TB_USUARIO AS USU ON N.id_usuario = USU.id_usuario
						 WHERE A.id_matricula = @RA
						 --WHERE A.id_matricula = @RA AND year([data]) = @ANO
						 ORDER BY N.data
END
ELSE IF @DATAF = ''
SELECT        dbo.formatarData(N.data) as data, A.nome_aluno, N.notificacao, USU.nome_usuario
FROM            dbo.TB_ALUNO AS A INNER JOIN
                         dbo.TB_NOTIFICACOES AS N ON A.id_matricula = N.id_matricula INNER JOIN
                         dbo.TB_USUARIO AS USU ON N.id_usuario = USU.id_usuario
						 WHERE A.id_matricula = @RA AND data >= @DATAI
						 --WHERE A.id_matricula = @RA AND year([data]) = @ANO
						 ORDER BY N.data
ELSE IF @DATAI = ''
SELECT        dbo.formatarData(N.data) as data, A.nome_aluno, N.notificacao, USU.nome_usuario
FROM            dbo.TB_ALUNO AS A INNER JOIN
                         dbo.TB_NOTIFICACOES AS N ON A.id_matricula = N.id_matricula INNER JOIN
                         dbo.TB_USUARIO AS USU ON N.id_usuario = USU.id_usuario
						 WHERE A.id_matricula = @RA AND data <= @DATAF
						 --WHERE A.id_matricula = @RA AND year([data]) = @ANO
						 ORDER BY N.data
ELSE
SELECT        dbo.formatarData(N.data) as data, A.nome_aluno, N.notificacao, USU.nome_usuario
FROM            dbo.TB_ALUNO AS A INNER JOIN
                         dbo.TB_NOTIFICACOES AS N ON A.id_matricula = N.id_matricula INNER JOIN
                         dbo.TB_USUARIO AS USU ON N.id_usuario = USU.id_usuario
						 WHERE A.id_matricula = @RA AND data >= @DATAI AND data <= @DATAF
						 ORDER BY N.data
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_ProfDiscp]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Professor com disciplina
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_ProfDiscp]
(
	@NOME AS VARCHAR(50) = '',
	@DISCP AS VARCHAR(50) = ''
)
AS
BEGIN
IF @NOME = '' AND @DISCP = '' 
BEGIN
SELECT TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, TB_DISCP.disciplina
FROM            TB_USUARIO INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR')
END
ELSE IF @NOME = ''
SELECT        TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, TB_DISCP.disciplina
FROM            TB_USUARIO INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR') AND TB_DISCP.disciplina = @DISCP
ELSE IF @DISCP = ''
SELECT        TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, TB_DISCP.disciplina
FROM            TB_USUARIO INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR') AND TB_USUARIO.nome_usuario LIKE '%'+@NOME+'%'
ELSE
SELECT TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, TB_DISCP.disciplina
FROM            TB_USUARIO INNER JOIN
                         TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN
                         TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR') AND TB_DISCP.disciplina = @DISCP AND TB_USUARIO.nome_usuario LIKE '%'+@NOME+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_Professor]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Professor
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_Professor]
(
	@NOME AS VARCHAR(50) = ''
)
AS
BEGIN
IF @NOME = ''
BEGIN
SELECT        TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, CASE WHEN TB_USUARIO.sexo = 1 THEN 'FEMININO' ELSE 'MASCULINO' END AS sexo, dbo.formatarData(TB_USUARIO.dt_nasc) AS dt_nasc, 
                         dbo.formatarRG(TB_USUARIO.rg_usuario) AS rg_usuario, dbo.formatarCPF(TB_USUARIO.cpf_usuario) AS cpf_usuario, TB_USUARIO.login
FROM            TB_USUARIO
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR')
END
ELSE
SELECT        TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, CASE WHEN TB_USUARIO.sexo = 1 THEN 'FEMININO' ELSE 'MASCULINO' END AS sexo, dbo.formatarData(TB_USUARIO.dt_nasc) AS dt_nasc, 
                         dbo.formatarRG(TB_USUARIO.rg_usuario) AS rg_usuario, dbo.formatarCPF(TB_USUARIO.cpf_usuario) AS cpf_usuario, TB_USUARIO.login
FROM            TB_USUARIO
WHERE        (TB_USUARIO.tipo_usuario = 'PROFESSOR') AND TB_USUARIO.nome_usuario LIKE '%'+@NOME+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[Pr_TurmaTotal]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Objetivo: Consultar Relatorio Turmas
Autor...: Caio Cesar
Data....: JUNHO/2017
*/
CREATE PROCEDURE [dbo].[Pr_TurmaTotal]
(
@PERIODO AS VARCHAR(10) = '',
@ANO AS VARCHAR(4) = ''
)
as
BEGIN
IF @PERIODO = '' AND @ANO = ''
BEGIN
SELECT T.id_turma, T.turma, T.periodo, T.ano, ta.Qt_Aluno
FROM TB_TURMA T
     left Join 
	 (
		SELECT id_turma, Count(id_matricula) as Qt_Aluno
		  FROM dbo.TB_ALUNO_TURMA
		Group by id_turma
	) TA on TA.id_turma = T.id_turma
END
ELSE IF @ANO = ''
SELECT T.id_turma, T.turma, T.periodo, T.ano, ta.Qt_Aluno
FROM TB_TURMA T
     left Join 
	 (
		SELECT id_turma, Count(id_matricula) as Qt_Aluno
		  FROM dbo.TB_ALUNO_TURMA
		Group by id_turma
	) TA on TA.id_turma = T.id_turma
WHERE T.periodo = @PERIODO
--WHERE T.ano = '2017'
--WHERE T.periodo = 'MANHÃ'
ELSE IF @PERIODO = ''
SELECT T.id_turma, T.turma, T.periodo, T.ano, ta.Qt_Aluno
FROM TB_TURMA T
     left Join 
	 (
		SELECT id_turma, Count(id_matricula) as Qt_Aluno
		  FROM dbo.TB_ALUNO_TURMA
		Group by id_turma
	) TA on TA.id_turma = T.id_turma
WHERE T.ano LIKE '%'+@ANO+'%'
ELSE
SELECT T.id_turma, T.turma, T.periodo, T.ano, ta.Qt_Aluno
FROM TB_TURMA T
     left Join 
	 (
		SELECT id_turma, Count(id_matricula) as Qt_Aluno
		  FROM dbo.TB_ALUNO_TURMA
		Group by id_turma
	) TA on TA.id_turma = T.id_turma
WHERE T.periodo = @PERIODO AND T.ano LIKE '%'+@ANO+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarAluno]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultarAluno]

@nome_aluno Varchar(50) = null,
@dt_nasc DATE = null,
@id_matricula INT = null

AS

BEGIN

	SELECT * FROM TB_ALUNO WHERE nome_aluno = @nome_aluno and dt_nasc = @dt_nasc or id_matricula = @id_matricula
	 
END

GO
/****** Object:  StoredProcedure [dbo].[uspConsultarUsuario]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspConsultarUsuario]

@nome_usuario Varchar(50) = null,
@dt_nasc DATE = null,
@id_usuario INT = null

AS

BEGIN

	SELECT * FROM TB_USUARIO WHERE nome_usuario = @nome_usuario and dt_nasc = @dt_nasc or id_usuario = @id_usuario
	 
END
GO
/****** Object:  StoredProcedure [dbo].[uspDisciplina]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspDisciplina]

AS

BEGIN

	SELECT
	*
	FROM
	TB_DISCP

END

 
GO
/****** Object:  StoredProcedure [dbo].[uspIAEALUNO]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspIAEALUNO]
--PARÂMETROS--

	@ACAO INT, --0= EXCLUIR 1= INSERIR 2= ALTERAR
	@id_matricula INT = NULL,
	@rg VARCHAR(9) = NULL,
	@nome_aluno VARCHAR(50) = NULL,
	@cep_aluno VARCHAR(60) = NULL,
	@cpf VARCHAR(11) = NULL,
	@dt_nasc DATE = NULL,
	@nome_responsavel VARCHAR(50) = NULL,
	@senha VARCHAR(20) = NULL,
	@ponto_ref VARCHAR (60) = NULL,
	@dt_cad DATE = NULL,
	@foto_aluno VARCHAR(300) = NULL,
	@email_aluno VARCHAR(60) = NULL,
	@sexo BIT = NULL,
	@Num_Casa INT = Null
AS
BEGIN
	--CORPO--

	IF(@ACAO = 0) -- EXCLUIR --
	BEGIN
		DELETE FROM TB_ALUNO
		WHERE id_matricula = @id_matricula
		
		SELECT @id_matricula AS RETORNO

	END
	ELSE IF(@ACAO = 1) --INSERIR--
	BEGIN
			INSERT INTO TB_ALUNO (id_matricula, rg, nome_aluno, cep_aluno, cpf, dt_nasc, nome_responsavel, senha, ponto_ref, dt_cad, foto_aluno, email_aluno, sexo, Num_Casa)
			VALUES (@id_matricula, @rg ,@nome_aluno, @cep_aluno, @cpf, @dt_nasc, @nome_responsavel, @senha, @ponto_ref, @dt_cad, @foto_aluno, @email_aluno, @sexo, @Num_Casa)

			SELECT @@IDENTITY AS RETORNO
	END
	ELSE IF(@ACAO = 2) --ALTERAR--
	BEGIN
			
			UPDATE TB_ALUNO
			SET nome_aluno = @nome_aluno, rg = @rg, cep_aluno = @cep_aluno, cpf = @cpf, dt_nasc = @dt_nasc, nome_responsavel = @nome_responsavel, senha = @senha, ponto_ref = @ponto_ref, dt_cad = @dt_cad, foto_aluno = @foto_aluno, email_aluno = @email_aluno
			WHERE id_matricula = @id_matricula

			SELECT @id_matricula AS RETORNO
	END
	ELSE
	BEGIN
		RAISERROR('Ação não implementada', 14 , 1);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspTelefone]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTelefone]
@telefone VARCHAR(14) = NULL
AS

BEGIN
	
	SELECT 
	*
	FROM
	
	TB_TELEFONE where telefone like '%'+@telefone+'%' ;


END 
GO
/****** Object:  StoredProcedure [dbo].[uspTurma]    Script Date: 29/11/2021 14:16:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTurma]

AS
BEGIN

SELECT
*
FROM
TB_TURMA

END
GO
USE [master]
GO
ALTER DATABASE [BD_TCC] SET  READ_WRITE 
GO

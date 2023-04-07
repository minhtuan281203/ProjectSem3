CREATE TABLE [Candidate] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Fullname] nvarchar(255) NOT NULL,
  [Age] int NOT NULL,
  [Address] nvarchar(max) NOT NULL,
  [Phone] nvarchar(20) NOT NULL,
  [Literacy] nvarchar(255),
  [Majors] nvarchar(255) ,
  [Graduate] nvarchar(255) ,
  [Vacancy] nvarchar(255),
  [Description] nvarchar(max),
  [AccountID] int,
  FOREIGN KEY (AccountID) REFERENCES Account(ID)
)
GO

CREATE TABLE [Account] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Email] nvarchar(255) NOT NULL,
  [Password] nvarchar(255) NOT NULL,
  [Role] nvarchar(255) 
)
GO

CREATE TABLE [Candidate_list] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [job_id] int,
    FOREIGN KEY (job_id) REFERENCES Job(ID),
  [can_id] int,
    FOREIGN KEY (can_id) REFERENCES Candidate(ID),
  [Interview_id] int,
    FOREIGN KEY (Interview_id) REFERENCES Interview(ID)
)
GO

CREATE TABLE [Interview] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Inter_Date] date,
  [Static] nvarchar(255),
  [FullName] nvarchar(200)
)
GO

CREATE TABLE [Company] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Name] nvarchar(255) NOT NULL
)
GO

CREATE TABLE [Job] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Title] nvarchar(255) NOT NULL,
  [Wage] float NOT NULL,
  [Image] nvarchar(255) NOT NULL,
  [Date_create] date NOT NULL,
  [Modification] date,

  [Job_description] nvarchar(max),
  [Vacancy] nvarchar(255),
  [Address] nvarchar(max),
  [Tag] nvarchar(max) ,
  [CatID] int,
     FOREIGN KEY (CatID) REFERENCES Category(ID),
    [CompanyID] int,
	   FOREIGN KEY (CompanyID) REFERENCES Company(ID)
)
GO

CREATE TABLE [Category] (
  [ID] int PRIMARY KEY IDENTITY(1, 1),
  [Levers] int NOT NULL,
  [Following] float,
  [Title] nvarchar(255),
)
GO

ALTER TABLE [Company] ADD Image nvarchar(255) 
go

ALTER TABLE [Account] ADD FOREIGN KEY ([ID]) REFERENCES [Candidate] ([AccountID])
GO

ALTER TABLE [Category] ADD FOREIGN KEY ([ID]) REFERENCES [Job] ([CatID])
GO

ALTER TABLE [Candidate_list] ADD FOREIGN KEY ([can_id]) REFERENCES [Candidate] ([ID])
GO

ALTER TABLE [Job] ADD FOREIGN KEY ([ID]) REFERENCES [Candidate_list] ([job_id])
GO

ALTER TABLE [Company] ADD FOREIGN KEY ([ID]) REFERENCES [Job] ([CompanyID])
GO

ALTER TABLE [Interview] ADD FOREIGN KEY ([ID]) REFERENCES [Candidate_list] ([Interview_id])
GO


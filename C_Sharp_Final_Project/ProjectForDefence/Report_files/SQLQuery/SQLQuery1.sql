-- =========================================
-- Create Database
-- =========================================
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'PeerSyncDB')
BEGIN
    DROP DATABASE PeerSyncDB;
END
GO

CREATE DATABASE PeerSyncDB;
GO

USE PeerSyncDB;
GO

-- =========================================
-- Table 1: User
-- Stores user account information
-- =========================================
CREATE TABLE [User]
(
    UserId INT PRIMARY KEY IDENTITY(1,1),
    AiubId NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    Name NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Department NVARCHAR(50) NOT NULL,
    Semester NVARCHAR(20) NOT NULL,
    Role NVARCHAR(20) DEFAULT 'Student',
    ReputationScore INT DEFAULT 0
);

-- =========================================
-- Table 2: Skill
-- Stores user skills
-- =========================================
CREATE TABLE Skill
(
    SkillId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL
        FOREIGN KEY REFERENCES [User](UserId)
        ON DELETE CASCADE,
    SkillName NVARCHAR(50) NOT NULL
);

-- =========================================
-- Table 3: WorkStyle
-- Stores preferred work styles of users
-- =========================================
CREATE TABLE WorkStyle
(
    WorkStyleId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL
        FOREIGN KEY REFERENCES [User](UserId)
        ON DELETE CASCADE,
    StyleName NVARCHAR(50) NOT NULL
);

-- =========================================
-- Table 4: Swipe
-- Stores swipe actions between users
-- =========================================
CREATE TABLE Swipe
(
    SwipeId INT PRIMARY KEY IDENTITY(1,1),
    SwiperId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    SwipedId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    IsInterested BIT NOT NULL,
    [Timestamp] DATETIME DEFAULT GETDATE()
);

-- =========================================
-- Table 5: Match
-- Stores successful matches
-- =========================================
CREATE TABLE Match
(
    MatchId INT PRIMARY KEY IDENTITY(1,1),
    User1Id INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    User2Id INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    MatchedAt DATETIME DEFAULT GETDATE()
);

-- =========================================
-- Table 6: ProjectGroup
-- Stores project group information
-- =========================================
CREATE TABLE ProjectGroup
(
    GroupId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    ProjectTitle NVARCHAR(200) NOT NULL, -- Expanded to match documentation thresholds
    CreatorId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    CreatedAt DATETIME DEFAULT GETDATE()
);

-- =========================================
-- Table 7: GroupMember
-- Stores members of project groups
-- =========================================
CREATE TABLE GroupMember
(
    MemberId INT PRIMARY KEY IDENTITY(1,1),
    GroupId INT NOT NULL 
        FOREIGN KEY REFERENCES ProjectGroup(GroupId)
        ON DELETE CASCADE,
    UserId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    Role NVARCHAR(20) NOT NULL
);

-- =========================================
-- Table 8: Rating
-- Stores peer ratings and feedback
-- =========================================
CREATE TABLE Rating
(
    RatingId INT PRIMARY KEY IDENTITY(1,1),
    RaterId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    RateeId INT NOT NULL FOREIGN KEY REFERENCES [User](UserId),
    GroupId INT NOT NULL FOREIGN KEY REFERENCES ProjectGroup(GroupId),
    Contribution INT NOT NULL CHECK (Contribution BETWEEN 1 AND 5),
    Communication INT NOT NULL CHECK (Communication BETWEEN 1 AND 5),
    Reliability INT NOT NULL CHECK (Reliability BETWEEN 1 AND 5),
    Punctuality INT NOT NULL CHECK (Punctuality BETWEEN 1 AND 5),
    Comments NVARCHAR(500) -- Expanded length for better user feedback
);
GO

-- =========================================
-- Success Message
-- =========================================
PRINT 'Database & Tables created successfully!';
GO
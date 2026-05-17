-- ============================================================
--  PeerSync Database -- DDL Script (Microsoft SQL Server)
--  Project : PeerSync -- Peer-Driven Academic Group Formation
--  Course  : OOP2, AIUB
-- ============================================================

-- Create database (run once, comment out if DB already exists)
-- CREATE DATABASE PeerSync;
-- GO
-- USE PeerSync;
-- GO

-- ============================================================
-- TABLE 1: USER  (parent -- no FK dependencies)
-- ============================================================
CREATE TABLE [USER] (
    UserId          INT             PRIMARY KEY IDENTITY(1,1),
    AiubId          NVARCHAR(20)    NOT NULL UNIQUE,
    PasswordHash    NVARCHAR(255)   NOT NULL,
    Name            NVARCHAR(100)   NOT NULL,
    Gender          NVARCHAR(10)    NOT NULL,
    Department      NVARCHAR(50)    NOT NULL,
    Semester        NVARCHAR(10)    NOT NULL,
    Role            NVARCHAR(20)    NOT NULL DEFAULT 'Student',
    ReputationScore INT             NOT NULL DEFAULT 0
);
GO

-- ============================================================
-- TABLE 2: SKILL  (FK -> USER)
-- ============================================================
CREATE TABLE SKILL (
    SkillId     INT             PRIMARY KEY IDENTITY(1,1),
    UserId      INT             NOT NULL,
    SkillName   NVARCHAR(100)   NOT NULL,
    CONSTRAINT FK_Skill_User FOREIGN KEY (UserId)
        REFERENCES [USER](UserId) ON DELETE CASCADE
);
GO

-- ============================================================
-- TABLE 3: WORK_STYLE  (FK -> USER)
-- ============================================================
CREATE TABLE WORK_STYLE (
    WorkStyleId INT             PRIMARY KEY IDENTITY(1,1),
    UserId      INT             NOT NULL,
    StyleName   NVARCHAR(50)    NOT NULL,
    CONSTRAINT FK_WorkStyle_User FOREIGN KEY (UserId)
        REFERENCES [USER](UserId) ON DELETE CASCADE
);
GO

-- ============================================================
-- TABLE 4: SWIPE  (FK -> USER x2)
-- ============================================================
CREATE TABLE SWIPE (
    SwipeId         INT         PRIMARY KEY IDENTITY(1,1),
    SwiperId        INT         NOT NULL,
    SwipedId        INT         NOT NULL,
    IsInterested    BIT         NOT NULL DEFAULT 1,
    [Timestamp]     DATETIME    NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Swipe_Swiper FOREIGN KEY (SwiperId)
        REFERENCES [USER](UserId),
    CONSTRAINT FK_Swipe_Swiped FOREIGN KEY (SwipedId)
        REFERENCES [USER](UserId),
    CONSTRAINT CHK_Swipe_NoSelf CHECK (SwiperId <> SwipedId)
);
GO

-- ============================================================
-- TABLE 5: MATCH  (FK -> USER x2)
-- ============================================================
CREATE TABLE [MATCH] (
    MatchId     INT         PRIMARY KEY IDENTITY(1,1),
    User1Id     INT         NOT NULL,
    User2Id     INT         NOT NULL,
    MatchedAt   DATETIME    NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Match_User1 FOREIGN KEY (User1Id)
        REFERENCES [USER](UserId),
    CONSTRAINT FK_Match_User2 FOREIGN KEY (User2Id)
        REFERENCES [USER](UserId),
    CONSTRAINT CHK_Match_NoSelf CHECK (User1Id <> User2Id)
);
GO

-- ============================================================
-- TABLE 6: PROJECT_GROUP  (FK -> USER as Creator)
-- ============================================================
CREATE TABLE PROJECT_GROUP (
    GroupId         INT             PRIMARY KEY IDENTITY(1,1),
    CourseName      NVARCHAR(100)   NOT NULL,
    ProjectTitle    NVARCHAR(200)   NOT NULL,
    CreatorId       INT             NOT NULL,
    CreatedAt       DATETIME        NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Group_Creator FOREIGN KEY (CreatorId)
        REFERENCES [USER](UserId)
);
GO

-- ============================================================
-- TABLE 7: GROUP_MEMBER  (FK -> PROJECT_GROUP, USER)
-- ============================================================
CREATE TABLE GROUP_MEMBER (
    MemberId    INT             PRIMARY KEY IDENTITY(1,1),
    GroupId     INT             NOT NULL,
    UserId      INT             NOT NULL,
    Role        NVARCHAR(20)    NOT NULL DEFAULT 'Member',
    CONSTRAINT FK_Member_Group FOREIGN KEY (GroupId)
        REFERENCES PROJECT_GROUP(GroupId) ON DELETE CASCADE,
    CONSTRAINT FK_Member_User FOREIGN KEY (UserId)
        REFERENCES [USER](UserId),
    CONSTRAINT UQ_Member_GroupUser UNIQUE (GroupId, UserId)
);
GO

-- ============================================================
-- TABLE 8: RATING  (FK -> USER x2, PROJECT_GROUP)
-- ============================================================
CREATE TABLE RATING (
    RatingId        INT             PRIMARY KEY IDENTITY(1,1),
    RaterId         INT             NOT NULL,
    RateeId         INT             NOT NULL,
    GroupId         INT             NOT NULL,
    Contribution    INT             NOT NULL CHECK (Contribution    BETWEEN 1 AND 5),
    Communication   INT             NOT NULL CHECK (Communication   BETWEEN 1 AND 5),
    Reliability     INT             NOT NULL CHECK (Reliability     BETWEEN 1 AND 5),
    Punctuality     INT             NOT NULL CHECK (Punctuality     BETWEEN 1 AND 5),
    Comments        NVARCHAR(500)   NULL,
    CONSTRAINT FK_Rating_Rater FOREIGN KEY (RaterId)
        REFERENCES [USER](UserId),
    CONSTRAINT FK_Rating_Ratee FOREIGN KEY (RateeId)
        REFERENCES [USER](UserId),
    CONSTRAINT FK_Rating_Group FOREIGN KEY (GroupId)
        REFERENCES PROJECT_GROUP(GroupId),
    CONSTRAINT CHK_Rating_NoSelf CHECK (RaterId <> RateeId)
);
GO

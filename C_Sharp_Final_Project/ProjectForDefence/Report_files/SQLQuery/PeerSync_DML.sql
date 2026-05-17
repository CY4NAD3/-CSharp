-- ============================================================
--  PeerSync Database -- DML Script (Sample Data)
--  Matches the exact data from the project screenshots
-- ============================================================

USE PeerSyncDB;
GO

-- ============================================================
-- INSERT: User
-- ============================================================
SET IDENTITY_INSERT [User] ON;
INSERT INTO [User] (UserId, AiubId, PasswordHash, Name, Gender, Department, Semester, Role, ReputationScore) VALUES
(1, '22-49653-3', '12345', 'Sajal Mollick',   'Male',   'Cse', '10', 'Student', 4),
(2, '22-47521-2', '54321', 'Azizul Alam',     'Male',   'Cse', '10', 'Student', 3),
(3, '24-57476-2', '1234',  'Azraful Alam',    'Male',   'Cse', '6',  'Student', 4),
(4, '22-49569-3', '4321',  'Sabrina Islam',   'Female', 'Cse', '10', 'Student', 3);
SET IDENTITY_INSERT [User] OFF;
GO

-- ============================================================
-- INSERT: Skill
-- ============================================================
SET IDENTITY_INSERT Skill ON;
INSERT INTO Skill (SkillId, UserId, SkillName) VALUES
(1, 1, 'C#'),
(2, 2, 'C#'),
(3, 3, 'C#'),
(4, 3, 'JAVA'),
(5, 4, 'C++'),
(6, 4, 'JAVA'),
(7, 4, 'C#');
SET IDENTITY_INSERT Skill OFF;
GO

-- ============================================================
-- INSERT: WorkStyle (Fixed Table Name)
-- ============================================================
SET IDENTITY_INSERT WorkStyle ON;
INSERT INTO WorkStyle (WorkStyleId, UserId, StyleName) VALUES
(1, 1, 'Night'),
(2, 2, 'Day'),
(3, 3, 'Day'),
(4, 4, 'Night');
SET IDENTITY_INSERT WorkStyle OFF;
GO

-- ============================================================
-- INSERT: Swipe
-- ============================================================
SET IDENTITY_INSERT Swipe ON;
INSERT INTO Swipe (SwipeId, SwiperId, SwipedId, IsInterested, [Timestamp]) VALUES
(1, 1, 2, 1, '2026-05-16 00:03:20.220'),
(2, 1, 3, 1, '2026-05-16 00:03:21.913'),
(3, 1, 4, 1, '2026-05-16 00:03:22.863'),
(4, 2, 1, 1, '2026-05-16 00:04:00.023'),
(5, 2, 3, 1, '2026-05-16 00:04:02.907'),
(6, 2, 4, 1, '2026-05-16 00:04:05.630'),
(7, 3, 1, 1, '2026-05-16 00:04:45.367');
SET IDENTITY_INSERT Swipe OFF;
GO

-- ============================================================
-- INSERT: Match
-- ============================================================
SET IDENTITY_INSERT [Match] ON;
INSERT INTO [Match] (MatchId, User1Id, User2Id, MatchedAt) VALUES
(1, 2, 1, '2026-05-16 00:04:00.050'),
(2, 2, 3, '2026-05-16 00:04:45.383'),
(3, 3, 2, '2026-05-16 00:04:48.453'),
(4, 4, 1, '2026-05-16 00:05:17.953'),
(5, 4, 2, '2026-05-16 00:05:21.060'),
(6, 4, 3, '2026-05-16 00:05:23.643');
SET IDENTITY_INSERT [Match] OFF;
GO

-- ============================================================
-- INSERT: ProjectGroup (Fixed Table Name)
-- ============================================================
SET IDENTITY_INSERT ProjectGroup ON;
INSERT INTO ProjectGroup (GroupId, CourseName, ProjectTitle, CreatorId, CreatedAt) VALUES
(1, 'OOP2', 'PeerSync', 1, '2026-05-16 00:06:46.923');
SET IDENTITY_INSERT ProjectGroup OFF;
GO

-- ============================================================
-- INSERT: GroupMember (Fixed Table Name)
-- ============================================================
SET IDENTITY_INSERT GroupMember ON;
INSERT INTO GroupMember (MemberId, GroupId, UserId, Role) VALUES
(1, 1, 1, 'Creator'),
(2, 1, 2, 'Member'),
(3, 1, 3, 'Member'),
(4, 1, 4, 'Member');
SET IDENTITY_INSERT GroupMember OFF;
GO

-- ============================================================
-- INSERT: Rating
-- ============================================================
SET IDENTITY_INSERT Rating ON;
INSERT INTO Rating (RatingId, RaterId, RateeId, GroupId, Contribution, Communication, Reliability, Punctuality, Comments) VALUES
(1, 1, 2, 1, 3, 4, 4, 2, NULL),
(2, 1, 3, 1, 3, 4, 4, 5, NULL),
(3, 1, 4, 1, 4, 2, 4, 3, NULL),
(4, 2, 1, 1, 4, 3, 4, 4, NULL),
(5, 3, 1, 1, 5, 4, 2, 5, NULL),
(6, 4, 1, 1, 5, 5, 5, 5, NULL),
(7, 4, 2, 1, 2, 4, 4, 3, NULL),
(8, 4, 3, 1, 5, 5, 5, 5, NULL);
SET IDENTITY_INSERT Rating OFF;
GO

PRINT 'Sample data inserted successfully!';
GO
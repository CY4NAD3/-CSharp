-- ============================================================
--  PeerSync Database -- DML Script (Sample Data)
--  Matches the exact data from the project screenshots
-- ============================================================

-- USE PeerSync;
-- GO

-- ============================================================
-- INSERT: USER
-- ============================================================
SET IDENTITY_INSERT [USER] ON;
INSERT INTO [USER] (UserId, AiubId, PasswordHash, Name, Gender, Department, Semester, Role, ReputationScore) VALUES
(1, '22-49653-3', '12345', 'Sajal Mollick',   'Male',   'Cse', '10', 'Student', 4),
(2, '22-47521-2', '54321', 'Azizul Alam',     'Male',   'Cse', '10', 'Student', 3),
(3, '24-57476-2', '1234',  'Azraful Alam',    'Male',   'Cse', '6',  'Student', 4),
(4, '22-49569-3', '4321',  'Sabrina Islam',   'Female', 'Cse', '10', 'Student', 3);
SET IDENTITY_INSERT [USER] OFF;
GO

-- ============================================================
-- INSERT: SKILL
-- ============================================================
SET IDENTITY_INSERT SKILL ON;
INSERT INTO SKILL (SkillId, UserId, SkillName) VALUES
(1, 1, 'C#'),
(2, 2, 'C#'),
(3, 3, 'C#'),
(4, 3, 'JAVA'),
(5, 4, 'C++'),
(6, 4, 'JAVA'),
(7, 4, 'C#');
SET IDENTITY_INSERT SKILL OFF;
GO

-- ============================================================
-- INSERT: WORK_STYLE
-- ============================================================
SET IDENTITY_INSERT WORK_STYLE ON;
INSERT INTO WORK_STYLE (WorkStyleId, UserId, StyleName) VALUES
(1, 1, 'Night'),
(2, 2, 'Day'),
(3, 3, 'Day'),
(4, 4, 'Night');
SET IDENTITY_INSERT WORK_STYLE OFF;
GO

-- ============================================================
-- INSERT: SWIPE
-- ============================================================
SET IDENTITY_INSERT SWIPE ON;
INSERT INTO SWIPE (SwipeId, SwiperId, SwipedId, IsInterested, [Timestamp]) VALUES
(1, 1, 2, 1, '2026-05-16 00:03:20.220'),
(2, 1, 3, 1, '2026-05-16 00:03:21.913'),
(3, 1, 4, 1, '2026-05-16 00:03:22.863'),
(4, 2, 1, 1, '2026-05-16 00:04:00.023'),
(5, 2, 3, 1, '2026-05-16 00:04:02.907'),
(6, 2, 4, 1, '2026-05-16 00:04:05.630'),
(7, 3, 1, 1, '2026-05-16 00:04:45.367');
SET IDENTITY_INSERT SWIPE OFF;
GO

-- ============================================================
-- INSERT: MATCH
-- ============================================================
SET IDENTITY_INSERT [MATCH] ON;
INSERT INTO [MATCH] (MatchId, User1Id, User2Id, MatchedAt) VALUES
(1, 2, 1, '2026-05-16 00:04:00.050'),
(2, 2, 3, '2026-05-16 00:04:45.383'),
(3, 3, 2, '2026-05-16 00:04:48.453'),
(4, 4, 1, '2026-05-16 00:05:17.953'),
(5, 4, 2, '2026-05-16 00:05:21.060'),
(6, 4, 3, '2026-05-16 00:05:23.643');
SET IDENTITY_INSERT [MATCH] OFF;
GO

-- ============================================================
-- INSERT: PROJECT_GROUP
-- ============================================================
SET IDENTITY_INSERT PROJECT_GROUP ON;
INSERT INTO PROJECT_GROUP (GroupId, CourseName, ProjectTitle, CreatorId, CreatedAt) VALUES
(1, 'OOP2', 'PeerSync', 1, '2026-05-16 00:06:46.923');
SET IDENTITY_INSERT PROJECT_GROUP OFF;
GO

-- ============================================================
-- INSERT: GROUP_MEMBER
-- ============================================================
SET IDENTITY_INSERT GROUP_MEMBER ON;
INSERT INTO GROUP_MEMBER (MemberId, GroupId, UserId, Role) VALUES
(1, 1, 1, 'Creator'),
(2, 1, 2, 'Member'),
(3, 1, 3, 'Member'),
(4, 1, 4, 'Member');
SET IDENTITY_INSERT GROUP_MEMBER OFF;
GO

-- ============================================================
-- INSERT: RATING
-- ============================================================
SET IDENTITY_INSERT RATING ON;
INSERT INTO RATING (RatingId, RaterId, RateeId, GroupId, Contribution, Communication, Reliability, Punctuality, Comments) VALUES
(1, 1, 2, 1, 3, 4, 4, 2, NULL),
(2, 1, 3, 1, 3, 4, 4, 5, NULL),
(3, 1, 4, 1, 4, 2, 4, 3, NULL),
(4, 2, 1, 1, 4, 3, 4, 4, NULL),
(5, 3, 1, 1, 5, 4, 2, 5, NULL),
(6, 4, 1, 1, 5, 5, 5, 5, NULL),
(7, 4, 2, 1, 2, 4, 4, 3, NULL),
(8, 4, 3, 1, 5, 5, 5, 5, NULL);
SET IDENTITY_INSERT RATING OFF;
GO

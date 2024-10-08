﻿ALTER TABLE [Section] NOCHECK CONSTRAINT ALL;
INSERT INTO [Section] VALUES (1010, 'BSc Management', 12);
INSERT INTO [Section] VALUES (1020, 'MSc Management', 9);
INSERT INTO [Section] VALUES (1110, 'BSc Economics', 15);
INSERT INTO [Section] VALUES (1120, 'MSc Economics', 6);
INSERT INTO [Section] VALUES (1310, 'BA Sociology', 23);
INSERT INTO [Section] VALUES (1320, 'MA Sociology', 6);
ALTER TABLE [Section] CHECK CONSTRAINT ALL;

ALTER TABLE [Professor] NOCHECK CONSTRAINT ALL;
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Zidda', 'Pietro', 1020, 402, 'pzidda', '2004-12-11', 1900);
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Decrop', 'Alain', 1120, 403, 'adecrop', '2003-05-09', 1950);
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Giot', 'Pierre', 1310, 404, 'pgiot', '2002-12-21', 2100);
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Lecourt', 'Christelle', 1310, 406, 'clecourt', '2003-05-07', 1750);
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Scheppens', 'Georges', 1020, 410, 'gscheppens', '1986-10-09', 2450);
INSERT INTO [Professor] ([ProfessorName], [ProfessorSurname], [SectionId], [ProfessorOffice], [ProfessorEmail], [ProfessorHireDate], [ProfessorWage]) VALUES ('Louveaux', 'François', 1110, 407, 'flouveaux', '1990-05-07', 2200);
ALTER TABLE [Professor] CHECK CONSTRAINT ALL;

ALTER TABLE [Course] NOCHECK CONSTRAINT ALL;
INSERT INTO [Course] VALUES ('EG1010', 'Derivatives', 3.0, 3);
INSERT INTO [Course] VALUES ('EG1020', 'Marketing management', 3.5, 2);
INSERT INTO [Course] VALUES ('EG2110', 'Marketing engineering', 4.0, 1);
INSERT INTO [Course] VALUES ('EG2120', 'Financial Management', 4.0, 3);
INSERT INTO [Course] VALUES ('EG2210', 'Supply chain management et e-business', 2.5, 5);
ALTER TABLE [Course] CHECK CONSTRAINT ALL;

ALTER TABLE [Student] NOCHECK CONSTRAINT ALL;
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Georges', 'Lucas', '1944-05-17', 'glucas', 1320, 10, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Clint', 'Eastwood', '1930-05-31', 'ceastwoo', 1010, 4, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Sean', 'Connery', '1930-08-25', 'sconnery', 1020, 12, 'EG2110');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Robert', 'De Niro', '1943-08-17', 'rdeniro', 1110, 3, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Kevin', 'Bacon', '1958-07-08', 'kbacon', 1120, 16, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Kim', 'Basinger', '1953-12-08', 'kbasinge', 1310, 19, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Johnny', 'Depp', '1963-06-09', 'jdepp', 1110, 11, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Julia', 'Roberts', '1967-10-28', 'jroberts', 1120, 17, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Natalie', 'Portman', '1981-06-09', 'nportman', 1010, 4, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Georges', 'Clooney', '1961-05-06', 'gclooney', 1020, 4, 'EG2110');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Andy', 'Garcia', '1956-04-12', 'agarcia', 1110, 19, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Bruce', 'Willis', '1955-03-19', 'bwillis', 1010, 6, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Tom', 'Cruise', '1962-07-03', 'tcruise', 1020, 4, 'EG2110');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Reese', 'Witherspoon', '1976-03-22', 'rwithers', 1020, 7, 'EG1020');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Sophie', 'Marceau', '1966-11-17', 'smarceau', 1110, 6, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Sarah', 'Michelle Gellar', '1977-04-14', 'smichell', 1020, 7, 'EG2110');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Alyssa', 'Milano', '1972-12-19', 'amilano', 1110, 7, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Jennifer', 'Garner', '1972-04-17', 'jgarner', 1120, 18, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Michael J.', 'Fox', '1969-06-20', 'mfox', 1310, 3, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Tom', 'Hanks', '1956-07-09', 'thanks', 1020, 8, 'EG2110');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('David', 'Morse', '1953-10-11', 'dmorse', 1110, 2, NULL);
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Sandra', 'Bullock', '1964-07-26', 'sbullock', 1010, 2, 'EG1020');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Keanu', 'Reeves', '1964-09-02', 'kreeves', 1020, 10, 'EG2210');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Shannen', 'Doherty', '1971-04-12', 'sdoherty', 1320, 2, 'EG2120');
INSERT INTO [Student] ([FirstName], [LastName], [BirthDate], [Login], [SectionId], [YearResult], [CourseId]) VALUES ('Halle', 'Berry', '1966-08-14', 'hberry', 1320, 18, 'EG2210');
ALTER TABLE [Student] CHECK CONSTRAINT ALL;

ALTER TABLE [Grade] NOCHECK CONSTRAINT ALL;
INSERT INTO [Grade] VALUES ('IG', 0, 7);
INSERT INTO [Grade] VALUES ('I', 8, 9);
INSERT INTO [Grade] VALUES ('F', 10, 11);
INSERT INTO [Grade] VALUES ('S', 12, 13);
INSERT INTO [Grade] VALUES ('B', 14, 15);
INSERT INTO [Grade] VALUES ('TB', 16, 17);
INSERT INTO [Grade] VALUES ('E', 18, 20);
ALTER TABLE [Grade] CHECK CONSTRAINT ALL;

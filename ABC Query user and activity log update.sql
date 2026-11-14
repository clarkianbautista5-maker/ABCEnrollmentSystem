CREATE DATABASE ABCEnrollmentDb;
GO

USE ABCEnrollmentDb;
GO


CREATE TABLE Teachers (
    TeacherId NVARCHAR(20) NOT NULL PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NOT NULL
);

CREATE TABLE Sections (
    SectionCode NVARCHAR(20) NOT NULL PRIMARY KEY,
    SectionName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(200) NULL
);

CREATE TABLE Students (
    StudentId NVARCHAR(20) NOT NULL PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NOT NULL,
    HouseNo NVARCHAR(30) NULL,
    Street NVARCHAR(100) NULL,
    Municipality NVARCHAR(100) NULL,
    Province NVARCHAR(100) NULL,
    ZipCode NVARCHAR(10) NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NULL,
    Mobile NVARCHAR(20) NULL,
    Landline NVARCHAR(20) NULL,
    Email NVARCHAR(100) NULL,
    GuardianName NVARCHAR(150) NULL,
    GuardianAddress NVARCHAR(250) NULL,
    GuardianMobile NVARCHAR(20) NULL,
    GuardianLandline NVARCHAR(20) NULL
);

CREATE TABLE Subjects (
    SubjectCode NVARCHAR(20) NOT NULL PRIMARY KEY,
    SubjectName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(200) NULL,
    Units INT NOT NULL,
    TeacherId NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_Subjects_Teachers FOREIGN KEY (TeacherId) REFERENCES Teachers(TeacherId)
);

CREATE TABLE Enrollments (
    EnrollmentId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    StudentId NVARCHAR(20) NOT NULL,
    SubjectCode NVARCHAR(20) NOT NULL,
    SectionCode NVARCHAR(20) NOT NULL,
    SchoolYear NVARCHAR(9) NOT NULL,
    CONSTRAINT FK_Enrollments_Students FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    CONSTRAINT FK_Enrollments_Subjects FOREIGN KEY (SubjectCode) REFERENCES Subjects(SubjectCode),
    CONSTRAINT FK_Enrollments_Sections FOREIGN KEY (SectionCode) REFERENCES Sections(SectionCode),

    CONSTRAINT UQ_Enrollment UNIQUE (StudentId, SubjectCode, SchoolYear)
);
GO


--Pang demo kay sirrrrrr

INSERT INTO Teachers (TeacherId, FirstName, MiddleName, LastName) VALUES
('T-001', 'Maria', 'Lopez', 'Santos'),
('T-002', 'Jose', 'Reyes', 'Garcia');

INSERT INTO Sections (SectionCode, SectionName, Description) VALUES
('SEC-A', 'Grade 11 - Newton', 'STEM strand'),
('SEC-B', 'Grade 11 - Einstein', 'ABM strand');

INSERT INTO Subjects (SubjectCode, SubjectName, Description, Units, TeacherId) VALUES
('MATH11', 'General Mathematics', 'Core subject', 3, 'T-001'),
('ENG11', 'Oral Communication', 'Core subject', 3, 'T-002'),
('PHY11', 'Physical Science', 'Science subject', 3, 'T-001');
GO

-- sulit activity log and user log table for Activity Log and User Log
CREATE TABLE UserLogs (
    UserLogId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Action NVARCHAR(20) NOT NULL,
    LogDate DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE ActivityLogs (
    LogId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Action NVARCHAR(50) NOT NULL,
    Module NVARCHAR(30) NULL,
    Details NVARCHAR(250) NULL,
    LogDate DATETIME NOT NULL DEFAULT GETDATE()
);
GO
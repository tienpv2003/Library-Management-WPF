CREATE DATABASE Library_Management;
GO
USE Library_Management;
GO
-- Table: Student
CREATE TABLE Student (
    StudentId NVARCHAR(50) PRIMARY KEY,
    StudentName NVARCHAR(100) NULL,
    Phone NVARCHAR(20) NULL,
    Dob DATE NULL,
    Address NVARCHAR(200) NULL
);
-- Table: Publisher
CREATE TABLE Publisher (
    PublisherId NVARCHAR(50) PRIMARY KEY,
    PublisherName NVARCHAR(100) NULL
);
-- Table: BookCategory
CREATE TABLE BookCategory (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NULL
);
-- Table: Author
CREATE TABLE Author (
    AuthorId NVARCHAR(50) PRIMARY KEY,
    AuthorName NVARCHAR(100) NULL
);
-- Table: Book
CREATE TABLE Book (
    BookId NVARCHAR(50) PRIMARY KEY,
    BookName NVARCHAR(100) NULL,
    Amount INT NULL,
    CategoryId INT NULL,
    AuthorId NVARCHAR(50) NULL,
    PublisherId NVARCHAR(50) NULL,
    FOREIGN KEY (CategoryId) REFERENCES BookCategory(CategoryId),
    FOREIGN KEY (AuthorId) REFERENCES Author(AuthorId),
    FOREIGN KEY (PublisherId) REFERENCES Publisher(PublisherId)
);
-- Table: BorrowBook
CREATE TABLE BorrowBook (
    BorrowId INT PRIMARY KEY IDENTITY(1,1),
    BookId NVARCHAR(50) NOT NULL,
    StudentId NVARCHAR(50) NOT NULL,
    BorrowedDate DATE NULL,
    ReturnDate DATE NULL,
    FOREIGN KEY (BookId) REFERENCES Book(BookId),
    FOREIGN KEY (StudentId) REFERENCES Student(StudentId)
);
-- Table: Management
CREATE TABLE Management (
    ManagementId INT PRIMARY KEY IDENTITY(1,1),
    BookId NVARCHAR(50) NOT NULL,
    StudentId NVARCHAR(50) NOT NULL,
    BorrowId INT NOT NULL,
    FOREIGN KEY (BookId) REFERENCES Book(BookId),
    FOREIGN KEY (StudentId) REFERENCES Student(StudentId),
    FOREIGN KEY (BorrowId) REFERENCES BorrowBook(BorrowId)
);

-- Tạo bảng Role
CREATE TABLE Role (
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(100) NOT NULL
);

-- Tạo bảng User
CREATE TABLE [User] (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(100) NOT NULL,
    UserPassword NVARCHAR(100) NOT NULL,
    RoleId INT NOT NULL,
    ManagementId INT,
    FOREIGN KEY (RoleId) REFERENCES Role(RoleId),
    FOREIGN KEY (ManagementId) REFERENCES Management(ManagementId)
);
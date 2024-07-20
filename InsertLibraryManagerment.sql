
-- Thêm vai trò mặc định cho Admin và Staff
INSERT INTO Role (RoleName) VALUES ('Admin'), ('Staff'),('Guest');

-- Insert data into Student table
INSERT INTO Student (StudentId, StudentName, Phone, Dob, Address)
VALUES
('S001', 'John Doe', '1234567890', '1995-05-10', '123 Main St, City A'),
('S002', 'Jane Smith', '2345678901', '1996-08-15', '456 Elm St, City B'),
('S003', 'Robert Brown', '3456789012', '1997-12-20', '789 Oak St, City C'),
('S004', 'Emily Johnson', '4567890123', '1998-02-25', '101 Pine St, City D'),
('S005', 'Michael White', '5678901234', '1999-03-30', '202 Birch St, City E');

-- Insert data into Publisher table
INSERT INTO Publisher (PublisherId, PublisherName)
VALUES
('P001', 'Penguin Random House'),
('P002', 'HarperCollins'),
('P003', 'Macmillan Publishers'),
('P004', 'Simon & Schuster'),
('P005', 'Hachette Livre');

-- Insert data into BookCategory table
INSERT INTO BookCategory (CategoryName)
VALUES
('Fiction'),
('Non-Fiction'),
('Science Fiction'),
('Biography'),
('Children');

-- Insert data into Author table
INSERT INTO Author (AuthorId, AuthorName)
VALUES
('A001', 'J.K. Rowling'),
('A002', 'George Orwell'),
('A003', 'Isaac Asimov'),
('A004', 'Walter Isaacson'),
('A005', 'Roald Dahl');

-- Insert data into Book table
INSERT INTO Book (BookId, BookName, Amount, CategoryId, AuthorId, PublisherId)
VALUES
('B001', 'Harry Potter and the Philosopher Stone', 10, 1, 'A001', 'P001'),
('B002', '1984', 15, 2, 'A002', 'P002'),
('B003', 'Foundation', 8, 3, 'A003', 'P003'),
('B004', 'Steve Jobs', 12, 4, 'A004', 'P004'),
('B005', 'Charlie and the Chocolate Factory', 20, 5, 'A005', 'P005');

-- Insert data into BorrowBook table
INSERT INTO BorrowBook (BookId, StudentId, BorrowedDate, ReturnDate)
VALUES
('B001', 'S001', '2024-07-01', '2024-07-15'),
('B002', 'S002', '2024-07-05', '2024-07-10'),
('B003', 'S003', '2024-07-10', '2024-07-25'),
('B004', 'S004', '2024-07-15', '2024-07-30'),
('B005', 'S005', '2024-07-10', '2024-07-15');

-- Insert data into Management table
INSERT INTO Management (BookId, StudentId, BorrowId)
VALUES
('B001', 'S001', 1),
('B002', 'S002', 2),
('B003', 'S003', 3),
('B004', 'S004', 4),
('B005', 'S005', 5);

--INSERT INTO "User" VALUES('admin','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92',1,1);
--INSERT INTO "Role" VALUES('Guest');
select * from "User"
select * from "Role"
select * from Management
--update "User" set UserPassword = 'bcb15f821479b4d5772bd0ca866c00ad5f926e3580720659cc80d39c9d09802a' where UserId = 2;

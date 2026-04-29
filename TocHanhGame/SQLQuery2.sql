-- 1. Tạo cơ sở dữ liệu cho Game
CREATE DATABASE TocHanhGameDB;
GO

-- 2. Trỏ vào Database vừa tạo
USE TocHanhGameDB;
GO

-- 3. Tạo bảng Bảng xếp hạng (Leaderboard)
CREATE TABLE Leaderboard (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PlayerName NVARCHAR(50) NOT NULL,
    Score INT NOT NULL,
    PlayDate DATETIME DEFAULT GETDATE()
);
GO

-- 4. Thêm thử 2 dòng dữ liệu mồi (để lát nữa test API)
INSERT INTO Leaderboard (PlayerName, Score) VALUES ('Anh Giải Phóng', 1975);
INSERT INTO Leaderboard (PlayerName, Score) VALUES ('Người Nông Dân', 304);
GO
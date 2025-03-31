# Practical 15
# User Database Setup
In this practical I use DbFirst Approach
This project contains SQL scripts to create and populate two tables: **User** and **FormUser**.

## 📌 Table: User

### **Insert Data For Task 1**
```sql
create database Practical15;
use Practical15
CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    FullName NVARCHAR(200) NOT NULL,
    Email NVARCHAR(200) NULL,
    Role NVARCHAR(50) NOT NULL
);
INSERT INTO Users (Username, FullName, Email, Role)
VALUES 
('Himanshi18', 'Himanshi', 'Himanshi@example.com', 'Admin'),
('Panthee18', 'Panthee', 'p@example.com', 'User');
```
### **Insert Data For Task 2**
```sql

CREATE TABLE FormUsers (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);
	
INSERT INTO FormUsers (Username, Password)
VALUES ('user1', '12345'),
		('user2','12345')

```


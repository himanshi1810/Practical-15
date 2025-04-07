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
('Panthee18', 'Panthee', 'p@example.com', 'User'),
('SIMFORM\himanshi.gandhi', 'Himanshi Gandhi', 'himanshi.gandhi@simformsolutions.com', 'Admin');
```
### **Steps You have to follow**
**Step 1. In the web.config file You have to enable authentication Mode**
```csharp
<system.web>
  <authentication mode="Forms">
    <forms loginUrl="~/Account/Login" timeout="30" />
  </authentication>
  <compilation debug="true" targetFramework="4.7.2" />
  <httpRuntime targetFramework="4.7.2" />
</system.web>
```
**Step 2.Then use [Authorize] in controller**
**Step 3.Then disable the anpnymous authentication & enable windows authentication in C:\Users\himanshi.gandhi\Desktop\Practical\MVC\Practical 15\.vs\Practical 15\config\applicationhost** 
```csharp

<authentication>

<anonymousAuthentication enabled="false" userName="" />

<basicAuthentication enabled="false" />

<clientCertificateMappingAuthentication enabled="false" />

<digestAuthentication enabled="false" />

<iisClientCertificateMappingAuthentication enabled="false">
</iisClientCertificateMappingAuthentication>

<windowsAuthentication enabled="true">
    <providers>
	<add value="Negotiate" />
	<add value="NTLM" />
    </providers>
</windowsAuthentication>

</authentication>
```
**Step 4. Then in controller pannel go to the Internet options and in that security tab go to the local intranet then in sited and in advance settings and add http://localhost**

![Practcal15_img](https://github.com/user-attachments/assets/a327403a-4cf3-4022-a5e0-241ab23332d9)

**Step 5. Then from internet go to custom level and in User Authentication change as mentioned in below image**

![image](https://github.com/user-attachments/assets/2cfdad2e-634a-49d2-ade8-d872a2dd9760)

**Step 6. It's now ready to run**

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


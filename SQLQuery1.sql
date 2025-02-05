CREATE TABLE Students (
    RegNo NVARCHAR(50) PRIMARY KEY,  
    FirstName NVARCHAR(100) NOT NULL,  
    LastName NVARCHAR(100) NOT NULL,  
    Gender NVARCHAR(10) NOT NULL,     
    Address NVARCHAR(255) NOT NULL,    
    Email NVARCHAR(100) NOT NULL,      
    MobilePhone NVARCHAR(15) NOT NULL, 
    HomePhone NVARCHAR(15),            
    ParentName NVARCHAR(100) NOT NULL, 
    NIC NVARCHAR(12) NOT NULL,         
    ContactNumber NVARCHAR(15) NOT NULL, 
    DoB DATE NOT NULL                  
);
GO



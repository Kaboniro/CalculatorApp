VB.NET
=====

VB.NET, short for Visual Basic .NET, is a programming language and development environment provided by Microsoft. 
It is a modernized version of the Visual Basic (VB) programming language, designed to be part of the .NET framework. 
VB.NET is an object-oriented programming (OOP) language that allows developers to create a wide range of applications, including desktop, web, and mobile applications.
=====

CalculatorAPP.
=====
*Consists of:*
Main Page - Form2.vb (Login page)
Calculator - Form1.vb
Registration form - Form4.vb
Admin Panel - Form3.vb
HistoryForm.vb
=====

Db - MSSQL
=====

Create tables Users and HistoryForm
======


CREATE TABLE Users(
	UserID int IDENTITY(1,1),
	Username nvarchar(50),
	Passwords nvarchar(50),
	Email nvarchar(100),
	Phone_no nvarchar(20)
);

CREATE TABLE History (
    ID INT PRIMARY KEY IDENTITY,
    UserID INT,
    Expression NVARCHAR(MAX),
    Result FLOAT,
    Timestamp DATETIME
);
======

In the forms, replace the connection string with yours.

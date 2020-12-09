--create database student_database_Project;
use student_database_Project;
--Creating Table For Student Details 
create table student_details(
    register_no bigint,
    student_name varchar(100),
    Department varchar(5),
    Section varchar(5),
    Dob date,
	age int,
	graduate varchar(3),
	gender varchar(10),
    year_ varchar(20),
    bloodgroup varchar(3),
    father_name varchar(20),
    mother_name varchar(20),
    guardian_name varchar(30),
    address_home varchar(150),
    personal_email varchar(55),
    college_email varchar(55),
    pincode int not null,
    unique(register_no) 
    );
insert into student_details values(1801721033001,'Amutha','BCA','A','2000-10-02',19,'UG','Female','2018 - 2021','A+','Karthick','RajaLakshmi','','jawahar street,albert road,chennai','amutha@gmail.com','1801721033001@mcc.edu.in',600070);
create table login(
	username varchar(100),
	_Password varchar(100)
	);
insert into login values('admin','0000');

use student_database_Project;
create table yearone(
    register_no bigint unique,
    student_name varchar(100),
    Department varchar(5),
    Section varchar(5),
	year_ varchar(20),
	subject1 int,
	subject2 int,
	subject3 int,
	subject4 int,
	subject5 int,
	overall_grade varchar(10),
	totalmarks int
);
create table yeartwo(
    register_no bigint unique,
    student_name varchar(100),
    Department varchar(5),
    Section varchar(5),
	year_ varchar(20),
	subject1 int,
	subject2 int,
	subject3 int,
	subject4 int,
	subject5 int,
	overall_grade varchar(10),
	totalmarks int
);
create table yearthree(
    register_no bigint unique,
    student_name varchar(100),
    Department varchar(5),
    Section varchar(5),
	year_ varchar(20),
	subject1 int,
	subject2 int,
	subject3 int,
	subject4 int,
	subject5 int,
	overall_grade varchar(10),
	totalmarks int
);
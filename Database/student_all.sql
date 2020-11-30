use student_info;
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
  
insert into student_details values(1801721033001,'Anfra','BCA','A','2000-10-02',19,'UG','Female','2018 - 2021','A+','Akbar','Amutha','','jawahar street,albert road,chennai','anbu@gmail.com','1801721033001@mcc.edu.in',600070);
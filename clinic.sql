use clinic

--create table patients(
--	Id int not null IDENTITY PRIMARY KEY,
--	patient_name varchar(20) not null,
--	doctor_id int not null,
--	profession_id int null
--);

--create table doctors(
--	doctor_id int not null IDENTITY PRIMARY KEY,
--	doctor_name varchar(20) not null,
	
--);
--ALTER table patients add foreign key (doctor_id) references doctors(doctor_id);

--create table professions(
--	profession_id int not null IDENTITY PRIMARY KEY,
--	profession_name varchar(20) not null,
	
--);
--ALTER table patients add foreign key (profession_id) references professions(profession_id);

--insert into patients values ('Eliza Holding',1,1);
--insert into patients values ('Eugene Dodson',1,1);
--insert into patients values ('Ayat Chase',2,2);
--insert into patients values ('Bear Curry',2,2);
--insert into patients values ('Josephine Reeve',3,3);
--insert into patients values ('Alannah Rowley',3,3);
--insert into patients values ('Ayse Boyce',4,4);
--insert into patients values ('Giulia Horton',4,4);
--insert into patients values ('Abdi Barclay',5,5);
--insert into patients values ('Blanche Cummings',5,5);

--insert into professions values ('accountant');
--insert into professions values ('teacher');
--insert into professions values ('architect');
--insert into professions values ('programmer');
--insert into professions values ('lawyer');

--insert into doctors(doctor_name) values ('Karter Wyatt');
--insert into doctors(doctor_name) values ('Konnor Strickland');
--insert into doctors(doctor_name) values ('Tai Cabrera');
--insert into doctors(doctor_name) values ('Aron Saunders');
--insert into doctors(doctor_name) values ('Mamie Vinson');

select * from professions;
select * from doctors;

select patient_name,doctor_name from patients
inner join doctors
on doctors.doctor_id=patients.doctor_id;

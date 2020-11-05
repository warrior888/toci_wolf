drop table UserSpeeches
drop table Projects;
drop table Users;

create table Users
(
	Id integer indentity (1,1) primary key,
	Login varchar(50),
	Password varchar(50)
);

create table Projects
(
	Id integer indentity (1,1) primary key,
	Name varchar(50)
);

create table UserSpeeches
(
	Id integer indentity (1,1) primary key,
	IdUsers integer references Users(Id),
	IdProjects integer references Projects(Id),
	Phrases varchar(1000)
);
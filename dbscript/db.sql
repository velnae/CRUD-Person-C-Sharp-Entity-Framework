create database dbstorage;
use dbstorage;

create table tperson
(
idPerson char(36) not null,
dni char(8) not null,
firstName varchar(70) not null,
surName varchar(40) not null,
birthDate date not null,
primary key(idPerson)
);
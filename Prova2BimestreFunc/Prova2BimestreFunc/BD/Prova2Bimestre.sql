CREATE DATABASE prova;
USE prova;

CREATE TABLE funcionario
(
 id_fun int auto_increment primary key,
 nom_fun varchar(100) not null,
 sex_fun char(1) not null,
 dt_nasc_fun date not null,
 num_crt_trab_fun char(9) not null,
 tel_fix_fun varchar(15) not null,
 tel_cel_fun varchar(15) not null,
 email_fun varchar(100) not null,
 log_end_fun varchar(100) not null,
 num_end_fun varchar(20) not null,
 bair_end_fun varchar(100) not null,
 cid_end_fun varchar(100) not null,
 uf_end_fun char(2) not null
);




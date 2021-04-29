create table tecnicos(
	usuario varchar(30) not null,
	senha varchar(150) not null,
	nome varchar(300),
	telefone varchar(20),
	endereco varchar(150),
	is_admin bool 
);

-- Gerar usuario admin para Login no sistema
insert into tecnicos values('admin', 'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC', 'Administrador','17-3345-9100', 'Prefeitura Municipal de Bebedouro' true);
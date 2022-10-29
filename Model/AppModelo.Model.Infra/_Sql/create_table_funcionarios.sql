CREATE TABLE funcionarios 
(
	id INT NOT NULL AUTO_INCREMENT,
	nome_completo varchar(250) NOT NULL,
	data_nascimento datetime NOT NULL,
	sexo bool NOT NULL,
	cpf varchar(14) NOT NULL,
	nacionalidade varchar(150) NOT NULL,
	naturalidade varchar(150) NOT NULL,
	email varchar(200) NOT NULL,
	telefone varchar(14) NOT NULL,
	telefone_contato varchar(14),
	cep varchar(9) NOT NULL,
	logradouro varchar(100) NOT NULL,
	numero int NOT NULL,
	complemento varchar(100),
	bairro varchar(100) NOT NULL,
	municipio varchar(100) NOT NULL,
	uf varchar(2) NOT NULL,
	CONSTRAINT pk_funcionarios_id PRIMARY KEY (id)
);
CREATE TABLE funcionarios (
	id int PRIMARY KEY AUTO_INCREMENT NOT NULL,
	nome_completo varchar(250) NOT NULL,
	data_nascimento date NOT NULL,
	sexo bool NOT NULL,
	email varchar(250) NOT NULL,
	telefone varchar(14) NOT NULL,
	telefone_contato varchar(14),
	cep varchar(14) NOT NULL,
	logradouro varchar(50),
	numero int NOT NULL,
	complemento varchar(250),
	bairro varchar(250) NOT NULL,
	municipio varchar(250) NOT NULL,
	uf varchar(2) NOT NULL,
	fk_nacionalidade int NOT NULL,
	fk_naturalidade int NOT NULL,
	FOREIGN KEY (fk_naturalidade) REFERENCES naturalidades(id),
	FOREIGN KEY (fk_nacionalidade) REFERENCES nacionalidades(id)
	
);
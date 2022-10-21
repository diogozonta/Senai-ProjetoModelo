CREATE TABLE naturalidades
(
	id int NOT NULL AUTO_INCREMENT,
	descricao varchar(100) NOT NULL,
	dataCriacao datetime NOT NULL,
	dataAlteracao datetime NOT NULL,
	ativo bool NOT NULL,
	CONSTRAINT pk_naturalidades_id PRIMARY KEY (id)
);

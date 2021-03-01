--CONECTANDO COM O BANCO DE DADOS
USE BDInGames;
GO

--ALIMENTANDO AS TABELAS DO BANCO DE DADOA
INSERT INTO Estudio (NomeEstudio)
VALUES ('Blizzard'), ('Rockstar Studios'), ('Square Enix'), ('Steam'), ('EA Sports'), ('Ubisoft');
GO

INSERT INTO Jogo(NomeJogo, Descricao, DataDeLancamento, Valor, IdEstudio)	
VALUES ('Diablo 3','� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�', '15/05/2012', 99.00, 1),
('Red Dead Redemption II','Jogo eletr�nico de a��o-aventura western','26/10/2018', 120.00, 2),
('Rainbow Six Seige','A��o e estrat�gia','10/10/2016', 850.00, 5),
('FIFA 20','Jogo eletr�nico de esporte','26/10/2018', 240.00, 5);
GO

INSERT INTO  TipoUsuario(Titulo)
VALUES ('Administrador'), ('Cliente');
GO

INSERT INTO Usuarios (Email, Senha, IdTipoUsuario)
VALUES ('admin@admin.com','admin', 1), ('cliente@cliente.com','cliente', 2), ('cliente2@cliente.com','cliente2', 2);
GO



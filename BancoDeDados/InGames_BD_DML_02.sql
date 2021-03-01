--CONECTANDO COM O BANCO DE DADOS
USE BDInGames;
GO

--ALIMENTANDO AS TABELAS DO BANCO DE DADOA
INSERT INTO Estudio (NomeEstudio)
VALUES ('Blizzard'), ('Rockstar Studios'), ('Square Enix'), ('Steam'), ('EA Sports'), ('Ubisoft');
GO

INSERT INTO Jogo(NomeJogo, Descricao, DataDeLancamento, Valor, IdEstudio)	
VALUES ('Diablo 3','É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã', '15/05/2012', 99.00, 1),
('Red Dead Redemption II','Jogo eletrônico de ação-aventura western','26/10/2018', 120.00, 2),
('Rainbow Six Seige','Ação e estratégia','10/10/2016', 850.00, 5),
('FIFA 20','Jogo eletrônico de esporte','26/10/2018', 240.00, 5);
GO

INSERT INTO  TipoUsuario(Titulo)
VALUES ('Administrador'), ('Cliente');
GO

INSERT INTO Usuarios (Email, Senha, IdTipoUsuario)
VALUES ('admin@admin.com','admin', 1), ('cliente@cliente.com','cliente', 2), ('cliente2@cliente.com','cliente2', 2);
GO



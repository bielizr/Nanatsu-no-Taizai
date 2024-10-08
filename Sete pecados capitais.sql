CREATE DATABASE sete_pecados_capitais;
USE sete_pecados_capitais;


CREATE TABLE racas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);


CREATE TABLE clas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);


CREATE TABLE personagens (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    id_raca INT,
    id_cla INT,
    imagem VARCHAR(240),
    FOREIGN KEY (id_raca) REFERENCES racas(id),
    FOREIGN KEY (id_cla) REFERENCES clas(id)
);


INSERT INTO racas (nome) VALUES 
('Humano'),
('Demônio'),
('Fada'),
('Gigante'),
('Deus');


INSERT INTO clas (nome) VALUES 
('Demônio'),
('Fada'),
('Gigante'),
('Deus'),
('Sem Clã');

INSERT INTO personagens (nome, descricao, id_raca, id_cla, imagem) VALUES 
('Meliodas', 'O capitão dos Sete Pecados Capitais e representante do Pecado da Ira. É um demônio com habilidades poderosas.', 2, 1, '/img/Meliodas.webp'),
('Diane', 'Representante do Pecado da Inveja, Diane é uma gigante com habilidades relacionadas à terra e força física.', 4, 3, '/img/Diane.webp'),
('King', 'O Pecado da Preguiça e o rei das fadas. Ele controla a natureza e usa uma lança mágica.', 3, 2, '/img/King.webp'),
('Gowther', 'O Pecado da Luxúria e um demônio com habilidades mágicas avançadas.', 2, 1, '/img/Gowther.webp'),
('Ban', 'O Pecado da Avareza, conhecido por sua habilidade de se regenerar rapidamente e por sua busca pelo Fruto da Árvore da Vida.', 1, 5, '/img/Ban.webp'),
('Merlin', 'A Pecadora da Gula e a mais poderosa maga do grupo.', 1, 5, '/img/Merlin.webp'),
('Escanor', 'O Pecado do Orgulho e o membro mais poderoso dos Sete Pecados Capitais. Seu poder aumenta com o sol.', 1, 5, '/img/Escanor.webp');
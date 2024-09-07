-- Criação do Banco de Dados e Seleção
CREATE DATABASE sete_pecados_capitais;
USE sete_pecados_capitais;

-- Tabela para Raças
CREATE TABLE racas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

-- Tabela para Clãs
CREATE TABLE clas (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

-- Tabela para Personagens
CREATE TABLE personagens (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    descricao TEXT,
    id_raca INT,
    id_cla INT,
    imagem BLOB, -- Armazenamento da imagem local
    FOREIGN KEY (id_raca) REFERENCES racas(id),
    FOREIGN KEY (id_cla) REFERENCES clas(id)
);

-- Inserção de Raças
INSERT INTO racas (nome) VALUES 
('Humano'),
('Demônio'),
('Fada'),
('Gigante'),
('Deus');

-- Inserção de Clãs
INSERT INTO clas (nome) VALUES 
('Demônio'),
('Fada'),
('Gigante'),
('Deus');

INSERT INTO personagens (nome, descricao, id_raca, id_cla, imagem) VALUES 
('Meliodas', 'O capitão dos Sete Pecados Capitais e representante do Pecado da Ira. É um demônio com habilidades poderosas.', 2, 2, LOAD_FILE('/path/to/meliodas.jpg')),
('Diane', 'Representante do Pecado da Inveja, Diane é uma gigante com habilidades relacionadas à terra e força física.', 4, 4, LOAD_FILE('/path/to/diane.jpg')),
('King', 'O Pecado da Preguiça e o rei das fadas. Ele controla a natureza e usa uma lança mágica.', 3, 3, LOAD_FILE('/path/to/king.jpg')),
('Gowther', 'O Pecado da Luxúria e um demônio com habilidades mágicas avançadas.', 2, 2, LOAD_FILE('/path/to/gowther.jpg')),
('Ban', 'O Pecado da Avareza, conhecido por sua habilidade de se regenerar rapidamente e por sua busca pelo Fruto da Árvore da Vida.', 1, 1, LOAD_FILE('/path/to/ban.jpg')),
('Merlin', 'A Pecadora da Gula e a mais poderosa maga do grupo.', 1, NULL, LOAD_FILE('/path/to/merlin.jpg')),
('Escanor', 'O Pecado do Orgulho e o membro mais poderoso dos Sete Pecados Capitais. Seu poder aumenta com o sol.', 1, NULL, LOAD_FILE('/path/to/escanor.jpg'));
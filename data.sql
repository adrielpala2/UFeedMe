CREATE DATABASE ufeedme

CREATE TABLE Avaliacoes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(255) NOT NULL,
    exposicao_escolhida ENUM('traje espacial de marte', 'o foguete para marte', 'água em marte') NOT NULL,
    opiniao ENUM('péssimo', 'ruim', 'neutro', 'bom', 'excelente') NOT NULL,
    sugestao VARCHAR(255) NOT NULL,
    data_registro DATETIME DEFAULT CURRENT_TIMESTAMP
);

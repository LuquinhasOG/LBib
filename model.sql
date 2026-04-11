CREATE TABLE categoria (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE editora (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    endereco VARCHAR(150) NOT NULL
);

CREATE TABLE autor (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(150),
    nacionalidade VARCHAR(50)
);

CREATE TABLE livro (
    id SERIAL PRIMARY KEY,
    titulo VARCHAR(150) NOT NULL,
    isbn CHAR(13) UNIQUE,
    edicao INT,
    ano_publicacao INT,
    sinopse TEXT,
    qt_total INT NOT NULL,
    qt_disponivel INT NOT NULL,
    editora_id INT REFERENCES editora(id),
    autor_id INT REFERENCES autor(id)
);

CREATE TABLE usuario (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(150) NOT NULL,
    email VARCHAR(150) UNIQUE NOT NULL,
    ddd VARCHAR(2),
    telefone VARCHAR(9),
    bairro VARCHAR(150),
    endereco VARCHAR(150),
    dt_cadastro DATE DEFAULT CURRENT_DATE
);

CREATE TABLE emprestimo (
    id SERIAL PRIMARY KEY,
    usuario_id INT REFERENCES usuario(id),
    livro_id INT REFERENCES livro(id),
    dt_emprestimo DATE DEFAULT CURRENT_DATE,
    dt_devolicao DATE NOT NULL,
    dt_devolvido DATE,
    estado VARCHAR(20) CHECK (estado IN ('regular', 'renovado', 'devolvido', 'atrasado'))
);
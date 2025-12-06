CREATE TYPE GENERO AS ENUM ('DRAMA','COMEDIA', 'ACAO');

DROP TABLE IF EXISTS filmes;

CREATE TABLE IF NOT EXISTS filmes (
    titulo TEXT DEFAULT 'sem titulo',
    genero GENERO DEFAULT NULL,
    hype INTEGER DEFAULT 3,
    assistido BOOLEAN DEFAULT FALSE
);

INSERT INTO filmes VALUES (
    'Velozes e furiosos 9',
    'ACAO',
    4,
    FALSE
);
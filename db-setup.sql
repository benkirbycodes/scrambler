

USE scrambler;

-- SHOW databases;

-- DROP TABLE IF EXISTS sentences;
-- CREATE TABLE sentences (
--   id int NOT NULL AUTO_INCREMENT,
--   text VARCHAR(255) NOT NULL,
--   PRIMARY KEY (id)
-- );

-- DROP TABLE IF EXISTS stories;
-- CREATE TABLE stories (
--   id int NOT NULL AUTO_INCREMENT,
--   title VARCHAR(255) NOT NULL, 
--   INDEX id (id),
--   PRIMARY KEY (id)
-- );

-- DROP TABLE IF EXISTS storysentences;
-- CREATE TABLE storysentences (
--   id int NOT NULL AUTO_INCREMENT,
--   sentenceId int NOT NULL,
--   storyId int NOT NULL,
--   sentenceOrder int NOT NULL,

--   PRIMARY KEY (id),
--   INDEX (sentenceId, storyId),
--   INDEX (id),

--   FOREIGN KEY (sentenceId)
--     REFERENCES sentences(id)
--     ON DELETE CASCADE,

--   FOREIGN KEY (storyId)
--     REFERENCES stories(id)
--     ON DELETE CASCADE
-- );


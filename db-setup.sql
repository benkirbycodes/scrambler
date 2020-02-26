USE scrambler;

-- SHOW databases;

-- CREATE TABLE sentences (
--   id int NOT NULL AUTO_INCREMENT,
--   text VARCHAR(255) NOT NULL,
--   PRIMARY KEY (id)
-- );

-- CREATE TABLE stories (
--   id int NOT NULL AUTO_INCREMENT,
--   title VARCHAR(255) NOT NULL, 
--   userId VARCHAR(255),
--   INDEX userId (userId),
--   PRIMARY KEY (id)
-- );

-- CREATE TABLE storysentences (
--   id int NOT NULL AUTO_INCREMENT,
--   sentenceId int NOT NULL,
--   storyId int NOT NULL,
--   userId VARCHAR(255) NOT NULL,

--   PRIMARY KEY (id),
--   INDEX (sentenceId, storyId),
--   INDEX (userId),

--   FOREIGN KEY (sentenceId)
--     REFERENCES sentences(id)
--     ON DELETE CASCADE,

--     FOREIGN KEY (storyId)
--     REFERENCES stories(id)
--     ON DELETE CASCADE
-- );

-- DROP TABLE IF EXISTS sentences;
-- DROP TABLE IF EXISTS stories;
-- DROP TABLE IF EXISTS storysentences;
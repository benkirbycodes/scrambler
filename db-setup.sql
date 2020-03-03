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

-- INSERT INTO sentences 
--       (text) VALUES ("The dark line where eye persists in seeing something that was never there to begin with.");
--       SELECT LAST_INSERT_ID();

-- INSERT INTO sentences 
--       (text) VALUES ("We had a week of peace together.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("That last part was like a snakebite.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("This house was so frail a shelter that one seemed to be sitting in the heart of a world made of dusty earth and moving air. ");
--       SELECT LAST_INSERT_ID();

-- INSERT INTO sentences 
--       (text) VALUES ("After a decade of distance, the house was supposed to be a new beginning.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("He began pouring out our secrets left and right in total disregard for my safety if not for his own, omitting nothing, knot-hole, pants and all.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("I burst out laughing.");
--       SELECT LAST_INSERT_ID();

-- INSERT INTO sentences 
--       (text) VALUES ("The air one breathed was saturated with earthy smells, and the grass underfoot had a reflection of blue in it.");
--       SELECT LAST_INSERT_ID();

-- INSERT INTO sentences 
--       (text) VALUES ("All blurred and in silhouette.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("We knew there was a crowd, but we had not bargained for the multitudes in the first-floor hallway.");
--       SELECT LAST_INSERT_ID();
      
-- INSERT INTO sentences 
--       (text) VALUES ("This was the plant that began to grow in the old man's bedroom after a strange dust storm.");
--       SELECT LAST_INSERT_ID();
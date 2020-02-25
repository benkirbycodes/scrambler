USE scrambler;

CREATE TABLE sentences (
  id int NOT NULL AUTO_INCREMENT,
  text VARCHAR(255) NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE stories (
  id int NOT NULL AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL, 
  userId VARCHAR(255),
  INDEX userId (userId),
  PRIMARY KEY (id)
);

CREATE TABLE storysentences (
  id int NOT NULL AUTO_INCREMENT,
  sentenceId int NOT NULL,
  storyId int NOT NULL,
  userId VARCHAR(255) NOT NULL,

  PRIMARY KEY (id),
  INDEX (sentenceId, storyId),
  INDEX (userId),

  FOREIGN KEY (sentenceId)
    REFERENCES sentence(id)
    ON DELETE CASCADE,

    FOREIGN KEY (storyId)
    REFERENCES story(id)
    ON DELETE CASCADE
);
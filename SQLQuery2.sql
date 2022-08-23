CREATE TABLE tickets(
   Id          INTEGER  NOT NULL PRIMARY KEY 
  ,Title       VARCHAR(50) NOT NULL
  ,Description VARCHAR(200) NOT NULL
  ,Submitter   VARCHAR(50) NOT NULL
  ,Status      VARCHAR(6) NOT NULL
  ,Priority    INTEGER  NOT NULL
  ,Type        VARCHAR(50) NOT NULL
);
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (1,'Bug Problems','Bugs in my PC','John Dev','Open',1,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (2,'Front-End Update','Incompatible with mobile devices','John Dev','Closed',3,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (3,'Front-End Update','Incompatible with mobile devices','John Dev','Open',3,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (4,'Optimize Back-End','Goal is same execution with 70% of the overhead','John Dev','Closed',4,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (5,'Bug Problems','Bugs in my PC','John Dev','Open',2,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (6,'Optimize Back-End','Goal is same execution with 70% of the overhead','John Dev','Closed',3,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (7,'Front-End Update','Incompatible with mobile devices','John Dev','Open',3,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (8,'IT Problems','John from IT called me Fat','John Dev','Closed',1,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (9,'Optimize Back-End','Goal is same execution with 70% of the overhead','John Dev','Open',2,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (10,'Bug Problems','Bugs in my PC','John Dev','Closed',2,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (11,'IT Problems','John from IT called me Fat','John Dev','Open',4,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (12,'Bug Problems','Bugs in my PC','James Dev','Closed',2,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (13,'Optimize Back-End','Goal is same execution with 70% of the overhead','James Dev','Open',3,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (14,'Front-End Update','Incompatible with mobile devices','James Dev','Closed',3,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (15,'Bug Problems','Bugs in my PC','James Dev','Open',2,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (16,'Front-End Update','Incompatible with mobile devices','James Dev','Closed',1,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (17,'IT Problems','John from IT called me Fat','James Dev','Closed',3,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (18,'IT Problems','John from IT called me Fat','James Dev','Closed',2,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (19,'Bug Problems','Bugs in my PC','James Dev','Open',4,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (20,'IT Problems','John from IT called me Fat','James Dev','Open',2,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (21,'Optimize Back-End','Goal is same execution with 70% of the overhead','James Dev','Closed',1,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (22,'Front-End Update','Incompatible with mobile devices','Jane Dev','Closed',1,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (23,'IT Problems','John from IT called me Fat','Jane Dev','Open',3,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (24,'Optimize Back-End','Goal is same execution with 70% of the overhead','Jane Dev','Closed',2,'Optimize');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (25,'Bug Problems','Bugs in my PC','Jane Dev','Closed',1,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (26,'IT Problems','John from IT called me Fat','Jane Dev','Open',4,'IT');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (27,'Front-End Update','Incompatible with mobile devices','Jane Dev','Closed',1,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (28,'Bug Problems','Bugs in my PC','Jane Dev','Closed',2,'Bug');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (29,'Front-End Update','Incompatible with mobile devices','Jane Dev','Closed',1,'Front-End');
INSERT INTO tickets(Id,Title,Description,Submitter,Status,Priority,Type) VALUES (30,'Optimize Back-End','Goal is same execution with 70% of the overhead','Jane Dev','Open',3,'Optimize');

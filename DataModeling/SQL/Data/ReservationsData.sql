--ReservationsData--
USE TravelAgency;
GO

--HotelReservationsData--
INSERT Agency.Reservations(HotelReservation,TripID) -- Count 100
VALUES (1,33),(1,5),(1,100),(1,9),(1,3),(1,2),
(1,28),(1,70),(1,72),(1,48),(1,66),(1,53),(1,13),
(1,83),(1,6),(1,79),(1,84),(1,61),(1,42),(1,8),
(1,42),(1,41),(1,64),(1,6),(1,82),(1,3),(1,67),
(1,99),(1,12),(1,55),(1,55),(1,11),(1,78),(1,81),
(1,16),(1,14),(1,54),(1,72),(1,82),(1,28),(1,68),
(1,43),(1,25),(1,34),(1,24),(1,63),(1,39),(1,92),
(1,57),(1,2),(1,39),(1,47),(1,60),(1,99),(1,23),
(1,52),(1,42),(1,19),(1,78),(1,52),(1,31),(1,71),
(1,25),(1,85),(1,74),(1,36),(1,21),(1,29),(1,53),
(1,100),(1,89),(1,39),(1,73),(1,40),(1,33),(1,100),
(1,3),(1,80),(1,51),(1,98),(1,87),(1,65),(1,57),
(1,48),(1,3),(1,66),(1,18),(1,54),(1,29),(1,35),
(1,56),(1,67),(1,44),(1,43),(1,10),(1,79),(1,18),
(1,12),(1,9),(1,44);
INSERT Hotels.HotelReservation(ReservationID,HotelID,CheckInDate,Price) -- ReservationID 1 - 100
VALUES (1,42,'2020-11-10',20),(2,57,'2020-10-22',21.5),(3,65,'2020-10-03',23),
(4,7,'2020-08-06',24.5),(5,20,'2020-05-06',26),(6,3,'2020-08-12',27.5),
(7,9,'2019-07-04',29),(8,8,'2019-01-28',30.5),(9,34,'2020-07-03',32),
(10,80,'2020-03-29',33.5),(11,96,'2019-08-30',35),(12,2,'2019-10-29',36.5),
(13,76,'2020-04-04',38),(14,60,'2020-01-14',39.5),(15,27,'2020-10-18',41),
(16,40,'2019-06-20',42.5),(17,24,'2019-09-18',44),(18,11,'2019-12-09',45.5),
(19,29,'2019-02-14',47),(20,54,'2019-07-07',48.5),(21,88,'2019-11-30',50),
(22,90,'2019-03-24',51.5),(23,58,'2020-05-07',53),(24,17,'2019-12-09',54.5),
(25,19,'2020-09-03',56),(26,40,'2020-01-18',57.5),(27,30,'2020-02-06',59),
(28,30,'2020-06-23',60.5),(29,86,'2019-09-15',62),(30,62,'2020-01-23',63.5),
(31,43,'2020-07-04',65),(32,12,'2018-12-23',66.5),(33,52,'2019-07-22',68),
(34,61,'2019-07-27',69.5),(35,20,'2020-05-25',71),(36,69,'2019-10-19',72.5),
(37,77,'2019-02-19',74),(38,95,'2020-01-10',75.5),(39,38,'2019-04-20',77),
(40,30,'2020-03-26',78.5),(41,41,'2018-12-06',80),(42,34,'2019-02-19',81.5),
(43,44,'2019-06-23',83),(44,46,'2019-10-22',84.5),(45,67,'2020-11-08',86),
(46,65,'2020-09-17',87.5),(47,91,'2019-10-27',89),(48,96,'2020-10-05',90.5),
(49,72,'2020-05-02',92),(50,59,'2020-02-13',93.5),(51,15,'2019-03-05',95),
(52,43,'2020-07-25',96.5),(53,53,'2019-06-06',98),(54,74,'2020-10-09',99.5),
(55,52,'2019-02-10',101),(56,71,'2019-12-03',102.5),(57,46,'2019-02-05',104),
(58,79,'2019-09-12',105.5),(59,11,'2020-02-28',107),(60,100,'2019-10-11',108.5),
(61,60,'2020-07-02',110),(62,25,'2019-12-03',111.5),(63,46,'2020-01-05',113),
(64,29,'2019-08-18',114.5),(65,46,'2020-05-21',116),(66,99,'2019-11-26',117.5),
(67,18,'2018-12-22',119),(68,51,'2019-04-28',120.5),(69,60,'2020-06-27',122),
(70,91,'2020-05-19',123.5),(71,30,'2019-11-24',125),(72,18,'2020-04-17',126.5),
(73,86,'2020-01-29',128),(74,86,'2020-09-16',129.5),(75,78,'2019-01-13',131),
(76,26,'2019-08-27',132.5),(77,57,'2019-07-13',134),(78,80,'2019-01-18',135.5),
(79,86,'2019-11-08',137),(80,16,'2020-09-25',138.5),(81,10,'2020-03-15',140),
(82,67,'2019-05-28',141.5),(83,3,'2020-02-13',143),(84,55,'2019-10-13',144.5),
(85,54,'2019-09-01',146),(86,19,'2019-06-28',147.5),(87,27,'2019-04-30',149),
(88,98,'2019-05-22',150.5),(89,92,'2019-08-11',152),(90,9,'2019-04-17',153.5),
(91,92,'2020-05-11',155),(92,43,'2020-08-22',156.5),(93,71,'2020-10-05',158),
(94,61,'2019-11-16',159.5),(95,3,'2020-06-14',161),(96,80,'2020-09-15',162.5),
(97,18,'2019-06-11',164),(98,51,'2019-06-01',165.5),(99,82,'2019-06-13',167),
(100,83,'2020-03-13',168.5);

--BoardingPass Reservations
INSERT Agency.Reservations(BoardingPass,TripID) -- Count 100
VALUES (1,52),(1,24),(1,13),(1,81),(1,32),(1,41),
(1,17),(1,71),(1,69),(1,84),(1,15),(1,73),(1,45),
(1,10),(1,50),(1,43),(1,9),(1,89),(1,22),(1,77),
(1,10),(1,89),(1,15),(1,2),(1,16),(1,10),(1,92),
(1,14),(1,48),(1,31),(1,74),(1,74),(1,11),(1,90),
(1,5),(1,79),(1,22),(1,16),(1,42),(1,90),(1,39),
(1,3),(1,78),(1,40),(1,47),(1,46),(1,20),(1,32),
(1,27),(1,61),(1,16),(1,24),(1,32),(1,33),(1,19),
(1,59),(1,25),(1,68),(1,56),(1,94),(1,29),(1,8),
(1,80),(1,15),(1,53),(1,58),(1,39),(1,70),(1,52),
(1,96),(1,65),(1,33),(1,18),(1,55),(1,9),(1,70),
(1,67),(1,62),(1,88),(1,96),(1,97),(1,64),(1,92),
(1,73),(1,99),(1,32),(1,57),(1,3),(1,88),(1,100),
(1,88),(1,86),(1,67),(1,87),(1,51),(1,63),(1,3),
(1,71),(1,78),(1,52);
INSERT Airlines.BoardingPass(ReservationID,FlightID,Price) -- ReservationsID 101 - 200
VALUES (101,47,80),(102,55,80),(103,45,80),(104,46,80),(105,30,80),
(106,65,80),(107,40,80),(108,5,80),(109,33,80),(110,29,80),
(111,69,80),(112,7,80),(113,52,80),(114,48,80),(115,100,80),
(116,88,80),(117,7,80),(118,18,80),(119,76,80),(120,97,80),
(121,99,84.5),(122,24,84.5),(123,21,84.5),(124,79,84.5),(125,26,84.5),
(126,37,84.5),(127,77,84.5),(128,3,84.5),(129,86,84.5),(130,78,84.5),
(131,40,84.5),(132,40,84.5),(133,22,84.5),(134,71,84.5),(135,57,84.5),
(136,30,87.5),(137,89,87.5),(138,57,87.5),(139,27,87.5),(140,96,87.5),
(141,38,87.5),(142,60,87.5),(143,71,87.5),(144,93,87.5),(145,20,87.5),
(146,39,92.25),(147,17,92.25),(148,98,92.25),(149,89,92.25),(150,13,92.25),
(151,16,92.25),(152,15,92.25),(153,92,92.25),(154,58,92.25),(155,79,92.25),
(156,56,92.25),(157,9,92.25),(158,58,92.25),(159,93,92.25),(160,36,92.25),(161,41,92.25),
(162,58,92.25),(163,86,97.25),(164,38,97.25),(165,82,97.25),(166,59,97.25),(167,44,97.25),
(168,81,97.25),(169,78,97.25),(170,6,97.25),(171,96,97.25),(172,96,97.25),(173,42,97.25),
(174,31,97.25),(175,67,97.25),(176,13,97.25),(177,24,97.25),(178,94,97.25),(179,90,97.25),
(180,100,127.25),(181,51,127.25),(182,27,127.25),(183,49,127.25),(184,17,127.25),(185,21,127.25),
(186,18,127.25),(187,49,127.25),(188,29,175),(189,1,175),(190,9,175),(191,16,175),
(192,79,175),(193,44,175),(194,31,175),(195,33,175),(196,3,175),(197,44,175),
(198,72,175),(199,4,175),(200,66,175);
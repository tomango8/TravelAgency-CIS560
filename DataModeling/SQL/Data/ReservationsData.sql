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

--AttractionTickets--
INSERT Agency.Reservations(AttractionTicket,TripID) -- Count 100
VALUES (1,63),(1,93),(1,99),(1,59),(1,98),(1,52),
(1,79),(1,76),(1,41),(1,48),(1,2),(1,29),(1,81),
(1,86),(1,88),(1,43),(1,95),(1,58),(1,46),(1,46),
(1,70),(1,41),(1,25),(1,69),(1,74),(1,47),(1,38),
(1,71),(1,87),(1,16),(1,26),(1,81),(1,89),(1,11),
(1,20),(1,54),(1,88),(1,18),(1,22),(1,72),(1,36),
(1,69),(1,42),(1,87),(1,44),(1,69),(1,82),(1,16),
(1,59),(1,86),(1,80),(1,33),(1,51),(1,100),(1,13),
(1,99),(1,55),(1,32),(1,49),(1,9),(1,81),(1,74),
(1,18),(1,9),(1,85),(1,60),(1,71),(1,74),(1,76),
(1,89),(1,37),(1,85),(1,55),(1,75),(1,17),(1,14),
(1,92),(1,83),(1,81),(1,66),(1,60),(1,27),(1,47),
(1,45),(1,12),(1,45),(1,4),(1,50),(1,91),(1,36),
(1,6),(1,55),(1,14),(1,64),(1,82),(1,84),(1,80),
(1,32),(1,41),(1,63);
INSERT Attractions.AttractionTicket(ReservationID,AttractionID,TicketDate, Price) -- ReservationID 201 - 300
VALUES (201,71,'2020-01-13',8.99),(202,32,'2019-04-14',8.99),(203,31,'2019-12-19',8.99),
(204,34,'2020-11-28',8.99),(205,30,'2019-10-25',8.99),(206,84,'2019-01-24',8.99),
(207,58,'2019-08-05',8.99),(208,32,'2019-10-12',8.99),(209,96,'2020-11-23',8.99),
(210,67,'2019-09-08',7.99),(211,7,'2019-06-27',7.99),(212,24,'2020-09-05',7.99),
(213,44,'2019-04-29',7.99),(214,1,'2020-01-24',19.99),(215,74,'2019-04-06',19.99),
(216,43,'2020-09-20',19.99),(217,90,'2019-07-09',19.99),(218,27,'2019-05-06',19.99),
(219,73,'2020-11-15',19.99),(220,69,'2020-04-22',19.99),(221,71,'2020-04-21',19.99),
(222,7,'2018-12-23',23.99),(223,70,'2020-02-27',23.99),(224,25,'2019-08-07',23.99),
(225,53,'2020-11-11',23.99),(226,50,'2020-08-12',23.99),(227,100,'2020-08-06',23.99),
(228,90,'2020-01-26',23.99),(229,8,'2020-11-02',23.99),(230,85,'2020-08-29',23.99),
(231,11,'2019-02-01',45.99),(232,59,'2020-01-28',45.99),(233,2,'2018-12-22',45.99),
(234,24,'2020-03-04',45.99),(235,31,'2020-02-27',45.99),(236,61,'2019-03-26',45.99),
(237,90,'2019-12-09',45.99),(238,70,'2020-03-12',32.99),(239,91,'2020-03-24',32.99),
(240,14,'2019-01-21',32.99),(241,44,'2018-12-18',32.99),(242,14,'2020-11-11',32.99),
(243,48,'2019-11-08',32.99),(244,47,'2020-04-12',32.99),(245,67,'2020-06-21',32.99),
(246,69,'2019-12-28',32.99),(247,22,'2019-12-13',32.99),(248,82,'2019-11-06',32.99),
(249,91,'2019-05-04',32.99),(250,60,'2019-09-29',32.99),(251,9,'2020-08-10',32.99),
(252,47,'2019-04-12',26.99),(253,68,'2019-02-11',26.99),(254,88,'2019-03-14',26.99),
(255,25,'2018-12-05',26.99),(256,13,'2019-06-03',26.99),(257,65,'2019-12-29',26.99),
(258,23,'2020-03-30',26.99),(259,73,'2019-10-11',26.99),(260,99,'2020-11-13',26.99),
(261,6,'2020-05-08',13.99),(262,52,'2020-10-19',13.99),(263,47,'2019-07-12',13.99),
(264,9,'2020-03-08',13.99),(265,97,'2020-10-08',13.99),(266,49,'2019-12-11',13.99),
(267,32,'2019-11-10',13.99),(268,76,'2020-07-20',13.99),(269,74,'2020-04-01',13.99),
(270,42,'2020-11-20',13.99),(271,25,'2019-11-11',16.99),(272,49,'2019-01-21',16.99),
(273,5,'2019-10-14',16.99),(274,85,'2020-04-28',16.99),(275,53,'2020-02-03',16.99),
(276,80,'2019-01-10',16.99),(277,75,'2019-12-12',16.99),(278,98,'2019-10-24',16.99),
(279,1,'2019-10-07',16.99),(280,45,'2018-12-23',16.99),(281,46,'2019-05-29',16.99),
(282,78,'2019-11-24',16.99),(283,18,'2020-09-19',16.99),(284,34,'2019-01-30',16.99),
(285,45,'2019-06-05',16.99),(286,5,'2020-07-16',16.99),(287,48,'2019-06-16',18.99),
(288,76,'2020-09-04',18.99),(289,99,'2019-06-28',18.99),(290,77,'2019-01-02',18.99),
(291,7,'2019-07-11',18.99),(292,88,'2020-06-17',18.99),(293,2,'2020-06-04',18.99),
(294,91,'2019-04-08',18.99),(295,97,'2020-01-16',18.99),(296,71,'2019-08-17',18.99),
(297,30,'2020-02-07',18.99),(298,63,'2019-08-26',18.99),(299,40,'2019-05-18',18.99),
(300,87,'2020-05-10',18.99);

--RestaurantReservations
INSERT Agency.Reservations(RestaurantReservation,TripID) -- Count 100
VALUES (1,34),(1,5),(1,2),(1,7),(1,8),(1,75),(1,12),(1,31),(1,98),(1,75),(1,61),
(1,41),(1,62),(1,85),(1,36),(1,83),(1,88),(1,72),(1,73),(1,35),(1,1),(1,25),(1,83),
(1,87),(1,86),(1,15),(1,76),(1,53),(1,61),(1,98),(1,97),(1,26),(1,6),(1,34),(1,85),
(1,92),(1,3),(1,60),(1,28),(1,42),(1,57),(1,96),(1,70),(1,62),(1,21),(1,2),(1,62),
(1,91),(1,75),(1,67),(1,6),(1,53),(1,12),(1,89),(1,31),(1,99),(1,81),(1,3),(1,2),
(1,57),(1,23),(1,28),(1,56),(1,61),(1,39),(1,89),(1,9),(1,5),(1,40),(1,3),(1,74),
(1,91),(1,25),(1,54),(1,75),(1,13),(1,72),(1,87),(1,28),(1,79),(1,66),(1,31),(1,92),
(1,38),(1,90),(1,68),(1,61),(1,67),(1,30),(1,66),(1,97),(1,8),(1,68),(1,26),(1,38),
(1,12),(1,17),(1,39),(1,20),(1,88);
INSERT Restaurants.RestaurantReservation(ReservationID,ReservationDate,RestaurantID) -- ReservationID 301 - 400
VALUES (301,'2018-12-13 00:23:00',42),(302,'2019-12-17 07:07:00',13),(303,'2020-04-29 14:55:00',89),
(304,'2020-03-31 16:50:00',30),(305,'2019-11-13 22:54:00',75),(306,'2019-09-29 19:43:00',92),
(307,'2019-11-15 00:35:00',84),(308,'2019-11-06 09:39:00',13),(309,'2020-08-18 18:44:00',14),
(310,'2020-07-14 15:34:00',59),(311,'2020-03-16 09:36:00',19),(312,'2020-04-22 06:55:00',57),
(313,'2019-07-17 16:45:00',29),(314,'2020-03-06 15:39:00',62),(315,'2020-02-05 03:01:00',69),
(316,'2020-09-24 22:43:00',33),(317,'2020-11-05 21:49:00',83),(318,'2020-07-23 23:37:00',30),
(319,'2019-02-08 15:36:00',20),(320,'2020-02-24 15:07:00',52),(321,'2019-03-24 13:17:00',56),
(322,'2020-07-17 02:15:00',90),(323,'2018-12-24 20:15:00',22),(324,'2020-09-03 11:39:00',21),
(325,'2019-05-04 01:09:00',12),(326,'2019-07-17 00:35:00',47),(327,'2019-04-04 03:00:00',48),
(328,'2020-09-11 17:00:00',19),(329,'2019-03-23 08:44:00',91),(330,'2020-11-01 19:08:00',51),
(331,'2019-10-29 19:32:00',13),(332,'2020-03-15 07:58:00',40),(333,'2020-10-09 13:08:00',25),
(334,'2020-04-10 11:39:00',84),(335,'2019-06-11 12:22:00',53),(336,'2019-01-08 07:08:00',75),
(337,'2020-09-07 03:19:00',4),(338,'2020-06-01 16:29:00',57),(339,'2020-10-09 17:22:00',24),
(340,'2020-04-24 06:14:00',62),(341,'2019-04-28 18:37:00',30),(342,'2019-10-11 15:10:00',5),
(343,'2019-01-01 13:45:00',10),(344,'2020-09-06 19:34:00',21),(345,'2019-04-14 12:20:00',9),
(346,'2019-05-07 18:53:00',16),(347,'2019-10-19 17:58:00',87),(348,'2020-04-19 19:36:00',57),
(349,'2019-03-08 17:42:00',80),(350,'2020-10-26 13:07:00',7),(351,'2019-11-16 20:01:00',18),
(352,'2020-09-30 11:28:00',64),(353,'2020-01-27 16:28:00',98),(354,'2019-08-13 17:32:00',45),
(355,'2020-08-26 10:28:00',85),(356,'2020-04-28 23:04:00',94),(357,'2020-11-28 21:55:00',39),
(358,'2019-11-01 05:12:00',80),(359,'2020-01-11 17:19:00',20),(360,'2019-02-02 04:34:00',53),
(361,'2020-07-09 08:23:00',55),(362,'2019-03-24 00:28:00',25),(363,'2020-09-23 06:45:00',58),
(364,'2020-02-04 01:23:00',71),(365,'2019-09-19 15:23:00',82),(366,'2019-05-26 03:01:00',5),
(367,'2020-08-22 03:28:00',63),(368,'2020-06-17 04:22:00',13),(369,'2019-12-27 11:06:00',18),
(370,'2019-05-01 00:09:00',83),(371,'2020-02-05 20:31:00',21),(372,'2019-07-21 02:03:00',94),
(373,'2019-09-03 12:27:00',26),(374,'2020-05-22 16:32:00',83),(375,'2020-05-30 18:56:00',21),
(376,'2019-07-26 04:24:00',56),(377,'2020-07-27 09:31:00',74),(378,'2019-07-20 04:37:00',46),
(379,'2019-06-03 08:57:00',90),(380,'2020-06-23 06:37:00',60),(381,'2019-08-14 07:13:00',52),
(382,'2020-04-30 09:14:00',2),(383,'2020-04-24 09:25:00',82),(384,'2019-08-10 03:27:00',64),
(385,'2020-10-19 02:28:00',33),(386,'2019-08-05 16:19:00',59),(387,'2019-01-23 12:04:00',46),
(388,'2019-01-03 09:27:00',7),(389,'2018-12-12 00:47:00',77),(390,'2020-02-18 13:33:00',25),
(391,'2020-01-12 04:19:00',66),(392,'2019-07-24 19:47:00',23),(393,'2019-02-11 03:30:00',67),
(394,'2019-01-02 08:53:00',25),(395,'2019-05-17 18:29:00',60),(396,'2019-10-01 23:53:00',55),
(397,'2020-04-03 14:47:00',29),(398,'2019-11-09 16:38:00',59),(399,'2020-11-14 07:37:00',39),
(400,'2020-10-25 13:26:00',95);

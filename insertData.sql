INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(1, 'Losail International Circuit', 'QATAR', 5380, 16, 12, 1068, '00:01:54.927');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(2, 'Termas de Río Hondo', 'ARGENTINA', 4805, 14, 16, 1076, '00:01:39.019');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(3, 'Circuit Of The Americas', 'UNITED STATES', 5513, 20, 15, 1200, '00:02:03.575');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(4, 'Circuito de Jerez - Angel Nieto', 'SPAIN', 4423, 13, 11, 607, '00:01:38.735');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(5, 'Le Mans', 'FRANCE', 4180, 11, 13, 674, '00:01:32.309');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(6, 'Autodromo del Mugello', 'ITALY', 5245, 15, 14, 1141, '00:01:47.639');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(7, 'Circuit de Barcelona-Catalunya', 'SPAIN', 4727, 16, 14, 1047, '00:01:47.639');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(8, 'TT Circuit Assen', 'NETHERLANDS', 4542, 18, 14, 487, '00:01:33.617');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(9, 'Sachsenring', 'GERMANY', 3671, 13, 12, 700, '00:01:21.442');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(10, 'Automotodrom Brno', 'CZECH REPUBLIC', 5403, 14, 15, 636, '00:01:56.027');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(11, 'Red Bull Ring - Spielberg', 'AUSTRIA', 4318, 10, 13, 626, '00:01:24.312');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(12, 'Silverstone Circuit', 'GREAT BRITAIN', 5900, 18, 15, 770, '00:02:01.560');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(13, 'Misano World Circuit Marco Simoncelli', 'ITALY', 4226, 16, 14, 530, '00:01:32.979');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(14, 'MotorLand Aragon', 'SPAIN', 5078, 19, 15, 968, '00:01:48.120');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(15, 'Chang International Circuit', 'THAILAND', 4554, 12, 12, 1000, '00:01:31.471');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(16, 'Twin Ring Motegi', 'JAPAN', 4801, 14, 15, 762, '00:01:45.350');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(17, 'Phillip Island', 'AUSTRALIA', 4448, 12, 13, 1956, '00:01:28.108');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(18, 'Sepang International Circuit', 'MALAYSIA', 5548, 15, 16, 920, '00:02:00.606');
GO

INSERT INTO [Circuits]
([ID], [Name], [Country], [Length], [NumberOfCurves], [Width], [StraightLonger], [RaceLapRecord])
VALUES
(19, 'Circuit Ricardo Tormo', 'SPAIN', 4005, 14, 12, 876, '00:01:31.171');
GO

INSERT INTO [Events] 
([ID], [Name], [Date], [CircuitId])
VALUES
(1, 'VisitQatar Grand Prix', '2019-03-10', 1);
GO

INSERT INTO [Events] 
([ID], [Name], [Date], [CircuitId])
VALUES
(2, 'Gran Premio Motul de la República Argentina', '2019-03-31', 2);
GO

INSERT INTO [Events] 
([ID], [Name], [Date], [CircuitId])
VALUES
(3, 'Red Bull Grand Prix of The Americas', '2019-04-14', 3);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(4, 'Gran Premio Red Bull de España', '2019-05-05', 4);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(5, 'SHARK Helmets Grand Prix de France', '2019-05-19', 5);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(6, 'Gran Premio d''Italia Oakley', '2019-06-02', 6);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(7, 'Gran Premi Monster Energy de Catalunya', '2019-06-16', 7);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(8, 'Motul TT Assen', '2019-06-30', 8);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(9, 'HJC Helmets Motorrad Grand Prix Deutschland', '2019-07-07', 9);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(10, 'Monster Energy Grand Prix České republiky', '2019-08-04', 10);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(11, 'myWorld Motorrad Grand Prix von Österreich', '2019-08-11', 11);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(12, 'GoPro British Grand Prix', '2019-08-25', 12);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(13, 'Gran Premio Octo di San Marino e della Riviera di Rimini', '2019-09-15', 13);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(14, 'Gran Premio de Aragón', '2019-09-22', 14);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(15, 'PTT Thailand Grand Prix', '2019-10-06', 15);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(16, 'Motul Grand Prix of Japan', '2019-10-20', 16);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(17, 'Australian Motorcycle Grand Prix', '2019-10-27', 17);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(18, 'Shell Malaysia Motorcycle Grand Prix', '2019-11-03', 18);
GO

INSERT INTO [Events]
([ID], [Name], [Date], [CircuitId])
VALUES
(19, 'Gran Premio Motul de la Comunitat Valenciana', '2019-11-17', 19);
GO
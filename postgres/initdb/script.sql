--- TABLA 


CREATE TABLE vehiculo(
	id SERIAL PRIMARY KEY,
	marca TEXT NOT NULL,
	modelo INTEGER NOT NULL,
	description TEXT
);



--- DATOS 

INSERT INTO vehiculo(marca,modelo,description)
VALUES 
('Toyota', 2015, 'Sedán gris en excelentes condiciones'),
('Honda', 2012, 'Camioneta roja con 4x4'),
('Ford', 2010, 'Pickup blanca con asientos de cuero'),
('Nissan', 2018, 'SUV negra con capacidad para 7 pasajeros'),
('Chevrolet', 2008, 'Auto compacto plateado'),
('Dodge', 2016, 'Camioneta verde con caja de herramientas'),
('Jeep', 2019, 'SUV azul con techo panorámico'),
('Mazda', 2013, 'Sedán negro con detalles en cromo'),
('Subaru', 2005, 'Auto deportivo rojo con alerón trasero'),
('Hyundai', 2017, 'Camioneta gris con reproductor de DVD'),
('Kia', 2014, 'Sedán blanco con sistema de navegación'),
('BMW', 2011, 'Auto deportivo amarillo con interior de piel'),
('Mercedes-Benz', 2018, 'SUV blanca con faros LED'),
('Audi', 2015, 'Sedán negro con asientos deportivos'),
('Volkswagen', 2007, 'Auto compacto gris con llantas de aleación'),
('Lexus', 2012, 'SUV plateada con sistema de sonido premium'),
('Infiniti', 2016, 'Sedán rojo con techo solar'),
('Porsche', 2010, 'Auto deportivo negro con motor turbo'),
('Tesla', 2020, 'Auto eléctrico blanco con piloto automático'),
('Land Rover', 2009, 'Camioneta negra con suspensión todoterreno');



---VIEW 



CREATE VIEW ultimos_vehiculos AS 
SELECT marca,modelo
FROM vehiculo
WHERE modelo >= EXTRACT(YEAR FROM NOW()) - 5
ORDER BY marca,modelo;



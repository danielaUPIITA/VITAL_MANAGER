INSERT INTO pacientes.paciente (nombre, fecha_nacimiento, telefono, direccion)
VALUES ('Canela Monzon', '2024-10-31', '5551234567', 'Calle Falsa 123');
INSERT INTO pacientes.paciente (nombre, fecha_nacimiento, telefono, direccion)
VALUES ('Andrea Vargas', '2000-12-23', '5551234567', 'Calle Falsa 123');
INSERT INTO pacientes.paciente (nombre, fecha_nacimiento, telefono, direccion)
VALUES ('Daniela Monzon', '1999-07-21', '546912', 'Calle Falsa 123');

SELECT * FROM pacientes.paciente;

INSERT INTO personal.personal_medico (nombre, usuario, password, rol)
VALUES ('Dr. Juan Pérez', 'jperez', 'clave_segura', 'medico');

SELECT * FROM personal.personal_medico WHERE id_personal = 1;

INSERT INTO atencion.atencion (id_paciente, id_personal, tipo_atencion, diagnostico)
VALUES (1, 1, 'Urgencia', 'Fractura de brazo');

SELECT a.id_atencion, p.nombre AS paciente, m.nombre AS medico, a.diagnostico
FROM atencion.atencion a
JOIN pacientes.paciente p ON a.id_paciente = p.id_paciente
JOIN personal.personal_medico m ON a.id_personal = m.id_personal;

INSERT INTO triage.triage (id_paciente, nivel, observaciones)
VALUES (1, 'Rojo', 'Paciente en estado crítico');
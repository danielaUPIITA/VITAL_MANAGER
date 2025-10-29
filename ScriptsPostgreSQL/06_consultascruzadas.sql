SELECT t.id_triage, p.nombre, t.nivel, t.fecha_triage
FROM triage.triage t
JOIN pacientes.paciente p ON t.id_paciente = p.id_paciente;
SELECT * FROM pacientes.paciente;


SELECT table_schema, table_name
FROM information_schema.tables
WHERE table_name = 'insumo_medico';

SELECT * FROM recursos.insumo_medico;

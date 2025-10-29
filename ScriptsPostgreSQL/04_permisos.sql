GRANT SELECT ON pacientes.paciente TO medico;
GRANT INSERT, SELECT ON atencion.atencion TO medico;
GRANT SELECT ON triage.triage TO medico;

GRANT SELECT ON pacientes.paciente TO enfermera;
GRANT INSERT, SELECT ON triage.triage TO enfermera;

GRANT ALL PRIVILEGES ON recursos.espacio TO admin_recursos;
GRANT ALL PRIVILEGES ON recursos.insumo_medico TO admin_recursos;
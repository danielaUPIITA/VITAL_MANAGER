CREATE TABLE pacientes.paciente (
    id_paciente SERIAL PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    telefono VARCHAR(15),
    direccion TEXT
);

CREATE TABLE personal.personal_medico (
    id_personal SERIAL PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    usuario VARCHAR(50) UNIQUE NOT NULL,
    password TEXT NOT NULL,
    rol VARCHAR(50) NOT NULL
);

CREATE TABLE atencion.atencion (
    id_atencion SERIAL PRIMARY KEY,
    id_paciente INT NOT NULL,
    id_personal INT NOT NULL,
    fecha_atencion TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    tipo_atencion VARCHAR(50),
    diagnostico TEXT,
    CONSTRAINT fk_atencion_paciente FOREIGN KEY (id_paciente) REFERENCES pacientes.paciente(id_paciente),
    CONSTRAINT fk_atencion_personal FOREIGN KEY (id_personal) REFERENCES personal.personal_medico(id_personal)
);

CREATE TABLE triage.triage (
    id_triage SERIAL PRIMARY KEY,
    id_paciente INT NOT NULL,
    nivel VARCHAR(20) NOT NULL,
    fecha_triage TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    observaciones TEXT,
    CONSTRAINT fk_triage_paciente FOREIGN KEY (id_paciente) REFERENCES pacientes.paciente(id_paciente)
);

CREATE TABLE recursos.espacio (
    id_espacio SERIAL PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,
    disponible BOOLEAN DEFAULT TRUE
);

CREATE TABLE recursos.insumo_medico (
    id_insumo SERIAL PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT,
    cantidad INT NOT NULL,
    fecha_caducidad DATE
);

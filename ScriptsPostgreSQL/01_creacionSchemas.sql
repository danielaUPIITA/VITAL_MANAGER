CREATE USER admin_vital WITH PASSWORD 'AdminPass123';
GRANT ALL PRIVILEGES ON DATABASE bd_vitalmanager TO admin_vital;
CREATE SCHEMA pacientes AUTHORIZATION admin_vital;
CREATE SCHEMA triage AUTHORIZATION admin_vital;
CREATE SCHEMA atencion AUTHORIZATION admin_vital;
CREATE SCHEMA personal AUTHORIZATION admin_vital;
CREATE SCHEMA recursos AUTHORIZATION admin_vital;
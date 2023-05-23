CREATE TABLE area (
    id_area  NUMBER(10) NOT NULL,
    nom_area VARCHAR2(100) NOT NULL
);

ALTER TABLE area ADD CONSTRAINT area_pk PRIMARY KEY ( id_area );

CREATE TABLE cargo (
    id_cargo  NUMBER(10) NOT NULL,
    nom_cargo VARCHAR2(300) NOT NULL
);

ALTER TABLE cargo ADD CONSTRAINT cargo_pk PRIMARY KEY ( id_cargo );

CREATE TABLE compañia (
    id_compania  NUMBER(10) NOT NULL,
    nom_compañia VARCHAR2(100) NOT NULL,
    logo         BLOB NOT NULL
);

ALTER TABLE compañia ADD CONSTRAINT compañia_pk PRIMARY KEY ( id_compania );

CREATE TABLE componente (
    id_componente NUMBER(8) NOT NULL,
    componente    VARCHAR2(25) NOT NULL
);

ALTER TABLE componente ADD CONSTRAINT componente_pk PRIMARY KEY ( id_componente );

CREATE TABLE estado (
    id_estado  NUMBER(10) NOT NULL,
    nom_estado VARCHAR2(25) NOT NULL
);

ALTER TABLE estado
    ADD CHECK ( nom_estado IN ( 'Asignado', 'Atrasado', 'Devuelto', 'En Proceso', 'Pendiente',
                                'Realizado' ) );

ALTER TABLE estado ADD CONSTRAINT estado_pk PRIMARY KEY ( id_estado );

CREATE TABLE fecha (
    id_fehca       NUMBER(10) NOT NULL,
    fecha_creacion DATE NOT NULL,
    fecha_inicio   DATE NOT NULL,
    fecha_termino  DATE NOT NULL,
    id_tarea       NUMBER(10) NOT NULL,
    id_resultados  NUMBER(10) NOT NULL,
    id_proceso     NUMBER(10) NOT NULL
);

ALTER TABLE fecha ADD CONSTRAINT fecha_pk PRIMARY KEY ( id_fehca );

CREATE TABLE login (
    id_login    VARCHAR2(10) NOT NULL,
    contraseña  VARCHAR2(10) NOT NULL,
    id_compania NUMBER(10) NOT NULL,
    rut_1       VARCHAR2(12) NOT NULL
);

ALTER TABLE login ADD CONSTRAINT login_pk PRIMARY KEY ( id_login );

CREATE TABLE proceso (
    id_proceso  NUMBER(10) NOT NULL,
    nom_proceso VARCHAR2(20) NOT NULL
);

ALTER TABLE proceso ADD CONSTRAINT proceso_pk PRIMARY KEY ( id_proceso );

CREATE TABLE resultados (
    id_resultados NUMBER(10) NOT NULL,
    nom_resultado VARCHAR2(25) NOT NULL,
    resultado     BLOB NOT NULL,
    descripcion   VARCHAR2(1000) NOT NULL
);

ALTER TABLE resultados ADD CONSTRAINT resultados_pk PRIMARY KEY ( id_resultados );

CREATE TABLE sucursal (
    id_sucursal  NUMBER(10) NOT NULL,
    nom_sucursal VARCHAR2(150) NOT NULL,
    id_compania  NUMBER(10) NOT NULL
);

ALTER TABLE sucursal ADD CONSTRAINT sucursal_pk PRIMARY KEY ( id_sucursal );

CREATE TABLE tareas (
    id_tarea      NUMBER(10) NOT NULL,
    nom_tarea     VARCHAR2(100) NOT NULL,
    desc_tarea    VARCHAR2(100) NOT NULL,
    id_login      VARCHAR2(10) NOT NULL,
    id_estado     NUMBER(10) NOT NULL,
    id_resultados NUMBER(10) NOT NULL,
    id_proceso    NUMBER(10) NOT NULL
);

ALTER TABLE tareas
    ADD CONSTRAINT tareas_pk PRIMARY KEY ( id_tarea,
                                           id_resultados,
                                           id_proceso );

CREATE TABLE tipo_usuario (
    id_tipo       NUMBER(10) NOT NULL,
    nom_tipo      VARCHAR2(25) NOT NULL,
    id_componente NUMBER(8) NOT NULL
);

ALTER TABLE tipo_usuario
    ADD CHECK ( nom_tipo IN ( 'Administrador', 'Especialista', 'Funcionario' ) );

ALTER TABLE tipo_usuario ADD CONSTRAINT tipo_usuario_pk PRIMARY KEY ( id_tipo );

CREATE TABLE usuario (
    rut                VARCHAR2(12) NOT NULL,
    nom_usuario        VARCHAR2(25) NOT NULL,
    ape_paterno        VARCHAR2(25) NOT NULL,
    apematerno         VARCHAR2(25) NOT NULL,
    id_cargo           NUMBER(10) NOT NULL,
    usuario_id_tipo    NUMBER(10) NOT NULL,
    permiso_id_permiso NUMBER NOT NULL,
    foto_usuario       BLOB,
    id_area            NUMBER(10) NOT NULL
);

ALTER TABLE usuario ADD CONSTRAINT usuario_pk PRIMARY KEY ( rut );

ALTER TABLE fecha
    ADD CONSTRAINT fecha_tareas_fk FOREIGN KEY ( id_tarea,
                                                 id_resultados,
                                                 id_proceso )
        REFERENCES tareas ( id_tarea,
                            id_resultados,
                            id_proceso );

ALTER TABLE login
    ADD CONSTRAINT login_compañia_fk FOREIGN KEY ( id_compania )
        REFERENCES compañia ( id_compania );

ALTER TABLE login
    ADD CONSTRAINT login_usuario_fkv2 FOREIGN KEY ( rut_1 )
        REFERENCES usuario ( rut );

ALTER TABLE sucursal
    ADD CONSTRAINT sucursal_compañia_fk FOREIGN KEY ( id_compania )
        REFERENCES compañia ( id_compania );

ALTER TABLE tareas
    ADD CONSTRAINT tareas_estado_fk FOREIGN KEY ( id_estado )
        REFERENCES estado ( id_estado );

ALTER TABLE tareas
    ADD CONSTRAINT tareas_login_fk FOREIGN KEY ( id_login )
        REFERENCES login ( id_login );

ALTER TABLE tareas
    ADD CONSTRAINT tareas_proceso_fk FOREIGN KEY ( id_proceso )
        REFERENCES proceso ( id_proceso );

ALTER TABLE tareas
    ADD CONSTRAINT tareas_resultados_fk FOREIGN KEY ( id_resultados )
        REFERENCES resultados ( id_resultados );

ALTER TABLE tipo_usuario
    ADD CONSTRAINT tipo_usuario_componente_fk FOREIGN KEY ( id_componente )
        REFERENCES componente ( id_componente );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_area_fk FOREIGN KEY ( id_area )
        REFERENCES area ( id_area );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_cargo_fk FOREIGN KEY ( id_cargo )
        REFERENCES cargo ( id_cargo );

ALTER TABLE usuario
    ADD CONSTRAINT usuario_tipo_usuario_fk FOREIGN KEY ( usuario_id_tipo )
        REFERENCES tipo_usuario ( id_tipo );




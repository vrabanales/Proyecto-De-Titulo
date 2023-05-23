--Informacion de compañia y sus sucursales
select c.nom_compañia COMPAÑIA,c.logo LOGO,s.id_sucursal ID,
s.nom_sucursal SUCURSAL
from sucursal s join compañia c on s.id_compania = c.id_compania
where s.id_compania = c.id_compania
;
--Informacion de estado de las tareas 
select t.nom_tarea TAREA,p.nom_proceso PROCESO, e.nom_estado ESTADO
from tareas t join proceso p on t.id_proceso = p.id_proceso
join estado e on e.id_estado = t.id_estado
;
--Estado: Realizado
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'Realizado'
;
--Estado: Atrasado
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'Atrasado'
;
--Estado: En Proceso
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'En Proceso'
;
--Estado: Asignado
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'Asignado'
;
--Estado: Devuelto
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'Devuelto'
;
--Estado: Pendiente
select u.NOM_USUARIO ||' '|| u.APE_PATERNO ||' '|| u.APEMATERNO "NOMBRE COMPLETO",
t.NOM_TAREA TAREA,e.NOM_ESTADO ESTADO
from estado e join tareas t on t.ID_ESTADO = e.ID_ESTADO
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
where nom_estado = 'Pendiente'
;
--Asociacion de cargo,area con usuario
select u.rut RUT, u.nom_usuario NOMBRE,u.ape_paterno "APELLIDO PATERNO",
apematerno "APELLIDO MATERNO",a.nom_area AREA,c.nom_cargo CARGO
from usuario u join cargo c on u.id_cargo = c.id_cargo
join area a on a.id_area = u.id_area
;
--Login para los usuarios con sus permisos
SELECT l.id_login RUT,l.contraseña CONTRASEÑA ,
u.nom_usuario USUARIO
FROM login l join usuario u ON l.id_login = u.rut
join tipo_usuario t on u.rut = t.id_tipo 
join componente c on t.id_tipo = c.id_componente
where u.nom_usuario = c.ID_COMPONENTE
;
--Generar los permiso de accesos con los respondientes permiso que son admin,funcionario,especialista
--Especialista
select u.RUT, u.APE_PATERNO "APELLIDO PATERNO",u.APEMATERNO "APELLIDO MATERNO",
t.NOM_TIPO "TIPO USUARIO",c.id_componente "ID COMPONENTE"
from usuario u join tipo_usuario t on u.usuario_id_tipo = t.id_tipo
join componente c on c.id_componente = t.id_componente 
where t.NOM_TIPO = 'Especialista' and c.id_componente = 2
;
--Administrador
select u.RUT, u.APE_PATERNO "APELLIDO PATERNO",u.APEMATERNO "APELLIDO MATERNO",
t.NOM_TIPO "TIPO USUARIO",c.id_componente "ID COMPONENTE"
from usuario u join tipo_usuario t on u.usuario_id_tipo = t.id_tipo
join componente c on c.id_componente = t.id_componente 
where t.NOM_TIPO = 'Administrador' and c.id_componente = 1
;
--Funcionario
select u.RUT, u.APE_PATERNO "APELLIDO PATERNO",u.APEMATERNO "APELLIDO MATERNO",
t.NOM_TIPO "TIPO USUARIO",c.id_componente "ID COMPONENTE"
from usuario u join tipo_usuario t on u.usuario_id_tipo = t.id_tipo
join componente c on c.id_componente = t.id_componente 
where t.NOM_TIPO = 'Funcionario' and c.id_componente = 3
;
--Union de datos de sucursal con compañia y sus usuarios respectivos
select u.rut,u.NOM_USUARIO ||' '|| u.ape_paterno ||' '|| u.apematerno Nombre,
s.NOM_SUCURSAL SUCURSAL,c.nom_compañia COMPAÑIA
from usuario u join login l on u.RUT = l.RUT_1 
join compañia c on c.id_compania = l.ID_COMPANIA 
join sucursal s on s.ID_COMPANIA = c.id_compania
where s.NOM_SUCURSAL = c.id_compania
;
--Infome de resultados de sierto usuario y sus respectivos datos y 
--en que sucursal lo realizo
select u.rut "RUT USUARIO ASIGNADO",
u.nom_usuario ||' '|| u.ape_paterno ||' '|| u.apematerno "USUARIO ASIGNADO"
,t.NOM_TAREA TAREA,t.DESC_TAREA "DSCRIPCION TAREA",
r.ID_RESULTADOS "ID RESULTADO", r.NOM_RESULTADO RESULTADO,
r.DESCRIPCION "DESCRIPCION RESULTADOS",r.RESULTADO GRAFICO
from tareas t join resultados r on r.ID_RESULTADOS = t.id_resultados
join login l on l.ID_LOGIN = t.ID_LOGIN
join usuario u on u.RUT = l.RUT_1
join cargo c on c.ID_CARGO = u.ID_CARGO
join area a on a.ID_AREA = u.ID_AREA
join proceso p on p.ID_PROCESO = t.ID_PROCESO
join fecha f on f.ID_TAREA = t.ID_TAREA
;

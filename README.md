# Gradia.Valentin.PrimerParcial

## CRUD- Equipo de jugadores
___
## Sobre Mi
**Me llamo Valentin, tengo 18 años y estudio programacion en la UTN. Siempre me gusto la programacion desde chico, en la 
primaria una profesora mia tuvo un incoveniente por lo que pusieron un profesor de la universidad (UAI) a enseñarnos. Vimos access y como proyecto tuvimos 
que hacer una calculadora lo cual me gusto mucho y encontre una relacion por asi decirlo con la programacion**
___
## Resumen
**La aplicacion se encarga de crear equipos los cuales puedes agregar jugadores, modificar sus datos o eliminarlos del equipo. No solo eso sino que puedes tambien 
puedes modificar los equipos en el cual  puedes acceder a estas caracteristicas. Dichos jugadores pueden ser guardados y/O almacenados en una base de datos, o si optas 
otra opcion, serealizarlos en archivo JSON**

![Alt text](DiagramaDeClases.png)

___

## SQL
**Se utiliza la BBDD para almacenar los tipos de jugadores. De ese modo podras tenerlos guardados y poder obtenerlos en otro equipo**

## Excepciones
**Se emplean excepciones en diversas secciones del código, en situaciones donde podría surgir un error durante la ejecución o en casos de errores del usuario. 
Por ejemplo, en el proceso de inicio de sesión, se desencadena una excepción controlada si los datos proporcionados por el usuario son incorrectos.**

## Generics
**Se utilizan generics tanto en metodos como en interfaces para poder trabajar con varios tipos de datos con el fin de hacer el codigo mucho mas flexible y
reutilizable, adaptandose a los diferentes datos.**

## Delegados
**Se emplean delegados a la hora de la creacion de eventos tales como confirmar una serie de eliminacion de datos o para actualizar procesos y comprobarlos**

## Task
**Se utilizan task para poder agregar y modificar diferentes equipos y no estar agregando y/o modificando equipo por equipo.**

## Serializacion
**Se emplea el termino serealizacion a la hora de obtener la lista de usuarios que pueden acceder a la aplicacion y tambien si el usuario quiere serelizar los diferentes
tipos de jugadores**

## Eventos
**Se utilizan eventos a la hora de comprobar la contraseña del usuario que este ingresando, lanzar mensajes de dialogos si ocurre algun error.**






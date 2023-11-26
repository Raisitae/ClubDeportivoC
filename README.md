
# Club Deportivo Supernova

El presente projecto es el trabajo final e integrador de la materia Desarrollo de Sistemas Orientados a Objetos, desarrollado con C# y Winforms con conexión a una base de datos SQL.

Todas las vistas, el código y los store procedures fueron realizados por nosotros a lo largo de la cursada de la materia.

## Funcionalidades
El club deportivo cuenta con un sistema de inicio de sesión y registro de nuevos usuarios, que pueden ser socios o no socios. Los socios pueden pagar una cuota mensual para acceder al club, los no socios pueden pagar una cuota diaria.

Cada socio cuenta con un perfil o carnet que, al iniciar sesión, le dice el estado de su membresía y, de estar vencida, le permite pagar nuevamente la cuota.

El administrador puede, además, generar un listado de todos los socios del club y revisar a quiénes (socios y no socios) se les vence su cuota ese mismo día.

**TLDR; de las funciones de un CRUD, tenemos Create y Read de socios, no socios y cuotas**



## Instalación
Para instalar la aplicación, se hace un git clone del projecto. Para que el projecto funcione es importante agregar App.config dentro de la carpeta ClubDeportivoWinForms que tenga la siguiente estructura:
```
<configuration>
	<appSettings>
		<add key="baseDatos" value="clubdeportivo" />
		<add key="servidor" value="localhost" />
		<add key="puerto" value="3306" />
		<add key="usuario" value="TU_USUARIO" />
		<add key="clave" value="TUCLAVE" />
	</appSettings>
</configuration>
```
Allí se realiza la conexión con la base de datos. (Estamos trabajando para lograr una conexión con una base de datos online!)

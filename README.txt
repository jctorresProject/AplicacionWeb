******************************************************************************************************************************************
REQUISITOR PARA SU INSTALACION
******************************************************************************************************************************************
1. Crear la base de datos con el nombre que guste, y se debe ejecutar el script que crea las tablas que esta relacionado en el documento de la prueba

2. Ejecutar el archivo Scipts.sql  de la ruta : [\PruebaTecnicaJulioTorres]

3. Para configurar la base de datos se debe modificar el archivo [appsettings] de la ruta : [\PruebaTecnicaJulioTorres\AppWebPruebaTecnicaSICO\AppWebPruebaTecnicaSICO]  
   {
  "ConnectionStrings": {
    "ConnectionString": "Server=XXXXXXXX;Initial Catalog=XXXXXXXXXX;Integrated Security=True"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}

4. Ejecutar la solucion del proyecto BACKEND  de la ruta : [\PruebaTecnicaJulioTorres\AppWebPruebaTecnicaSICO]
5. Ejecutar la solucion del proyecto FRONTEND de la ruta : [\PruebaTecnicaJulioTorres\FRONT_AppWebPruebaTecnicaSICO]
   NOTA : El proyecto FRONTEND no funcionará si el proyecto BACKEND no esta corriendo.

6. ALCANCE DE LA PRUEBA : Señores evaluadores, por favor sin el animo de excusarme el alcance de esta prueba es un un CRUD de la tabla Estudiante.
                       	  Por razones ajenas a mi no lo pude llevar hasta el final, pero como muestra de mi responsabilidad hago entrega de la prueba
                          con un alcance algo pequeño pero funcional.
		          MUCHAS GRACIAS.!!

******************************************************************************************************************************************
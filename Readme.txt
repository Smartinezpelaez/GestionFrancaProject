-- Version.1.0.0
-Creaci�n de la arquitectura en capas 
-Creaci�n de los modelos 
-Creaci�n del DbConnection
-Creaci�n del patron Repositroy
-Creaci�n del servicio
-Creaci�n de los controladores y las vistas
-Agragar el patron singleton 
-Agregar el Automapper

-- Pendientes

-Ajustar la logica de los servicios y viewBags
-Ajustar las vistas 


-- Ingenieria Inversa
Instalador-Cli y Scaffol
dotnet tool install -g linq2db.cli 
dotnet linq2db scaffold -p SqlServer -c "data source=DESKTOP-I0OTQSJ\SQLEXPRESS;initial catalog=GestionFranca;user id=UserGestionfranca;password=Sqa`$12345;MultipleActiveResultSets=True;TrustServerCertificate=true;" --overwrite true --include-default-schema-name true -OutputDir Models
Scaffold-DbContext "Server=DESKTOP-I0OTQSJ\SQLEXPRESS;Database=GestionFranca;User ID=UserGestionfranca;Password=Sqa`$12345;TrustServerCertificate=Yes"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

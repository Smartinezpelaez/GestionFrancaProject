-- Version.1.0.0
-Creación de la arquitectura en capas 
-Creación de los modelos 
-Creación del DbConnection
-Creación del patron Repositroy
-Creación del servicio
-Creación de los controladores y las vistas
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

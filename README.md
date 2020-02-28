# AspNetCoreEfCoreMySQL
Asp.Net Core 2.0 , EFCore and MySQL

 ASp.net Core 2.0, EntityFramework Core and MySQL
 
 
 Step 1: Set MySQL ConnectionString in appsettings
 
 Step 2: Install nuget package Pomelo.EntityFrameworkCore.MySql 2.2.6
 
 Step 3: Generate Model and DB Context from Scaffold-DbContext in PowerShell as per below command
 
Scaffold-DbContext "server=localhost;userid=root;password=root;database=quiz;" Pomelo.EntityFrameworkCore.MySql -OutputDir Models -f 
 
 Step 4: Add MySQL DBContxt in Startp.cs
 
             var sqlConnectionString = Configuration.GetConnectionString("DataAccessMySqlProvider");

            services.AddDbContext<quizContext>(options => options.UseMySql(sqlConnectionString));
			
			
 Step 5: Thats's it now mySQL DB integrated succeessful

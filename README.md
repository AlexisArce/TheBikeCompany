# The Bike Company

Hice una clase que represente la factura (Invoice) que tenga una lista de los
alquileres (Rentals). Invoice tiene la responsabilidad de calcular el total, pidiendole
a cada Rental su "charge" (se utiliza un strategy para determinar el charge correspondiente). 
Invoice solicita la promoción correspondiente para cada caso a un simple factory muy básico.

Se pueden correr las unit tests mediante Visual Studio, o ejecutando el comando 
dotnet xunit (habiando compilado la solución previamente).

 por ej:	\TheBikeCompany\TheBikeCompany.Tests> dotnet xunit
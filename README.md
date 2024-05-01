PASSO A PASSO

dotnet new web -n NomeProjeto //Cria uma minimal API
---
instalar pacotes EntityFramework - Nuget - Design e sqlite... 8.04
---
fazer a pasta models e arquivo http...
---




---
dotnet tool install --global dotnet ef  //instalar globalmente
dotnet ef migrations add VersaoInicial... // adiciona uma migracao ao prpjeto
dotnet ef database update // atualiza a migracao
dotnet ef migrations remove // remove a migracao
---

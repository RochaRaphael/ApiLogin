# ApiLogin

Essa API foi desenvolvida  com o foco de melhorar as habilidades com o uso de rotas e verbos.


## Arquitetura
Usei a arquitetura MVC, mas como não temos a parte do Front-end na API, usei apenas o "M" (Model) e o "C"(Controller).

A pasta `Data` faz parte do uso do Entity Framework, para fazer o mapeamento fluente. As configurações do mapeamento estão dentro da pasta `Mapping`.

A pasta `ViewModels` armazena um modelo de inserção de dados, já que não faz sentido o uso do Model.Login que exige a entrada de todos os dados, pois no mapeamento foi configurado que a propriedade ID será gerada automaticamente pelo banco de dados.

O `ResulViewModel` foi feito para padronizar as respostas da API, assim facilitando o trabalho do Front-end que saberá o que esperar de retorno. 

---------------------------------------------
Tecnologias usadas:
- ASP.NET 6
- Entity Framework
- SQL Server
- Docker
- Azure Data Studio

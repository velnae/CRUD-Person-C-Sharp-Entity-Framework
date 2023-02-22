# CRUD de Person en C# .NET conectado con Mysql con ADO.NET
## _Dividido en 4 capas_

![Crud Person C# .Net](ss.png "Crud Person")

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Esta repositorio muestra en 4 capas el crud de una tabla person de mysql conectado con ADO.NET.  


## Features
Las capas son:  

- BusinessEntities
- BusinessLogic
- DataAccess✨
- PresentationLayer✨

## Installation

Para que pueda funcionar este repositorio instale:

- Microsoft visual studio 2019
- [ADO.NET Driver for MySQL (Connector/NET)](https://www.mysql.com/products/connector/)
- [MySQL Installer for Visual Studio.](https://dev.mysql.com/downloads/windows/visualstudio/1.2.html)
- Servidor Mysql 8.0.31 (MysqlServer, Xampp, Laragon u otro de su gusto)

Clone este repositorio y abralo directamente desde el IDE indicado mas arriba

```sh
git clone git@github.com:velnae/CRUD-Person-C-Sharp-ADO-MySQL.git
```

Correr el siguiente script sql:  

```sql
create table tperson
(
    idPerson char(36) not null,
    dni char(8) not null,
    firstName varchar(70) not null,
    surName varchar(40) not null,
    birthDate date not null,
    primary key(idPerson)
) engine=innodb;
```

## License

MIT

**Free Software, Hell Yeah!**



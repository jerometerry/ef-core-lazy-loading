# ef-core-lazy-loading

Setup the user and database in Postgres. 

This is just a test, so don't use this on a production system. 

```
CREATE ROLE aspnet_user WITH SUPERUSER LOGIN PASSWORD 'dotnetrocks';
CREATE DATABASE aspnet_user OWNER aspnet_user;
CREATE DATABASE dotnetcore_test OWNER aspnet_user;
```

# auth-jwt
Implementando autenticação e autorização com JWT

## 1. Pacotes utilizados

- Microsoft.AspNetCore.Authentication 2.2.0
- Microsoft.AspNetCore.Authentication.JwtBearer 6.0.10

## 2. Endpoints

- v1/login: Endpoint para requisições POST, retornando o token de autenticação do usuário.
- v1/roles/anonymous: Endpoint para requisições GET sem autenticação.
- v1/roles/authenticated: Endpoint para requisições GET com autenticação.
- v1/roles/employee: Endpoint para requisições GET com autenticação e autorização para as duas Roles existentes na API.
- v1/roles/manager: Endpoint para requisições GET com autenticação e autorização apenas para Role manager.

## 3. Referências

- [ASP.NET 5 e 6 - Autenticação e Autorização com Bearer e Token JWT | por André Baltieri #balta - YouTube](https://www.youtube.com/watch?v=vAUXU0YIWlU)
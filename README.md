# MicroserviceOcelotAuth

- Containts Ocelot which represented as API gateway with integrated Authentication based on JWT tokens
- Contains simple REST microservice Customer which retreives sample data
- Contains simple REST microservice Product which retreives sample data

How it works :

1. Running all projects locally
2. Retreiving JWT token by calling endpoint https://localhost:7086/authentication
3. Sending request on API gateway https://localhost:7086/apigateway/Customer or https://localhost:7086/apigateway/Product with JWT token in headers and getting list of products/customers
4. Sending request without token and see that we are getting 401 Unauthorised

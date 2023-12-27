
# Building a Mini E-Commerce with Onion Architecture Using Angular


Onion Architecture is a design approach for software development, suggesting the division of software projects into layers, where each layer has a specific responsibility. This approach aims to create an internal structure by inverting the dependencies of the software. To implement Onion Architecture using Angular for building a mini e-commerce application, you can follow the steps below:

Create Project Structure:

Create a folder within the src directory to hold main application files and code.
Inside src/app, organize Angular components and services.
Define Layers:

Core Layer: This layer contains entities, interfaces, and shared utilities. Create a folder like core within src/app to house these files.
Infrastructure Layer: Manage external concerns such as data access and third-party integrations. Create a folder like infrastructure for services and data-related files.
Application Layer: Implement application-specific logic. Create a folder like application for services that coordinate actions.
Presentation Layer: Build user interfaces using Angular components. Organize components and views within a folder like presentation.
Establish Dependencies:

Ensure that dependencies flow inward, with inner layers unaware of outer layers.
For example, the core layer should not depend on the infrastructure layer.
Implement Business Logic:

Write services in the application layer to handle business logic and orchestrate actions.
Keep the services in the application layer lightweight, relying on the core layer for entities and interfaces.
User Interface Development:

Leverage Angular components to create the user interface in the presentation layer.
Use Angular services in the application layer to connect the user interface to the application logic.

## Renk Referansı

| Renk             | Hex                                                                |
|![#0a192f](https://via.placeholder.com/10/0a192f?text=+) ##00b48a |
|| ![#f8f8f8](https://via.placeholder.com/10/f8f8f8?text=+) ##00b48a |
|| ![#00b48a](https://via.placeholder.com/10/00b48a?text=+) ##00b48a |
|| ![#00d1a0](https://via.placeholder.com/10/00b48a?text=+) ##00b48a | 


  
## Ortam Değişkenleri

`API_KEY`

`ANOTHER_API_KEY`

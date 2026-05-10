# Assignment 12 – Layered Architecture

```mermaid
flowchart TB

    UI[Swagger UI / Web Layer]

    API[API Controllers]

    APP[Application Layer Services]

    DOMAIN[Domain Layer]

    INFRA[Infrastructure Layer]

    DATA[In-Memory Data Storage]

    UI --> API
    API --> APP
    APP --> DOMAIN
    DOMAIN --> INFRA
    INFRA --> DATA
```
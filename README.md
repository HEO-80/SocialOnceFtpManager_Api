<div align="center">

# 📁 SocialOnce FTP Manager — Backend API

<img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"/>
<img src="https://img.shields.io/badge/Clean_Architecture-000000?style=for-the-badge&logo=archlinux&logoColor=white"/>
<img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white"/>
<img src="https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white"/>

**🌍 [English](#-english-version) · 🇪🇸 [Español](#-versión-en-español)**

</div>

---

## 🇬🇧 English Version

> **📌 Project Note:** This repository contains the **Backend layer (REST API)** of a real project developed during my professional internship at **SOCIAL11** (Zaragoza, Spain). Published for demonstrative purposes as part of my professional portfolio. The Frontend was developed in Angular by another team member.

### 📝 Description

**SocialOnce FTP Manager** is an internal web-based file management tool designed to optimize company workflows. It allows secure transfer and management of heavy files, and integrates a **real-time communication system (chat)** for internal users.

This repository covers exclusively the **server-side logic**, structured under **Clean Architecture** principles to ensure scalability, maintainability, and low coupling between layers.

---

### ✨ Key Features

- 📂 **Advanced File Management** — Upload, download, and administration of heavy files through a secure protocol.
- 💬 **Real-Time Communication** — Backend support for an internal chat module.
- 🏛️ **Scalable Architecture** — Strict separation of concerns: Domain, Application, Infrastructure, and API layers.
- 🐳 **Container-Ready** — Baseline configuration for Docker deployment.

---

### 🛠️ Tech Stack

| Area | Technology |
|---|---|
| Language | C# / .NET |
| Architecture | Clean Architecture (Domain-Driven Design) |
| Frontend Client | Angular SPA |
| Testing | Unit & Integration Tests |
| Deployment | Docker |

---

### 🏗️ Project Structure
```
SocialOnceFtpManager_Api/
├── src/
│   ├── Domain/           # Core business entities and contracts (interfaces)
│   ├── Application/      # Use cases, commands and queries (CQRS)
│   ├── Infrastructure/   # Data access, external services and repositories
│   └── Api/              # REST API controllers exposing endpoints
└── tests/                # Test projects ensuring software quality
```

---

### 🚀 Local Setup

#### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) *(e.g. 6.0 / 8.0)*
- Database engine *(e.g. SQL Server, PostgreSQL)*
- [Docker](https://www.docker.com/) *(optional)*

#### Installation Steps

**1. Clone the repository**
```bash
git clone https://github.com/HEO-80/SocialOnceFtpManager_Api.git
```

**2. Navigate to the API directory**
```bash
cd SocialOnceFtpManager_Api/src/Api
```

**3. Restore dependencies**
```bash
dotnet restore
```

**4. Update the database**
```bash
dotnet ef database update
```

**5. Run the project**
```bash
dotnet run
```

---

### 🧑‍💻 Author

**Héctor Oviedo** — Backend Developer

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/YOUR-LINKEDIN)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/HEO-80)

---
---

## 🇪🇸 Versión en Español

> **📌 Nota sobre el proyecto:** Este repositorio contiene la **capa Backend (API REST)** de un proyecto real desarrollado durante mis prácticas profesionales en **SOCIAL11** (Zaragoza, España). Publicado con fines demostrativos como parte de mi portfolio profesional. El Frontend fue desarrollado en Angular por otro miembro del equipo.

### 📝 Descripción

**SocialOnce FTP Manager** es una herramienta interna de gestión de archivos web, diseñada para optimizar los flujos de trabajo de la empresa. Permite la transferencia segura y gestión de archivos pesados, e integra un **sistema de comunicación en tiempo real (chat)** para usuarios internos.

Este repositorio abarca exclusivamente la **lógica de servidor**, estructurada bajo los principios de **Clean Architecture** para garantizar escalabilidad, mantenibilidad y bajo acoplamiento entre capas.

---

### ✨ Características Principales

- 📂 **Gestión Avanzada de Archivos** — Subida, descarga y administración de archivos pesados mediante protocolo seguro.
- 💬 **Comunicación en Tiempo Real** — Soporte backend para un módulo de chat interno.
- 🏛️ **Arquitectura Escalable** — Separación estricta de responsabilidades: Domain, Application, Infrastructure y API.
- 🐳 **Preparado para Contenedores** — Configuración base para despliegue con Docker.

---

### 🛠️ Stack Tecnológico

| Área | Tecnología |
|---|---|
| Lenguaje | C# / .NET |
| Arquitectura | Clean Architecture (Domain-Driven Design) |
| Cliente Frontend | Angular SPA |
| Testing | Pruebas Unitarias e Integración |
| Despliegue | Docker |

---

### 🏗️ Estructura del Proyecto
```
SocialOnceFtpManager_Api/
├── src/
│   ├── Domain/           # Entidades del negocio y contratos (interfaces)
│   ├── Application/      # Casos de uso, comandos y consultas (CQRS)
│   ├── Infrastructure/   # Acceso a datos, servicios externos y repositorios
│   └── Api/              # Controladores REST que exponen los endpoints
└── tests/                # Proyectos de pruebas de calidad
```

---

### 🚀 Configuración Local

#### Prerrequisitos

- [.NET SDK](https://dotnet.microsoft.com/download) *(ej. 6.0 / 8.0)*
- Motor de base de datos *(ej. SQL Server, PostgreSQL)*
- [Docker](https://www.docker.com/) *(opcional)*

#### Pasos de Instalación

**1. Clona el repositorio**
```bash
git clone https://github.com/HEO-80/SocialOnceFtpManager_Api.git
```

**2. Navega al directorio de la API**
```bash
cd SocialOnceFtpManager_Api/src/Api
```

**3. Restaura las dependencias**
```bash
dotnet restore
```

**4. Actualiza la base de datos**
```bash
dotnet ef database update
```

**5. Ejecuta el proyecto**
```bash
dotnet run
```

---

### 🧑‍💻 Autor

**Héctor Oviedo** — Backend Developer

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/YOUR-LINKEDIN)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/HEO-80)

---

<div align="center">
  <sub>Desarrollado con ❤️ durante las prácticas en <strong>SOCIAL11</strong> · Zaragoza, España</sub>
</div>

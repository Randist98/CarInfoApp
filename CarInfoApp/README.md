# Car Info App

A web application that allows users to select the **car make** and **manufacture year**, and view available vehicle types and models for the selected criteria.  
The application uses the **NHTSA Vehicle API** to fetch the data and is built with **ASP.NET Core MVC**. It is also **Dockerized** for easy deployment.

---

## Features
- Select car make and year.
- View available vehicle types and models.
- Built with **ASP.NET Core MVC**.
- Dockerized for easy deployment.

---

## Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (for local development without Docker)
- [Docker Desktop](https://www.docker.com/get-started) (to run in a container)
- (Optional) Visual Studio 2022 or VS Code

---

## Project Structure
CarInfoApp/
│-- Controllers/
│-- Models/
│-- Services/
│-- Views/
│-- wwwroot/
│-- Dockerfile
│-- .dockerignore
│-- README.md


---

## Getting Started

### Run Locally (Without Docker)
```bash
# 1) Clone the repository
git clone https://github.com/Randist98/CarInfoApp.git
cd CarInfoApp

# 2) Restore and run the project
dotnet restore
dotnet run --project CarInfoApp/CarInfoApp.csproj

Open your browser at:

HTTP: http://localhost:`PORT`

HTTPS: https://localhost:`PORT`
(The ports may vary depending on the output from dotnet run.)


---


### Run with Docker
```bash
# 1) Build the Docker image
docker build -t carinfoapp .

# 2) Run the Docker container
docker run -d -p 8080:8080 carinfoapp

Open your browser at:
http://localhost:8080


---


### Notes
Ensure Docker Desktop is running before building and running the container.

Replace <PORT> with the actual port number if different from defaults.

The project is set up for easy containerization and local development.

---

### License
This project is licensed under the MIT License.
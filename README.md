# Appointment Management API

## Overview
This project is a basic appointment management API for a healthcare clinic. It allows authorized users to register, log in, and manage appointments.

### Key Features:
- **User Authentication**: JWT-based authentication for secure access.
- **Appointment Management**: Create, retrieve, update, and delete appointments.
- **Entity Framework Core**: Database management with MSSQL.
- **Dockerized Deployment**: Seamless containerization for easy deployment.

---

## Prerequisites

1. Install **.NET 7.0 SDK** from [dotnet.microsoft.com](https://dotnet.microsoft.com/).
2. Install **Docker Desktop** for containerization.
3. Install **SQL Server Management Studio (SSMS)** or any other SQL client to manage MSSQL database.

---

## Installation and Setup

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-repository/appointment-management-api.git
   cd appointment-management-api
   ```

2. **Update Environment Variables:**
   - Update `appsettings.json` with your `Jwt` settings (Issuer, Audience, SecretKey).
   - Set the database connection string in `appsettings.json` under `DefaultConnection`.

3. **Build and Run using Docker:**
   ```bash
   docker-compose up --build
   ```

   This will:
   - Set up the web API at `http://localhost:5000`
   - Start the MSSQL server on `localhost:1433`

4. **Apply Database Migrations:**
   Open a terminal in the running web container:
   ```bash
   docker exec -it <container_name> bash
   dotnet ef database update
   ```

---

## API Endpoints

### **Authentication Endpoints**

1. **Register**
   - **Endpoint**: `POST /api/auth/register`
   - **Body**:
     ```json
     {
       "username": "example",
       "password": "password123"
     }
     ```

2. **Login**
   - **Endpoint**: `POST /api/auth/login`
   - **Body**:
     ```json
     {
       "username": "example",
       "password": "password123"
     }
     ```
   - **Response**:
     ```json
     {
       "token": "<JWT Token>"
     }
     ```

### **Appointment Endpoints**

All endpoints require the `Authorization: Bearer <token>` header.

1. **Create Appointment**
   - **Endpoint**: `POST /api/appointments`
   - **Body**:
     ```json
     {
       "patientName": "John Doe",
       "patientContact": "1234567890",
       "appointmentDateTime": "2025-01-20T10:00:00",
       "doctorId": 1
     }
     ```

2. **Get All Appointments**
   - **Endpoint**: `GET /api/appointments`

3. **Get Appointment by ID**
   - **Endpoint**: `GET /api/appointments/{id}`

4. **Update Appointment**
   - **Endpoint**: `PUT /api/appointments/{id}`
   - **Body**:
     ```json
     {
       "appointmentDateTime": "2025-01-22T14:00:00",
       "doctorId": 2
     }
     ```

5. **Delete Appointment**
   - **Endpoint**: `DELETE /api/appointments/{id}`

---

## Testing

1. Use **Postman** or similar tools to test the API.
2. For automated testing, integrate **NUnit** or **XUnit** with the project.

---

## Folder Structure

```
AppointmentManagementApi/
├── Controllers/
│   ├── AuthController.cs
│   ├── AppointmentsController.cs
├── Models/
│   ├── User.cs
│   ├── Doctor.cs
│   ├── Appointment.cs
├── Data/
│   ├── AppDbContext.cs
├── Properties/
│   ├── launchSettings.json
├── appsettings.json
├── Dockerfile
├── docker-compose.yml
├── AppointmentManagementApi.csproj
├── Program.cs
```

---

## Additional Notes

- Ensure your database password is strong and adheres to best practices.
- Replace `YourSecretKey` with a secure randomly generated string.
- Use `dotnet ef` CLI for managing migrations.

For further queries, feel free to contact [saifulrubd@gmail.com].


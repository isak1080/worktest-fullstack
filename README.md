# TrainingApp Work Test Starter

This is a starter project for the full-stack developer test.

## Backend (ASP.NET Core Minimal API)

### Run Instructions

```bash
cd TrainingApp.Api
dotnet run
```

Implements basic structure for:
- Athletes
- Exercises
- Groups

Use the in-memory database and add CRUD endpoints in `Program.cs`.

---

## Frontend (React)

You can create the frontend in a separate folder named `/frontend` using Vite or Create React App.

Example:

```bash
npm create vite@latest frontend -- --template react
cd frontend
npm install
npm run dev
```

Connect the frontend to the backend API running at `http://localhost:5000`.

# 1080Motion - Training App Work Test

This repository contains the starting code for a timeboxed work test for a full-stack developer position.

## Objective

Build a full-stack training management application using ASP.NET Core (backend) and React (frontend). The app should allow users to manage athletes, exercises, and training groups.

## Task Overview

Below is a list of tasks to implement. Focus on completing as much as possible within the time limit, but
if you get stuck on something just move on to the next requirement instead.

If you skip something, be prepared to discuss during the interview how it could have been solved

### Time Limit

Estimated time: **4-5 hours**, but you may spend as much or as little time as you see fit.

### Backend Requirements (ASP.NET Core)

- Implement CRUD (Create, Read, Update, Delete) endpoints for:
  - **Athletes**: Manage athlete profiles.
  - **Exercises**: Manage exercise definitions.
  - **Groups**: Manage training groups.
- Use Entity Framework Core with the provided in-memory SQLite database. 
- Return appropriate HTTP status codes and handle errors gracefully.
- Add basic validation for input data.

### Frontend Requirements (React)

- Initialize a TypeScript React project using Vite:
  - `pnpm create vite frontend --template react-ts`
- Use TypeScript throughout the project.
- Build a user interface to interact with all backend endpoints.
- Implement views for:
  - Listing all athletes, exercises, and groups.
  - Creating new athletes, exercises, and groups.
  - Editing existing records.
  - Deleting records.
- Provide clear feedback for user actions (success/error messages).
- Ensure the UI is responsive and user-friendly.
- You may use any framework/library (or none). Recommended libraries:
  - [TailwindCSS](https://tailwindcss.com/) – for styling
  - [shadcn](https://ui.shadcn.com/) – for UI components
  - [TanStack Router](https://tanstack.com/router) – for routing
  - [TanStack Query](https://tanstack.com/Query) – for data fetching

### Stretch Goals

- Assign athletes to groups.
- Add search or filtering features.
- Implement loading states and error handling in the UI.
- Write unit and/or integration tests for the backend.

## Deliverables

Submit your source code as a public repository or zip file.

Include a short README.md covering:
- Code structure and design choices. How will the application scale?
- Time spent vs. expected, and why.
- What you would do differently with more time.
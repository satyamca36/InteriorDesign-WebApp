# Interior Design Web App

A .NET 8 ASP.NET Core MVC project for an interior design business with:
- Separate Admin and User access
- Login and registration with secure ASP.NET Core Identity password hashing
- Project portfolio pages and management
- Admin dashboard and user dashboard
- JSON APIs for projects
- Interior-design themed UI

## Default Admin Login
- Email: admin@interiorhome.com
- Password: Admin@123

## Run locally
1. Open the solution folder in terminal
2. Run:
   ```bash
   dotnet restore
   dotnet run
   ```
3. Open the site in your browser at:
   ```text
   https://localhost:5001
   ```

## Notes
- Passwords are stored using ASP.NET Core Identity's built-in PBKDF2 hashing, which is secure and industry standard.
- The database is created automatically with SQLite to keep setup simple.
- The app uses seeded demo data for projects, services, and testimonials.

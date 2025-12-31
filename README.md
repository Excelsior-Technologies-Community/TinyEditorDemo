# TinyEditorDemo – TinyMCE HTML Editor

---

## 🚀 Features
- Rich text editor using TinyMCE
- Save HTML content to SQL Server
- Render saved HTML safely
- ASP.NET Core MVC + EF Core

---

## 🧱 Tech Stack
- ASP.NET Core MVC (.NET 7/8)
- Entity Framework Core
- SQL Server
- TinyMCE Cloud

---

## 📁 Key Files
Models/Article.cs
Data/AppDbContext.cs
Controllers/ArticleController.cs
Views/Article/Create.cshtml
Views/Article/List.cshtml

---

## ⚙️ Setup Steps

### 1️⃣ Install Packages
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

2️⃣ Run Migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update

📝 TinyMCE Setup
Create a TinyMCE account
Get an API key
Replace YOUR_API_KEY in the script URL

▶️ Run Project
bash
Copy code
dotnet run
Open:

/Article/Create

```
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/aaf394bf-3f5b-4d07-9393-6b3525f704d8" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/18ad97ad-7a2b-4342-a71d-df8ce6042588" />





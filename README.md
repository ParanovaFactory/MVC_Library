# MVC Library Project

## 📄 Description

This project is a **Library Management System** developed using **ASP.NET MVC** and **SQL Server**. It includes features such as book borrowing, member management, staff management, and statistics. The frontend is based on a ready-made template, with both admin and user panels implemented.

## 🛠️ Technologies Used

- **Backend:** ASP.NET MVC
- **Database:** SQL Server
- **Frontend:** Ready-made template (HTML, CSS, JavaScript)
- **Admin Panel:** Full CRUD operations for managing books, members, and staff
- **User Panel:** Book search, borrowing functionality, and statistics display

## 🗂️ Project Structure

<pre>
/MVC_Library
│
├── /Controllers            <!-- MVC Controllers -->
│   ├── HomeController.cs
│   ├── MemberController.cs
│   ├── BookController.cs
│   └── AdminController.cs
│
├── /Models                <!-- Data Models -->
│   ├── Book.cs
│   ├── Member.cs
│   └── Staff.cs
│
├── /Views                 <!-- MVC Views (HTML templates) -->
│   ├── /Home
│   ├── /Member
│   ├── /Book
│   └── /Admin
│
├── /Scripts               <!-- JavaScript and custom scripts -->
│   └── /jquery.js
│
├── /Content               <!-- Stylesheets, Images, Fonts -->
│   ├── /css
│   ├── /images
│   └── /fonts
│
├── /App_Data              <!-- Database connection and migrations -->
│   └── /Database.mdf
│
└── /Properties            <!-- Project settings -->
    └── AssemblyInfo.cs
</pre>

## 📚 Features

- **Book Borrowing:** Allows users to borrow books and track due dates.
- **Member Management:** Admins can manage members, including registration and details.
- **Staff Management:** Admins can manage staff, including permissions and roles.
- **Statistics:** Display statistics for book availability and borrowings.
- **Ready-to-use Template:** The frontend uses a pre-made template for a seamless user interface.

## 👤 Author

**Sadık Berkay Karaduman**  
📧 [karadumansadikberkay@gmail.com](mailto:karadumansadikberkay@gmail.com)  
🔗 [GitHub – ParanovaFactory](https://github.com/ParanovaFactory)

---

## 📄 License

MIT License — Feel free to use, modify, and contribute.

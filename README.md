# Job Board Application

A professional ASP.NET Core MVC web application that simulates a company careers page, allowing users to browse job openings, apply for active positions, and check their application status.

## Project Overview

This project was developed as a midterm practical assignment and designed to replicate the core functionality of a real-world job board system. The application presents available job postings, automatically marks expired positions as closed based on their deadline, and allows applicants to submit their information for open roles.

The system focuses on demonstrating strong foundational web development skills using ASP.NET Core MVC, including routing, controller logic, model design, Razor views, partial views, and form validation. Rather than relying on a database, the project uses a Static Repository pattern to manage application data in memory, keeping the project lightweight while emphasizing application structure and logic.

## Key Features

- Browse a list of current job openings on the homepage
- Apply only to positions that are still open
- Automatically display **Position Closed** for expired job postings
- Submit applicant information through a validated application form
- View the selected job title on the application page
- Search submitted applications by email address
- Render job rows using a reusable partial view
- Store job postings and applications in memory using a static repository

## Technologies Used

- **C#**
- **ASP.NET Core MVC**
- **Razor Views**
- **Bootstrap**
- **Static Repository Pattern**

## Architecture and Design

The application follows the MVC architectural pattern:

- **Models** define the structure for applicants, job postings, and repository logic
- **Controllers** handle navigation, data flow, and form processing
- **Views** present the user interface using Razor syntax
- **Partial Views** improve reusability and keep UI code organized

This design makes the application easy to follow, maintain, and extend.

## Project Structure

```text
Job_BoardApplication/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── Applicant.cs
│   ├── JobPosting.cs
│   └── Repository.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── ApplyForm.cshtml
│   │   └── CheckStatus.cshtml
│   └── Shared/
│       └── _JobRow.cshtml
├── Program.cs
└── README.md
```
## How the Application Works

When the application loads, users are presented with a list of available job postings. Each posting includes the job title, department, closing date, and an action column. If the current date is before the closing date, users can click **Apply Now**. If the deadline has passed, the application displays **Position Closed** instead.

When a user selects an open role, they are taken to an application form where they can enter their name and email. Form validation ensures required fields are completed before the application is submitted. Once submitted successfully, the applicant is stored in the corresponding job posting’s application list.

The **Check Status** page allows users to enter their email address and search for the positions they have applied to.

## Learning Outcomes Demonstrated

This project demonstrates practical experience in:

- Building an ASP.NET Core MVC application from scratch
- Structuring a project using models, views, and controllers
- Implementing business logic with deadline-based conditions
- Handling form submissions and model validation
- Creating reusable UI components with partial views
- Managing temporary in-memory data without a database
- Designing a clean and user-friendly workflow

## Limitations

This project was intentionally built without a database or Entity Framework, so application data is stored only during runtime and will reset when the application stops. This was done to align with the project requirements and focus on MVC fundamentals.

## Future Improvements

Potential future enhancements could include:

- Adding persistent database storage with SQL Server or Entity Framework
- Implementing user authentication for applicants and administrators
- Adding resume upload functionality
- Creating an admin dashboard for posting and managing jobs
- Improving search and filtering options for job listings

## Author

**Daniel Guillaumont**

## Notes

This project was created as part of an ASP.NET Core MVC midterm practical and is intended to showcase core web development skills, clean project organization, and professional application design.

using BlazorAppMyCV.Models;

namespace BlazorAppMyCV.Repositories
{
    public class SkillRepository
    {
        public static List<SkillsModel> GetSkillCards() => new List<SkillsModel>
        {
        new SkillsModel
        {
            Id = 1,
            Title = "C# Developer",
            Description = "Strongly-typed, modern OOP language for building robust .NET applications.",
            IconSrc = "/png/c-sharp-c-seeklogo.png",
            IconAlt = "C# Icon"
        },
        new SkillsModel
        {
            Id = 2,
            Title = "TypeScript Developer",
            Description = "Typed superset of JavaScript, supporting frameworks like React and Angular for scalable web apps.",
            IconSrc = "./png/ts.jpg",
            IconAlt = "TypeScript Icon"
        },
        new SkillsModel
        {
            Id = 3,
            Title = "ASP.NET Core",
            Description = "Cross-platform framework for building modern, cloud-enabled web applications.",
            IconSrc = "./png/ASP.NET-Core.png",
            IconAlt = "ASP.NET Core Icon"
        },
        new SkillsModel
        {
            Id = 4,
            Title = "Blazor",
            Description = "Microsoft’s cross-platform UI framework for building interactive web UIs with C#.",
            IconSrc = "./png/Blazor.png",
            IconAlt = "Blazor Icon"
        },
        new SkillsModel
        {
            Id = 5,
            Title = "Entity Framework Core",
            Description = "Lightweight, extensible ORM for .NET, enabling efficient data access with LINQ and strong typing.",
            IconSrc = "./png/EFCore.png",
            IconAlt = "Entity Framework Core Icon"
        },
        new SkillsModel
        {
            Id = 6,
            Title = "MS SQL Server",
            Description = "Reliable, high-performance relational database system optimized for scalable .NET applications.",
            IconSrc = "./png/MSSQL.png",
            IconAlt = "MS SQL Server Icon"
        },
        new SkillsModel
        {
            Id = 7,
            Title = "Dapper (ORM)",
            Description = "High-performance micro-ORM for .NET offering fast and simple data access with raw SQL and minimal overhead.",
            IconSrc = "./png/Dapper.jpg",
            IconAlt = "Dapper ORM Icon"
        },
        new SkillsModel
        {
            Id = 8,
            Title = "Microsoft Azure",
            Description = "Basic knowledge of Microsoft Azure services including App Service, SQL Database, DevOps, and Portal for cloud deployment and management of .NET apps.",
            IconSrc = "./png/azure.png",
            IconAlt = "Microsoft Azure Icon"
        },
        new SkillsModel
        {
            Id = 9,
            Title = "Angular 2 +",
            Description = "Basic knowledge of the framework, experience in combining the framework with Web API .NET.",
            IconSrc = "./png/angular.png",
            IconAlt = "Angular Icon"
        },
        new SkillsModel
        {
            Id = 10,
            Title = "React",
            Description = "Basic knowledge of the framework, experience in combining the framework with Web API .NET.",
            IconSrc = "./png/react.png",
            IconAlt = "React Icon"
        },
        new SkillsModel
        {
            Id = 10,
            Title = "Docker",
            Description = "Basic knowledge of creating Docker images and configuring containers, including deploying projects with a persistent database.",
            IconSrc = "./png/docker.png",
            IconAlt = "Docker Icon"
        }
        };
    }
}

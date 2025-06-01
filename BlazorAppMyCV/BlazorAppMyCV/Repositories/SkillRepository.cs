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
                Description = "Strongly typed modern OOP language for .NET development.",
                IconSrc = "/png/c-sharp-c-seeklogo.png",
                IconAlt = "C# Icon"
            },
            new SkillsModel
            {
                Id = 2,               
                Title = "TypeScript Developer",
                Description = "Modern JavaScript with types, including frameworks like React and Angular.",
                IconSrc = "./png/ts.jpg",
                IconAlt = "TypeScript Icon"
            },
            new SkillsModel
            {
                Id = 3,                
                Title = "ASP.NET Cor",
                Description = "Cross-platform framework for web apps.",
                IconSrc = "./png/ASP.NET-Core.png",
                IconAlt = "ASP.NET Cor Icon"
            },
             new SkillsModel
            {
                Id = 3,               
                Title = "Blazor",
                Description = "Cross-platform UI framework by Microsoft.",
                IconSrc = "./png/Blazor.png",
                IconAlt = "Blazor Icon"
            }
        };
    }
}

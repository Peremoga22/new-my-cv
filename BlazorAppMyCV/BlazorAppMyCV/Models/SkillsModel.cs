namespace BlazorAppMyCV.Models
{
    public class SkillsModel
    {
        public int Id { get; set; }      
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string IconSrc   { get; set; } = string.Empty;
        public string IconAlt   { get; set; } = string.Empty;
    }
}

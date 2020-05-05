using System;


namespace R5T.Palembang.Default
{
    public class StaticValueProjectNameProvider : IProjectNameProvider
    {
        public static string ProjectName { get; set; }


        public string GetProjectName()
        {
            return StaticValueProjectNameProvider.ProjectName;
        }
    }
}

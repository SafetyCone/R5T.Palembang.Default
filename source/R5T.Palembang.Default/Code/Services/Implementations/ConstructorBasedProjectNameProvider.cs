using System;


namespace R5T.Palembang.Default
{
    public class ConstructorBasedProjectNameProvider : IProjectNameProvider
    {
        private string ProjectName { get; }


        public ConstructorBasedProjectNameProvider(string projectName)
        {
            this.ProjectName = projectName;
        }

        public string GetProjectName()
        {
            return this.ProjectName;
        }
    }
}

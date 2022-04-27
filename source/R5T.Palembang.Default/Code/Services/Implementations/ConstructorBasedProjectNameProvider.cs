using System;

using R5T.T0064;


namespace R5T.Palembang.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedProjectNameProvider : IProjectNameProvider, IServiceImplementation
    {
        private string ProjectName { get; }


        public ConstructorBasedProjectNameProvider(
            [NotServiceComponent] string projectName)
        {
            this.ProjectName = projectName;
        }

        public string GetProjectName()
        {
            return this.ProjectName;
        }
    }
}

using System;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class StaticValueProjectNameProvider : IProjectNameProvider,IServiceImplementation
    {
        public static string ProjectName { get; set; }


        public string GetProjectName()
        {
            return StaticValueProjectNameProvider.ProjectName;
        }
    }
}

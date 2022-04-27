using System;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class StaticValueBuildConfigurationNameProvider : IBuildConfigurationNameProvider,IServiceImplementation
    {
        public static string BuildConfigurationName { get; set; }


        public string GetBuildConfigurationName()
        {
            return StaticValueBuildConfigurationNameProvider.BuildConfigurationName;
        }
    }
}

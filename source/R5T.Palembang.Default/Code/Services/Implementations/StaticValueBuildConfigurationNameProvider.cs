using System;


namespace R5T.Palembang.Default
{
    public class StaticValueBuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        public static string BuildConfigurationName { get; set; }


        public string GetBuildConfigurationName()
        {
            return StaticValueBuildConfigurationNameProvider.BuildConfigurationName;
        }
    }
}

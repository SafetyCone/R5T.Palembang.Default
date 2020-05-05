using System;


namespace R5T.Palembang.Default
{
    public class ConstructorBasedBuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        private string BuildConfigurationName { get; }


        public ConstructorBasedBuildConfigurationNameProvider(string buildConfigurationName)
        {
            this.BuildConfigurationName = buildConfigurationName;
        }

        public string GetBuildConfigurationName()
        {
            return this.BuildConfigurationName;
        }
    }
}

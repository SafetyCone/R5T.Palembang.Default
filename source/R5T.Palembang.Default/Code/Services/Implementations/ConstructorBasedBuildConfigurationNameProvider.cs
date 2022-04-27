using System;

using R5T.T0064;


namespace R5T.Palembang.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedBuildConfigurationNameProvider : IBuildConfigurationNameProvider , IServiceImplementation
    {
        private string BuildConfigurationName { get; }


        public ConstructorBasedBuildConfigurationNameProvider(
            [NotServiceComponent] string buildConfigurationName)
        {
            this.BuildConfigurationName = buildConfigurationName;
        }

        public string GetBuildConfigurationName()
        {
            return this.BuildConfigurationName;
        }
    }
}

using System;

using R5T.Angleterria;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class ReleaseBuildConfigurationNameProvider : IBuildConfigurationNameProvider,IServiceImplementation
    {
        public string GetBuildConfigurationName()
        {
            return BuildConfigurationName.Release;
        }
    }
}

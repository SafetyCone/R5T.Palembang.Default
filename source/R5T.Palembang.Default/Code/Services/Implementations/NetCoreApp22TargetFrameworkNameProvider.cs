using System;

using R5T.Angleterria;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class NetCoreApp22TargetFrameworkNameProvider : ITargetFrameworkNameProvider,IServiceImplementation
    {
        public string GetTargetFrameworkName()
        {
            return TargetFrameworkName.NetCoreApp2_2;
        }
    }
}

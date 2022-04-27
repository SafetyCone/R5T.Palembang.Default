using System;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class StaticValueTargetFrameworkNameProvider : ITargetFrameworkNameProvider,IServiceImplementation
    {
        public static string TargetFrameworkName { get; set; }


        public string GetTargetFrameworkName()
        {
            return StaticValueTargetFrameworkNameProvider.TargetFrameworkName;
        }
    }
}

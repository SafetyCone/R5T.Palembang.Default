using System;

using R5T.T0064;


namespace R5T.Palembang.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedTargetFrameworkNameProvider : ITargetFrameworkNameProvider, IServiceImplementation
    {
        private string TargetFrameworkName { get; set; }


        public ConstructorBasedTargetFrameworkNameProvider(
            [NotServiceComponent] string targetFrameworkName)
        {
            this.TargetFrameworkName = targetFrameworkName;
        }

        public string GetTargetFrameworkName()
        {
            return this.TargetFrameworkName;
        }
    }
}

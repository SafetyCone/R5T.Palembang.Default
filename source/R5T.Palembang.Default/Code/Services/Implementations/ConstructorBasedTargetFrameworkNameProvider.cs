using System;


namespace R5T.Palembang.Default
{
    public class ConstructorBasedTargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        private string TargetFrameworkName { get; set; }


        public ConstructorBasedTargetFrameworkNameProvider(string targetFrameworkName)
        {
            this.TargetFrameworkName = targetFrameworkName;
        }

        public string GetTargetFrameworkName()
        {
            return this.TargetFrameworkName;
        }
    }
}

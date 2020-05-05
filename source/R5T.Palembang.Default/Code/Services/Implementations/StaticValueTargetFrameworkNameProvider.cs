using System;


namespace R5T.Palembang.Default
{
    public class StaticValueTargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public static string TargetFrameworkName { get; set; }


        public string GetTargetFrameworkName()
        {
            return StaticValueTargetFrameworkNameProvider.TargetFrameworkName;
        }
    }
}

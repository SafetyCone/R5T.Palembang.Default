using System;using R5T.T0064;


namespace R5T.Palembang.Default
{[ServiceImplementationMarker]
    public class StaticValueSolutionNameProvider : ISolutionNameProvider,IServiceImplementation
    {
        public static string SolutionName { get; set; }


        public string GetSolutionName()
        {
            return StaticValueSolutionNameProvider.SolutionName;
        }
    }
}

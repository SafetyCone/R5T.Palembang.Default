using System;


namespace R5T.Palembang.Default
{
    public class StaticValueSolutionNameProvider : ISolutionNameProvider
    {
        public static string SolutionName { get; set; }


        public string GetSolutionName()
        {
            return StaticValueSolutionNameProvider.SolutionName;
        }
    }
}

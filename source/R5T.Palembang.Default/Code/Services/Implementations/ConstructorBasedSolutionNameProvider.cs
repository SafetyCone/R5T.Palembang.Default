using System;


namespace R5T.Palembang.Default
{
    public class ConstructorBasedSolutionNameProvider : ISolutionNameProvider
    {
        private string SolutionName { get; }


        public ConstructorBasedSolutionNameProvider(string solutionName)
        {
            this.SolutionName = solutionName;
        }

        public string GetSolutionName()
        {
            return this.SolutionName;
        }
    }
}

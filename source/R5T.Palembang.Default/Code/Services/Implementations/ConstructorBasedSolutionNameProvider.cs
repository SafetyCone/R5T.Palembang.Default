using System;

using R5T.T0064;


namespace R5T.Palembang.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedSolutionNameProvider : ISolutionNameProvider, IServiceImplementation
    {
        private string SolutionName { get; }


        public ConstructorBasedSolutionNameProvider(
            [NotServiceComponent] string solutionName)
        {
            this.SolutionName = solutionName;
        }

        public string GetSolutionName()
        {
            return this.SolutionName;
        }
    }
}

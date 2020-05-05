using System;

using R5T.Angleterria;


namespace R5T.Palembang.Default
{
    public class NetStandard20TargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public string GetTargetFrameworkName()
        {
            return TargetFrameworkName.NetStandard2_0;
        }
    }
}

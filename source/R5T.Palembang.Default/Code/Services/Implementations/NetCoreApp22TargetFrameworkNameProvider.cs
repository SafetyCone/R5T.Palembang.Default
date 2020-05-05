using System;

using R5T.Angleterria;


namespace R5T.Palembang.Default
{
    public class NetCoreApp22TargetFrameworkNameProvider : ITargetFrameworkNameProvider
    {
        public string GetTargetFrameworkName()
        {
            return TargetFrameworkName.NetCoreApp2_2;
        }
    }
}

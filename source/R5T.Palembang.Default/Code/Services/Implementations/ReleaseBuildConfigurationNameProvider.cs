﻿using System;

using R5T.Angleterria;


namespace R5T.Palembang.Default
{
    public class ReleaseBuildConfigurationNameProvider : IBuildConfigurationNameProvider
    {
        public string GetBuildConfigurationName()
        {
            return BuildConfigurationName.Release;
        }
    }
}

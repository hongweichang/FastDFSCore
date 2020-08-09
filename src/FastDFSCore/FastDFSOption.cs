﻿using System.Collections.Generic;

namespace FastDFSCore
{
    /// <summary>配置信息
    /// </summary>
    public class FastDFSOption
    {
        public List<ClusterConfiguration> ClusterConfigurations { get; }

        public FastDFSOption()
        {
            ClusterConfigurations = new List<ClusterConfiguration>();
        }

    }
}

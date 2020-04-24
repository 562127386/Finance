﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MicroFeel.Finance
{
    public class FinancialOptions
    {
        public FinancialType FinancialType { get; set; }
        public string FinancialDbConnectionString { get; set; }
    }

    public enum FinancialType
    {
        [FinancialAssemblyName("MicroFeel.KingDee")]
        [FinancialTypeName("MicroFeel.KingDee.Kis.KisContext")]
        KingDeeKis = 0,
        [FinancialAssemblyName("MicroFeel.KingDee")]
        [FinancialTypeName("MicroFeel.KingDee.K3.K3Context")]
        KingDeeK3,
        [FinancialAssemblyName("MicroFeel.Yonyou.Services")]
        [FinancialTypeName("MicroFeel.Yonyou.Services.YongYouService")]
        YongYouU8
    }
}

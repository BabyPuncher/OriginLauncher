﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyPuncher.OriginGameLauncher.ManagedOrigin
{
    public class OfflineOrigin : Origin
    {
        public OfflineOrigin(int gameId) : base(String.Format(@"""/StartOffline"" ""origin://LaunchGame/{0}""", gameId)) { }
    }
}

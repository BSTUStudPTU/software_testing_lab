﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Framework.Tests.Tests tests = new Framework.Tests.Tests();
            tests.FromBakuToMinskTestSearch();
            tests.SearchOnSiteByTextMoscow();
            tests.ChangeToEng();
        }
    }
}

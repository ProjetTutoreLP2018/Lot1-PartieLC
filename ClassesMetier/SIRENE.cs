﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lot1
{
    public class SIRENE
    {
        public int nhits { get; set; }
        public Parameters parameters { get; set; }
        public List<Record> records { get; set; }
        public List<FacetGroup> facet_groups { get; set; }
    }
}

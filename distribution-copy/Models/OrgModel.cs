﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_copy.Models
{
    public class OrgModel
    {
        public int Count { get; set; }
        public List<ProjectDetails> Value { get; set; }
        public orgCounts counts { get; set; }
    }
    public class countGen
    {
        public int Count { get; set; }
    }

  
}
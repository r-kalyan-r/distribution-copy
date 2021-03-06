﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace distribution_copy.Models.AccountsResponse
{
    public class AccountsResponse
    {
        public class Properties
        {
        }
        public class Value
        {
            public string accountId { get; set; }
            public string accountUri { get; set; }
            public string accountName { get; set; }
            public Properties properties { get; set; }
        }

        public class AccountList
        {
            public int count { get; set; }
            public IList<Value> value { get; set; }
        }
    }
}
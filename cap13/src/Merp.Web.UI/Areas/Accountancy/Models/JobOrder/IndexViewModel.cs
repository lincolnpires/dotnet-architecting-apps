﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Merp.Web.UI.Areas.Accountancy.Models.JobOrder
{
    public class IndexViewModel
    {
        public bool CurrentOnly { get; set; }

        public class JobOrder
        {
            public int Id { get; set; }
            public Guid OriginalId { get; set; }
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Number { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}
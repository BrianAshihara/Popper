﻿using popper.domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popper.domain.Entities
{
    public class Local : BaseEntity<int>
    {
        public Local() { }

        public Local(int id, string? localdesc):base(id)
        {
            Localdesc = localdesc;
        }

        public string? Localdesc { get; set; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceImageUrl { get; set; }
    }
}

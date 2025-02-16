﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Entities
{
    internal class Topic
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_DATPHONG
    {
        public int ID { get; set; }
        public string TENPHONG { get; set; }
        public double DONGIA {  get; set; }
        public bool STATUS { get; set; }
        public int IDTANG { get; set; }
        public int IDLOAIPHONG { get; set; }
        public bool DISABLED { get; set; }
        public string TENTANG { get; set; }
        public string TENLOAIPHONG { get; set; }
    }
}

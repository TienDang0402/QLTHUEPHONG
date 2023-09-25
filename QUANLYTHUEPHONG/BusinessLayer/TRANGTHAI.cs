﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TRANGTHAI
    {
        public bool _value { get; set; }
        public string _display { get; set; }
        public TRANGTHAI()
        {
        }
        public TRANGTHAI(bool _val, string _dis)
        {
            this._value = _val;
            this._display = _dis;

        }
        public static List<TRANGTHAI> getList()
        {
            List<TRANGTHAI> lsTrangThai = new List<TRANGTHAI>();
            TRANGTHAI[] collect = new TRANGTHAI[2] {
            new TRANGTHAI(false,"Chưa hoàn tất"),
            new TRANGTHAI(true,"Đã hoàn tất"),
            };
            lsTrangThai.AddRange(collect);
            return lsTrangThai;
        }


    }
}

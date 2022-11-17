using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Luyentap3.Models
{
    public class Sach
    {
        public string masach { get; set; }
        public string tensach { get; set; }
        public int soluong { get; set; }
        public double giatien { get; set; }
        public double tongtien
        {
            get{
                return soluong *giatien;
            }
        }
        public Sach()
        {

        }
        public Sach(string Masach, string Tensach, int Soluong, double Giatien)
        {
            masach = Masach;
            tensach = Tensach;
            soluong = Soluong;
            giatien = Giatien;
        }
    } 
}
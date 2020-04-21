using System;

namespace Application_Programming.Lab3
{
    public class Hang:Fashion
    {
        protected string mausac;
        protected string kichco;

        public void setmausac(string m)
        {
            mausac = m;
        }

        public void setkichco(string k)
        {
            kichco = k;
        }

        public Hang(string s, string m, string k)
        {
            this.mausac = s;
            this.kichco = k;
        }

        public string gethang()
        {
            return "Ten san pham" + sanpham +
                   "Mau sac" + mausac +
                   "Kich co" + kichco 
                ;

        }

        public void kiemtra()
        {
        }
    }
}
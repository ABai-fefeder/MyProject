using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;


namespace 作業_訂單系統
{
    internal class GlobalData
    {
        public static string DbConStr = "";
        public static string Acount = "";       
        public static int Level = 0;

        public static string userName = "";
        public static string userTel = "";
        public static string userAddress = "";
        public static List<ArrayList> ShopCartList = new List<ArrayList>();
    }
}

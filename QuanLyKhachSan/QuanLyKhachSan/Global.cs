using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    internal class Global
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int id)
        {
            GlobalUserId = id;
        }
        public static string Globalrole { get; private set; }
        public static void SetGlobalrole(string role)
        {
            Globalrole = role;
        }
    }
}

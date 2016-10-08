using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lab_2_web_design.Models;

namespace lab_2_web_design.Data
{
    public static class Database
    {
        public static List<User> Users { get; set; }
        static Database()
        {
            Users = new List<User>();
        }
    }
}
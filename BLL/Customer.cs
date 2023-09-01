using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DAL;

namespace BLL
{
    public class Customer
    {


        public int cprno { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string usename { get; set; }
        public string password { get; set; }
    
        private void AddCustomers() 
        {
            string newData = File.CreateText();
           
            

    }



    
}
     
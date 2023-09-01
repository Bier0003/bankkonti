//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAL;


//namespace BLL
//{
//    public class CprNo
//    {
        
//        public void checkCPR() 
//        {
            
//             var cpr = new CprNo();
//            cpr.checkCPR();
//            if (cpr == null)
//            {
//                Console.WriteLine("Fydt op CPR her");
//            }
//            else
//            {
//                string cpr = cpr.Replace('-','' );

//                if (cpr.Length != 10) 
//                {
//                    Console.WriteLine("Forkert antal");
//                }
//                //else {DateValid }
//            }



//            static void DateValid(string cpr) 
//            {
//                string Date = cpr.Substring(0,2); 
//                string Month = cpr.Substring(2,2);
//                string Year = cpr.Substring(4,2);

            
//            }

          

//        }
//    }
//}

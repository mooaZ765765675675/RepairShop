using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepairShop
{
    //تعريف صنف يمثل جهازاً منزلياً 
    public class Appliance
    {
        public int Id { get; set; }//رقم الجهاز
        public string Name { get; set; } = "";// samsung اسم الجهاز، مثل
        public string Type { get; set; } = "";// Washing Machine نوع الجهاز، مثل 
        public decimal RepairCost { get; set; }// decimal تكلفة الصيانة، واستخدمنا  لأنها مناسبة للقيم المالية
    }
}

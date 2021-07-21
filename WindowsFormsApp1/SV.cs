using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SV
    {
        [Key]
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public int ID_Lop { get; set; }
    }
}

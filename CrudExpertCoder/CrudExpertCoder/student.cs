using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudExpertCoder
{
    public class student
    {
        public int studentid { get; set; }
        [StringLength(255)]
        public string fullname { get; set; }
        [StringLength(15)]
        public string birthday { get; set; }
        [StringLength(255)]
        public string mail { get; set; }
        [StringLength(255)]
        public string adress { get; set; }
        [StringLength(255)]
        public string imageurl { get; set; }
        public bool gender { get; set; }
    }
}

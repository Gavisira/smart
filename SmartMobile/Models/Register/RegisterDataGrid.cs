using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMobile.Models.Register
{
    public class RegisterDataGrid
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Document { get; set; }
        public string Status { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}

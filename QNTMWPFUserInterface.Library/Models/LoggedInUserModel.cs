using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QNTMWPFUserInterface.Library.Models
{
    public class LoggedInUserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool IsOnline { get; set; }
    }
}

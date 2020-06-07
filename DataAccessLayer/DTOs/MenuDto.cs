using DataAccessLayer.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class MenuDTO
    {
        public Menu Menu { get; set; }
        public List<Menu> Items { get; set; }
    }
}

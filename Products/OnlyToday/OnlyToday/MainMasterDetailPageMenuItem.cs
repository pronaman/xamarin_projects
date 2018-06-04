using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyToday
{
    public class MainMasterDetailPageMenuItem
    {
        public enum MenuNames
        {
            Home,
            SignIn,
            Setting
        }

        public MainMasterDetailPageMenuItem()
        {
        }
        public MenuNames Id { get; set; }
        public string Title { get; set; }
    }
}
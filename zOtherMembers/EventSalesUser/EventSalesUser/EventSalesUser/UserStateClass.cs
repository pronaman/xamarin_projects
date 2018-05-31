using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.IO;

namespace EventSalesUser
{
    public class UserStateClass
    {
        public string str_json;

        public static UserStateClass MyClass;

        private bool bLogin;
        public bool BLogin { get => bLogin; set => bLogin = value; }

        public void Init()
        {
            if (MyClass == null )
            {
                MyClass = this;
            }

            bLogin = false;

            str_json = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Intf_Indx_Excp
{
    public interface IAccount
    {
        public bool PasswordChecker(string pasword);


        public void ShowInfo();
    }
}

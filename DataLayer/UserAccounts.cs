using System;
using System.Collections.Generic;

namespace DataLayer
{
    public class UserAccounts
    {
        //3 artificial assumed accounts
        //Professor ID TAG
        private List<int> _profTag = new List<int>() { 100, 101, 102, };
        //Professor Username
        private List<string> _profName = new List<string>() { "admin", "user", "default" };
        //Professor Password
        private List<string> _profPass = new List<string>() { "1234", "user", "default" };

        public bool VerifyLogin(int profTag, string ProfName, string ProfPass)
        {
            if (this._profTag.Contains(profTag) &&
             ProfName.Equals(this._profName[profTag - 100]) &&
             ProfPass.Equals(this._profPass[profTag - 100]))
            { return true; }

            else
            { return false; }

        }

    }
}

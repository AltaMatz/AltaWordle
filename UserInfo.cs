using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltaWordle
{
    public class UserInfo
    {
        public string username { get; set; }
        public string password { get; set; }
        public int victories { get; set; }
        public int defeats { get; set; }
        public int firstTry { get; set; }
        public int secondTry { get; set; }
        public int thirdTry { get; set; }
        public int fourthTry { get; set; }
        public int fifthTry { get; set; }
        public int sixthTry { get; set; }
    }
}

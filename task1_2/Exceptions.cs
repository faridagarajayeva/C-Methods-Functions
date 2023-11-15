using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace task1_2
//{


//    class Account
//    {
//        public string PasswordChecker { get; set; }
//        public string ShowInfo { get; set; }
//    }


//    class IncorrectPasswordExeption : Exception
//    {
//        public IncorrectPasswordExeption() { }

//        public IncorrectPasswordExeption(string PasswordChecker)
//            : base(String.Format("Invalid password: {0}", PasswordChecker))
//        {

//        }
//    }
//}


public class IncorrectPasswordExeption : Exception
{
    public IncorrectPasswordExeption() : base() { }
    public IncorrectPasswordExeption(string message) : base(message) { }
    public IncorrectPasswordExeption(string message, Exception innerException) : base(message, innerException) { }
}
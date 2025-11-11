using System;
using System.Collections.Generic;
using System.Text;

namespace Catch
{
    class MyException : Exception
{
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public override string Message
        {
            get
            {
                Message="ikugiuju"
            }
        }



    }
}

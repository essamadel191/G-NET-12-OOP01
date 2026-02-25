using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP01
{
    internal class StudentClass
    {
        public string Name;
        public int Age;
        private string lastName = "Test";

        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string value)
        {
            lastName = value;
        }
    }
}

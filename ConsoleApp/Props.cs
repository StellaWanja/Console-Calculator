using System;
using System.Collections.Generic;  


namespace ConsoleApp
{
    public class Props
    {
        public int Choice {get; set;}
        public int Result { get; set; }
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public List<int> ListHistory = new List<int>();
    }
}
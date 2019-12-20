using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class SymbolTable
    {
        public SymbolTable() { }

        public void Put(string Key, string Value) { }

        public string Get(string Key) { return string.Empty; }

        public void Delete(string Key) { }

        public Boolean Contains(string Key) { return false; }

        public Boolean IsEmpty
        {
            get { return false; }
        }

        public int Size
        {
            get { return 0; }
        }


    }
}

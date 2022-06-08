using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericScale
{
    public class EqualityScale<T>
    {
        //------------------- Fields ---------------------
        private T left;
        private T right;

        //---------------- Constructors ------------------
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        //------------------ Methods ---------------------
        public bool AreEqual()
        {
            bool result = this.left.Equals(this.right);
            return result;
        }
    }
}

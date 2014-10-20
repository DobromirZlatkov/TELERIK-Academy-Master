using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits
{
    public class Bit64Array : IEnumerable<int>
    {
        private int[] bitArray = new int[64];
        private ulong number;

        public Bit64Array(ulong number)
        {
            this.number = number;
            for (int i = 0; i < 64; i++)
            {
                bitArray[i] = (int)(number % 2);
                number /= 2;
            }
        }
       
        public ulong Number
        {
            get { return this.number; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        public override bool Equals(object obj)
        {
            Bit64Array bitArray = obj as Bit64Array;

            if ((object)bitArray == null)
            {
                return false;
            }

            if (Object.Equals(this.number, bitArray.number))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Bit64Array firstNumber,
                                  Bit64Array secondNumber)
        {
            return Bit64Array.Equals(firstNumber, secondNumber);
        }

        public static bool operator !=(Bit64Array firstNumber,
                           Bit64Array secondNumber)
        {
            return !(Bit64Array.Equals(firstNumber, secondNumber));
        }

        public int this[int key]
        {
            get { return this.bitArray[key]; }
            set
            {
                if (value == 1 || value == 0)
                {
                    this.bitArray[key] = value;
                    ChangeNumber();
                }
                else
                {
                    throw new ArgumentException("You can insert only bits 0 and 1.");
                }
            }
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        private void ChangeNumber()
        {
            this.number = 0;
            for (int i = 0; i < 64; i++)
            {
                this.number += (ulong)(this.bitArray[i] << i); 
            }
        }
    }
}
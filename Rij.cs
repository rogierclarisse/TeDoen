using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class Rij<T>
    {
        List<T> list = new List<T>();
        
        public void Toevoegen(T item)
        {
            list.Add(item);
        }

        public T Verwijderen()
        {
            if(list.Count == 0)
            {
                throw new StackOverflowException();
            }
            else
            {
                T even = list[0];
                list.RemoveAt(0);
                return even;
            }
        }

        public T ToonElement()
        {
            int counter = 0;
            if (list.Count == 0)
            {
                throw new StackOverflowException();
            }
            else
            {
                T even = list[counter];
                counter++;
                return even;
            }
        }

        public void Leegmaken()
        {
            list.Clear();
        }

        public override string ToString()
        {
            string legeString = "";
            foreach(T item in list)
            {
                legeString += item;
            }
            return legeString;
        }

        public bool IsEmpty()
        {
            if(list.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void Copy()
        {
            List<T> backupList = new List<T>();
            backupList = list;
        }
    }
}

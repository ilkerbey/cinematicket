using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBilet
{
    public abstract class ListADT
    {
        public Node Head;
        public int size = 0;
        public abstract void InsertFirst(object value);
        public abstract void InsertPos(int position, object value);
        public abstract void DeletePos(int position);
        public abstract object GetElement(int position);

    }
}

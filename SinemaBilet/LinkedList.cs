using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaBilet
{
    public class LinkedList:ListADT
    {





        public override void InsertFirst(object value)
        {
            Node tmphead=new Node{
            
            Data=value
            };

            if(Head==null)
            {

                Head=tmphead;

            }

            else
            {

                tmphead.Next = Head;
                Head = tmphead;

            }

            size++;
        }

        public override void InsertPos(int position, object value)
        {
            Node newNode = Head;
                
            for (int i = 1; i <= 60; i++)
            {
                if(i == position)
                {
                    newNode.Data = value;
                    break;
                }
                newNode = newNode.Next;
            }


        }

        public override void DeletePos(int position)
        {
            Node posNode = Head;
            
            for (int i = 1; i <= 60 ; i++)
            {
                
                if(position==i)
                {
                    posNode.Data = null;
                    break;
                }
                posNode = posNode.Next;


            }
           

        }



        public override object GetElement(int position)
        {
            Node retNode = null;

            Node tmpnode = Head;
            int count = 1;


            while (tmpnode != null)
            {
                if (count == position)
                {
                    retNode = tmpnode;
                    break;
                }

                tmpnode = tmpnode.Next;
                count++;

            }

            return retNode;
        }


    }
}

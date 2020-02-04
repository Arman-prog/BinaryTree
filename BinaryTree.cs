using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree<T> where T : Car
    {
        private BinaryTree<T> Left { get; set; }
        private BinaryTree<T> Right { get; set; }
        private BinaryTree<T> Head { get; set; }
        public int Count { get; private set; }//set Count by increment when add elements
        private int ElementsCount { get; set; }//for Count by recursively method
        public T Value { get; set; }

        public BinaryTree(T val)
        {
            Value = val;
        }
        public BinaryTree() { }


        #region public methods
        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Add(T val)
        {
            PrivateAdd(val, Head);
        }


        public void Print()
        {
            PrivatePrint(Head);
        }

        public int ElCount
        {
            get
            {
                return PrivateCount(Head);
            }
        }
                

        public void PrintLeft()
        {
            if (!IsEmpty())
            {
                PrivatePrintLeft(Head.Left);
            }
            else
            {
                Console.WriteLine("Collection is Empty");
            }
        }
        public void PrintRight()
        {
            if (!IsEmpty())
            {
                PrivatePrintRight(Head.Right);
            }
            else
            {
                Console.WriteLine("Collection is Empty");
            }
        }
        #endregion

        #region private methods
        private void PrivateAdd(T val, BinaryTree<T> node)
        {
            BinaryTree<T> temp = new BinaryTree<T>(val);

            if (!IsEmpty())
            {
                if (val > node.Value)
                {
                    if (node.Right == null)
                    {
                        node.Right = temp;
                        Count++;
                    }
                    else
                    {
                        PrivateAdd(val, node.Right);
                    }
                }
                else
                {
                    if (node.Left == null)
                    {
                        node.Left = temp;
                        Count++;
                    }
                    else
                    {
                        PrivateAdd(val, node.Left);
                    }
                }
            }
            else
            {
                Head = temp;
                Count++;
            }
        }

        private void PrivatePrintRight(BinaryTree<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PrivatePrintRight(node.Right);
                PrivatePrintRight(node.Left);
            }
        }

        private void PrivatePrintLeft(BinaryTree<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PrivatePrintLeft(node.Left);
                PrivatePrintLeft(node.Right);
            }
        }

        private int PrivateCount(BinaryTree<T> node)
        {

            if (node != null)
            {
                PrivateCount(node.Right);
                PrivateCount(node.Left);
                ElementsCount++;
            }
            return ElementsCount;
        }

        private void PrivatePrint(BinaryTree<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PrivatePrint(node.Right);
                PrivatePrint(node.Left);
            }
        }
        #endregion
    }
}

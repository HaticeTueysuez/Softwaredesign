using System;
using System.Collections.Generic;


namespace ForEach_im_Baum
{
    class Tree<T>
    {
        public T Data;
        public List<Tree<T>> children = new List<Tree<T>>();


        public Tree<T> CreateNode(T data)
        {
            Tree<T> newNode = new Tree<T>
            {
                Data = data
            };
            return newNode;
        }

        public void AppendChild(Tree<T> child)
        {
            children.Add(child);
        }

        public void RemoveChild(Tree<T> child)
        {
            children.Remove(child);
        }

        public void PrintTree(String showTree = "")
        {
            Console.WriteLine(showTree + Data);
            foreach (Tree<T> child in children)
            {
                child.PrintTree(showTree + "*");
            }
        }

        public void ForEach(Action<string> func)
        {         
            for (int i = 0; i < children.Count; i++)
            {
                func(children[i].ToString());
                children[i].ForEach(Program.Func);
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }


    }
}
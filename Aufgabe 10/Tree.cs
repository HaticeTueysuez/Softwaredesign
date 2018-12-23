using System;
using System.Collections.Generic;


namespace Aufgabe_10
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

    }
}
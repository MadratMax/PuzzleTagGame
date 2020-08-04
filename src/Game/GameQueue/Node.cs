using System;

namespace PuzzleTag
{
    public class Node <T>
    {
        private readonly T data;
        private int number;

        public Node(T data, int number)
        {
            this.data = data;
            this.number = number;
        }

        public int NumberInQueue => number;

        public int Id => this.data.GetHashCode();

        public Type DataType => this.data.GetType();

        public T Data => data;
    }
}
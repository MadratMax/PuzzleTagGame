using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleTag
{
    public class Nodes <T>
    {
        private List<Node<T>> nodeList;
        private HashSet<Type> typeList;
        private readonly QueueType queueType;
        private int nodeCounter;
        private int currentNodeNumber = 1;
        private int maxNodeNumber;

        public Nodes(QueueType queueType)
        {
            this.nodeList = new List<Node<T>>();
            this.typeList = new HashSet<Type>();
            this.queueType = queueType;
        }

        public Node <T> AddNode(T nodeData, bool replaceNode = false)
        {
            if (!replaceNode)
                nodeCounter++;

            var newNode = new Node<T>(nodeData, nodeCounter);

            nodeList.Add(newNode);
            typeList.Add(newNode.DataType);

            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
            {
                currentNodeNumber = nodeCounter;
            }

            maxNodeNumber = nodeCounter;

            return newNode;
        }

        public Node <T> GetNode()
        {
            Node <T> node = nodeList.FirstOrDefault(n => n.NumberInQueue == currentNodeNumber);

            while (node == null)
            {
                if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                {
                    if (currentNodeNumber <= 0)
                    {
                        if (queueType == QueueType.CircleLIFO)
                        {
                            Reset();
                            GetNode();
                        }
                        else
                        {
                            break;
                        }
                    }

                    currentNodeNumber--;
                }

                if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                {
                    if (currentNodeNumber >= maxNodeNumber)
                    {
                        if (queueType == QueueType.CircleFIFO)
                        {
                            Reset();
                            GetNode();
                        }
                        else
                        {
                            return nodeList.FirstOrDefault(n => n.NumberInQueue == currentNodeNumber);
                        }
                    }

                    currentNodeNumber++;
                }

                node = nodeList.FirstOrDefault(n => n.NumberInQueue == currentNodeNumber);

                if (node != null)
                {
                    if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                        currentNodeNumber--;
                    if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                        currentNodeNumber++;

                    return node;
                }
            }

            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                currentNodeNumber--;
            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                currentNodeNumber++;

            return node;
        }

        public Node<T> GetFirstNode()
        {
            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                return nodeList.FirstOrDefault(n => n.NumberInQueue == nodeCounter);
            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                return nodeList.FirstOrDefault(n => n.NumberInQueue == 1);

            return null;
        }

        public Node<T> GetLastNode()
        {
            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                return nodeList.FirstOrDefault(n => n.NumberInQueue == 1);
            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                return nodeList.FirstOrDefault(n => n.NumberInQueue == nodeCounter);

            return null;
        }

        public bool HaveSameType()
        {
            return typeList.Count == 1;
        }

        public bool AllNodeTypesAre(Type type)
        {
            return HaveSameType() && typeList.Contains(type);
        }

        public bool NodeTypeIs(Node<T> node, Type type)
        {
            return nodeList.FirstOrDefault(n => n.Id == node.Id)?.DataType == type;
        }

        public bool IsLastNode(Node<T> node)
        {
            if (node == null)
                return false;

            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                return node.NumberInQueue == 1;
            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                return node.NumberInQueue == nodeCounter;

            return false;
        }

        public void RemoveNode(Node<T> node)
        {
            maxNodeNumber--;

            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
            {
                if (IsLastNode(node))
                {
                    nodeCounter--;
                }
            }
            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
            {
                if (IsLastNode(node))
                {
                    nodeCounter--;
                }
            }

            nodeList.Remove(node);
        }

        public void RemoveDataFromNode(Node<T> node)
        {
            
        }

        public void Reset()
        {
            if (queueType == QueueType.LIFO || queueType == QueueType.CircleLIFO)
                this.currentNodeNumber = nodeCounter;

            if (queueType == QueueType.FIFO || queueType == QueueType.CircleFIFO)
                this.currentNodeNumber = 1;
        }

        public void RemoveNodes()
        {
            foreach (var node in nodeList)
            {
                RemoveNode(node);
            }

            Reset();
        }
    }
}

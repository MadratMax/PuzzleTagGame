using System;

namespace PuzzleTag
{
    public class Queue <T>
    {
        /// <summary>
        /// Represents a custom queue.
        /// </summary>
        private readonly QueueType queueType;
        private readonly Nodes <T> nodes;
        private bool isLimited;
        private Node<T> node;
        private int limit;
        private int limitCounter;

        public Queue(QueueType queueType)
        {
            this.queueType = queueType;
            this.nodes = new Nodes <T>(queueType);
        }

        /// <summary>
        /// Sets max queue size. New nodes won't be added when the limit is exceeded.
        /// </summary>
        public void SetQueueLimit(int maxNodeQuantity)
        {
            this.limit = maxNodeQuantity;
            this.isLimited = true;
        }

        /// <summary>
        /// Returns true if all node type in queue are equal to the specified type.
        /// </summary>
        public bool NodeTypesAre(Type type)
        {
            return nodes.AllNodeTypesAre(type);
        }

        /// <summary>
        /// Add new node to queue.
        /// </summary>
        public Node<T> Add(T data)
        {
            if (data == null || (IsLimited && limitCounter == limit))
                return null;

            var newNode = nodes.AddNode(data);
            limitCounter++;

            return newNode;
        }

        /// <summary>
        /// Removes the entire node data. Actual node is replaced by null.
        /// </summary>
        public void Remove(Node <T> node)
        {
            this.nodes.RemoveNode(node);
            limitCounter--;
        }

        /// <summary>
        /// Removes data from node. Actual node remains the same.
        /// </summary>
        public void RemoveDataFromNode(Node <T> node)
        {
            this.nodes.RemoveDataFromNode(node);
        }

        /// <summary>
        /// Returns queue with set current node as the first node.
        /// </summary>
        public Queue <T> First()
        {
            this.node = nodes.GetFirstNode();
            return this;
        }

        /// <summary>
        /// Returns queue with set current node as the last node.
        /// </summary>
        public Queue<T> Last()
        {
            this.node = nodes.GetLastNode();
            return this;
        }

        /// <summary>
        /// Set current node as the next node. Returns Queue instance.
        /// </summary>
        public Queue <T> Next()
        {
            var currentNode = nodes.GetNode();

            if (queueType == QueueType.CircleFIFO || queueType == QueueType.CircleLIFO)
            {
                if (nodes.IsLastNode(currentNode))
                {
                    nodes.Reset();
                }
            }

            this.node = currentNode;
            return this;
        }

        public Node<T> Node => node;

        private int Limit => limit;

        private bool IsLimited => isLimited;
    }
}

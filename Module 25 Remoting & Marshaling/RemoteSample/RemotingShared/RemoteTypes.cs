﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingShared
{
    /// <summary>
    /// A simple type to be created and accessed cross-process
    /// </summary>
    public class MessageHolder
    {
        public string Name { get; }

        internal Queue<string> MessageQueue { get; } = new Queue<string>();

        public byte Length => (byte)MessageQueue.Count;

        public byte MaxLength { get; set; } = 5;

        public MessageHolder(string name)
        {
            Name = name;
        }

        public void AddMessageToQueue(string message)
        {
            if (MessageQueue.Count < MaxLength)
                MessageQueue.Enqueue(message);
        }

        public string RetrieveMessageFromQueue()
        {
            return MessageQueue.Dequeue();
        }

        /// <summary>
        /// A Console.WriteLine-using diagnostic to demonstrate where the object is running
        /// </summary>
        public void LogQueueToConsole()
        {
            Console.WriteLine($"Contents of queue '{Name}' in process {Process.GetCurrentProcess().Id}:\n\t{string.Join("\n\t", MessageQueue)}");
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// 队列
/// </summary>
public class QueueProduces
{
    // 产品库中产品数量
    public int Count { get; private set; }

    // 产品库的数量
    public int Capacity { get; set; }

    /// <summary>
    /// 构造函数
    /// </summary>
    public QueueProduces()
    {
        Count = 0;
        Capacity = 100;
        head = new Node();
        end = head;
    }

    /// <summary>
    /// 添加一个产品到容器
    /// </summary>
    /// <param name="task"></param>
    public void Push(Produce produce)
    {
        // 加锁，线程安全
        lock (end)
        {
            end.Produce = produce;
            end.Next = new Node();
            end = end.Next;
            Console.WriteLine("+");
            Count++;

            // 加入队列成功
            Console.WriteLine("EnQueue");
            
        }
    }

    /// <summary>
    /// 得到一个产品
    /// </summary>
    /// <returns></returns>
    public Produce Get()
    {
        // 加锁，线程安全
        lock (head)
        {
            if (head.Produce == null)
            {
                return null;
            }
            Produce produce = head.Produce;
            head = head.Next;
            Console.WriteLine("-");
            Count--;

            // 返回一个产品
            return produce;
        }
    }

    class Node
    {
        public Node()
        {
            Produce = null;
            Next = null;
        }

        public Node(Produce produce)
        {
            Produce = produce;
            Next = null;
        }

        public Produce Produce;

        public Node Next;
    }

    Node head;
    Node end;
}

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 消费者
/// </summary>
public class Producer : Person
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="name">名字</param>
    public Producer(string name)
        : base(name)
    {
        //Console.WriteLine("Producer Construct");
    }
}

using System;
using System.Collections.Generic;

/// <summary>
/// 消费者
/// </summary>
public class Consumer : Person
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="name"></param>
    public Consumer(string name)
        : base(name)
    {
        //Console.WriteLine("Consumer Construct");
    }

    public void Consume()
    {

    }
}
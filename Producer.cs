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
    public Producer(string name) : base(name)
    {
        //Console.WriteLine("Producer Construct");
    }

    /// <summary>
    /// 生产者生产一件产品
    /// </summary>
    /// <returns></returns>
    public Produce Create()
    {
        // 生产者生产产品
        Produce produce = new Produce();

        // 返回该产品
        return produce;
    }
}

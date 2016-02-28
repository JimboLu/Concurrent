using System;
using System.Collections.Generic;

/// <summary>
/// 任务
/// </summary>
public class Produce
{
    /// <summary>
    /// 任务名
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// 生产它所需要花费的时间
    /// </summary>
    public int TimeOfProduce { get; private set; }

    /// <summary>
    /// 消费它需要花费的时间
    /// </summary>
    public int TimeOfConsume { get; private set; }

    /// <summary>
    /// 构造函数
    /// </summary>
    public Produce()
    {

    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="name">任务名</param>
    /// <param name="timeOfProduce">生产它所需要花费的时间</param>
    /// <param name="timeOfConsume">消费它所需要花费的时间</param>
    public Produce(String name, Int32 timeOfProduce, Int32 timeOfConsume)
    {
        Name = name;
        TimeOfProduce = timeOfProduce;
        TimeOfConsume = TimeOfConsume;
    }

    /// <summary>
    /// 生产者生产一件产品
    /// </summary>
    /// <returns></returns>
    public static Produce Create()
    {
        // 生产者生产产品
        Produce produce = new Produce();

        // 返回该产品
        return produce;
    }

    public static Produce Create(String name, Int32 timeOfProduce, Int32 timeOfConsume)
    {
        Produce produce = new Produce(name, timeOfProduce, timeOfConsume);
        return produce;
    }
}

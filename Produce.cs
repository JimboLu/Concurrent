﻿using System;
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
    /// 设置信息
    /// </summary>
    /// <param name="name">任务名</param>
    /// <param name="timeOfProduce">生产它所需要花费的时间</param>
    /// <param name="timeOfConsume">消费它所需要花费的时间</param>
    public void SetInfo(String name, Int32 timeOfProduce, Int32 timeOfConsume)
    {
        Name = name;
        TimeOfProduce = timeOfProduce;
        TimeOfConsume = timeOfConsume;
    }
}

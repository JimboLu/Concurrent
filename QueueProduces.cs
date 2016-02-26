using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 队列
/// </summary>
public class QueueProduces
{
    /// <summary>
    /// 容器
    /// </summary>
    List<Produce> produces = new List<Produce>();

    /// <summary>
    /// 构造函数
    /// </summary>
    public QueueProduces()
    {

    }

    /// <summary>
    /// 添加一个产品到容器
    /// </summary>
    /// <param name="task"></param>
    public void Push(Produce produce)
    {
        lock (produces)
        {
            produces.Add(produce);
            int count = produces.Count;
            String taskName = count.ToString();
            produce.SetInfo(taskName, 1000, 1000);

            // 打印日志
            StringBuilder log = new StringBuilder("生产 ");
            log.Append("Name: ").Append(produce.Name);
            Console.WriteLine(log);
        }
    }

    /// <summary>
    /// 得到一个产品
    /// </summary>
    /// <returns></returns>
    public Produce Get()
    {
        lock (produces)
        {
            if (produces.Count >= 1 && null != produces[0])
            {
                // 从List中把待消费的引用删除并返回
                Produce produce = produces[0];
                produces.RemoveAt(0);
                return produce;
            }

            // 缓冲区中没有产品
            // Console.WriteLine("缓冲区中无产品");
            return null;
        }


    }
}

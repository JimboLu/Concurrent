using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

/// <summary>
/// 测试者
/// </summary>
public class Tester
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public Tester()
    {
        
    }

    /// <summary>
    /// 并发测试
    /// </summary>
    public void ConcurrentTest()
    {
        // 得到生产者数量
        Console.WriteLine("Input Producer's Number: ");
        String input = Console.ReadLine();
        int producerNum = Int32.Parse(input);

        // 得到消费者数量
        Console.WriteLine("Input Consumer's Number: ");
        input = Console.ReadLine();
        int consumerNum = Int32.Parse(input.ToString());

        // 打印生产者数量
        StringBuilder log = new StringBuilder("Producer's Number: ");
        log.Append(producerNum);
        Console.WriteLine(log);

        // 打印消费者数量
        log.Clear();
        log.Append("Consumer's Number: ").Append(consumerNum);
        Console.WriteLine(log);

        // 实例化缓冲区
        QueueProduces produces = new QueueProduces();

        // 根据生产者数量开启线程
        for (int i = 0; i < producerNum; i++)
        {
            // 线程实例化
            Thread t = new Thread(ProducerThread);

            // 线程参数实例化
            Parameter p = new Parameter(i.ToString(), produces);

            // 启动线程
            t.Start(p);
        }

        // 根据消费者数量开启线程
        for (int i = 0; i < consumerNum; i++)
        {
            // 线程实例化
            Thread t = new Thread(ConsumeThread);

            // 线程参数实例化
            Parameter p = new Parameter(i.ToString(), produces);

            // 启动线程
            t.Start(p);
        }

        // 暂停
        Console.ReadLine();
    }

    /// <summary>
    /// 生产者线程
    /// </summary>
    /// <param name="parameter"></param>
    void ProducerThread(object parameter)
    {
        // 拿到参数
        Parameter par = parameter as Parameter;

        // 拿到缓冲区
        QueueProduces produces = par.Produces;

        // 拿到生产者名字
        String producerName = par.Name;

        // 实例化生产者
        Producer producer = new Producer(producerName);

        // 打印日志
        StringBuilder log = new StringBuilder("生产者");
        log.Append("Name: ").Append(producerName);
        Console.WriteLine(log);

        // 该生产者一直生产产品
        while(true)
        {
            Produce produce = producer.Create();
            produces.Push(produce);
            Thread.Sleep(1000);
        }
    }

    /// <summary>
    /// 消费者线程
    /// </summary>
    /// <param name="parameter"></param>
    void ConsumeThread(object parameter)
    {
        // 拿到参数
        Parameter par = parameter as Parameter;

        // 消费者名字
        string name = par.Name;

        // 实例化消费者
        Consumer c = new Consumer(name);

        // 拿到缓冲区
        QueueProduces produces = par.Produces;

        // 打印日志
        StringBuilder log = new StringBuilder("消费者 ");
        log.Append("Name: ").Append(name);
        Console.WriteLine(log);

        // 开始消费
        while(true)
        {
            Produce produce = produces.Get();
            if(null != produce)
            {
                int timeOfConsume = produce.TimeOfConsume;
                Thread.Sleep(timeOfConsume);

                // 打印日志
                log.Clear();
                log = new StringBuilder("消费 ");
                log.Append("Name: ").Append(produce.Name);
                Console.WriteLine(log);
            }
        }
    }

    /// <summary>
    /// 参数
    /// </summary>
    class Parameter
    {
        // 名字
        public String Name;

        // 缓冲区
        public QueueProduces Produces;

        // 构造函数
        public Parameter(String name, QueueProduces produces)
        {
            Name = name;
            Produces = produces;
        }
    }
}
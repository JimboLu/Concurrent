using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// 进程入口
/// </summary>
class Program
{
    /// <summary>
    /// 入口方法
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // 实例化测试者
        Tester tester = new Tester();

        // 开始测试并发
        tester.ConcurrentTest();
    }
}

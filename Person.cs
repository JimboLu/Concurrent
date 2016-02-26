using System;
using System.Collections.Generic;

public class Person
{
    // 名字
    public string Name { get; private set; }

    // 构造函数
    public Person(string name)
    {
        this.Name = name;
        //Console.WriteLine("Person Construct");
    }
}

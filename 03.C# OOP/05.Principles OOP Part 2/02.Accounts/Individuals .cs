using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Individuals : Customers
{
    private int age;
    private string name;
    private string sex;
    public Individuals(int age, string name, string sex)
    {
        this.age = age;
        this.name = name;
        this.sex = sex;
    }
}


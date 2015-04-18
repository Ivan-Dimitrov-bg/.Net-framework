using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Companies : Customers
{
    private string name;
    private int bulstat;
    public Companies(string name, int bulstat)
    {
        this.name = name;
        this.bulstat = bulstat;
    }
}
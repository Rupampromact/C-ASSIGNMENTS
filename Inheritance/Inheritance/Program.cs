using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Employee
{
    public String id;
    public String name;
    public String designatiom;
    public int experience;
    public int ann_salary;
    public String joining;
    public abstract void Calculate_salary();
}
class HR:Employee
{
    public double basic_salary;
    public HR(int experience,double basic_salary) :base()
    {
        this.experience = experience;
        this.basic_salary = basic_salary;
    }
    public override void Calculate_salary()
    {
        double salary = basic_salary + (1000 * experience);
        Console.WriteLine("The salary of hr is:" + " " + salary);
    }

}
class Developer : Employee
{
    public double basic_salary;
    public Developer( int experience, double basic_salary) :base()
    {
        this.experience = experience;
        this.basic_salary = basic_salary;
    }
    public override void Calculate_salary()
    {
        double salary = basic_salary + (2000 * experience);
        Console.WriteLine("The salary of developer is:" + " " + salary);
    }

}

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            HR h = new HR(4, 8000);
            Developer d = new Developer(5, 8000);
            h.Calculate_salary();
            d.Calculate_salary();


        }
    }
}

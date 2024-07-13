class Student
{
    string Name;
    int Age;

    public Student(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public void getdata(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void print()
    {
        Console.WriteLine($"{Name} - {Age}");
    }
    public string grad()
    {
        if (Age >= 22)
        {
            return $"{Name} is graduated";
        }
        else
        {
            return $"{Name} isn't graduated";
        }
    }
}
namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student student1 = new Student(Name: "mohamed", Age: 20);
            Student student2 = new Student(Name: "Ahmed", Age: 25);
            student1.print();
            student2.print();
            Console.WriteLine(student1.grad());
            Console.WriteLine(student2.grad());
            Console.ReadLine();
        }
    }
}
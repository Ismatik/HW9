using System;

namespace HW9Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Converter cash1 = new Converter();
            // cash1.Convert_to_Somoni(10 , 5 , 1000);
            // Converter cash2 = new Converter();
            // cash2.Convert_from_Somoni(150 , 200 , 155);

            Employee emp = new Employee("Ismat" , "Mukhamedzhanov" , "Student" , 1000);
            emp.ShowInfo();
            emp.calculate_clear_salary();
        }
    }

    class Converter
    {
        public double usd;
        public double eur;
        public double rub;

        public Converter()
        {

        }
        public Converter(double usd, double eur, double rub)
        {
            this.usd  = usd;
            this.eur  = eur;
            this.rub  = rub;
        }


        public void Convert_to_Somoni(double usd, double eur, double rub)
        {
            double somoni_usd = usd * 11.326;
            double somoni_eur = eur * 13.3024;
            double somoni_rub = rub * 0.1530;

            Console.WriteLine($"{usd} Usd to somoni is {somoni_usd} somoni.");
            Console.WriteLine($"{eur} Eur to somoni is {somoni_eur} somoni.");
            Console.WriteLine($"{rub} Rub to somoni is {somoni_rub} somoni.");
        }

        public void Convert_from_Somoni(double somoni_usd, double somoni_eur, double somoni_rub)
        {
            double usd = somoni_usd / 11.326;
            double eur = somoni_eur / 13.3024;
            double rub = somoni_rub / 0.1530;

            Console.WriteLine($"{somoni_usd}  somoni is {usd} dollars.");
            Console.WriteLine($"{somoni_eur} somoni is {eur} eur.");
            Console.WriteLine($"{somoni_rub} somoni is {rub} rub.");
        }
    }

    class Employee
    {
        public string first_name;
        public string second_name;
        public string position;
        public int salary;

        public Employee()
        {
        }

        public Employee(string first_name, string second_name, string position, int salary)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.position = position;
            this.salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"First name: {first_name}, Last name : {second_name}, Position {position}. The salary of {first_name} is {salary}");
        }

        public void calculate_clear_salary()
        {
            decimal result;
            result = salary - ((salary * 14) / 100);
            Console.WriteLine($"Clear salry of {first_name} is {result}.");
        }
    }
}

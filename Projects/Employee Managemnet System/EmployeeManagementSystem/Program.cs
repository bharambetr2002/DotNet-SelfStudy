using System;

namespace EmployeeManagementSystem
{
    class Employee
    {
        private string? name;
        private decimal basic;
        private short deptNo;

        private static int empCounter = 0;
        private int empNo;

        // single construotor with all the posible inputs we want avoiding the duplications
        public Employee(string name = "Unknown", decimal basic = 1000, short deptNo = 1)
        {
            empCounter++;
            this.empNo = empCounter;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }

        // public Employee()
        // {
        //     empCounter++;
        //     this.empNo = empCounter;
        // }
        // public Employee(string name, decimal basic, short deptNo)
        // {
        //     empCounter++;
        //     this.empNo = empCounter;
        //     this.Name = name;
        //     this.Basic = basic;
        //     this.DeptNo = deptNo;
        // }
        // public Employee(string name, decimal basic)
        // {
        //     empCounter++;
        //     this.empNo = empCounter;
        //     this.Name = name;
        //     this.Basic = basic;
        // }
        // public Employee(string name)
        // {
        //     empCounter++;
        //     this.empNo = empCounter;
        //     this.Name = name;
        // }

        public string Name
        {
            get { return name!; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Name");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int EmpNo
        {
            get { return empNo; }
        }

        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 1000 && value <= 10000000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Basic salary must be between 1000 and 10000000");
                }
            }
        }

        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Department number must be greater than 0");
                }
            }
        }

        public decimal GetNetSalary()
        {
            return basic + (basic * 0.20m) - (basic * 0.10m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Tanmay", 123456, 10);
            Employee employee2 = new Employee("Amit", 100000);
            Employee employee3 = new Employee("Ravi");
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            Console.WriteLine("employee1 EmpNo: " + employee1.EmpNo);
            Console.WriteLine("employee2 EmpNo: " + employee2.EmpNo);
            Console.WriteLine("employee3 EmpNo: " + employee3.EmpNo);
            Console.WriteLine("employee4 EmpNo: " + employee4.EmpNo);
            Console.WriteLine("employee5 EmpNo: " + employee5.EmpNo);

            //Testing in reverse order
            // Console.WriteLine("employee5 EmpNo: " + employee5.EmpNo);
            // Console.WriteLine("employee4 EmpNo: " + employee4.EmpNo);
            // Console.WriteLine("employee3 EmpNo: " + employee3.EmpNo);
            // Console.WriteLine("employee2 EmpNo: " + employee2.EmpNo);
            // Console.WriteLine("employee1 EmpNo: " + employee1.EmpNo);
        }
    }
}

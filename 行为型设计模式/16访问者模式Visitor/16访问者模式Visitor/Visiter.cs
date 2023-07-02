using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16访问者模式Visitor {
    /// <summary>
    /// 抽象元素类：Employee
    /// </summary>
    public interface IEmployee {
        void Accept(Department handler);
    }
    /// <summary>
    /// 具体元素类：FullTimeEmployee
    /// </summary>
    public class FullTimeEmployee : IEmployee {
        public string Name { get; set; }
        public double WeeklyWage { get; set; }
        public int WorkTime { get; set; }

        public FullTimeEmployee(string name, double weeklyWage, int workTime) {
            this.Name = name;
            this.WeeklyWage = weeklyWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler) {
            handler.Visit(this);
        }
    }

    /// <summary>
    /// 具体元素类：PartTimeEmployee
    /// </summary>
    public class PartTimeEmployee : IEmployee {
        public string Name { get; set; }
        public double HourWage { get; set; }
        public int WorkTime { get; set; }

        public PartTimeEmployee(string name, double hourWage, int workTime) {
            this.Name = name;
            this.HourWage = hourWage;
            this.WorkTime = workTime;
        }

        public void Accept(Department handler) {
            handler.Visit(this);
        }
    }
    /// <summary>
    /// 对象结构类：EmployeeList
    /// </summary>
    public class EmployeeList {
        private IList<IEmployee> empList = new List<IEmployee>();

        public void AddEmployee(IEmployee emp) {
            this.empList.Add(emp);
        }

        public void Accept(Department handler) {
            foreach (var emp in empList) {
                emp.Accept(handler);
            }
        }
    }
        /// <summary>
        /// 抽象访问者类：Department
        /// </summary>
        public abstract class Department {
        // 声明一组重载的访问方法，用于访问不同类型的具体元素
        public abstract void Visit(FullTimeEmployee employee);
        public abstract void Visit(PartTimeEmployee employee);
    }
    /// <summary>
    /// 具体访问者类：FinanceDepartment
    /// </summary>
    public class FinanceDepartment : Department {
        // 实现财务部对兼职员工数据的访问
        public override void Visit(PartTimeEmployee employee) {
            int workTime = employee.WorkTime;
            double hourWage = employee.HourWage;
            Console.WriteLine("临时工 {0} 实际工资为：{1} 元", employee.Name, workTime * hourWage);
        }

        // 实现财务部对全职员工数据的访问
        public override void Visit(FullTimeEmployee employee) {
            int workTime = employee.WorkTime;
            double weekWage = employee.WeeklyWage;

            if (workTime > 40) {
                weekWage = weekWage + (workTime - 40) * 50;
            }
            else if (workTime < 40) {
                weekWage = weekWage - (40 - workTime) * 80;
                if (weekWage < 0) {
                    weekWage = 0;
                }
            }

            Console.WriteLine("正式员工 {0} 实际工资为：{1} 元", employee.Name, weekWage);
        }
    }

    /// <summary>
    /// 具体访问者类：HRDepartment
    /// </summary>
    public class HRDepartment : Department {
        // 实现人力资源部对兼职员工数据的访问
        public override void Visit(PartTimeEmployee employee) {
            int workTime = employee.WorkTime;
            Console.WriteLine("临时工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);
        }

        // 实现人力资源部对全职员工数据的访问
        public override void Visit(FullTimeEmployee employee) {
            int workTime = employee.WorkTime;
            Console.WriteLine("正式员工 {0} 实际工作时间为：{1} 小时", employee.Name, workTime);

            if (workTime > 40) {
                Console.WriteLine("正式员工 {0} 加班时间为：{1} 小时", employee.Name, workTime - 40);
            }
            else if (workTime < 40) {
                Console.WriteLine("正式员工 {0} 请假时间为：{1} 小时", employee.Name, 40 - workTime);
            }
        }
    }
}

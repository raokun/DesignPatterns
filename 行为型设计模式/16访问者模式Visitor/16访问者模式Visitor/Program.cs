using _16访问者模式Visitor;

EmployeeList employeeList = new EmployeeList();
employeeList.AddEmployee(new PartTimeEmployee("张三",1000,80));
employeeList.AddEmployee(new PartTimeEmployee("李四", 10000, 40));
employeeList.AddEmployee(new FullTimeEmployee("王五", 1000, 80));
employeeList.AddEmployee(new FullTimeEmployee("赵六", 10000, 100));

Department finance = new FinanceDepartment();
Department hr = new HRDepartment();
//employeeList.Accept(finance);
employeeList.Accept(hr);



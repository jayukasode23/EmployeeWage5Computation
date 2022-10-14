using EmployeeWage5Program;
 Console.WriteLine("Welcome To Employee Wage Computation");

EmployeeCheck employeeAttendance = new EmployeeCheck();
employeeAttendance.CheckEmployeeAttendance();

DailyEmployeeWage dailyEmployeeWage = new DailyEmployeeWage();
dailyEmployeeWage.CheckDailyEmployeeWage();

PartTimeEmpWage partTimeEmpWage = new PartTimeEmpWage();
partTimeEmpWage.CheckEmployeePartTimeWage();

SwitchCaseStatement employeeWageSwitchCase = new SwitchCaseStatement();
employeeWageSwitchCase.CheckDailyEmpWage();

EmployeeMonthWages monthlyEmloyeeWage = new EmployeeMonthWages();
monthlyEmloyeeWage.CheckEmployeeMonthlyWage();

EmployeeTotalWages monthlyEmpWage2 = new EmployeeTotalWages ();
monthlyEmpWage2.CheckEmployeeMonth();

RefactoreEmployeeWage refactoreEmpWage = new RefactoreEmployeeWage();
refactoreEmpWage.CheckComputeEmployeeWage();

ComputeEmployeeWage obj1 = new ComputeEmployeeWage();
obj1.computeEmpWage("DMart", 20, 2, 10);
obj1.computeEmpWage("Relieance", 10, 4, 20);

EmpWageObjectBuilder dMart = new EmpWageObjectBuilder("DMart", 20, 4, 10);
EmpWageObjectBuilder reliance = new EmpWageObjectBuilder("Reliance", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());


EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
empWageBuilderArray.addCompanyEmpWage("DMart", 20, 4, 10);
empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuilderArray.computeEmpWage();


using System;


public class Project
{
    public string project{get;set;}

    public Project(string ProjectName)
    {
        project=ProjectName;
    }
}

public class ProjectManagement
{
    List<Project> prolifics= new List<Project>();
    
    public void addproject(Project project)
    {
        prolifics.Add(project);
    
    }

    public void viewProject()
    {
        foreach(var a in prolifics)
        {
           Console.WriteLine(a.project);
        }
    }
}
public class Employee
{
    public string employee{get;set;}

    public Employee(string EmployeeName)
    {
        employee=EmployeeName;
    }
}

public class EmployeeData
{
    List<Employee> Employeeprolifics= new List<Employee>();
    
    public void addemployee(Employee employee)
    {
        Employeeprolifics.Add(employee);
    
    }

    public void viewEmployee()
    {
        foreach(var a in Employeeprolifics)
        {
           Console.WriteLine(a.employee);
        }
    }
}
public class EmployeeRole
{
    public string employeerole{get;set;}

    public EmployeeRole(string EmployeeRoleName)
    {
        employeerole=EmployeeRoleName;
    }
}

public class EmployeeRolebase
{
    List<EmployeeRole> EmployeeRoleprolifics= new List<EmployeeRole>();
    
    public void addemployeerole(EmployeeRole employeerole)
    {
        EmployeeRoleprolifics.Add(employeerole);
    
    }

    public void viewEmployeeRole()
    {
        foreach(var a in EmployeeRoleprolifics)
        {
           Console.WriteLine(a.employeerole);
        }
    }
}
public class ProlificsProjectManagement
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("WELCOME TO PROLIFICS PROJECT MANAGEMENT ");
        Console.WriteLine("SELECT OPERATIONS");
        Console.WriteLine("");
        Console.Write("Enter 1 for add  project               ");
        Console.WriteLine("         Enter 2 for view all projects");
        Console.WriteLine("");
        Console.Write("Enter 3 for add Employee              ");
        Console.WriteLine("         Enter 4 for view all Employees");
        Console.WriteLine("");
        Console.Write("Enter 5 for add  EmployeeRole                  ");
        Console.WriteLine("Enter 6 for view all EmployeeRoles");
        Console.WriteLine("");
        Console.WriteLine("Enter x  for exit");
        ProjectManagement obj = new ProjectManagement();
        EmployeeData obj1 = new EmployeeData();
        EmployeeRolebase obj2 = new EmployeeRolebase();

        var userInput = Console.ReadLine();

        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Project Name:");
                    var Project = Console.ReadLine();
                    var projectadd=new Project(Project);
                    obj.addproject(projectadd);
                    Console.WriteLine("Project added successfully");
                    break;
                case "2":
                    obj.viewProject();
                    break;
                case "3":
                    Console.WriteLine("Employee Name:");
                    var Employee = Console.ReadLine();
                    var employeeadd=new Employee(Employee);
                    obj1.addemployee(employeeadd);
                    Console.WriteLine("Employee added successfully");
                    break;
                case"4":
                    obj1.viewEmployee();
                    break;
                case "5":
                    Console.WriteLine("Employee Role");
                    var EmployeeRole = Console.ReadLine();
                    var employeeroleadd = new EmployeeRole(EmployeeRole);
                    obj2.addemployeerole(employeeroleadd);
                    Console.WriteLine("EmployeeRole added successfully");
                    break;
                case "6":
                    obj2.viewEmployeeRole();
                    break;
                case "x":
                     return;
                default:
                    Console.WriteLine("SELECT VAILD OPERATION");
                    break;
            }
            Console.WriteLine("Select operation");
            userInput = Console.ReadLine();
    
        }

    }
}  

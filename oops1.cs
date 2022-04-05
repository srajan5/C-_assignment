using System;
public class Employee
{
	private int EmpNo;
	private string EmpName;
	private double Salary;
	private double HRA;
	private double TA;
	private double DA;
	private double PF;
	private double TDS;
	private double NetSalary;
	private double GrossSalary;

	public int empNo
	{
		get { return EmpNo; }
		set { EmpNo = value; }
	}
	public string empName
	{
		get { return EmpName; }
		set { EmpName = value; }
	}
	public void GetSalary_hra_ta_da(double s)
	{
		Salary = s;
		if (Salary < 5000)
		{
			HRA = (Salary / 100) * 10;
			TA = (Salary / 100) * 5;
			DA = (Salary / 100) * 15;




		}
		else if (Salary > 5000 && Salary < 10000)
		{
			HRA = (Salary / 100) * 15;
			TA = (Salary / 100) * 10;
			DA = (Salary / 100) * 20;


		}
		else if (Salary > 10000 && Salary < 15000)
		{
			HRA = (Salary / 100) * 20;
			TA = (Salary / 100) * 15;
			DA = (Salary / 100) * 25;

		}
		else if (Salary > 15000 && Salary < 20000)
		{
			HRA = (Salary / 100) * 25;
			TA = (Salary / 100) * 20;
			DA = (Salary / 100) * 30;

		}
		else
		{
			HRA = (Salary / 100) * 30;
			TA = (Salary / 100) * 25;
			DA = (Salary / 100) * 35;

		}
		GrossSalary = Salary + HRA + TA + DA;

		double GetSalary()
		{
			return Salary;
		}

		void CalculateSalary()
		{
			PF = (GrossSalary / 100) * 10;
			TDS = (GrossSalary / 100) * 10;
			NetSalary = GrossSalary - (PF + TDS);
		}


	}
	public void DisplayGrossSalary()
	{
		Console.WriteLine("The gross Salary of Employee is {0}", GrossSalary);
	}

}
class Litwarelib
{
	public static void Main()
	{
		Employee E = new Employee();
		try
		{
			Console.WriteLine("Please give employee_No");
			int emp_no = Convert.ToInt32(Console.ReadLine());
			if (emp_no <= 0)
			{
				throw new Exception("Invalid Emp_no");
			}
			E.empNo = emp_no;
		}
		catch (Exception ex)
		{
			console.WriteLine(ex.Message);
			
		}
		try
		{
			Console.WriteLine("Please give employee_Name");
			string emp_name = Console.ReadLine();
			if (emp_name == null || emp_name == "")
			{
				throw new Exception("emp_name cannot be null");
			}
			E.empName = emp_name;
		}
		catch(NullReferenceExpection ex )
        {
			console.writeLine("please give valid name");
        }
		try
		{
			Console.WriteLine("Please give employee_Salary");
			Double emp_salary = Convert.ToDouble(Console.ReadLine());
			if (emp_salary <= 0)
			{
				throw new Exception("Salary Cannot be negative or zero");
			}
			E.GetSalary_hra_ta_da(emp_salary);
		}
		catch(Exception ex)
        {
			console.WriteLine("Invalid entry");
        }

		E.DisplayGrossSalary();

	}

}
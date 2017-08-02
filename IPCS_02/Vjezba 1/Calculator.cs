using System;

class Calculator
{
	public static void Main()
	{
		Console.Write("Operand 1: ");
		int op1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Operand 2: ");
		int op2 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Operator: ");
		string oper = Console.ReadLine();
		
		switch(oper)
		{
			case "+":
				Console.WriteLine(op1 + op2);
				break;
			case "-":
				Console.WriteLine(op1 - op2);
				break;
			case "*":
				Console.WriteLine(op1 * op2);
				break;
			case "/":
				Console.WriteLine(op1 / op2);
				break;
		}
	}
}
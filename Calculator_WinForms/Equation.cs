namespace Calculator_WinForms;

public class Equation
{
    #region Properties

	public List<double> Operands { get; }

	public List<OperatorType> Operators { get; }

	public double Result => GetResult();

    #endregion

    #region Constructors

	public Equation()
	{
		Operands = new List<double>
		{
			0,
		};
		Operators = new List<OperatorType>();
	}

	public void SetOperand(string operand)
	{
		Operands[^1] = double.Parse(operand);
	}

	public void SetOperator(string operatorString)
	{
		OperatorType selectedOperator = operatorString switch
		                                {
			                                "+" => OperatorType.Plus,
			                                "-" => OperatorType.Subtract,
			                                "/" => OperatorType.Divide,
			                                "*" => OperatorType.Multiply,
			                                _ => throw new ArgumentOutOfRangeException(nameof(operatorString), operatorString, null),
		                                };
		Operators.Add(selectedOperator);
		Operands.Add(0);
	}

	private double GetResult()
	{
		double result = Operands.First();

		for (int i = 0; i < Operators.Count; i++)
		{
			double operand = Operands[i + 1];
			switch (Operators[i])
			{
				case OperatorType.Plus:
					result += operand;
					break;
				case OperatorType.Divide:
					result /= operand;
					break;
				case OperatorType.Subtract:
					result -= operand;
					break;
				case OperatorType.Multiply:
					result *= operand;
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		return result;
	}
	#endregion
}

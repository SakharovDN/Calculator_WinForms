namespace Calculator_WinForms
{
	public class Equation
	{
		#region Properties

		public List<double> Operands { get; }

		public List<OperatorType> Operators { get; }

		public bool IsCalculatable => Operators.Count > 0;

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

		#endregion

		#region Methods

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

		public string GetEquationText()
		{
			string equationText = string.Empty;

			for (int i = 0; i < Operators.Count; i++)
			{
				equationText += $" {Operands[i]}";
				equationText += Operators[i] switch
				                {
					                OperatorType.Plus => " +",
					                OperatorType.Divide => " /",
					                OperatorType.Subtract => " -",
					                OperatorType.Multiply => " *",
					                _ => throw new ArgumentOutOfRangeException(),
				                };
			}

			return equationText;
		}

		public double GetResult()
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

			Operands.Clear();
			Operators.Clear();
			Operands.Add(result);

			return result;
		}

		#endregion
	}
}

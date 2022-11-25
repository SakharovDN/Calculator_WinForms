namespace Calculator_WinForms;

public class Equation
{
    #region Properties

    public List<double> Operands { get; }

    public List<OperatorType> Operators { get; }

    public bool IsCalculatable => Operators.Count > 0 && Operands.Count > Operators.Count;

    #endregion

    #region Constructors

    public Equation()
    {
        Operands = new List<double>();
        Operators = new List<OperatorType>();
    }

    #endregion

    #region Methods

    public void SetOperand(string operand)
    {
        double value = double.Parse(operand);

        if (Operands.Count == Operators.Count)
        {
            Operands.Add(value);
        }
        else
        {
            Operands[^1] = value;
        }
    }

    public void SetOperator(string operatorString)
    {
        OperatorType selectedOperator = operatorString switch
                                        {
                                            "+" => OperatorType.Plus,
                                            "-" => OperatorType.Subtract,
                                            "/" => OperatorType.Divide,
                                            "*" => OperatorType.Multiply,
                                            _ => throw new ArgumentOutOfRangeException(nameof(operatorString), operatorString, null)
                                        };

        if (Operands.Count == Operators.Count)
        {
            Operators[^1] = selectedOperator;
        }
        else
        {
            Operators.Add(selectedOperator);
        }
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
                                _ => throw new ArgumentOutOfRangeException()
                            };
        }

        return equationText;
    }

    public double GetResult()
    {
        double result = Calculate();
        MergeOperands(result);

        return result;
    }

    private double Calculate()
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

    private void MergeOperands(double mergeValue)
    {
        Operands.Clear();
        Operators.Clear();
        Operands.Add(mergeValue);
    }

    #endregion
}

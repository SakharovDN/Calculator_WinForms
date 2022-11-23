namespace Calculator_WinForms;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ViewModel : INotifyPropertyChanged
{
    #region Constants

    public const string ZERO_STRING = "0";

    #endregion

    #region Fields

    private string _resultText = ZERO_STRING;

    #endregion

    #region Properties

    public Equation Equation { get; }

    public string ResultText
    {
        get => _resultText;
        private set
        {
            _resultText = value;
            OnPropertyChanged();
        }
    }

    #endregion

    #region Events

    public event PropertyChangedEventHandler? PropertyChanged;

    #endregion

    #region Constructors

    public ViewModel()
    {
        Equation = new Equation();
    }

    #endregion

    #region Methods

    public void SetDigit(string digitString)
    {
        if (!int.TryParse(digitString, out int digit))
        {
            return;
        }

        if (ResultText == ZERO_STRING)
        {
            ResultText = digitString;
        }
        else
        {
            ResultText += digitString;
        }

        if (Equation.Operator.HasValue)
        {
            Equation.SecondOperand = Equation.SecondOperand * 10 + digit;
        }
        else
        {
            Equation.FirstOperand = Equation.FirstOperand * 10 + digit;
        }
    }

    public void SetOperator(string operatorString)
    {
        Equation.Operator = operatorString switch
                            {
                                "+" => Operator.Plus,
                                "-" => Operator.Subtract,
                                "/" => Operator.Divide,
                                "*" => Operator.Multiply,
                                _ => Equation.Operator
                            };

        ResultText = ZERO_STRING;
    }

    public void ShowResult()
    {
        double result;

        switch (Equation.Operator)
        {
            case Operator.Plus:
                result = Equation.FirstOperand + Equation.SecondOperand;

                break;
            case Operator.Divide:
                result = Equation.FirstOperand / Equation.SecondOperand;

                break;
            case Operator.Subtract:
                result = Equation.FirstOperand - Equation.SecondOperand;

                break;
            case Operator.Multiply:
                result = Equation.FirstOperand * Equation.SecondOperand;

                break;
            default:
                return;
        }

        ResultText = result.ToString();
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

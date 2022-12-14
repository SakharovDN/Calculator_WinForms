namespace Calculator_WinForms;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public class ViewModel : INotifyPropertyChanged
{
    #region Constants

    public const string ZERO_STRING = "0";
    public const string POINT_STRING = ",";

    #endregion

    #region Fields

    private string _resultText;
    private string _equationText;
    private bool _isShowingResult;

    #endregion

    #region Properties

    public Equation Equation { get; private set; }

    public string ResultText
    {
        get => _resultText;
        private set
        {
            _resultText = value;
            Equation.SetOperand(_resultText);
            OnPropertyChanged();
        }
    }

    public string EquationText
    {
        get => _equationText;
        private set
        {
            _equationText = value;
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
        _equationText = string.Empty;
        _resultText = ZERO_STRING;
        Equation = new Equation();
    }

    #endregion

    #region Methods

    public void OnDigitButtonPressed(string digitString)
    {
        if (_isShowingResult)
        {
            Cancel();
        }

        if (!int.TryParse(digitString, out int _))
        {
            return;
        }

        if (ResultText == ZERO_STRING || Equation.Operators.Count == Equation.Operands.Count)
        {
            ResultText = digitString;
        }
        else
        {
            ResultText += digitString;
        }
    }

    public void OnOperatorButtonPressed(string operatorString)
    {
        Equation.SetOperator(operatorString);
        EquationText = Equation.GetEquationText();
        _isShowingResult = false;
    }

    public void OnEqualButtonPressed()
    {
        if (!Equation.IsCalculatable)
        {
            return;
        }

        ResultText = Equation.GetResult().ToString();
        EquationText = string.Empty;
        _isShowingResult = true;
    }

    public void Cancel()
    {
        ResultText = ZERO_STRING;
        Equation = new Equation();
        EquationText = string.Empty;
        _isShowingResult = false;
    }

    public void OnBackspaceButtonPressed()
    {
        if (ResultText == ZERO_STRING || _isShowingResult)
        {
            return;
        }

        ResultText = ResultText.Length == 1 ? ZERO_STRING : ResultText.Remove(ResultText.Length - 1);
    }

    public void SetPoint()
    {
        if (_isShowingResult)
        {
            Cancel();
        }

        if (ResultText.Contains(POINT_STRING))
        {
            return;
        }

        ResultText += POINT_STRING;
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}

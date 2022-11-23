namespace Calculator_WinForms;

public class Equation
{
    #region Properties

    public double FirstOperand { get; set; }

    public double SecondOperand { get; set; }

    public Operator? Operator { get; set; }

    public double? Result { get; set; }

    #endregion

    #region Constructors

    public Equation()
    {
        FirstOperand = 0;
        SecondOperand = 0;
    }

    #endregion
}

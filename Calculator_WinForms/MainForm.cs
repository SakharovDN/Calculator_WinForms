namespace Calculator_WinForms;

using System.ComponentModel;

public partial class MainForm : Form
{
    #region Fields

    private readonly ViewModel _viewModel;

    #endregion

    #region Constructors

    public MainForm()
    {
        _viewModel = new ViewModel();
        _viewModel.PropertyChanged += HandlePropertyChanged;
        InitializeComponent();
    }

    #endregion

    #region Methods

    private void HandlePropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(ViewModel.ResultText):
                resultLabel.Text = _viewModel.ResultText;

                break;
            case nameof(ViewModel.EquationText):
                equationLabel.Text = _viewModel.EquationText;

                break;
        }
    }

    private void digitButton_Click(object sender, EventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        _viewModel.OnDigitButtonPressed(button.Text);
    }

    private void operatorButton_Click(object sender, EventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        _viewModel.OnOperatorButtonPressed(button.Text);
    }

    private void equalButton_Click(object sender, EventArgs e)
    {
        _viewModel.OnEqualButtonPressed();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        _viewModel.Cancel();
    }

    private void backspaceButton_Click(object sender, EventArgs e)
    {
        _viewModel.OnBackspaceButtonPressed();
    }

    private void pointButton_Click(object sender, EventArgs e)
    {
        _viewModel.SetPoint();
    }

    private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (int.TryParse(e.KeyChar.ToString(), out int digit))
        {
            _viewModel.OnDigitButtonPressed(digit.ToString());
        }
        else
        {
            switch (e.KeyChar)
            {
                case '-' or '+' or '/' or '*':
                    _viewModel.OnOperatorButtonPressed(e.KeyChar.ToString());
                    break;
                case ',':
                    _viewModel.SetPoint();
                    break;
                case '\b':
                    _viewModel.OnBackspaceButtonPressed();
                    break;
                case '\u001b':
                    _viewModel.Cancel();
                    break;
                case '=':
                    _viewModel.OnEqualButtonPressed();
                    break;
            }
        }
    }

    #endregion
}

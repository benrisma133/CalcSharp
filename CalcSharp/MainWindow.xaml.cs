using System.Windows;
using System.Windows.Controls;

namespace CalcSharp;

public partial class MainWindow : Window
{
    private double _firstNumber;
    private string _operator = "";
    private bool _newInput = true;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnNumber(object sender, RoutedEventArgs e)
    {
        var btn = (Button)sender;
        if (_newInput)
        {
            DisplayText.Text = btn.Content.ToString();
            _newInput = false;
        }
        else
        {
            DisplayText.Text = DisplayText.Text == "0"
                ? btn.Content.ToString()
                : DisplayText.Text + btn.Content;
        }
    }

    private void OnOperator(object sender, RoutedEventArgs e)
    {
        var btn = (Button)sender;
        _firstNumber = double.Parse(DisplayText.Text);
        _operator = btn.Tag.ToString()!;
        ExpressionText.Text = $"{_firstNumber} {btn.Content}";
        _newInput = true;
    }

    private void OnEquals(object sender, RoutedEventArgs e)
    {
        if (_operator == "") return;

        double second = double.Parse(DisplayText.Text);
        double result = _operator switch
        {
            "+" => _firstNumber + second,
            "-" => _firstNumber - second,
            "*" => _firstNumber * second,
            "/" => second != 0 ? _firstNumber / second : double.NaN,
            _ => 0
        };

        ExpressionText.Text = $"{_firstNumber} {_operator} {second} =";
        DisplayText.Text = double.IsNaN(result) ? "Error" : result.ToString();
        _operator = "";
        _newInput = true;
    }

    private void OnClear(object sender, RoutedEventArgs e)
    {
        DisplayText.Text = "0";
        ExpressionText.Text = "";
        _firstNumber = 0;
        _operator = "";
        _newInput = true;
    }

    private void OnNegate(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(DisplayText.Text, out double val))
            DisplayText.Text = (-val).ToString();
    }

    private void OnPercent(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(DisplayText.Text, out double val))
            DisplayText.Text = (val / 100).ToString();
    }

    private void OnDecimal(object sender, RoutedEventArgs e)
    {
        if (!DisplayText.Text.Contains('.'))
            DisplayText.Text += ".";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Temperature temperature;
        Weight weight;
        Power power;

        double _oneVeriable;
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt16(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.FahrenheitCelsiusResult;
                textBoxResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonCF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.CelsiusFahrenheitResult;
                textBoxResult.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonCK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.CelsiusKelvinRsult;
                textBoxResult.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonKF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.KelvinFahrenheitResult;
                textBoxResult.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonFK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.FahrenheitKelvinResult;
                textBoxResult.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonKC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
                temperature = new Temperature(_oneVeriable);

                result = temperature.KelvinCelsiusResult;
                textBoxResult.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ButtonCenKg_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.CenterKilogrammResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonTonKg_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.TonKilogramResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonTonGr_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.TonGrammResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonTonCen_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.TonCenterResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonKgTon_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.KilogramTonResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonKgGr_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.KilogrammGrammResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonKgCen_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.KilogrammCenterResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonCenTon_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.CenterTonResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonCenGr_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.CenterGrammResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonGrTon_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.GrammTonResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonGrKg_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.GrammKilogrammResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonGrCen_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            weight = new Weight(_oneVeriable);

            result = weight.GrammCenteResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonWattkW_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.WattkWResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonWattmWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.WattmWResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonWattHorsepower_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.WattHorsepowerResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonkWwatt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.kWwattResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonkWmWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.kWmWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonkWHorsepower_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.kWHorsepowerResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonMWtWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.MWtWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonMWtkWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.MWtkWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonMWtHorsepower_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.MWtHorsepowerResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonHorsepowerWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.HorsepowerWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonHorsepowerkWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.HorsepowerkWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }

        private void ButtonHorsepowermWt_Click(object sender, RoutedEventArgs e)
        {
            _oneVeriable = Convert.ToInt32(textBoxVeriable.Text);
            power = new Power(_oneVeriable);

            result = power.HorsepowermWtResult;
            textBoxResult.Text = Convert.ToString(result);
        }
    }
}

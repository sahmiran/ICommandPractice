using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp6
{
    public class ViewModel
    {
        public ICommand MyCommand { get; set; }

        public ViewModel()
        {
            MyCommand = new Command(ExecuteMethode , canExecuteMethode);
        }

        private bool canExecuteMethode(object parameter)
        {
            return true;
        }

        private void ExecuteMethode(object parameter)
        {
            MessageBox.Show("Command executed");
        }
    }
}

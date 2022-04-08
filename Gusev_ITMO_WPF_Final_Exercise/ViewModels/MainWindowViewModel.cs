using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gusev_ITMO_WPF_Final_Exercise.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private int operandStringMaxLength = 10;

        private double operand1;

        private double operand2;

        private double answer;

        private string operation="";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            if (this.PropertyChanged != null)
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }



        public double Operand1
        {
            get
            {
                return operand1;
            }
            set
            {
                operand1 = value;
                OnPropertyChanged();
            }
        }

        public double Operand2
        {
            get
            {
                return operand2;
            }
            set
            {
                operand2 = value;
                OnPropertyChanged();
            }
        }

        public double Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
                OnPropertyChanged();
            }
        }

        public string Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
                OnPropertyChanged();
            }
        }

        public int OperandStringMaxLength
        {
            get
            {
                return operandStringMaxLength;
            }
            set
            {
                operandStringMaxLength = value;
                OnPropertyChanged();
            }
        }

        //public ICommand RadiusToCircumferenceCommand { get; }

        public ICommand DigitOneCommand { get; set; } //1 

        public ICommand DigitTwoCommand { get; set; } //2

        public ICommand DigitThreeCommand { get; set; }

        public ICommand DigitFourCommand { get; set; }

        public ICommand DigitFiveCommand { get; set; }

        public ICommand DigitSixCommand { get; set; }

        public ICommand DigitSevenCommand { get; set; }

        public ICommand DigitEightCommand { get; set; }

        public ICommand DigitNineCommand { get; set; }

        public ICommand ZeroCommand { get; set; }

        public ICommand ClearCommand { get; set; }

        public ICommand SqrtCommand { get; set; }

        public ICommand DivideCommand { get; set; }

        public ICommand MultiplyCommand { get; set; }

        public ICommand MinusCommand { get; set; }

        public ICommand PlusCommand { get; set; }

        public ICommand ReverseXCommand { get; set; }

        public ICommand ProcentCommand { get; set; }

        public ICommand EqualCommand { get; set; }

        //public ICommand RadiusToCircumferenceCommand { get; set; }

    /*    private void OnRadiusToCircumferenceCommandExecute(object p)
        {
            Operand2 = MyMath.GetCircumferenceFromRadius(Operand1);
        }

        private bool CanRadiusToCircumferenceCommandExecuted(object p)
        {
            if (Operand1 >= 0) return true;
            else return false;//
        }*/

        public MainWindowViewModel()
        {

           // RadiusToCircumferenceCommand = new RelayCommand(OnRadiusToCircumferenceCommandExecute, CanRadiusToCircumferenceCommandExecuted);

            DigitOneCommand = new RelayCommand(OnDigitOneCommandExecute, CanDigitOneCommandExecuted);

            DigitTwoCommand = new RelayCommand(OnDigitTwoCommandExecute, CanDigitTwoCommandExecuted);

            DigitThreeCommand = new RelayCommand(OnDigitThreeCommandExecute, CanDigitThreeCommandExecuted);

            DigitFourCommand = new RelayCommand(OnDigitFourCommandExecute, CanDigitFourCommandExecuted);

            DigitFiveCommand = new RelayCommand(OnDigitFiveCommandExecute, CanDigitFiveCommandExecuted);

            DigitSixCommand = new RelayCommand(OnDigitSixCommandExecute, CanDigitSixCommandExecuted);

            DigitSevenCommand = new RelayCommand(OnDigitSevenCommandExecute, CanDigitSevenCommandExecuted);

            DigitEightCommand = new RelayCommand(OnDigitEightCommandExecute, CanDigitEightCommandExecuted);

            DigitNineCommand = new RelayCommand(OnDigitNineCommandExecute, CanDigitNineCommandExecuted);

            ZeroCommand = new RelayCommand(OnZeroCommandExecute, CanZeroCommandExecuted);

            ClearCommand = new RelayCommand(OnClearCommandExecute, CanClearCommandExecuted);

            SqrtCommand = new RelayCommand(OnSqrtCommandExecute, CanSqrtCommandExecuted);

            DivideCommand = new RelayCommand(OnDivideCommandExecute, CanDivideCommandExecuted);

            MultiplyCommand = new RelayCommand(OnMultiplyCommandExecute, CanMultiplyCommandExecuted);

            MinusCommand = new RelayCommand(OnMinusCommandExecute, CanMinusCommandExecuted);

            PlusCommand = new RelayCommand(OnPlusCommandExecute, CanPlusCommandExecuted);

            ReverseXCommand = new RelayCommand(OnReverseXCommandExecute, CanReverseXCommandExecuted);

            ProcentCommand = new RelayCommand(OnProcentCommandExecute, CanProcentCommandExecuted);

            EqualCommand = new RelayCommand(OnEqualCommandExecute, CanEqualCommandExecuted);
        }

        private bool CanEqualCommandExecuted(object arg)
        {
            return true;
        }

        private void OnEqualCommandExecute(object obj)
        {
            Solve();
        }

        private bool CanProcentCommandExecuted(object arg)
        {
            return true;
        }

        private void OnProcentCommandExecute(object obj)
        {
            if (operation != "")
            {
                Solve();
                Operand1 = Answer;
                Operand2 = 0;
            }
            Operation = "%";
            Solve();
        }

        private bool CanReverseXCommandExecuted(object arg)
        {
            if (Operand1 != 0)
                return true;
            else
                return false;
        }

        private void OnReverseXCommandExecute(object obj)
        {
            if (operation != "")
            {
                Solve();
                Operand1 = Answer;
                Operand2 = 0;
            }
            Operation = "1/x";
            Solve();
        }
        private bool CanPlusCommandExecuted(object arg)
        {
            return true;
        }

        private void OnPlusCommandExecute(object obj)
        {
            if (operation == "")
            {
                Operand2 = Operand1;
            }
            else 
            {
                Solve();
                Operand2 = Answer;
                Answer = 0;
            }

            Operation = "+";
            Operand1 = 0;
        }

        private bool CanMinusCommandExecuted(object arg)
        {
            return true;
        }

        private void OnMinusCommandExecute(object obj)
        {
            if (operation == "")
            {
                Operand2 = Operand1;
            }
            else
            {
                Solve();
                Operand2 = Answer;
                Answer = 0;
            }

            Operation = "+";
            Operand1 = 0;
        }

        private bool CanMultiplyCommandExecuted(object arg)
        {
            return true;
        }

        private void OnMultiplyCommandExecute(object obj)
        {
            if (operation == "")
            {
                Operand2 = Operand1;
            }
            else
            {
                Solve();
                Operand2 = Answer;
                Answer = 0;
            }

            Operation = "*";
            Operand1 = 0;
        }

        private bool CanDivideCommandExecuted(object arg)
        {
            if (Operand1 != 0)
                return true;
            else
                return false;
        }

        private void OnDivideCommandExecute(object obj)
        {
            {
                if (operation == "")
                {
                    Operand2 = Operand1;
                }
                else
                {
                    Solve();
                    Operand2 = Answer;
                    Answer = 0;
                }

                Operation = "/";
                Operand1 = 0;
            }
        }

        private bool CanSqrtCommandExecuted(object arg)
        {
            if (Operand1 >= 0)
                return true;
            else
                return false;
        }

        private void OnSqrtCommandExecute(object obj)
        {
            {
                if (operation != "")
                {
                    Solve();
                    Operand1 = Answer;
                    Operand2 = 0;
                }
                Operation = "√";
                Solve();
            }
        }

        private bool CanClearCommandExecuted(object arg)
        {
            return true;
        }

        private void OnClearCommandExecute(object obj)
        {
            Operand1 = 0;
            Operand2 = 0;
            Answer = 0;
            Operation = "";

        }

        private bool CanZeroCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnZeroCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "0");
        }

        private bool CanDigitNineCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitNineCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "9");
        }

        private bool CanDigitEightCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitEightCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "8");
        }

        private bool CanDigitSevenCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitSevenCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "7");
        }

        private bool CanDigitSixCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitSixCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "6");
        }

        private bool CanDigitFiveCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitFiveCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "5");
        }

        private bool CanDigitFourCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitFourCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "4");
        }

        private bool CanDigitThreeCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitThreeCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "3");
        }

        private bool CanDigitTwoCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        private void OnDigitTwoCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "2");
        }

        private void OnDigitOneCommandExecute(object obj)
        {
            Operand1 = Convert.ToDouble(Convert.ToString(Operand1) + "1");
        }

        private bool CanDigitOneCommandExecuted(object arg)
        {
            if ((Convert.ToString(Operand1)).Length < operandStringMaxLength)
                return true;
            else
                return false;
        }

        public void Solve()
        {
            switch (operation)
            {
                case "+":
                    Answer = MyMath.Summ(Operand1, Operand2);
                    break;
                case "-":
                    Answer = MyMath.Subt(Operand1, Operand2);
                    break;
                case "*":
                    Answer = MyMath.Mult(Operand1, Operand2);
                    break;
                case "/":
                    Answer = MyMath.Div(Operand1, Operand2);
                    break;
                case "√":
                    Answer = MyMath.Sqrtt(Operand1);
                    break;
                case "1/x":
                    Answer = MyMath.RevX(Operand1);
                    break;
                case "%":
                    Answer = MyMath.Procent(Operand1);
                    break;
                default:
                    Answer = 0;
                    break;
            }
        }

       
    }
}

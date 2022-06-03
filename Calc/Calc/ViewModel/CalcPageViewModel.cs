using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calc.ViewModel
{
    public class CalcPageViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand AddCommand { protected set; get; }
        public ICommand DiffCommand { protected set; get; }
        public ICommand MultCommand { protected set; get; }
        public ICommand DivCommand { protected set; get; }
        public ICommand NullCommand { protected set; get; }
        public ICommand OneCommand { protected set; get; }
        public ICommand SecondCommand { protected set; get; }
        public ICommand ThirdCommand { protected set; get; }
        public ICommand FourthCommand { protected set; get; }
        public ICommand FiveCommand { protected set; get; }
        public ICommand SixCommand { protected set; get; }
        public ICommand SevenCommand { protected set; get; }
        public ICommand EightCommand { protected set; get; }
        public ICommand NineCommand { protected set; get; }
        public ICommand DelCommand { protected set; get; }
        public ICommand ResCommand { protected set; get; }
        public string Str
        {
            get { return str; }
            set
            {
                str = value;
                OnPropertyChanged("Str");
            }
        }
        public string str = "";
        public CalcPageViewModel()
        {
            AddCommand = new Command(ToAdd);
            DiffCommand = new Command(ToDiff);
            MultCommand = new Command(ToMult);
            DivCommand = new Command(ToDiv);
            NullCommand = new Command(ValueNull);
            OneCommand = new Command(ValueOne);
            SecondCommand = new Command(ValueSecond);
            ThirdCommand = new Command(ValueThird);
            FourthCommand = new Command(ValueFourth);
            FiveCommand = new Command(ValueFive);
            SixCommand = new Command(ValueSix);
            SevenCommand = new Command(ValueSeven);
            EightCommand = new Command(ValueEight);
            NineCommand = new Command(ValueNine);
            DelCommand = new Command(Del);
            ResCommand = new Command(Result);
        }
        private void ValueNull()
        {
            str = str + "0";
            OnPropertyChanged("Str");
        }
        private void ValueOne()
        {
            str = str + "1";
            OnPropertyChanged("Str");
        }
        private void ValueSecond()
        {
            str = str + "2";
            OnPropertyChanged("Str");
        }
        private void ValueThird()
        {
            str = str + "3";
            OnPropertyChanged("Str");
        }
        private void ValueFourth()
        {
            str = str + "4";
            OnPropertyChanged("Str");
        }
        private void ValueFive()
        {
            str = str + "5";
            OnPropertyChanged("Str");
        }
        private void ValueSix()
        {
            str = str + "6";
            OnPropertyChanged("Str");
        }
        private void ValueSeven()
        {
            str = str + "7";
            OnPropertyChanged("Str");
        }
        private void ValueEight()
        {
            str = str + "8";
            OnPropertyChanged("Str");
        }
        private void ValueNine()
        {
            str = str + "9";
            OnPropertyChanged("Str");
        }
        private void ToAdd()
        {
           if (Char.IsDigit(str[str.Length - 1]))
            {
                str = str + "+";
                OnPropertyChanged("Str");
            }
        }

        private void ToDiff()
        {
            if (Char.IsDigit(str[str.Length - 1]))
            {
                str = str + "-";
                OnPropertyChanged("Str");
            }
        }

        private void ToMult()
        {
            if (Char.IsDigit(str[str.Length - 1]))
            {
                str = str + "*";
                OnPropertyChanged("Str");
            }
        }

        private void ToDiv()
        {
            if (Char.IsDigit(str[str.Length - 1]))
            {
                str = str + "/";
                OnPropertyChanged("Str");
            }
        }
        private void Del()
        {
            str = "";
            OnPropertyChanged("Str");
        }

        private void Result()
        {
            if (Char.IsDigit(str[str.Length - 1]))
            {
                Str = Convert.ToDouble(new DataTable().Compute(str, "")).ToString();
                OnPropertyChanged("Str");
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

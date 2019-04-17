using System;
using System.Windows;
using System.Windows.Input;
using Lab1_Mysko.Models;
using Lab1_Mysko.Tools;

namespace Lab1_Mysko.ViewModels
{
    class PickDataViewModel : ObservableItem
    {
        private DateTime _date;
        private string _westernZodiac;
        private string _chineseZodiac;
        private string _birthday;
        private string _age;

        public PickDataModel Model { get; private set; }

        private ICommand _calculateDateCommand;
        private ICommand _addBirthdayCommand;

        public PickDataViewModel()
        {
            Model = new PickDataModel();
            _date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        public DateTime SelectedDate
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged("SelectedDate");
            }
        }

        public string ChineseZodiac
        {
            get => _chineseZodiac;
            set
            {
                _chineseZodiac = value;
                OnPropertyChanged("ChineseZodiac");
            }
        }

        public string WesternZodiac
        {
            get => _westernZodiac;
            set
            {
                _westernZodiac = value;
                OnPropertyChanged("WesternZodiac");
            }
        }
        public string Birthday
        {
            get { return _birthday; }
            set
            {
                _birthday = value;
                OnPropertyChanged();
            }
        }
        public string Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public ICommand CalculateDateCommand
        {
            get
            {
                if (_calculateDateCommand == null)
                    _calculateDateCommand = new RelayCommand(CalulateExecute, CanCalculate);
                return _calculateDateCommand;
            }
        }

        public ICommand AddBirthdayCommand
        {
            get
            {
                if (_addBirthdayCommand == null)
                    _addBirthdayCommand = new RelayCommand(CalulateExecute, CanCalculate);
                return _calculateDateCommand;
            }
        }

        public void CalulateExecute(object obj)
        {
            try
            {
                Age = Model.CalculateAge(SelectedDate);
                Birthday = Model.IsBirthday(SelectedDate);
                ChineseZodiac = Model.CalculateChineseSign(SelectedDate);
                WesternZodiac = Model.CalculateWesternSign(SelectedDate);
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Incorrect input of date !","Error");
                Age = "";
                Birthday = "";
                ChineseZodiac = "";
                WesternZodiac = "";
            }
        }

        public bool CanCalculate(object obj)
        {
            if (SelectedDate.Day <= DateTime.DaysInMonth(SelectedDate.Year, SelectedDate.Month))
                return true;
            MessageBox.Show("Date does not exist !","Error");
            return false;
        }
    }
}
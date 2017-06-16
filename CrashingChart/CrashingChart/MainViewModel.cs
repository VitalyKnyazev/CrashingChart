using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CrashingChart
{
    public sealed class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DataPoint[] m_incomeDataPoints = new DataPoint[0];
        private DataPoint[] m_expensesDataPoints = new DataPoint[0];
        private DataPoint[] m_balanceDataPoints = new DataPoint[0];

        public DataPoint[] IncomeDataPoints
        {
            get => m_incomeDataPoints;
            private set => SetProperty(ref m_incomeDataPoints, value);
        }

        public DataPoint[] ExpensesDataPoints
        {
            get => m_expensesDataPoints;
            private set => SetProperty(ref m_expensesDataPoints, value);
        }

        public DataPoint[] BalanceDataPoints
        {
            get => m_balanceDataPoints;
            private set => SetProperty(ref m_balanceDataPoints, value);
        }

        public MainViewModel()
        {
            IncomeDataPoints = new[]
            {
                new DataPoint {Type = "Income", Category = "May", Value = 1.23M},
                new DataPoint {Type = "Income", Category = "June", Value = 1.25M}
            };

            ExpensesDataPoints = new[]
            {
                new DataPoint {Type = "Expenses", Category = "May", Value = 0.5M},
                new DataPoint {Type = "Expenses", Category = "June", Value = 0.7M}
            };

            BalanceDataPoints = new[]
            {
                new DataPoint {Type = "Balance", Category = "May", Value = 0.83M},
                new DataPoint {Type = "Balance", Category = "June", Value = 0.85M}
            };
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(value, storage))
            {
                storage = value;
                RaisePropertyChanged(propertyName);
            }
        }
    }

    public sealed class DataPoint
    {
        public string Type { get; set; }
        public string Category { get; set; }
        public decimal Value { get; set; }
    }
}
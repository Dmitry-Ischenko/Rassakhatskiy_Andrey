using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1Company.Annotations;

namespace WpfApp1Company.Models
{
    /// <summary>
    /// Курс
    /// </summary>
    class Courses : INotifyPropertyChanged
    {
        private string _name;
        /// <summary>
        /// Название курса
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Name)));
            }
        }
        public Courses(string name)
        {
            _name = name;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

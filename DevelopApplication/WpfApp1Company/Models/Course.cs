using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1Company.Annotations;

namespace WpfApp1Company.Models
{
    /// <summary> Курс </summary>
    class Course : INotifyPropertyChanged
    {
        private string _name;
        /// <summary> Название курса </summary>
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
        protected IEnumerable<Student> _students;
        public virtual IEnumerable<Student> Students => _students.Where(s => s.Course == this);

        public Course(string name, IEnumerable<Student> students)
        {
            _name = name;
            _students = students;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

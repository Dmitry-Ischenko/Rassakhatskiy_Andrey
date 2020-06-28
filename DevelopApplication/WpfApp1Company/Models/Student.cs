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
    /// <summary> Ученик </summary>
    class Student : INotifyPropertyChanged
    {
        private string _fam;
        /// <summary> Фамилия </summary>
        public string Fam
        {
            get => _fam;
            set
            {
                if (value == _fam) return;
                _fam = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Fam)));
            }
        }
        private string _name;
        /// <summary> Имя </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this._name)));
            }
        }
        private DateTime _birthday;
        /// <summary> День рождения </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value == _birthday) return;
                _birthday = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Birthday)));
            }
        }
        private int _progress;
        /// <summary> Успеваемость </summary>
        public int Progress
        {
            get => _progress;
            set
            {
                if (value == _progress) return;
                _progress = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Progress)));
            }
        }
        private Course _course;
        /// <summary> Курс </summary>
        public Course Course
        {
            get => _course;
            set
            {
                if (value == _course) return;
                _course = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Course)));
            }
        }
        public Student(string fam, string name, DateTime birthday, int progress)
        {
            _fam = fam;
            _name = name;
            _birthday = birthday;
            _progress = progress;
        }
        public Student(string fam, string name, DateTime birthday, int progress, Course course) : this(fam, name, birthday, progress)
        {
            _course = course;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

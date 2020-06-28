using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1Company.Models
{
    /// <summary> Гигбрейнсы </summary>
    class Geekbrains
    {
        public ObservableCollection<Course> Courses { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public Geekbrains(int sizeCours, int sizeStud)
        {
            Random random = new Random();
            Courses = new ObservableCollection<Course>();
            Students = new ObservableCollection<Student>();
            Courses.Add(new NoCourse(Students));
            for (int i = 0; i < sizeCours; i++)
                Courses.Add(new Course($"Курс продвинутый C# {i}", Students));
            for (int i = 0; i < sizeStud; i++)
                Students.Add(new Student($"Бут {i}", $"Сергей {i}", new DateTime( random.Next(1900,2000), random.Next(1,10),random.Next(1,10) ), random.Next(5), Courses[random.Next(Courses.Count)] ));
        }
        /// <summary>
        /// Новый курс
        /// </summary>
        /// <param name="newCourse"></param>
        public void AddCourse(Course newCourse)
        {
            if (newCourse == null) return;
            Courses.Add(newCourse);
        }
        /// <summary>
        /// Удаление курса
        /// </summary>
        /// <param name="newCourse"></param>
        public void DelCourse(Course delCourse)
        {
            if (delCourse == null) return;
            if (delCourse is NoCourse)
            {
                MessageBox.Show("Нулевой курс удалить нельзя!");
                return;
            }
            if (Students.Count(s => s.Course == delCourse) > 0)
            {
                MessageBox.Show("На этом курсе еще учатся несколько учеников!");
                return;
            }
            Courses.Remove(delCourse);
        }
        /// <summary> Новый ученик </summary>
        /// <param name="newStudent"></param>
        public void AddStudent(Student newStudent)
        {
            if (newStudent == null) return;
            Students.Add(newStudent);
        }
        /// <summary> Исключение ученика </summary>
        /// <param name="delStudent"></param>
        public void DelStudent(Student delStudent)
        {
            if (delStudent == null) return;
            Students.Remove(delStudent);
        }
    }
}

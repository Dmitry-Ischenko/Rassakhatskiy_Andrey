using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1Company.Models
{
    class NoCourse : Course
    {
        /// <summary> Нулевый курс </summary>
        /// <param name="students"></param>
        public NoCourse(IEnumerable<Student> students) : base("<без курса>", students)
        {
        }

        public override IEnumerable<Student> Students
        {
            get => _students.Where(s => s.Course == null);
        }
    }
}

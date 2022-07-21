using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace VGlinskii.WPF.Lab9._1_DataBindingDemo.StudentList
{

        public class Student
        {
            public string StudentName { get; set; }
            public bool IsEnrolled { get; set; }
        }

    public class StudentList : ObservableCollection<Student>
    {
    }


}

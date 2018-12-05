using MVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<StudentModel> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<StudentModel> students = new ObservableCollection<StudentModel>();

            students.Add(new StudentModel { FirstName = "Mark", LastName = "Allain" });
            students.Add(new StudentModel { FirstName = "Allen", LastName = "Brown" });
            students.Add(new StudentModel { FirstName = "Linda", LastName = "Hamerski" });

            Students = students;
        }
    }
}

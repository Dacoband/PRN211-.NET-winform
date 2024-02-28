using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Student
    {//put Property here, ToString()
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        // NGUYỄN MINH THỨC 1 2 3 4 5 6 SE170295 THUCNMSE17O295 
        public override string ToString() => $"Student: {Id} | {Name} | {Email} | {Yob} | {Gpa}";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_ÖVningGenrics
{
    internal class StudentSameProp: EqualityComparer<Student>
    {
        public override bool Equals(Student U1,Student U2)
        {
           if(U1.ID == U2.ID && U1.Grade == U2.Grade && U1.Total == U2.Total)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode(Student s)
        {
            return s.GetHashCode();
        }
    }
}

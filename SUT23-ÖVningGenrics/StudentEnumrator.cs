using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_ÖVningGenrics
{
    internal class StudentEnumrator: IEnumerator<Student>
    {
        private StudentCollection _stdents;
        private int currentIndex;
        private Student currentStudent;


        public StudentEnumrator(StudentCollection student)
        {
            this._stdents = student;
            currentIndex = -1;
            currentStudent = default(Student);
        }


        public Student Current { get { return currentStudent; } }

        object IEnumerator.Current { get { return Current; } }


        public int count
        {
            get { return _stdents.Count; }
        }

        public bool MoveNext()
        {
            if(++currentIndex >= _stdents.Count)
            {
                return false;
            }
            else
            {
                currentStudent = _stdents[currentIndex];
            }
            return true;
        }

        void IEnumerator.Reset()
        {
            currentIndex = -1;
        }

        public void Dispose() { }
    }
}

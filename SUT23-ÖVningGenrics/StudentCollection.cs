using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_ÖVningGenrics
{
    internal class StudentCollection : ICollection<Student>
    {
        private List<Student> innerCollection;

        public StudentCollection()
        {
            innerCollection = new List<Student>();
        }

        public bool IsReadOnly { get {  return false; } }


        public Student this[int index]
        {
            get { return (Student)innerCollection[index]; }
            set { innerCollection[index] = value;}

        }
        public void Add(Student item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine(" This student is allready exist in the collection");
            }
        }




        public bool Contains(Student item)
        {
            bool found = false;
            foreach (Student s in innerCollection)
            {
                if (s.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public bool Contains(Student item, EqualityComparer<Student> comp)
        {
            bool found = false;
            foreach (Student s in innerCollection)
            {
                if (comp.Equals(s, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return new StudentEnumrator(this);
        }

        public bool Remove(Student item)
        {
            bool result = false;
            for(int i =0; i < innerCollection.Count; i++)
            {
                Student currentStudent = innerCollection[i];
                if(new StudentSameProp().Equals(currentStudent, item))
                {
                    innerCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StudentEnumrator(this);
        }

        public int Count
        {
            get
            {
                return innerCollection.Count;
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }
    }
}

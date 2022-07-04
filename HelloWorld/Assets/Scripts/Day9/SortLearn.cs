using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIRO.Practices.Day9
{

public class SortLearn : MonoBehaviour
    {
        private ArrayList studentArr;
        private SortedList studentList;
        private void Start()
        {
            //studentArr = new ArrayList();
            //studentArr.Add(new Student("A", 10,5));
            //studentArr.Add(new Student("T", 9,7));
            //studentArr.Add(new Student("C", 17,4));
            //studentArr.Add(new Student("H", 19,9));
            //studentArr.Add(new Student("B", 21,9));
            //studentArr.Sort(2,3,new StudentSort());

            //foreach(Student student in studentArr)
            //{
            //    Debug.Log(student.name);
            //}


            studentList = new SortedList(new StudentSort());
            //studentList.Add("x", 3);
            //studentList.Add("c", "f");

            studentList.Add(new Student("H", 45, 2), 3);
            studentList.Add(new Student("f", 12, 0), "f");

            foreach (DictionaryEntry temp in studentList)
            {
                Student student = (Student)temp.Key;
                Debug.Log($"Key: {student.age} Value {temp.Value}");
            }
        }

    }

    public class Student
    {
        public string name;
        public int age;
        public int classRoom;
        public Student(string name, int age, int classroom)
        {
            this.name = name;
            this.age = age;
            this.classRoom = classroom;
        }
    }
    public class StudentSort : IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;

            //if (string.Compare(s1.name,s2.name) < 0)
            //    return -1;
            //else if (string.Compare(s1.name, s2.name) > 0)
            //    return 1;
            //else
            //    return 0;

            if (s1.age < s2.age)
                return -1;
            else if (s1.age > s2.age)
                return 1;
            else
                return 0;
        }
    }
}

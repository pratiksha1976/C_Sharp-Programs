using System;
using System.Collections.Generic;
using System.Linq;

class Student
    {
        private string _name;
        private int _problemCount;

        public Student(string name, int problemCount)
        {
            _name = name;
            _problemCount = problemCount;
        }

        public string Name
        {
            get { return _name; }
        }

        public int ProblemCount
        {
            get { return _problemCount; }
        }

        public static Func<Student, bool> CountLessThan100()
        {
            return student => student.ProblemCount < 100;
        }

        public static Func<Student, bool> CountBet100to200()
        {
            return student => student.ProblemCount >= 100 && student.ProblemCount <= 200;
        }

        public static Func<Student, bool> CountGreaterThan200()
        {
            return student => student.ProblemCount > 200;
        }
    }

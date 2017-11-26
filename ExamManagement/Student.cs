using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement
{
    enum Level
    {
        Level1,
        Level2,
        Level3,
        Level4
    };

    class Student
    {
        #region Properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int MinimumAge { get; private set; }
        public Level StudentLevel { get; set; }
#endregion

        #region Statics
        private static int age;
#endregion

        #region Constructor
        public Student()
        {
            MinimumAge = 6;
        }
        #endregion

        #region Methods
        //Methods need to be defined
#endregion
    }
}

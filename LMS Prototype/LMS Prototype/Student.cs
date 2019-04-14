using CourseNamespace;

namespace StudentNamespace
{
    public class Student
    {
        //All variables and classes must be private (removed extra "student" from variable names because it's repetitive)
        private string name;
        private int ID;
        private string password;
        private double GPA;
        private bool account;
        private Course course1;
        private Course course2;
        private Course course3;

        public Student()
        {
            //Assign dummy values.
            name = "dummy";
            ID = 0000000001;
            GPA = 0.5;
            course1 = new Course();
            course2 = new Course();
            course3 = new Course();
        }
        public Student(string name, int ID, string password, double GPA, bool account)
        {
            this.name = name;
            this.ID = ID;
            this.password = password;
            this.GPA = GPA;
            this.account = account;

            //Add three courses
            course1 = new Course();
            course2 = new Course();
            course3 = new Course();
        }
        public string getName()
        {
            return name;
        }
        public int getID()
        {
            return ID;
        }
        
        public double getGPA()
        {
            return GPA;
        }
        public bool getAccount()
        {
            return account;
        }

        public Course getCourse1()
        {
            return course1;
        }

        public Course getCourse2()
        {
            return course2;
        }

        public Course getCourse3()
        {
            return course3;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        
        public void setGPA(double GPA)
        {
            this.GPA = GPA;
        }
        public void setAccount(bool account)
        {
            this.account = account;
        }
        //public void account()
        //{

        //}
        public void logIn()
        {

        }
        public void logOff()
        {

        }
        public void viewRecord()
        {

        }
    }
}
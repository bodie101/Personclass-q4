using System;

namespace personq4
{
    class Student : Person
    {
    public int SID {get; set;}
    public string Campus {get; set;}

    public Student (string firstName, string lastName, string campus, DateTime dob) : base(firstName, lastName, dob) {
        Campus = campus;
    }

    public string GetCampus() {
        return $"{Campus}";
    }
      

//enerate random student ID
        public void EnrollStudent() {

            var rand = new Random();
            SID = rand.Next(1000, 9999);
        }

        public override string PersonInfo() {
            return $"Person: {GetFullName()} of {GetCampus()} campus has a student id of {SID}";
        }
    }
}
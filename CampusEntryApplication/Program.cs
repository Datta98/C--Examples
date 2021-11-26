using System;

namespace CampusEntryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentid = new Student("shridatta", "22 / 05 / 1198", "16u108350", "Bca", "8095956531", "Hubli");
            Staff staffid = new Staff("Kumar", "24 / 03 / 1991", "Junior Assistant", "6363899781", "vidya Nagar");
            Teacher teacherid = new Teacher("Kiran", " 08 / 11 / 1989", "Computer Science","Assistant Lecture" ,"9884885244", "Gadag");            
            Guest guestid = new Guest("Darshan", " 15 / 8 / 1987", "9986789878", "HOD", "Laxmi colony");

        }

    }
}

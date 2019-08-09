using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    public class Session
    {
        private int Id;

        private DateTime starting;

        private DateTime ending;

        private Course course;
        private int courseId;

        //private ArrayList<User> students;

        //private ArrayList<RateSession> ratesSession;

        //private ArrayList<RateStudent> ratesStudents;

        private User trainer;
    }
}

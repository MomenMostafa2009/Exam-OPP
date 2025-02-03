using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exam.q;

namespace Exam
{
    internal class Ex
    {
        public abstract class Exam
        {
            public DateTime TimeOfExam {get;set;}
            public int NumberOfQuestions {get;set;}
            public List<Question> Questions {get;set;} = new List<Question>();
            public Exam(DateTime timeOfExam,int numberOfQuestions)
            {
                TimeOfExam = timeOfExam;
                NumberOfQuestions = numberOfQuestions;
            }

            public abstract void ShowExam();
        }
        public class FinalExam:Exam
        {
            public FinalExam(DateTime timeOfExam, int numberOfQuestions): base(timeOfExam, numberOfQuestions)
            {
            }

            public override void ShowExam()
            { }
        }
        public class PracticalExam : Exam
        {
            public PracticalExam(DateTime timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
            { }
            public override void ShowExam()
            { }
        }
        public class Subject
        { public int SubjectId {get;set;}
            public string SubjectName {get;set;}
            public Exam SubjectExam {get;set;}

            public Subject(int subjectId,string subjectName)
            {
                SubjectId = subjectId;
                SubjectName = subjectName;
            }

            public void CreateExam(Exam exam)
            {
                SubjectExam = exam;
            }
        }


    }
}

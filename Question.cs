using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class q
    {
        public abstract class Question
        {
            public string Header {get;set;}
            public string Body {get;set;}
            public int Mark {get;set;}
            public Answer[] AnswerList {get;set;}
            public Answer RightAnswer {get;set;}

            public Question(string header,string body,int mark)
            {
                Header = header;
                Body = body;
                Mark = mark;
            }
            public abstract void ShowQuestion();
        }
        public class FinalQuestion:Question
        { public enum QuestionType {TrueFalse,MCQ}
            public QuestionType Type {get;set;}

            public FinalQuestion(string header, string body, int mark, QuestionType type): base(header, body, mark)
            {Type = type;}

            public override void ShowQuestion()
            {
            }
        }
        public class PracticalQuestion:Question
        {
            public PracticalQuestion(string header, string body, int mark): base(header, body, mark)
            {
            }
            public override void ShowQuestion()
            {
            }
        }
        public class Answer
        {public int AnswerId { get; set; }
         public string AnswerText { get; set; }

            public Answer(int answerId,string answerText)
            {
                AnswerId = answerId;
                AnswerText = answerText;
            }
        }


    }
}

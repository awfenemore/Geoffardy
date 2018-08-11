using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geoffardy
{
    class Question
    {
        //Question string
        private String questionString;

        //Boolean for answered status. False when question has not been answered
        private Boolean answeredStatus;

        //List of potential answers
        private List<String> answers;

        //Points value of the question
        private int points;



        //Constructor. Takes delimited string and populates question string and suggested answer list
        public Question (String delimitedString)
        {
            //TODO
            answeredStatus = false;
            answers = new List<string>();
        }


        //Returns the question String
        public String getQuestionString ()
        {
            return questionString;
        }


        //Returns a list of Strings of suggested answers
        public List<string> getAnswers ()
        {
            return answers;
        }


        //Sets the question to answered
        public void setAnswered ()
        {
            answeredStatus = true;
        }

        //Gets the points value
        public int getPoints()
        {
            return points;
        }
    }
}

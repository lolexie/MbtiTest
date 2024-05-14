using System.Collections.Generic;
using System.Linq;

namespace MbtiTest
{
    public class QuestionBlock
    {
        private Dictionary<string, string> _profileTypes;
        private Question[] _questions;
        private int[] _answers = new int[5];

        public QuestionBlock(Dictionary<string, string> profileTypes, Question[] questions)
        {
            _profileTypes = profileTypes;
            _questions = questions;
        }

        public KeyValuePair<string, string> GetProfileType()
        {
            int firstLetter = _answers.Count(ans => ans <= 2);
            int secondLetter = _answers.Count(ans => ans >= 3);
            if (firstLetter > secondLetter)
            {
                return _profileTypes.First();
            }
            else return _profileTypes.Last();
        }

        public void PushAnswer(int answer, int index)
        {
            _answers[index] = answer;
        }

        public int[] GetAnswers() { return _answers; }
        public Question[] GetQuestions() { return _questions; }
        public Dictionary<string, string> GetProfileTypes() { return _profileTypes; }
    }
}

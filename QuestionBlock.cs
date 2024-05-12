using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbtiTest
{
    internal class QuestionBlock
    {
        private Dictionary<string, string> _profileTypes;
        private Question[] _questions;
        private int _score = 0;

        public QuestionBlock(Dictionary<string, string> profileTypes, Question[] questions)
        {
            _profileTypes = profileTypes;
            _questions = questions;
        }

        public void UpdateScore(int score)
        {
            _score += score;
        }

        public string GetProfileType()
        {
            if (_score < 10)
            {
                return _profileTypes.First().Key;
            }
            else
            {
                return _profileTypes.Last().Key;
            }
        }

        public int GetScore() { return _score; }
        public Question[] GetQuestions() { return _questions; }
        public Dictionary<string, string> GetProfileTypes() { return _profileTypes; }
    }
}

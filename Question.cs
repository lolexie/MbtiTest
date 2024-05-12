using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MbtiTest
{
    internal class Question
    {
        private string _text;
        private string[] _answers;

        public Question(string text, string[] answers)
        {
            _text = text;
            _answers = answers;
        }

        public string GetText()
        {
            return _text;
        }

        public string[] GetAnswers()
        {
            return _answers;
        }

    }
}

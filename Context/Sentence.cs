using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Sentence
    {
        public Sentence(string original)
        {

        }

        public bool IsMeaningAct(string act, bool isTrue = true)
            => IsMeaningAct(new Act(act), isTrue);

        public bool IsMeaningAct(Act act, bool isTrue = true)
            => throw new NotImplementedException();

        public Act GetAct(string act)
            => throw new NotImplementedException();

        public bool IsAskingAct(string act, AskingType type)
            => throw new NotImplementedException();
    }
}

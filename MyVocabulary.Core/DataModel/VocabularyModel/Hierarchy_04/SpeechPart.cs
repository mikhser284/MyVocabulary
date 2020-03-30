using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class SpeechPart : BaseObj
    {
        public Language Lang { get; set; }

        public SpeechPart Ancestor { get; set; }

        public List<SpeechPart> Descendants { get; set; }
    }
}

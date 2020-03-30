using System;
using System.Collections.Generic;

namespace MyVocabulary.Core
{
    public class Word : PrimitiveObj
    {
        public Language Lang { get; set; }

        public SpeechPart PartOfSpeech { get; set; }

        public Boolean? IsBaseForm { get; set; }

        public Word BaseForm { get; set; }

        public String Writing { get; set; }

        public String Speeling { get; set; }

        public String Remarks { get; set; }

        public List<Word> Synonims { get; set; }

    }
}

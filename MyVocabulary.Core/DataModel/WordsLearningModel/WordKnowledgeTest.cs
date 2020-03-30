using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class WordKnowledgeTest : PrimitiveObj
    {
        public Int32 OrdinalNumber { get; set; }
        public Int32 NoOfRepetition { get; set; }
        public Int32 NoOfAttemptToPassCurrentRepetition { get; set; }
        public String ExpectedAnswer { get; set; }
        //? Не прийдется ли обновлять поле в случае обновления самого слова
        public WordWnowledgeTestAnswer UserAnswer { get; set; }
    }

    public class WordWnowledgeTestAnswer : PrimitiveObj
    {
        public DateTime TestStartedAt { get; set; }
        public String AnswerOfUser { get; set; }
        public String UserRemarks { get; set; }
        public Boolean UserRemarksIsComplain { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public Boolean AnswerIsCorrect { get; set; }
        public Int32 TestScore { get; set; }
    }
}

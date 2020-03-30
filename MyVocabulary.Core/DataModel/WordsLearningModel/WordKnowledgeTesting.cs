using System;
using System.Collections.Generic;

namespace MyVocabulary.Core
{
    public class WordKnowledgeTesting : PrimitiveObj
    {
        public Word WordToLearn { get; set; }
        public User TestedUser { get; set; }
        public List<WordKnowledgeTest> TestingHistory { get; set; }
        public Int32? LearningPriorityOfUser { get; set; }
        public Int32? LearningPriorityOfSheduler { get; set; }        
        public Int32 AttemptsTotal { get; set; }
        public Int32 AttemptsSussesfuly { get; set; }
        public Int32 AttemptsUnsussesfuly { get; set; }
        public DateTime? TestSheduledAt { get; set; }
        public DateTime? TestIsNotActualTill { get; set; }
        public TimeSpan? TestIsNotActualAfter { get; set; }
        public ELearningDifficulty? DifficultyOfLearning { get; private set; }
        public TimeSpan? ElapsedTime { get; set; }
        public TimeSpan? WorseTime { get; set; }
        public TimeSpan? BestTime { get; set; }
        public TimeSpan? AverageTime { get; set; }        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class Directory : BaseObj
    {
        public List<Directory> ChildDirectories { get; set; }

        public List<WordsContainer> WordContainers { get; set; }
    }
}

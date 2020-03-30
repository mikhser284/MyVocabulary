using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class BaseObj : PrimitiveObj, IBaseObj
    {
        public String ObjTitle { get; set; }

        public String ObjDescription { get; set; }
    }
}

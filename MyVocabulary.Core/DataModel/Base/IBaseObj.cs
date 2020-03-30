using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public interface IBaseObj : IPrimitiveObj
    {
        String ObjTitle { get; set; }

        String ObjDescription { get; set; }
    }
}

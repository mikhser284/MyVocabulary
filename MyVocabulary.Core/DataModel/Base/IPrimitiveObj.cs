using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public interface IPrimitiveObj
    {
        Guid ObjId { get; set; }

        DateTime ObjCreatedOn { get; set; }

        User ObjCreatedBy { get; set; }

        DateTime ObjUpdatedOn { get; set; }

        User ObjUpdatedBy { get; set; }

        DateTime ObjDeletedOn { get; set; }

        User ObjDeletedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class PrimitiveObj : IPrimitiveObj
    {
        public Guid ObjId { get; set; }

        public DateTime ObjCreatedOn { get; set; }

        public User ObjCreatedBy { get; set; }

        public DateTime ObjUpdatedOn { get; set; }

        public User ObjUpdatedBy { get; set; }

        public DateTime ObjDeletedOn { get; set; }

        public User ObjDeletedBy { get; set; }
    }
}

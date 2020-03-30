using System;
using System.Collections.Generic;
using System.Text;

namespace MyVocabulary.Core
{
    public class User : IBaseObj
    {
        public Guid ObjId { get; set; }

        public DateTime ObjCreatedOn { get; set; }

        public User ObjCreatedBy { get; set; }

        public DateTime ObjUpdatedOn { get; set; }

        public User ObjUpdatedBy { get; set; }

        public String ObjTitle { get; set; }

        public String ObjDescription { get; set; }
    }
}

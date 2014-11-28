﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Glossary
{
    public class BO
    {
        [DataContract]
        public class Word
        {
            [DataMember]
            public Int64 ID { get; set; }

            [DataMember]
            public string English { get; set; }

            [DataMember]
            public string Persian { get; set; }

            [DataMember]
            public string Description { get; set; }

            [DataMember]
            public List<Word_Details> Details { get; set; }

            [DataMember]
            public List<Tags> Tags { get; set; }
        }



        [DataContract]
        public class Word_Details
        {
            [DataMember]
            public string Body { get; set; }
            [DataMember]

            public int Kind { get; set; }
        }



        [DataContract]
        public class Tags
        {
            [DataMember]
            public Int64 Id { get; set; }
            [DataMember]
            public string Title { get; set; }
         
            public Int64 Pid { get; set; }

        }
    }

}

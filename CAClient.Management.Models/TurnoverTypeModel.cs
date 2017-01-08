﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CAClient.Management.Models
{
    [DataContract]
    public class TurnoverTypeModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string TurnOverType { get; set; }

        [DataMember]
        public DateTime DateUpdated { get; set; }
    }
}

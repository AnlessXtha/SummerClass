﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerClass.Domain.Shared
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime LastModificationTime { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime DeletionTime { get; set; }
        public Guid DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}

﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserOperationClaim : BaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

    }
}
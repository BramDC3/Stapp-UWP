﻿using System.Collections.Generic;

namespace stappBackend.Models
{
    public class Customer : User
    {
        public List<EstablishmentSubscription> Subscriptions { get; set; } = new List<EstablishmentSubscription>();
    }
}

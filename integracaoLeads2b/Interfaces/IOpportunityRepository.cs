﻿using integracaoLeads2b.Entities;

namespace integracaoLeads2b.Interfaces
{
    public interface IOpportunityRepository
    {
        public void Add(Opportunity leads);
        public int SaveChanges();
    }
}

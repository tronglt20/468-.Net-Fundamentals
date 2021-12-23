﻿using _468_.Net_Fundamentals.Domain.Entities;
using _468_.Net_Fundamentals.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _468_.Net_Fundamentals.Domain.Interface.Services
{
    public interface IProjectService
    {
        public Task Create(ProjectCreateVM request);
        public Task<IList<Project>> GetAll();
        public Task<ProjectVM> Get(int id);
        public Task Update(int id, string name);
        public Task Delete(int id);

       

    }
}



﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia10.Services
{
    public interface IDbServices
    {
        public void PromoteStudents();

        public void Update();
        public void Delete();

    }
}

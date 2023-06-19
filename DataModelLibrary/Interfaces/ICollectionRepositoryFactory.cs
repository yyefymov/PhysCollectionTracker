﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModelLibrary.Interfaces
{
    public interface ICollectionRepositoryFactory
    {
        ICollectionRepository<T> Create<T>() where T : class;
    }
}

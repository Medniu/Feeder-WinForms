﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface ICreateUser : IView
    {
        event Action AddUser;
        string CharacterName { get;  }
    }
}

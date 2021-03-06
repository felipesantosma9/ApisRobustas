﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories.Base;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogo : IRepositoryBase<Jogo, Guid>
    {
        
    }
}

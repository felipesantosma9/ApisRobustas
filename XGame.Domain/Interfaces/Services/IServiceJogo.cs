using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Interfaces.Services.Base;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogo : IServiceBase
    {
        IEnumerable<JogoResponse> ListarJogo();
        AdicionarJogoResponse AdicionarJogo(AdicionarJogoRequest request);
        ResponseBase AlterarJogo(AlterarJogoRequest request);
        ResponseBase ExcluirJogo(Guid id);
    }
}

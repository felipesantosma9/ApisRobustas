using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Jogo
{
    public class AdicionarJogoResponse
    {
        public string Message { get; set; }
        public Guid Id { get; set; }

        public static explicit operator AdicionarJogoResponse(Entities.Jogo entidade)
        {
            return new AdicionarJogoResponse()
            {
                Id = entidade.Id,
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}

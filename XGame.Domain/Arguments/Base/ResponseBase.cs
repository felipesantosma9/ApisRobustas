using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO;
        }

        public static explicit operator ResponseBase(Entities.Jogo entidade)
        {
            return new ResponseBase()
            {
                Message = Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando .....");

            var service = new ServiceJogador();

            Console.WriteLine("Criei instância do servico.");

            //AutenticarJogadorRequest autenticarRequest = new AutenticarJogadorRequest();
            //Console.WriteLine("Criei instância do objeto request.");
            //autenticarRequest.Email = "paula@paula.com";
            //autenticarRequest.Senha = "123456789";

            //var AdicionarRequest = new AdicionarJogadorRequest()
            //{
            //    Email = "paula@hotmail.com",
            //    PrimeiroNome = "Paula Santos",
            //    UltimoNome = "Dantas Sousa",
            //    Senha = "123456"
            //};

            //var response = service.AutenticarJogador(autenticarRequest);

            //var response2 = service.AdicionarJogador(AdicionarRequest);

            var result = service.ListarJogador();

            Console.WriteLine("Serviço é válido -> " + service.IsValid());

            service.Notifications.ToList().ForEach(x => {
                Console.WriteLine(x.Message);
            });

            //if (service.IsValid())
            //{
            //    return response;
            //}

            //service.Notifications.Count

            Console.ReadKey();
        }
    }
}

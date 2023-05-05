using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigPatterns2.Cap6
{
    internal class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}

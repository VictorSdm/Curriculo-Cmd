using System;

namespace Curriculo_Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            int tel;
            int nascimento;
            int ende;
            int cep;
            int numecasa;
            string nome;
            string nacio;
            string status;
            string email;
            string objetivo;
            string formaçao;
            string Xp;
            string Ccp;

            Console.WriteLine("olá," +
                "Vamos começar seu cadastro completo");
            Console.WriteLine("Digite seu nome:");
        nome: Console.ReadLine();
            Console.WriteLine("Qual sua nacinalidade?;");
        nacio: Console.ReadLine();
            Console.WriteLine("Qual seu estado Civil?");
        status: Console.ReadLine();
            Console.WriteLine("Qual sua data de nascimento?");
        nascimento: Console.ReadLine();
            Console.WriteLine("Qual é seu endereço?");
        ende: Console.ReadLine();
            Console.WriteLine("Número da Casa:");
        numecasa: Console.ReadLine();
            Console.WriteLine("CEP:");
        cep: Console.ReadLine();
            Console.WriteLine("Telefone para contato:");
        tel: Console.ReadLine();
            Console.WriteLine("Email para contato:");
        email: Console.ReadLine();
            Console.WriteLine("Qual é seu objetivo profissional?");
        objetivo: Console.ReadLine();
            Console.WriteLine("Qua é sua Formação acadêmica?");
        formaçao: Console.ReadLine();
            Console.WriteLine("Possui experiência profissional?");
        Xp: Console.ReadLine();
            Console.WriteLine("Para fechar pressione qualquer tecla");
            Console.ReadKey();
        }
    }
}

using AgendaContato.ArquivoClasses;
using System.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

List<Contato> contatos = new List<Contato>();

bool programaRodando = true;

while (programaRodando)
{
    Console.WriteLine("1. Adicionar Contato\n2. Listar Contatos\n3. Sair\n");

    int.TryParse(Console.ReadLine(), out int opcao);

    switch (opcao)
    {
        case 1:
            //bool contatoInvalido = true;
           
            bool nomeValido = false;
            bool telefoneValido = false;
            Contato novoContato = new Contato();

            while (!nomeValido)
            {
                Console.WriteLine("Informar nome:\n");
                nomeValido = novoContato.TentarDefinirNome(Console.ReadLine());
                if (!nomeValido) Console.WriteLine("Nome inválido. Tente novamente.\n");
            }

            while (!telefoneValido)
            {
                Console.WriteLine("Informar telefone:\n");
                telefoneValido = novoContato.TentarDefinirTelefone(Console.ReadLine());
                if (!telefoneValido) Console.WriteLine("Número inválido. Tente novamente.\n");                
            }
            contatos.Add(novoContato);

            break;

        case 2:
            if (contatos.Any())
            {
                foreach (var cont in contatos)
                {
                    Console.WriteLine($"Nome: {cont.Nome}\nTelefone: {cont.Telefone}\n");
                }
            }
            else
            {
                Console.WriteLine("Lista vazia!\n\nAdicione um contato.\n");
            }
            
            break;

        case 3:
            Console.WriteLine("Programa encerrado.\n");
            programaRodando = false;
            break;

        default:
            Console.WriteLine("Opção inválida.\n\nDigite:\n");
            break;
    }
}



using EFCore_Introducao.Entidades;
using System;
using System.Linq;

namespace EFCore_Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando sistema...");

            AppDbContext db = new AppDbContext();

            #region INSERT
            //Cliente cliente = new Cliente()
            //{
            //    Nome = "Caio Nolasco",
            //    Data_Nascimento = new DateTime(1990, 7, 24)
            //};
            //db.Cliente.Add(cliente);

            //cliente = new Cliente()
            //{
            //    Nome = "Aluno",
            //    Data_Nascimento = new DateTime(2024, 3, 4)
            //};
            //db.Cliente.Add(cliente);

            //db.SaveChanges();
            #endregion


            #region SELECT
            var clientes = db.Cliente.ToList();
            foreach (var item in clientes)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Data de Nascimento: {item.Data_Nascimento}");
            }

            Console.WriteLine("_----------------------_");

            var clienteSelecionado = clientes.Where(x => x.Id == 1).First();
            Console.WriteLine("Item Selecionado: " +clienteSelecionado.Nome);
            #endregion


            #region UPDATE
            clienteSelecionado.Nome = "Torao";
            db.Entry<Cliente>(clienteSelecionado);
            db.SaveChanges();
            #endregion


            #region DELETE
            db.Attach(clienteSelecionado);
            db.Remove(clienteSelecionado);
            db.SaveChanges();
            #endregion

            Console.WriteLine("Fim do sistema...");

            Console.ReadKey();
        }
    }
}

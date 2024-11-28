using System;
using System.Collections.Generic;

class Equipamento {
    public int Numero { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public string NumeroSerie { get; set; }
    public DateTime DataFabricacao { get; set; }
    public string Fabricante { get; set; }
    public DateTime DataUltimaManutencao { get; set; }
}

class Program {
    static List<Equipamento> equipamentos = new List<Equipamento>();

    static void Main() {
        while (true) {
            Console.WriteLine("1. Login");
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (login == "admin" && senha == "1234") {
                MenuPrincipal();
                break;
            }
        }
    }

    static void MenuPrincipal() {
        int opcao;
        do {
            Console.WriteLine("\n1. Registrar Equipamento");
            Console.WriteLine("2. Visualizar Equipamentos");
            Console.WriteLine("3. Editar Equipamento");
            Console.WriteLine("4. Excluir Equipamento");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1: RegistrarEquipamento(); break;
                case 2: VisualizarEquipamentos(); break;
                case 3: EditarEquipamento(); break;
                case 4: ExcluirEquipamento(); break;
            }
        } while (opcao != 5);
    }

    static void RegistrarEquipamento() {
        Equipamento eq = new Equipamento();
        Console.Write("Nome do Equipamento: ");
        eq.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        eq.Preco = decimal.Parse(Console.ReadLine());
        Console.Write("Número de Série: ");
        eq.NumeroSerie = Console.ReadLine();
        Console.Write("Data de Fabricação (yyyy-MM-dd): ");
        eq.DataFabricacao = DateTime.Parse(Console.ReadLine());
        Console.Write("Fabricante: ");
        eq.Fabricante = Console.ReadLine();
        Console.Write("Data da Última Manutenção (yyyy-MM-dd): ");
        eq.DataUltimaManutencao = DateTime.Parse(Console.ReadLine());

        eq.Numero = equipamentos.Count + 1;
        equipamentos.Add(eq);
    }

    static void VisualizarEquipamentos() {
        foreach (var eq in equipamentos) {
            Console.WriteLine($"Número: {eq.Numero}, Nome: {eq.Nome}, Preço: {eq.Preco}, Número de Série: {eq.NumeroSerie}, Data de Fabricação: {eq.DataFabricacao.ToShortDateString()}, Fabricante: {eq.Fabricante}, Última Manutenção: {eq.DataUltimaManutencao.ToShortDateString()}");
        }
    }

    static void EditarEquipamento() {
        Console.Write("Informe o número do equipamento para editar: ");
        int num = int.Parse(Console.ReadLine());
        var eq = equipamentos.Find(e => e.Numero == num);

        if (eq != null) {
            Console.Write("Nome: ");
            eq.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            eq.Preco = decimal.Parse(Console.ReadLine());
            Console.Write("Número de Série: ");
            eq.NumeroSerie = Console.ReadLine();
            Console.Write("Data de Fabricação (yyyy-MM-dd): ");
            eq.DataFabricacao = DateTime.Parse(Console.ReadLine());
            Console.Write("Fabricante: ");
            eq.Fabricante = Console.ReadLine();
            Console.Write("Data da Última Manutenção (yyyy-MM-dd): ");
            eq.DataUltimaManutencao = DateTime.Parse(Console.ReadLine());
        }
    }

    static void ExcluirEquipamento() {
        Console.Write("Informe o número do equipamento para excluir: ");
        int num = int.Parse(Console.ReadLine());
        var eq = equipamentos.Find(e => e.Numero == num);

        if (eq != null) {
            equipamentos.Remove(eq);
            Console.WriteLine("Equipamento excluído.");
        }
    }
}

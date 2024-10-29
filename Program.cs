using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João");
Pessoa p2 = new Pessoa(nome: "Maria");
Pessoa p3 = new Pessoa(nome: "Bernardo");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new Suite(tipoSuite: "Star Plus", capacidade: 5, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 8);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria().ToString("F2")}");
using System.Numerics;

Console.WriteLine("Atividade Reservatório de Água");

Random rnd = new();
int nivelAgua = random.Next(0, 101);
bool bombaLigada = false;
int ciclosBomba = 0;

Console.WriteLine($"Nível atual da água: {nivelAgua}%");

if (nivelAgua <= 20)
{
  Console.WriteLine("Boia A: O reservatório está quase vazio. Estamos ligando a bomba...");
  bombaLigada = true;
}
else if (nivelAgua >= 80)
{
  Console.WriteLine("Boia B: O reservatório está quase cheio. Não é necessário estar ligando a bomba.");
  bombaLigada = false;
}
else
{
  Console.WriteLine("O Nível de água atual está estável, não é necessário que acione a bomba.");
}

bool erroBoias = random.Next( 0, 10) < 2;

if  (erroBoias)
{
  Console.WriteLine("Erro: As boias indicam informações contraditórias.");
  Console.WriteLine("Manutenção necessária nas boias.");
}
else
{
  Console.WriteLine("As boias estão funcionando corretamente");
}

if (!erroBoias)
{
  Console.WriteLine("\nDeseja ligar ou desligar a bomba manualmente? (1 - Ligar, 2 - Desligar, 3 - Manter o estado atual)");
  string input = Console.ReadLine();
}

if (input == 1);
{
  bombaLigada = true;
  Console.Write("A bomba foi ligada Manualmente.");
}
else if (input == "2")
{
  bombaLigada = false;
  Console.WriteLine("A bomba foi desligada Manualmente.");
}

if (bombaligada)
{
  ciclosBomba++;
  Console.WriteLine($"A bomba está ligada. Ciclos da bomba: {ciclosBomba}");
}
else
{
  Console.WriteLine("A bomba está desligada.");
}
}

// See https://aka.ms/new-console-template for more information
using Calculadora;

CalculadoraImpl Calc = new CalculadoraImpl();

string operacao;
float v1;
float v2;

while (true) {
  Console.Clear();

  Console.WriteLine("(+) Soma");
  Console.WriteLine("(-) Subtração");
  Console.WriteLine("(*) Multiplicação");
  Console.WriteLine("(/) Divisão");
  Console.WriteLine("(q) Sair");
  Console.Write("Escolha a operação: ");
  operacao = Console.ReadLine() ?? "+";

  if(operacao.Equals("q")) break;

  try {
    var operacaoSelecionada = Calc.GetType().GetMethod(Calc.getOperacoes()[operacao]);

    if (operacaoSelecionada != null){
      Console.WriteLine("Primeiro Valor: ");
      v1 = float.Parse(Console.ReadLine() ?? "0");
      Console.WriteLine("Segundo Valor: ");
      v2 = float.Parse(Console.ReadLine() ?? "0");

      var resultado = operacaoSelecionada.Invoke(Calc, new object[] {v1, v2});
      Console.WriteLine($"resultado: {resultado}");
      Console.WriteLine("aperte qualquer tecla para continuar operando");
      Console.ReadKey();
    } 
  } catch (System.Exception) {
    Console.WriteLine("Operação não encontrada, aperte qualquer tecla e tente dnv");
    Console.ReadKey();
  }
}


namespace Calculadora
{
  abstract class CalculadoraAbstrato {
    Dictionary<string, string> operacoes = new Dictionary<string, string> {
      ["+"] = "Soma",
      ["-"] = "Subtracao",
      ["*"] = "Multiplicacao",
      ["/"] = "Divisao",
    };

    public Dictionary<string, string> getOperacoes(){
      return this.operacoes;
    }

    public abstract float Soma(float val1, float val2);
    public abstract float Subtracao(float val1, float val2);
    public abstract float Multiplicacao(float val1, float val2);
    public abstract float Divisao(float val1, float val2);
  }
}

namespace Calculadora
{
  class CalculadoraImpl : CalculadoraAbstrato {
    public override float Soma(float val1, float val2) {
      float resultado = val1 + val2;

      return resultado;
    }

    public override float Subtracao(float val1, float val2) {
      return val1 - val2;
    }

    public override float Multiplicacao(float val1, float val2) {
      return val1 * val2;
    }

    public override float Divisao(float val1, float val2) {
      return val1 / val2;
    }
  }
}


using DevelopmentChallenge.Data.Infrastructure;

namespace DevelopmentChallenge.Data.Core
{
  public class TrapecioRectangulo : FormaGeometrica
  {
    private readonly decimal _baseMayor;
    private readonly decimal _baseMenor;
    private readonly decimal _altura;
    private readonly decimal _ladoInclinado;

    public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoInclinado)
        : base(altura)
    {
      _baseMayor = baseMayor;
      _baseMenor = baseMenor;
      _altura = altura;
      _ladoInclinado = ladoInclinado;
    }

    public override string Nombre(int idioma, int cantidad)
    {
      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Trapecio"] : TraduccionesHelper.Traducciones[idioma]["Trapecio"] + "s";
    }

    public override decimal CalcularArea() => ((_baseMayor + _baseMenor) / 2) * _altura;

    public override decimal CalcularPerimetro() => _baseMayor + _baseMenor + _altura + _ladoInclinado;
  }
}
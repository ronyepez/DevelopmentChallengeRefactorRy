using DevelopmentChallenge.Data.Infrastructure;

namespace DevelopmentChallenge.Data.Core
{
  public class Trapecio : FormaGeometrica
  {
    private readonly decimal _baseMayor;
    private readonly decimal _baseMenor;
    private readonly decimal _altura;
    private readonly decimal _lado1;
    private readonly decimal _lado2;

    public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        : base(altura)
    {
      _baseMayor = baseMayor;
      _baseMenor = baseMenor;
      _altura = altura;
      _lado1 = lado1;
      _lado2 = lado2;
    }

    public override string Nombre(int idioma, int cantidad)
    {
      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Trapecio"] : TraduccionesHelper.Traducciones[idioma]["Trapecio"] + "s";
    }

    public override decimal CalcularArea() => ((_baseMayor + _baseMenor) / 2) * _altura;

    public override decimal CalcularPerimetro() => _baseMayor + _baseMenor + _lado1 + _lado2;
  }
}
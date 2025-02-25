using DevelopmentChallenge.Data.Infrastructure;
using System.Globalization;

namespace DevelopmentChallenge.Data.Core
{
  public class Cuadrado : FormaGeometrica
  {
    public Cuadrado(decimal lado) : base(lado) { }

    public override string Nombre(CultureInfo culture, int cantidad)
    {
      return ResourceHelper.ObtenerTextoPluralizado("Cuadrado", culture.TwoLetterISOLanguageName, cantidad);
    }

    public override decimal CalcularArea() => _lado * _lado;

    public override decimal CalcularPerimetro() => _lado * 4;
  }
}
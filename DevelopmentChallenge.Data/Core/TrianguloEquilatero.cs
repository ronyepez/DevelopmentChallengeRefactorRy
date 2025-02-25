using DevelopmentChallenge.Data.Infrastructure;
using System;
using System.Globalization;

namespace DevelopmentChallenge.Data.Core
{
  public class TrianguloEquilatero : FormaGeometrica
  {
    public TrianguloEquilatero(decimal lado) : base(lado) { }

    public override string Nombre(CultureInfo culture, int cantidad)
    {
      return ResourceHelper.ObtenerTextoPluralizado("Triángulo", culture.TwoLetterISOLanguageName, cantidad);
    }

    public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

    public override decimal CalcularPerimetro() => _lado * 3;
  }
}
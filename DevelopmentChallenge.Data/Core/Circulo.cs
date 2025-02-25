using DevelopmentChallenge.Data.Infrastructure;
using System;
using System.Globalization;

namespace DevelopmentChallenge.Data.Core
{
  public class Circulo:FormaGeometrica
  {
    public Circulo(decimal radio) : base(radio) { }

    public override string Nombre(CultureInfo culture, int cantidad)
    {
      return ResourceHelper.ObtenerTextoPluralizado("Círculo", culture.TwoLetterISOLanguageName, cantidad);
    }

    public override decimal CalcularArea() => (decimal)Math.PI * (_lado / 2) * (_lado / 2);

    public override decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
  }
}

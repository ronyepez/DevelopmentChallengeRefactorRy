using DevelopmentChallenge.Data.Infrastructure;
using System.Globalization;

namespace DevelopmentChallenge.Data.Core
{
  public class Rectangulo : FormaGeometrica
  {
    private readonly decimal _ancho;
    private readonly decimal _alto;

    public Rectangulo(decimal ancho, decimal alto) : base(ancho)
    {
      _ancho = ancho;
      _alto = alto;
    }

    public override string Nombre(CultureInfo culture, int cantidad)
    {
      return ResourceHelper.ObtenerTextoPluralizado("Rectangulo", culture.TwoLetterISOLanguageName, cantidad);
    }

    public override decimal CalcularArea() => _ancho * _alto;

    public override decimal CalcularPerimetro() => 2 * (_ancho + _alto);

  }
}
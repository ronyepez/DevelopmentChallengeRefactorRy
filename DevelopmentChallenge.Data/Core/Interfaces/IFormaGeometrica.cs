using System.Globalization;

namespace DevelopmentChallenge.Data.Core.Interfaces
{
  public interface IFormaGeometrica
  {
    string Nombre(CultureInfo culture, int cantidad);

    decimal CalcularArea();

    decimal CalcularPerimetro();
  }
}

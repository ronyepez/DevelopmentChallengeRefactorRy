using System.Globalization;
using DevelopmentChallenge.Data.Core.Interfaces;

namespace DevelopmentChallenge.Data.Core
{
  public abstract class FormaGeometrica : IFormaGeometrica
  {
    protected decimal _lado;

    protected FormaGeometrica(decimal lado)
    {
      _lado = lado;
    }

    public abstract string Nombre(CultureInfo culture, int cantidad);

    public abstract decimal CalcularArea();

    public abstract decimal CalcularPerimetro();

  }
}

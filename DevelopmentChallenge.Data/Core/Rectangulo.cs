using DevelopmentChallenge.Data.Infrastructure;

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

    public override string Nombre(int idioma, int cantidad)
    {
      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Rectangulo"] : TraduccionesHelper.Traducciones[idioma]["Rectangulo"] + "s";
    }

    public override decimal CalcularArea() => _ancho * _alto;

    public override decimal CalcularPerimetro() => 2 * (_ancho + _alto);
  }
}
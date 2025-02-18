using DevelopmentChallenge.Data.Infrastructure;

namespace DevelopmentChallenge.Data.Core
{
  public class Cuadrado : FormaGeometrica
  {
    public Cuadrado(decimal lado) : base(lado) { }

    public override string Nombre(int idioma, int cantidad)
    {
      if (idioma == 3)
        return cantidad == 1 ? "Quadrato" : "Quadrati";

      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Cuadrado"] : TraduccionesHelper.Traducciones[idioma]["Cuadrado"] + "s";
    }

    public override decimal CalcularArea() => _lado * _lado;

    public override decimal CalcularPerimetro() => _lado * 4;
  }
}
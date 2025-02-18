using DevelopmentChallenge.Data.Infrastructure;
using System;

namespace DevelopmentChallenge.Data.Core
{
  public class Circulo:FormaGeometrica
  {
    public Circulo(decimal radio) : base(radio) { }

    public override string Nombre(int idioma, int cantidad)
    {
      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Círculo"] : TraduccionesHelper.Traducciones[idioma]["Círculo"] + "s";
    }

    public override decimal CalcularArea() => (decimal)Math.PI * (_lado / 2) * (_lado / 2);

    public override decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
  }
}

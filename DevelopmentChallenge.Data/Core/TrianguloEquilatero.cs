using DevelopmentChallenge.Data.Infrastructure;
using System;

namespace DevelopmentChallenge.Data.Core
{
  public class TrianguloEquilatero : FormaGeometrica
  {
    public TrianguloEquilatero(decimal lado) : base(lado) { }

    public override string Nombre(int idioma, int cantidad)
    {
      return cantidad == 1 ? TraduccionesHelper.Traducciones[idioma]["Triángulo"] : TraduccionesHelper.Traducciones[idioma]["Triángulo"] + "s";
    }

    public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
    public override decimal CalcularPerimetro() => _lado * 3;
  }
}
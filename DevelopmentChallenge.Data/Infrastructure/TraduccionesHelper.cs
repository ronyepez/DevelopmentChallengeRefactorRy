using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Infrastructure
{
  public static class TraduccionesHelper
  {
    public static readonly Dictionary<int, Dictionary<string, string>> Traducciones =
        new Dictionary<int, Dictionary<string, string>>
        {
                {
                    1, new Dictionary<string, string>
                    {
                        { "Reporte", "Reporte de Formas" },
                        { "Total", "TOTAL" },
                        { "Perimetro", "Perímetro" },
                        { "Área", "Área" },
                        { "Cuadrado", "Cuadrado" },
                        { "Círculo", "Círculo" },
                        { "Triángulo", "Triángulo" },
                        { "Trapecio", "Trapecio" },
                        { "Rectangulo", "Rectángulo" }
                    }
                },
                {
                    2, new Dictionary<string, string>
                    {
                        { "Reporte", "Shapes Report" },
                        { "Total", "TOTAL" },
                        { "Perimetro", "Perimeter" },
                        { "Área", "Area" },
                        { "Cuadrado", "Square" },
                        { "Círculo", "Circle" },
                        { "Triángulo", "Triangle" },
                        { "Trapecio", "Trapezoid" },
                        { "Rectangulo", "Rectangle" }
                    }
                },
                {
                    3, new Dictionary<string, string>
                    {
                        { "Reporte", "Rapporto sulle Forme" },
                        { "Total", "TOTALE" },
                        { "Perimetro", "Perimetro" },
                        { "Área", "Area" },
                        { "Cuadrado", "Quadrato" },
                        { "Círculo", "Cerchio" },
                        { "Triángulo", "Triangolo" },
                        { "Trapecio", "Trapezio" },
                        { "Rectangulo", "Rettangolo" },
                        { "formas", "forme" }
                    }
                }
        };
  }
}

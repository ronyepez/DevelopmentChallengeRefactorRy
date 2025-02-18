using DevelopmentChallenge.Data.Core.Interfaces;
using DevelopmentChallenge.Data.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Application
{
  public class ReporteService
  {
    public static string Imprimir(List<IFormaGeometrica> formas, int idioma)
    {
      var sb = new StringBuilder();
      if (!formas.Any())
      {
        sb.Append($"<h1>{(idioma == 1 ? "Lista vacía de formas!" : idioma == 3 ? "Rapporto sulle Forme" : "Empty list of shapes!")}</h1>");
        return sb.ToString();
      }

      sb.Append($"<h1>{TraduccionesHelper.Traducciones[idioma]["Reporte"]}</h1>");

      var resumen = formas.GroupBy(f => f.GetType().Name)
                          .Select(g => new
                          {
                            Nombre = g.First().Nombre(idioma, g.Count()),
                            Cantidad = g.Count(),
                            Area = g.Sum(f => f.CalcularArea()),
                            Perimetro = g.Sum(f => f.CalcularPerimetro())
                          });

      foreach (var item in resumen)
      {
        sb.Append($"{item.Cantidad} {item.Nombre} | {TraduccionesHelper.Traducciones[idioma]["Área"]} {item.Area:#.##} | {TraduccionesHelper.Traducciones[idioma]["Perimetro"]} {item.Perimetro:#.##} <br/>");
      }

      sb.Append($"{TraduccionesHelper.Traducciones[idioma]["Total"]}:<br/>");
      string palabraFormas = idioma == 3 ? "forme" : (idioma == 1 ? "formas" : "shapes");
      sb.Append($"{formas.Count} {palabraFormas} ");
      sb.Append($"{TraduccionesHelper.Traducciones[idioma]["Perimetro"]} {formas.Sum(f => f.CalcularPerimetro()):#.##} ");
      sb.Append($"{TraduccionesHelper.Traducciones[idioma]["Área"]} {formas.Sum(f => f.CalcularArea()):#.##}");

      return sb.ToString();
    }
  }
}

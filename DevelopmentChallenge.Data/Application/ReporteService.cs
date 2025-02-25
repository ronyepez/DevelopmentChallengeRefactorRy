using DevelopmentChallenge.Data.Core.Interfaces;
using DevelopmentChallenge.Data.Infrastructure;
using DevelopmentChallenge.Data.Infrastructure.Resources;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace DevelopmentChallenge.Data.Application
{
  public class ReporteService
  {
    public static string Imprimir(List<IFormaGeometrica> formas, string idioma)
    {
      var sb = new StringBuilder();
      var culture = new CultureInfo(idioma);

      ResourceManager rm = new ResourceManager(typeof(Strings));

      if (!formas.Any())
      {
        sb.Append($"<h1>{rm.GetString("Reporte", culture)}</h1>");
        return sb.ToString();
      }

      sb.Append($"<h1>{rm.GetString("Reporte", culture)}</h1>");

      var resumen = formas.GroupBy(f => f.GetType().Name)
          .Select(g => new
          {
            Nombre = g.First().Nombre(culture, g.Count()),  
            Cantidad = g.Count(),
            Area = g.Sum(f => f.CalcularArea()),
            Perimetro = g.Sum(f => f.CalcularPerimetro())
          });

      foreach (var item in resumen)
      {
        sb.Append($"{item.Cantidad} {item.Nombre} | {rm.GetString("Área", culture)} {item.Area:#.##} | {rm.GetString("Perimetro", culture)} {item.Perimetro:#.##} <br/>");
      }

      sb.Append($"{rm.GetString("Total", culture)}:<br/>");
      sb.Append($"{formas.Count} {ResourceHelper.ObtenerTexto("Formas", culture.TwoLetterISOLanguageName)} ");
      sb.Append($"{rm.GetString("Perimetro", culture)} {formas.Sum(f => f.CalcularPerimetro()):#.##} ");
      sb.Append($"{rm.GetString("Área", culture)} {formas.Sum(f => f.CalcularArea()):#.##}");

      return sb.ToString();
    }
  }
}

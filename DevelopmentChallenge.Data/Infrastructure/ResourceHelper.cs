using System.Globalization;
using System.Resources;
using DevelopmentChallenge.Data.Infrastructure.Resources;

namespace DevelopmentChallenge.Data.Infrastructure
{
  public static class ResourceHelper
  {
    private static readonly ResourceManager resourceManager = new ResourceManager(typeof(Strings));

    public static string ObtenerTexto(string clave, string idioma)
    {
      string valor = resourceManager.GetString(clave, new CultureInfo(idioma));
      return string.IsNullOrEmpty(valor) ? $"[{clave}]" : valor;
    }

    public static string ObtenerTextoPluralizado(string clave, string idioma, int cantidad)
    {
      string valorSingular = ObtenerTexto(clave, idioma);
      if (cantidad == 1) return valorSingular;

      string valorPlural = ObtenerTexto($"{clave}_Plural", idioma);

      return string.IsNullOrEmpty(valorPlural) ? $"{valorSingular}s" : valorPlural;
    }
  }
}

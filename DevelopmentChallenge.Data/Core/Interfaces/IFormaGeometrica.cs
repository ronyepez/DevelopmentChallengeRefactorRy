namespace DevelopmentChallenge.Data.Core.Interfaces
{
  public interface IFormaGeometrica
  {
    string Nombre(int idioma, int cantidad);
    decimal CalcularArea();
    decimal CalcularPerimetro();
  }
}

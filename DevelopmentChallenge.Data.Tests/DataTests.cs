using DevelopmentChallenge.Data.Application;
using DevelopmentChallenge.Data.Core;
using DevelopmentChallenge.Data.Core.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests
{
  [TestFixture]
  public class DataTests
  {
    [TestCase]
    public void TestResumenListaVacia()
    {
      Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), 1));
    }

    [TestCase]
    public void TestResumenListaVaciaFormasEnIngles()
    {
      Assert.AreEqual("<h1>Empty list of shapes!</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), 2));
    }

    [TestCase]
    public void TestResumenListaConUnCuadrado()
    {
      var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };
      var resumen = ReporteService.Imprimir(cuadrados, 1);
      Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 25", resumen);
    }

    [TestCase]
    public void TestResumenListaConMasCuadrados()
    {
      var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
      var resumen = ReporteService.Imprimir(cuadrados, 2);
      Assert.AreEqual("<h1>Shapes Report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
    }

    [TestCase]
    public void TestResumenListaConMasTipos()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
      var resumen = ReporteService.Imprimir(formas, 2);
      Assert.AreEqual("<h1>Shapes Report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65", resumen);
    }

    [TestCase]
    public void TestResumenListaConMasTiposEnCastellano()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
      var resumen = ReporteService.Imprimir(formas, 1);
      Assert.AreEqual("<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>3 Triángulos | Área 49.64 | Perímetro 51.6 <br/>TOTAL:<br/>7 formas Perímetro 97.66 Área 91.65", resumen);
    }

    [TestCase]
    public void TestResumenListaVaciaFormasEnItaliano()
    {
      Assert.AreEqual("<h1>Rapporto sulle Forme</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), 3));
    }

    [TestCase]
    public void TestResumenListaConMasCuadradosEnItaliano()
    {
      var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
      var resumen = ReporteService.Imprimir(cuadrados, 3);
      Assert.AreEqual("<h1>Rapporto sulle Forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTALE:<br/>3 forme Perimetro 36 Area 35", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecio()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6, 4, 3, 5, 5)
            };
      var resumen = ReporteService.Imprimir(formas, 1);
      Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 15 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Área 15", resumen);
    }

    [TestCase]
    public void TestResumenListaConRectangulo()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(4, 6)
            };
      var resumen = ReporteService.Imprimir(formas, 2);
      Assert.AreEqual("<h1>Shapes Report</h1>1 Rectangle | Area 24 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 24", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecioYRectanguloEnItaliano()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6, 4, 3, 5, 5),
                new Rectangulo(4, 6)
            };
      var resumen = ReporteService.Imprimir(formas, 3);
      Assert.AreEqual("<h1>Rapporto sulle Forme</h1>1 Trapezio | Area 15 | Perimetro 20 <br/>1 Rettangolo | Area 24 | Perimetro 20 <br/>TOTALE:<br/>2 forme Perimetro 40 Area 39", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecioRectangulo()
    {
      var formas = new List<IFormaGeometrica>
            {
                new TrapecioRectangulo(6, 4, 3, 5)
            };

      var resumen = ReporteService.Imprimir(formas, 1);

      Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Área 15 | Perímetro 18 <br/>TOTAL:<br/>1 formas Perímetro 18 Área 15", resumen);
    }
  }
}
using DevelopmentChallenge.Data.Application;
using DevelopmentChallenge.Data.Core;
using DevelopmentChallenge.Data.Core.Interfaces;
using DevelopmentChallenge.Data.Infrastructure;
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
      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), "es"));
    }

    [TestCase]
    public void TestResumenListaVaciaFormasEnIngles()
    {
      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "en")}</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), "en"));
    }

    [TestCase]
    public void TestResumenListaConUnCuadrado()
    {
      var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

      var resumen = ReporteService.Imprimir(cuadrados, "es");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>1 {ResourceHelper.ObtenerTexto("Cuadrado", "es")} | {ResourceHelper.ObtenerTexto("Área", "es")} 25 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 <br/>{ResourceHelper.ObtenerTexto("Total", "es")}:<br/>1 {ResourceHelper.ObtenerTexto("Formas", "es")} {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 {ResourceHelper.ObtenerTexto("Área", "es")} 25", resumen);
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

      var resumen = ReporteService.Imprimir(cuadrados, "en");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "en")}</h1>3 {ResourceHelper.ObtenerTexto("Cuadrado", "en")}s | {ResourceHelper.ObtenerTexto("Área", "en")} 35 | {ResourceHelper.ObtenerTexto("Perimetro", "en")} 36 <br/>{ResourceHelper.ObtenerTexto("Total", "en")}:<br/>3 {ResourceHelper.ObtenerTexto("Formas", "en")} {ResourceHelper.ObtenerTexto("Perimetro", "en")} 36 {ResourceHelper.ObtenerTexto("Área", "en")} 35", resumen);
    }

    [TestCase]
    public void TestResumenListaConMasTipos()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(2.03m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

      var resumen = ReporteService.Imprimir(formas, "en");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "en")}</h1>2 {ResourceHelper.ObtenerTexto("Cuadrado", "en")}s | {ResourceHelper.ObtenerTexto("Área", "en")} 29 | {ResourceHelper.ObtenerTexto("Perimetro", "en")} 28 <br/>2 {ResourceHelper.ObtenerTexto("Círculo", "en")}s | {ResourceHelper.ObtenerTexto("Área", "en")} 9.18 | {ResourceHelper.ObtenerTexto("Perimetro", "en")} 15.02 <br/>3 {ResourceHelper.ObtenerTexto("Triángulo", "en")}s | {ResourceHelper.ObtenerTexto("Área", "en")} 49.64 | {ResourceHelper.ObtenerTexto("Perimetro", "en")} 51.6 <br/>{ResourceHelper.ObtenerTexto("Total", "en")}:<br/>7 {ResourceHelper.ObtenerTexto("Formas", "en")} {ResourceHelper.ObtenerTexto("Perimetro", "en")} 94.62 {ResourceHelper.ObtenerTexto("Área", "en")} 87.82", resumen);
    }

    [TestCase]
    public void TestResumenListaConMasTiposEnCastellano()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(2.03m),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

      var resumen = ReporteService.Imprimir(formas, "es");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>2 {ResourceHelper.ObtenerTexto("Cuadrado", "es")}s | {ResourceHelper.ObtenerTexto("Área", "es")} 29 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 28 <br/>2 {ResourceHelper.ObtenerTexto("Círculo", "es")}s | {ResourceHelper.ObtenerTexto("Área", "es")} 9.18 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 15.02 <br/>3 {ResourceHelper.ObtenerTexto("Triángulo", "es")}s | {ResourceHelper.ObtenerTexto("Área", "es")} 49.64 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 51.6 <br/>{ResourceHelper.ObtenerTexto("Total", "es")}:<br/>7 {ResourceHelper.ObtenerTexto("Formas", "es")} {ResourceHelper.ObtenerTexto("Perimetro", "es")} 94.62 {ResourceHelper.ObtenerTexto("Área", "es")} 87.82", resumen);
    }

    [TestCase]
    public void TestResumenListaVaciaFormasEnItaliano()
    {
      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "it")}</h1>",
          ReporteService.Imprimir(new List<IFormaGeometrica>(), "it"));
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

      var resumen = ReporteService.Imprimir(cuadrados, "it");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "it")}</h1>3 {ResourceHelper.ObtenerTexto("Cuadrado", "it")}i | {ResourceHelper.ObtenerTexto("Área", "it")} 35 | {ResourceHelper.ObtenerTexto("Perimetro", "it")} 36 <br/>{ResourceHelper.ObtenerTexto("Total", "it")}:<br/>3 {ResourceHelper.ObtenerTexto("Formas", "it")} {ResourceHelper.ObtenerTexto("Perimetro", "it")} 36 {ResourceHelper.ObtenerTexto("Área", "it")} 35", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecio()
    {
      var formas = new List<IFormaGeometrica>
            {
                new Trapecio(6, 4, 3, 5, 5)
            };

      var resumen = ReporteService.Imprimir(formas, "es");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>1 {ResourceHelper.ObtenerTexto("Trapecio", "es")} | {ResourceHelper.ObtenerTexto("Área", "es")} 15 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 <br/>{ResourceHelper.ObtenerTexto("Total", "es")}:<br/>1 {ResourceHelper.ObtenerTexto("Formas", "es")} {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 {ResourceHelper.ObtenerTexto("Área", "es")} 15", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecioRectangulo()
    {
      var formas = new List<IFormaGeometrica>
            {
                new TrapecioRectangulo(6, 4, 3, 5)
            };

      var resumen = ReporteService.Imprimir(formas, "es");

      Assert.AreEqual($"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>1 {ResourceHelper.ObtenerTexto("Trapecio", "es")} | {ResourceHelper.ObtenerTexto("Área", "es")} 15 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 18 <br/>{ResourceHelper.ObtenerTexto("Total", "es")}:<br/>1 {ResourceHelper.ObtenerTexto("Formas", "es")} {ResourceHelper.ObtenerTexto("Perimetro", "es")} 18 {ResourceHelper.ObtenerTexto("Área", "es")} 15", resumen);
    }

    [TestCase]
    public void TestResumenListaConTrapecioYRectanguloEnItaliano()
    {
      var formas = new List<IFormaGeometrica>
      {
          new Trapecio(6, 4, 3, 5, 5),
          new Rectangulo(4, 6)
      };

      var resumen = ReporteService.Imprimir(formas, "it");

      Assert.AreEqual(
          $"<h1>{ResourceHelper.ObtenerTexto("Reporte", "it")}</h1>1 {ResourceHelper.ObtenerTexto("Trapecio", "it")} | {ResourceHelper.ObtenerTexto("Área", "it")} 15 | {ResourceHelper.ObtenerTexto("Perimetro", "it")} 20 <br/>1 {ResourceHelper.ObtenerTexto("Rectangulo", "it")} | {ResourceHelper.ObtenerTexto("Área", "it")} 24 | {ResourceHelper.ObtenerTexto("Perimetro", "it")} 20 <br/>{ResourceHelper.ObtenerTexto("Total", "it")}:<br/>2 {ResourceHelper.ObtenerTexto("Formas", "it")} {ResourceHelper.ObtenerTexto("Perimetro", "it")} 40 {ResourceHelper.ObtenerTexto("Área", "it")} 39",
          resumen);
    }

    [TestCase]
    public void TestResumenListaConRectangulo()
    {
      var formas = new List<IFormaGeometrica>
      {
          new Rectangulo(4, 6)
      };

      var resumen = ReporteService.Imprimir(formas, "es");

      Assert.AreEqual(
          $"<h1>{ResourceHelper.ObtenerTexto("Reporte", "es")}</h1>1 {ResourceHelper.ObtenerTexto("Rectangulo", "es")} | {ResourceHelper.ObtenerTexto("Área", "es")} 24 | {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 <br/>{ResourceHelper.ObtenerTexto("Total", "es")}:<br/>1 {ResourceHelper.ObtenerTexto("Formas", "es")} {ResourceHelper.ObtenerTexto("Perimetro", "es")} 20 {ResourceHelper.ObtenerTexto("Área", "es")} 24",
          resumen);
    }

  }
}
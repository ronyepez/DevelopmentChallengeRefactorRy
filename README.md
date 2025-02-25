# 📌 Development Challenge - Formas Geométricas

## 📖 Descripción del Proyecto

Este proyecto es una aplicación modular que genera reportes de formas geométricas en distintos idiomas, utilizando principios de **Clean Architecture**, **SOLID** y patrones de diseño. Está desarrollado en **.NET Framework 4.6.2**.

## 🚀 Arquitectura del Proyecto

La solución sigue un enfoque de **arquitectura en capas** con los siguientes módulos:

### **1️⃣ Core (Dominio)**

Contiene la lógica de negocio principal:

- `IFormaGeometrica.cs` → Define la interfaz base para todas las formas geométricas.
- `FormaGeometrica.cs` → Clase abstracta base que implementa `IFormaGeometrica`.
- Clases concretas de formas geométricas:
  - `Cuadrado.cs`
  - `Circulo.cs`
  - `TrianguloEquilatero.cs`
  - `Trapecio.cs`
  - `TrapecioRectangulo.cs`
  - `Rectangulo.cs`

### **2️⃣ Application (Servicios y Negocio)**

- `ReporteService.cs` → Servicio que genera reportes de formas en distintos idiomas.

### **3️⃣ Infrastructure (Soporte y Utilidades)**

- `TraduccionesHelper.cs` → Contiene diccionarios con traducciones en español, inglés e italiano.
- `Strings.resx, Strings.en.resx, Strings.it.resx` → Archivos de recursos para traducciones en español, inglés e italiano.

### **4️⃣ Tests (Pruebas Unitarias)**

- `DataTests.cs` → Pruebas unitarias que validan los reportes generados.

---

## 🔹 **Manejo de Idiomas con Recursos (.resx)**

El sistema de traducciones se ha mejorado utilizando archivos de recursos (.resx), en lugar de diccionarios estáticos.

**Implementación:**

1. Se han creado los archivos Strings.resx, Strings.en.resx, Strings.it.resx dentro de Infrastructure/Resources.
2. ResourceHelper.cs permite obtener textos traducidos con ResourceManager.
3. Se ha adaptado IFormaGeometrica para manejar pluralización correctamente.

---

## 🔹 **Patrones de Diseño Implementados**

- **Strategy Pattern**: `IFormaGeometrica` permite definir estrategias para el cálculo de área y perímetro.
- **Factory Pattern**: `ReporteService` usa `IFormaGeometrica` sin conocer implementaciones específicas.
- **Singleton Pattern**: `ResourceHelper` gestiona el acceso a recursos de traducción de manera centralizada.
- **Open/Closed Principle (OCP - SOLID)**: Se pueden agregar nuevas formas geométricas sin modificar código existente.

---

## 🔹 **Paradigmas de Programación Orientada a Objetos (POO) Utilizados**

- **Abstracción**: `IFormaGeometrica` define métodos sin implementación concreta.
- **Herencia**: `FormaGeometrica` es la base de `Cuadrado`, `Circulo`, `Trapecio`, `TrapecioRectangulo`, etc.
- **Polimorfismo**: `ReporteService` opera con `IFormaGeometrica`, sin importar su tipo concreto.
- **Encapsulamiento**: `ResourceHelper` protege el acceso a los recursos de traducción.

---

## 🛠 **Pruebas Unitarias (Unit Tests)**

Se han implementado varios tests con **NUnit**:

### **✔️ Tests de Lista Vacía**

- `TestResumenListaVacia()`
- `TestResumenListaVaciaFormasEnIngles()`
- `TestResumenListaVaciaFormasEnItaliano()`

### **✔️ Tests con una Sola Forma**

- `TestResumenListaConUnCuadrado()`
- `TestResumenListaConUnTrapecioRectangulo()`

### **✔️ Tests con Múltiples Formas**

- `TestResumenListaConMasCuadrados()`
- `TestResumenListaConMasTipos()`
- `TestResumenListaConTrapecioRectanguloYOtros()`

### **✔️ Tests con Traducciones en Italiano**

- `TestResumenListaConMasCuadradosEnItaliano()`
- `TestResumenListaConTrapecioYRectanguloEnItaliano()`
- `TestResumenListaConTrapecioRectanguloEnItaliano()`

### **✔️ Test para Trapecio Rectángulo**

- `TestResumenListaConTrapecioRectangulo()`

---

## 🎯 **Cómo Ejecutar el Proyecto**

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/DevelopmentChallenge
   ```
2. Abre el proyecto en **Visual Studio 2019+**.
3. Compila y ejecuta los tests con **NUnit**.

---

## 📌 **Conclusión**

Este proyecto ofrece una solución extensible y mantenible para el cálculo de áreas y perímetros de formas geométricas, con soporte multilingüe y pruebas unitarias para garantizar su correcto funcionamiento.

# 🎯 **✨ Mejoras clave:**

- Uso de **archivos de recursos (.resx)** para manejar idiomas.
- Pluralización adecuada según idioma.
- Estructura **más limpia y mantenible.**
- Soporte para **nuevas formas sin modificar el código existente.**

🚀 ¡Listo para ser extendido con nuevas formas y funcionalidades! 🔥

---

# 📌 **Ry**


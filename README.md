# Prácticas de Desarrollo Web y Móvil

**Asignatura:** Desarrollo Web y Móvil (DWM)
**Alumno:** Roberto Castillo — rct419@inlumine.ual.es

| Práctica | Tema | Carpeta |
|---|---|---|
| 1 | Dashboard TechMetrics con Blazor | [`BlazorApp1`](BlazorApp1/) |

## Práctica 1 - Dashboard TechMetrics

Aplicación Blazor Web App (.NET 10, renderizado interactivo en servidor) con un panel de control de cursos: cabecera, tarjetas KPI y catálogo de cursos en tarjetas.

| Actividad | Contenido | Estado |
|---|---|---|
| 28 oct | Maquetación con CSS aislado: Flexbox en cabecera y KPIs, CSS Grid responsivo en las tarjetas, efectos hover y badges de estado | Hecha |
| 4 nov | Versión con Bootstrap, componentes `KpiCard` y `CursoCard`, formulario en modal, búsqueda y filtro con LINQ, KPIs en tiempo real y JS Interop (portapapeles, localStorage y estado de la red) | Hecha |
| 18 nov | BlazorBootstrap: Toasts, gráficos de barras y circular, modal con subida de temario | Pendiente |
| 25 nov | Persistencia con Entity Framework Core y SQLite, CRUD completo | Pendiente |

### Ejecución

1. Abrir `BlazorApp1/BlazorApp1.slnx` con Visual Studio 2026.
2. Ejecutar con `F5`.
3. Entrar en la opción **Dashboard** del menú lateral (`/dashboard`).

También se puede lanzar desde consola:

```bash
cd BlazorApp1/BlazorApp1
dotnet run
```

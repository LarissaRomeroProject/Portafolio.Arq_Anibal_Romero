# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project overview

A Blazor WebAssembly (.NET 9) single-page portfolio site for an architect (Arq. Anibal Romero), styled in Spanish. Static content, no backend API — pages are hardcoded Razor markup with MudBlazor components.

## Commands

- Restore/build: `dotnet build`
- Run dev server (hot reload): `dotnet watch run` (or `dotnet run`) — serves at `http://localhost:5066` / `https://localhost:7264` (see `Properties/launchSettings.json`)
- Publish (static output for hosting): `dotnet publish -c Release`

There are no test projects and no lint configuration in this repo.

## Architecture

- **Entry point**: `Program.cs` bootstraps the WebAssembly host, registers a scoped `HttpClient`, and calls `AddMudServices()` for MudBlazor. Root component `App` mounts at `#app` in `wwwroot/index.html`.
- **Routing**: `App.razor` is the `<Router>`; every page under `Pages/` declares its route via `@page "/route"` at the top of the `.razor` file. There is no route-parameter or nested-routing complexity — each page is a flat, self-contained Razor file.
- **Layout**: `Layout/MainLayout.razor` wraps every page — MudBlazor `MudAppBar` + `MudDrawer` with the nav links (Inicio, Proyectos, Sobre mí, Servicios, Contacto). Note the nav menu currently lists a `/contacto` link but there is no corresponding `Pages/Contacto.razor` yet.
- **Theming**: `Themes/ArquitectoTheme.cs` defines a single `MudTheme` (`ArquitectoTheme.LightTheme`) with the site's color palette (dark neutrals + gold accent `#C9A96E`) and Poppins typography; applied in `MainLayout.razor` via `<MudThemeProvider Theme="@ArquitectoTheme.LightTheme" />`. Add new theme variants (e.g. dark mode) here rather than inlining styles on components.
- **Styling**: Each page/layout has a matching CSS isolation file (e.g. `Pages/Proyectos.razor` + `Pages/Proyectos.razor.css`) — component-scoped Blazor CSS isolation, not global stylesheets. Global styles live in `wwwroot/css/app.css`. Bootstrap is vendored under `wwwroot/lib/bootstrap/` but MudBlazor is the primary UI library in use.
- **Assets**: Images referenced by pages live in `wwwroot/images/` (e.g. `proyecto1.png` … `proyecto5.png`, `arquitectura.jpeg`), referenced with relative paths like `images/proyecto1.png`.
- **PWA**: The app is configured as a PWA (`wwwroot/manifest.webmanifest`, `wwwroot/service-worker.js` / `service-worker.published.js`, `<ServiceWorker>` item in the `.csproj`).
- **Global usings**: `_Imports.razor` centralizes `@using` directives (MudBlazor, ASP.NET Core Components namespaces, project namespaces) available to all `.razor` files — add new shared namespaces there instead of per-page `@using`.

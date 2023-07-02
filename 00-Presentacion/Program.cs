using _00_Presentacion.IoC_Container;
using _01_Aplicacion;
using _01_Aplicacion.DTO;
using _02_Dominio;
using _02_Dominio.Repositorio;
using _03_Infraestructura;
using Autofac;

IContainer container = IoCContainer.getContainer();

AutomovilDTO Fiat = new AutomovilDTO(
    "TOJ871",
    "Fiat",
    "2015",
    120000
);

CrearAutomovil creadorDeAutomoviles = container.Resolve<CrearAutomovil>();

creadorDeAutomoviles.ejecutar(Fiat);

ObtenerAutomovil obtenedorDeAutomoviles = container.Resolve<ObtenerAutomovil>();

List<AutomovilDTO> todosLosAutomoviles = obtenedorDeAutomoviles.ejecutar();
foreach (AutomovilDTO automovil in todosLosAutomoviles)
{
    Console.WriteLine(automovil.presentacion());
}

Console.WriteLine("____________________");


EliminarAutomovil eliminarAutomovil = container.Resolve<EliminarAutomovil>();
eliminarAutomovil.Ejecutar("TOJ810");

ActualizarAutomovil actualizarAutomovil = container.Resolve<ActualizarAutomovil>();
actualizarAutomovil.ejecutar("TOJ825", "renaut", "2023", 2503000);


List<AutomovilDTO> todosLosAutomoviles2 = obtenedorDeAutomoviles.ejecutar();
foreach (AutomovilDTO automovil in todosLosAutomoviles2)
{
    Console.WriteLine(automovil.presentacion());
}
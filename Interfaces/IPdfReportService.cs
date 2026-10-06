using POOMeireRenzo.Dto;


namespace POOMeireRenzo.Interfaces
{
    public interface IPdfReportService
    {
        void GenerarPdfPresupuesto(PresupuestoDto presupuestoDto, string rutaArchivo);
    }
}
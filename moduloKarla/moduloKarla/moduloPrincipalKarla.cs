namespace moduloKarla
{
    public class moduloPrincipalKarla
    {
        public void MOSTRARAUDITORIES()
        {
            mantenimientoAuditores maudi = new mantenimientoAuditores();
            maudi.Show();
        }
        public void MOSTRARANALISIS()
        {
            mantenimientosAnalisis manalisis = new mantenimientosAnalisis();
            manalisis.Show();
        }
        public void MOSTRARASIGNACION()
        {
            asignacionAuditoresAnalisis manalisis = new asignacionAuditoresAnalisis();
            manalisis.Show();
        }
    }
}

using System.Windows.Forms;

namespace GlobalHookDemo
{
    public interface IConfiguraciones
    {
        void CapturaCoordenadas(object sender, MouseEventArgs e);
    }
}
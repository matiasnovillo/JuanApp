using JuanApp.Areas.JuanApp.Interfaces;
using JuanApp.Areas.JuanApp.Entities;
using JuanApp.Areas.JuanApp.Repositories;
using JuanApp.Areas.JuanApp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JuanApp.Formularios.Entrada
{
    public partial class FormularioEntrada : Form
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly IEntradaService _entradaService;
        private readonly IProductoRepository _productoRepository;
        private readonly int _entradaId;

        public FormularioEntrada(IServiceProvider serviceProvider,
            int entradaId)
        {
            try
            {
                _entradaRepository = serviceProvider.GetRequiredService<IEntradaRepository>();
                _entradaService = serviceProvider.GetRequiredService<IEntradaService>();

                _productoRepository = serviceProvider.GetRequiredService<IProductoRepository>();

                _entradaId = entradaId;

                InitializeComponent();

                if (entradaId > 0)
                {
                    Areas.JuanApp.Entities.Entrada Entrada = _entradaRepository
                                                                        .GetByEntradaId(entradaId);

                    txtNroDeCodigoDeBarra.Text = Entrada.CodigoDeBarra;
                    txtNroDePesada.Text = Entrada.NroDePesaje.ToString();
                    txtCodigoDeProducto.Text = Entrada.CodigoDeProducto;
                    txtNombreDeProducto.Text = Entrada.NombreDeProducto;
                    txtTexContenido.Text = Entrada.TexContenido.ToString();
                    numericUpDownNeto.Value = Entrada.Neto;
                }

                statusLabel.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void menuItemMain_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNroDeCodigoDeBarra.Text) ||
                       string.IsNullOrEmpty(txtNroDePesada.Text) ||
                       string.IsNullOrEmpty(txtCodigoDeProducto.Text) ||
                       string.IsNullOrEmpty(txtTexContenido.Text) ||
                       numericUpDownNeto.Value == 0 ||
                       string.IsNullOrEmpty(txtNombreDeProducto.Text))
                {
                    statusLabel.Text = "Faltan datos a completar";
                }
                else
                {
                    if (_entradaId == 0)
                    {
                        //Agregar
                        Areas.JuanApp.Entities.Entrada Entrada = new()
                        {
                            EntradaId = _entradaId,
                            Active = true,
                            UserCreationId = 1,
                            UserLastModificationId = 1,
                            DateTimeCreation = DateTime.Now,
                            DateTimeLastModification = DateTime.Now,
                            CodigoDeBarra = txtNroDeCodigoDeBarra.Text,
                            NroDePesaje = Convert.ToInt32(txtNroDePesada.Text),
                            CodigoDeProducto = txtCodigoDeProducto.Text,
                            NombreDeProducto = txtNombreDeProducto.Text,
                            TexContenido = Convert.ToInt32(txtTexContenido.Text),
                            Neto = numericUpDownNeto.Value
                        };
                        _entradaRepository.Add(Entrada);
                    }
                    else
                    {
                        //Actualizar
                        Areas.JuanApp.Entities.Entrada Entrada = _entradaRepository.GetByEntradaId(_entradaId);

                        Entrada.CodigoDeBarra = txtNroDeCodigoDeBarra.Text;
                        Entrada.NroDePesaje = Convert.ToInt32(txtNroDePesada.Text);
                        Entrada.CodigoDeProducto = txtCodigoDeProducto.Text;
                        Entrada.NombreDeProducto = txtNombreDeProducto.Text;
                        Entrada.TexContenido = Convert.ToInt32(txtTexContenido.Text);
                        Entrada.Neto = numericUpDownNeto.Value;
                        Entrada.UserLastModificationId = 1;
                        Entrada.DateTimeLastModification = DateTime.Now;

                        _entradaRepository.Update(Entrada);
                    }

                    Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCodigoDeProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    Producto Producto = _productoRepository
                        .AsQueryable()
                        .Where(x => x.CodigoProducto == txtCodigoDeProducto.Text)
                        .FirstOrDefault();

                    if (Producto != null)
                    {
                        txtNombreDeProducto.Text = Producto.Nombre;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

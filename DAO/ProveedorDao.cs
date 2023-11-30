using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProveedorDao
    {
        public ProveedorEntity ObtenerProveedor(int codigoProveedor)
        {
            try
            {
                using (ContextDb context = new ContextDb())
                {
                    var proveedorDb = context.PROVEEDOR.SingleOrDefault(O => O.ID_PROVEEDOR == codigoProveedor);

                    var proveedor = new ProveedorEntity
                    {
                        CodigoProveedor = proveedorDb.ID_PROVEEDOR,
                        Dni = Convert.ToInt64(proveedorDb.DNI),
                        Nombre = proveedorDb.NOMBRE,
                        Apellido = proveedorDb.APELLIDO,
                        Email = proveedorDb.EMAIL
                    };

                    return proveedor;
                }
            }
            catch { throw; }
        }
    }
}

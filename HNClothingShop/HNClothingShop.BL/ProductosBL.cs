using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNClothingShop.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Carteras";
            producto1.Precio = 1000;
            producto1.Existencia = 13;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Camisetas";
            producto2.Precio = 350;
            producto2.Existencia = 190;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Jeans";
            producto3.Precio = 520;
            producto3.Existencia = 150;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Vestidos";
            producto4.Precio = 530;
            producto4.Existencia = 12;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);

            return listadeProductos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNClothingShop.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "michelle";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario2.Nombre = "edgar";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("456");

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario3.Nombre = "allan";
            nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("789");

            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(nuevoUsuario2);
            contexto.Usuarios.Add(nuevoUsuario3);

            base.Seed(contexto);
        }
    }
}

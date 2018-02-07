
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IUsuarioCAD
        {
        UsuarioEN ReadOIDDefault (int idUsuario);

        int Crear (UsuarioEN usuario);

        void Modificar (UsuarioEN usuario);


        void Eliminar (int idUsuario);


        UsuarioEN DamePorID (int idUsuario);


        System.Collections.Generic.IList<UsuarioEN> DameTodos (int first, int size);
        }
}

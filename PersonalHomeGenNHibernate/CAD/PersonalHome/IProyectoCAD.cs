
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IProyectoCAD
        {
        ProyectoEN ReadOIDDefault (int idProyecto);

        int Crear (ProyectoEN proyecto);

        void Modificar (ProyectoEN proyecto);


        void Eliminar (int idProyecto);


        ProyectoEN DamePorID (int idProyecto);


        System.Collections.Generic.IList<ProyectoEN> DameTodos (int first, int size);
        }
}

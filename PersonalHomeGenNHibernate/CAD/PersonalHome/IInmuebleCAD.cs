
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IInmuebleCAD
        {
        InmuebleEN ReadOIDDefault (int idInmueble);

        int Crear (InmuebleEN inmueble);

        void Modificar (InmuebleEN inmueble);


        void Eliminar (int idInmueble);


        InmuebleEN DamePorID (int idInmueble);


        System.Collections.Generic.IList<InmuebleEN> DameTodos (int first, int size);


        void AsignarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs);

        void QuitarVista (int p_Inmueble_OID, System.Collections.Generic.IList<int> p_vista_OIDs);
        }
}

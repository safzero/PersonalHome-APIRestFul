
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IVistaCAD
        {
        VistaEN ReadOIDDefault (int idVista);

        int Crear (VistaEN vista);

        void Modificar (VistaEN vista);


        void Eliminar (int idVista);


        VistaEN DamePorID (int idVista);


        System.Collections.Generic.IList<VistaEN> DameTodas (int first, int size);


        void AsignarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs);

        void QuitarEstancia (int p_Vista_OID, System.Collections.Generic.IList<int> p_estancia_OIDs);

        void AsignarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs);

        void QuitarInmueble (int p_Vista_OID, System.Collections.Generic.IList<int> p_inmueble_OIDs);
        }
}


using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IEstanciaCAD
        {
        EstanciaEN ReadOIDDefault (int idEstancia);

        int Crear (EstanciaEN estancia);

        void Modificar (EstanciaEN estancia);


        void Eliminar (int idEstancia);


        EstanciaEN DamePorID (int idEstancia);


        System.Collections.Generic.IList<EstanciaEN> DameTodas (int first, int size);


        void AsignarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs);

        void QuitarTipoEstancia (int p_Estancia_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs);

        void AsignarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs);

        void QuitarVista (int p_Estancia_OID, System.Collections.Generic.IList<int> p_vista_OIDs);
        }
}

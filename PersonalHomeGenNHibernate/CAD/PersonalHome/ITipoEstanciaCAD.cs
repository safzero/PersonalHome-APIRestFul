
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface ITipoEstanciaCAD
        {
        TipoEstanciaEN ReadOIDDefault (int idTipoEstancia);

        int Crear (TipoEstanciaEN tipoEstancia);

        void Modificar (TipoEstanciaEN tipoEstancia);


        void Eliminar (int idTipoEstancia);


        TipoEstanciaEN DamePorID (int idTipoEstancia);


        System.Collections.Generic.IList<TipoEstanciaEN> DameTodos (int first, int size);


        void AsignarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs);

        void QuitarFamiliaPack (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs);

        void AsignarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs);

        void QuitarEstancia (int p_TipoEstancia_OID, System.Collections.Generic.IList<int> p_estancia_OIDs);
        }
}

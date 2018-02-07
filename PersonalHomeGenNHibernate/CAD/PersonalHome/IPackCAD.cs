
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IPackCAD
        {
        PackEN ReadOIDDefault (int idPack);

        int Crear (PackEN pack);

        void Modificar (PackEN pack);


        void Eliminar (int idPack);


        PackEN DamePorID (int idPack);


        System.Collections.Generic.IList<PackEN> DameTodos (int first, int size);


        void AsignarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs);

        void QuitarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs);

        void AsignarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs);

        void QuitarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs);
        }
}

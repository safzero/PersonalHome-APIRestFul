
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IFamiliaPackCAD
        {
        FamiliaPackEN ReadOIDDefault (int idFamPack);

        int Crear (FamiliaPackEN familiaPack);

        void Modificar (FamiliaPackEN familiaPack);


        void Eliminar (int idFamPack);


        FamiliaPackEN DamePorID (int idFamPack);


        System.Collections.Generic.IList<FamiliaPackEN> DameTodas (int first, int size);


        void AsignarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs);

        void QuitarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs);

        void AsignarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs);

        void QuitarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs);
        }
}

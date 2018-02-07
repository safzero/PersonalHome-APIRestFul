
using System;
using PersonalHomeGenNHibernate.EN.PersonalHome;

namespace PersonalHomeGenNHibernate.CAD.PersonalHome
{
        public partial interface IVariableCAD
        {
        VariableEN ReadOIDDefault (int idVariable);

        void Eliminar (int idVariable);


        VariableEN DamePorID (int idVariable);


        System.Collections.Generic.IList<VariableEN> DameTodas (int first, int size);


        void AsignarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs);

        void QuitarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs);

        int Crear (VariableEN variable);

        void Modificar (VariableEN variable);
        }
}

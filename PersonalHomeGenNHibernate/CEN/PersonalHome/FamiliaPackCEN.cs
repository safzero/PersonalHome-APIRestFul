

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using PersonalHomeGenNHibernate.EN.PersonalHome;
using PersonalHomeGenNHibernate.CAD.PersonalHome;

namespace PersonalHomeGenNHibernate.CEN.PersonalHome
{
        public partial class FamiliaPackCEN
        {
        private IFamiliaPackCAD _IFamiliaPackCAD;

        public FamiliaPackCEN(IFamiliaPackCAD _IFamiliaPackCAD)
        {
                this._IFamiliaPackCAD = _IFamiliaPackCAD;
        }

        public int Crear (String p_nombre, String p_codigo, String p_color)
        {
                FamiliaPackEN familiaPackEN = null;
                int oid;

                //Initialized FamiliaPackEN
                familiaPackEN = new FamiliaPackEN ();
                familiaPackEN.Nombre = p_nombre;
                familiaPackEN.Codigo = p_codigo;
                familiaPackEN.Color = p_color;
                //Call to FamiliaPackCAD

                oid = _IFamiliaPackCAD.Crear (familiaPackEN);
                return oid;
        }

        public void Modificar (int p_FamiliaPack_OID, String p_nombre, String p_codigo, String p_color)
        {
                FamiliaPackEN familiaPackEN = null;

                //Initialized FamiliaPackEN
                familiaPackEN = new FamiliaPackEN ();
                familiaPackEN.IdFamPack = p_FamiliaPack_OID;
                familiaPackEN.Nombre = p_nombre;
                familiaPackEN.Codigo = p_codigo;
                familiaPackEN.Color = p_color;
                //Call to FamiliaPackCAD

                _IFamiliaPackCAD.Modificar (familiaPackEN);
        }

        public void Eliminar (int idFamPack)
        {
                _IFamiliaPackCAD.Eliminar (
                        idFamPack

                        );
        }

        public FamiliaPackEN DamePorID (int idFamPack)
        {
                FamiliaPackEN familiaPackEN = null;

                familiaPackEN = _IFamiliaPackCAD.DamePorID (
                        idFamPack

                        );
                return familiaPackEN;
        }

        public System.Collections.Generic.IList<FamiliaPackEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<FamiliaPackEN> list = null;

                list = _IFamiliaPackCAD.DameTodas (first, size);
                return list;
        }
        public void AsignarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                //Call to FamiliaPackCAD

                _IFamiliaPackCAD.AsignarPack (p_FamiliaPack_OID, p_pack_OIDs);
        }
        public void QuitarPack (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                //Call to FamiliaPackCAD

                _IFamiliaPackCAD.QuitarPack (p_FamiliaPack_OID, p_pack_OIDs);
        }
        public void AsignarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                //Call to FamiliaPackCAD

                _IFamiliaPackCAD.AsignarTipoEstancia (p_FamiliaPack_OID, p_tipoEstancia_OIDs);
        }
        public void QuitarTipoEstancia (int p_FamiliaPack_OID, System.Collections.Generic.IList<int> p_tipoEstancia_OIDs)
        {
                //Call to FamiliaPackCAD

                _IFamiliaPackCAD.QuitarTipoEstancia (p_FamiliaPack_OID, p_tipoEstancia_OIDs);
        }
        }
}

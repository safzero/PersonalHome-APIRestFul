

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
        public partial class PackCEN
        {
        private IPackCAD _IPackCAD;

        public PackCEN(IPackCAD _IPackCAD)
        {
                this._IPackCAD = _IPackCAD;
        }

        public int Crear (String p_nombre, String p_familia, String p_descripción, String p_color, String p_codigo)
        {
                PackEN packEN = null;
                int oid;

                //Initialized PackEN
                packEN = new PackEN ();
                packEN.Nombre = p_nombre;
                packEN.Familia = p_familia;
                packEN.Descripción = p_descripción;
                packEN.Color = p_color;
                packEN.Codigo = p_codigo;
                //Call to PackCAD

                oid = _IPackCAD.Crear (packEN);
                return oid;
        }

        public void Modificar (int p_Pack_OID, String p_nombre, String p_familia, String p_descripción, String p_color, String p_codigo)
        {
                PackEN packEN = null;

                //Initialized PackEN
                packEN = new PackEN ();
                packEN.IdPack = p_Pack_OID;
                packEN.Nombre = p_nombre;
                packEN.Familia = p_familia;
                packEN.Descripción = p_descripción;
                packEN.Color = p_color;
                packEN.Codigo = p_codigo;
                //Call to PackCAD

                _IPackCAD.Modificar (packEN);
        }

        public void Eliminar (int idPack)
        {
                _IPackCAD.Eliminar (
                        idPack

                        );
        }

        public PackEN DamePorID (int idPack)
        {
                PackEN packEN = null;

                packEN = _IPackCAD.DamePorID (
                        idPack

                        );
                return packEN;
        }

        public System.Collections.Generic.IList<PackEN> DameTodos (int first, int size)
        {
                System.Collections.Generic.IList<PackEN> list = null;

                list = _IPackCAD.DameTodos (first, size);
                return list;
        }
        public void AsignarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
        {
                //Call to PackCAD

                _IPackCAD.AsignarVariable (p_Pack_OID, p_variable_OIDs);
        }
        public void QuitarVariable (int p_Pack_OID, System.Collections.Generic.IList<int> p_variable_OIDs)
        {
                //Call to PackCAD

                _IPackCAD.QuitarVariable (p_Pack_OID, p_variable_OIDs);
        }
        public void AsignarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                //Call to PackCAD

                _IPackCAD.AsignarFamiliaPack (p_Pack_OID, p_familiaPack_OIDs);
        }
        public void QuitarFamiliaPack (int p_Pack_OID, System.Collections.Generic.IList<int> p_familiaPack_OIDs)
        {
                //Call to PackCAD

                _IPackCAD.QuitarFamiliaPack (p_Pack_OID, p_familiaPack_OIDs);
        }
        }
}



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
        public partial class VariableCEN
        {
        private IVariableCAD _IVariableCAD;

        public VariableCEN(IVariableCAD _IVariableCAD)
        {
                this._IVariableCAD = _IVariableCAD;
        }

        public void Eliminar (int idVariable)
        {
                _IVariableCAD.Eliminar (
                        idVariable

                        );
        }

        public VariableEN DamePorID (int idVariable)
        {
                VariableEN variableEN = null;

                variableEN = _IVariableCAD.DamePorID (
                        idVariable

                        );
                return variableEN;
        }

        public System.Collections.Generic.IList<VariableEN> DameTodas (int first, int size)
        {
                System.Collections.Generic.IList<VariableEN> list = null;

                list = _IVariableCAD.DameTodas (first, size);
                return list;
        }
        public void AsignarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                //Call to VariableCAD

                _IVariableCAD.AsignarPack (p_Variable_OID, p_pack_OIDs);
        }
        public void QuitarPack (int p_Variable_OID, System.Collections.Generic.IList<int> p_pack_OIDs)
        {
                //Call to VariableCAD

                _IVariableCAD.QuitarPack (p_Variable_OID, p_pack_OIDs);
        }
        public int Crear (String p_nombre, String p_caracteristicas, double p_precio, String p_imagen, int p_iva, String p_miniatura)
        {
                VariableEN variableEN = null;
                int oid;

                //Initialized VariableEN
                variableEN = new VariableEN ();
                variableEN.Nombre = p_nombre;
                variableEN.Caracteristicas = p_caracteristicas;
                variableEN.Precio = p_precio;
                variableEN.Imagen = p_imagen;
                variableEN.Iva = p_iva;
                variableEN.Miniatura = p_miniatura;
                //Call to VariableCAD

                oid = _IVariableCAD.Crear (variableEN);
                return oid;
        }

        public void Modificar (int p_Variable_OID, String p_nombre, String p_caracteristicas, double p_precio, String p_imagen, int p_iva, String p_miniatura)
        {
                VariableEN variableEN = null;

                //Initialized VariableEN
                variableEN = new VariableEN ();
                variableEN.IdVariable = p_Variable_OID;
                variableEN.Nombre = p_nombre;
                variableEN.Caracteristicas = p_caracteristicas;
                variableEN.Precio = p_precio;
                variableEN.Imagen = p_imagen;
                variableEN.Iva = p_iva;
                variableEN.Miniatura = p_miniatura;
                //Call to VariableCAD

                _IVariableCAD.Modificar (variableEN);
        }
        }
}

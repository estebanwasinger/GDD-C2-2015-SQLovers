﻿using System;
using System.Collections.Generic;
using System.Data;

using AerolineaFrba.Models.BO;
using AerolineaFrba.Models.Utils;

namespace AerolineaFrba.Models.DAO{
    public class DAOBase<T> where T :IBO<T>, new() {

        protected string tabla;
        protected string pk;

        public DAOBase(string _tabla, string _pk) {
            tabla = _tabla;
            pk = _pk;
        }

        virtual public T retrieveBase(Object _key) {			
			return DB.ExecuteReaderSingle<T>("SELECT * FROM " + tabla + " WHERE " + pk + " = @1", (int)_key);
        }

        virtual public List<T> retrieveBase() {
			return DB.ExecuteReader<T>("SELECT * FROM " + tabla);
        }

        virtual public int deleteBase(Object _key) {
			return DB.ExecuteCardinal("DELETE FROM " + tabla + " WHERE " + pk + " = @1", (int)_key);
        }

        virtual public int deleteAllBase() {
			return DB.ExecuteCardinal("DELETE FROM " + tabla);
        }

        virtual public int nextIdentity() {
			return DB.ExecuteCardinal("SELECT IDENT_CURRENT('" + tabla + "') + IDENT_INCR('" + tabla + "')");
        }

        protected string fechaQuereable(DateTime? fecha)
        {
            return " \'" + ((DateTime)fecha).ToString("MM/dd/yyyy hh:mm:ss") + "\' ";
//            return " \'" + ((DateTime)fecha).ToString("yyyy-dd-MM hh:mm:ss") + "\' ";


        }


    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Wolf.Dal.Nfs.Interfaces;

namespace Toci.Wolf.Dal.Nfs
{
    public class Dal<TModel> : IDal<TModel>

    {
        protected DbContext session
    {
        get
        {
            if (session == null)
                throw new InvalidOperationException("A session IUnitOfWork do repositório não está instanciada.");
            return session;
        }
}

public int Delete(TModel model)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TModel model)
        {
            try
            {
                session.Set(typeof(TModel)).Add(model);
                return session.Entry(model).GetValidationResult().IsValid;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new Exception(ex.InnerException.Message, ex);
                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}

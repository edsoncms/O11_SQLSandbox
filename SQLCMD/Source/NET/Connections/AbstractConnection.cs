using OutSystems.RuntimePublic.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssSQLCMD.Connections {
    public abstract class AbstractConnection : IDisposable {

        public CommittableTransaction trans { get; protected set; }

        public void Commit() {
            trans.Commit();
        }

        public void Rollback() {
            trans.Rollback();
        }

        public void Dispose() {
            trans.Dispose();
        }

        public IDbTransaction GetDriverTransaction()
        {
            return trans.GetDriverTransaction();
        }
    }
}

using OutSystems.RuntimePublic.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssSQLCMD.Connections {
    public class RuntimeConnection : AbstractConnection {
        private readonly DatabaseProvider transMgr;

        public RuntimeConnection(DatabaseProvider provider) {
            this.transMgr = provider;
            this.trans = transMgr.GetCommittableTransaction();
        }

    }
}

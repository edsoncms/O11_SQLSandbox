using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform;
using System.Data;
using OutSystems.RuntimeCommon;
using System.Data.Common;
using OutSystems.RuntimePublic.Db;
using System.Reflection;
using OutSystems.Internal.Db;
using System.Runtime.Serialization;

namespace OutSystems.NssSQLCMD.Connections {
    public class AdminConnection : AbstractConnection {

#if VOID_WARRANTY

        private readonly DatabaseProvider transMgr;

        public AdminConnection() {
            var settingsProvider = RuntimeSettingsProvider.Instance;
            var pluginProvider = OutSystems.Internal.Db.DatabaseAccess.CurrentPlatformDatabasesPluginProvider;
            var source = DatabaseSettingsSerialization.Source.Services;
            var user = DatabaseSettingsSerialization.User.Admin;
            var dataSpace = DatabaseSettingsSerialization.DataSpace.Platform;

            // protected static DatabaseAccessProvider<IPlatformDatabaseServices> CreatePlatformDatabaseAccessProvider(DatabaseSettingsSerialization.Source source, DatabaseSettingsSerialization.User user, DatabaseSettingsSerialization.DataSpace dataSpace, ISettingsProvider settingsProvider);
            MethodInfo createProvider = typeof(OutSystems.Internal.Db.DatabaseAccess).GetMethod("CreatePlatformDatabaseAccessProvider", BindingFlags.Static | BindingFlags.NonPublic);
            IDatabaseAccessProvider provider = (IDatabaseAccessProvider) createProvider.Invoke(null, new object[] { source, user, dataSpace, settingsProvider });

            /*
             * DatabaseProvider only has an internal constructor,
             * so we using an alternate method for constructing a new instance
             */
            this.transMgr = (DatabaseProvider) FormatterServices.GetUninitializedObject(typeof(DatabaseProvider));
            foreach (FieldInfo field in typeof(DatabaseProvider).GetFields(BindingFlags.Instance | BindingFlags.NonPublic)) {
                if (field.FieldType == typeof(OutSystems.Internal.Db.IDatabaseAccessProvider)) {
                    field.SetValue(this.transMgr, provider);
                }
            }

            this.trans = transMgr.GetCommittableTransaction();
        }

#endif

    }
}

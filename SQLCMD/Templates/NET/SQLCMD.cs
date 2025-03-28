using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssSQLCMD {

	public class CssSQLCMD: IssSQLCMD {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSQL"></param>
		/// <param name="ssMaxRecords"></param>
		/// <param name="ssCatalogName"></param>
		/// <param name="ssConnectionName"></param>
		/// <param name="ssRollbackTransaction"></param>
		/// <param name="ssColumns"></param>
		/// <param name="ssRows"></param>
		/// <param name="ssCount"></param>
		/// <param name="ssAffectedRows"></param>
		/// <param name="ssIncludeMessage"></param>
		/// <param name="ssMessage"></param>
		/// <param name="ssShowXML"></param>
		/// <param name="ssXMLSQLPlan"></param>
		public void MssExecute(string ssSQL, long ssMaxRecords, string ssCatalogName, string ssConnectionName, bool ssRollbackTransaction, out RLColumnRecordList ssColumns, out RLRowRecordList ssRows, out long ssCount, out long ssAffectedRows, bool ssIncludeMessage, out string ssMessage, bool ssShowXML, out string ssXMLSQLPlan) {
			ssColumns = new RLColumnRecordList();
			ssRows = new RLRowRecordList();
			ssCount = 0L;
			ssAffectedRows = 0L;
			ssMessage = "";
			ssXMLSQLPlan = "";
			// TODO: Write implementation for action
		} // MssExecute

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIsProduction"></param>
		public void MssIsProduction(out bool ssIsProduction) {
			ssIsProduction = false;
			// TODO: Write implementation for action
		} // MssIsProduction

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTimer"></param>
		public void MssStartTimer(out object ssTimer) {
			ssTimer = null;
			// TODO: Write implementation for action
		} // MssStartTimer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTimer"></param>
		/// <param name="ssMilliseconds"></param>
		public void MssStopTimer(object ssTimer, out long ssMilliseconds) {
			ssMilliseconds = 0L;
			// TODO: Write implementation for action
		} // MssStopTimer

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssContextualSQL"></param>
		/// <param name="ssContext"></param>
		/// <param name="ssSQL"></param>
		/// <param name="ssHasInferredConnectionName"></param>
		/// <param name="ssInferredConnectionName"></param>
		/// <param name="ssHasInferredOutput"></param>
		/// <param name="ssInferredOutput"></param>
		public void MssParseContextualQuery(string ssContextualSQL, RLEntityDetailsRecordList ssContext, out string ssSQL, out bool ssHasInferredConnectionName, out string ssInferredConnectionName, out bool ssHasInferredOutput, out RLEntityAttributeDetailsRecordList ssInferredOutput) {
			ssSQL = "";
			ssHasInferredConnectionName = false;
			ssInferredConnectionName = "";
			ssHasInferredOutput = false;
			ssInferredOutput = new RLEntityAttributeDetailsRecordList();
			// TODO: Write implementation for action
		} // MssParseContextualQuery

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSQL">SQL Statement(s)</param>
		/// <param name="ssTypeList">Statement Type</param>
		public void MssGetStatementType(string ssSQL, out RLTypeRecordList ssTypeList) {
			ssTypeList = new RLTypeRecordList();
			// TODO: Write implementation for action
		} // MssGetStatementType

	} // CssSQLCMD

} // OutSystems.NssSQLCMD


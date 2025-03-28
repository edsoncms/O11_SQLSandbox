using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssSQLCMD {

	public interface IssSQLCMD {

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
		void MssExecute(string ssSQL, long ssMaxRecords, string ssCatalogName, string ssConnectionName, bool ssRollbackTransaction, out RLColumnRecordList ssColumns, out RLRowRecordList ssRows, out long ssCount, out long ssAffectedRows, bool ssIncludeMessage, out string ssMessage, bool ssShowXML, out string ssXMLSQLPlan);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssIsProduction"></param>
		void MssIsProduction(out bool ssIsProduction);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTimer"></param>
		void MssStartTimer(out object ssTimer);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssTimer"></param>
		/// <param name="ssMilliseconds"></param>
		void MssStopTimer(object ssTimer, out long ssMilliseconds);

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
		void MssParseContextualQuery(string ssContextualSQL, RLEntityDetailsRecordList ssContext, out string ssSQL, out bool ssHasInferredConnectionName, out string ssInferredConnectionName, out bool ssHasInferredOutput, out RLEntityAttributeDetailsRecordList ssInferredOutput);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssSQL">SQL Statement(s)</param>
		/// <param name="ssTypeList">Statement Type</param>
		void MssGetStatementType(string ssSQL, out RLTypeRecordList ssTypeList);

	} // IssSQLCMD

} // OutSystems.NssSQLCMD

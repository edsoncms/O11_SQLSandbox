using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssSQLCMD {

	/// <summary>
	/// Structure <code>RCColumnRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCColumnRecord: ISerializable, ITypedRecord<RCColumnRecord> {
		internal static readonly GlobalObjectKey IdColumn = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2BDJLMegoxwxjOmXd72YFA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Column")]
		public STColumnStructure ssSTColumn;


		public static implicit operator STColumnStructure(RCColumnRecord r) {
			return r.ssSTColumn;
		}

		public static implicit operator RCColumnRecord(STColumnStructure r) {
			RCColumnRecord res = new RCColumnRecord(null);
			res.ssSTColumn = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCColumnRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTColumn = new STColumnStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTColumn.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTColumn.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCColumnRecord r) {
			this = r;
		}


		public static bool operator == (RCColumnRecord a, RCColumnRecord b) {
			if (a.ssSTColumn != b.ssSTColumn) return false;
			return true;
		}

		public static bool operator != (RCColumnRecord a, RCColumnRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCColumnRecord)) return false;
			return (this == (RCColumnRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTColumn.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCColumnRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTColumn = new STColumnStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTColumn", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTColumn' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTColumn = (STColumnStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTColumn.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTColumn.InternalRecursiveSave();
		}


		public RCColumnRecord Duplicate() {
			RCColumnRecord t;
			t.ssSTColumn = (STColumnStructure) this.ssSTColumn.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTColumn.ToXml(this, recordElem, "Column", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "column") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Column")) variable.Value = ssSTColumn; else variable.Optimized = true;
				variable.SetFieldName("column");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdColumn) {
				return ssSTColumn;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTColumn.FillFromOther((IRecord) other.AttributeGet(IdColumn));
		}
		public bool IsDefault() {
			RCColumnRecord defaultStruct = new RCColumnRecord(null);
			if (this.ssSTColumn != defaultStruct.ssSTColumn) return false;
			return true;
		}
	} // RCColumnRecord

	/// <summary>
	/// Structure <code>RCRowRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCRowRecord: ISerializable, ITypedRecord<RCRowRecord> {
		internal static readonly GlobalObjectKey IdRow = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IljvjbeHkyIpyV12JoAIbA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Row")]
		public STRowStructure ssSTRow;


		public static implicit operator STRowStructure(RCRowRecord r) {
			return r.ssSTRow;
		}

		public static implicit operator RCRowRecord(STRowStructure r) {
			RCRowRecord res = new RCRowRecord(null);
			res.ssSTRow = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCRowRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTRow = new STRowStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTRow.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTRow.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCRowRecord r) {
			this = r;
		}


		public static bool operator == (RCRowRecord a, RCRowRecord b) {
			if (a.ssSTRow != b.ssSTRow) return false;
			return true;
		}

		public static bool operator != (RCRowRecord a, RCRowRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCRowRecord)) return false;
			return (this == (RCRowRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTRow.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCRowRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTRow = new STRowStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTRow", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTRow' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTRow = (STRowStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTRow.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTRow.InternalRecursiveSave();
		}


		public RCRowRecord Duplicate() {
			RCRowRecord t;
			t.ssSTRow = (STRowStructure) this.ssSTRow.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTRow.ToXml(this, recordElem, "Row", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "row") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Row")) variable.Value = ssSTRow; else variable.Optimized = true;
				variable.SetFieldName("row");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdRow) {
				return ssSTRow;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTRow.FillFromOther((IRecord) other.AttributeGet(IdRow));
		}
		public bool IsDefault() {
			RCRowRecord defaultStruct = new RCRowRecord(null);
			if (this.ssSTRow != defaultStruct.ssSTRow) return false;
			return true;
		}
	} // RCRowRecord

	/// <summary>
	/// Structure <code>RCRowValueRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCRowValueRecord: ISerializable, ITypedRecord<RCRowValueRecord> {
		internal static readonly GlobalObjectKey IdRowValue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*42HSju00XEfOToSr+itH6Q");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("RowValue")]
		public STRowValueStructure ssSTRowValue;


		public static implicit operator STRowValueStructure(RCRowValueRecord r) {
			return r.ssSTRowValue;
		}

		public static implicit operator RCRowValueRecord(STRowValueStructure r) {
			RCRowValueRecord res = new RCRowValueRecord(null);
			res.ssSTRowValue = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCRowValueRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTRowValue = new STRowValueStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTRowValue.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTRowValue.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCRowValueRecord r) {
			this = r;
		}


		public static bool operator == (RCRowValueRecord a, RCRowValueRecord b) {
			if (a.ssSTRowValue != b.ssSTRowValue) return false;
			return true;
		}

		public static bool operator != (RCRowValueRecord a, RCRowValueRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCRowValueRecord)) return false;
			return (this == (RCRowValueRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTRowValue.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCRowValueRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTRowValue = new STRowValueStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTRowValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTRowValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTRowValue = (STRowValueStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTRowValue.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTRowValue.InternalRecursiveSave();
		}


		public RCRowValueRecord Duplicate() {
			RCRowValueRecord t;
			t.ssSTRowValue = (STRowValueStructure) this.ssSTRowValue.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTRowValue.ToXml(this, recordElem, "RowValue", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "rowvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".RowValue")) variable.Value = ssSTRowValue; else variable.Optimized = true;
				variable.SetFieldName("rowvalue");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdRowValue) {
				return ssSTRowValue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTRowValue.FillFromOther((IRecord) other.AttributeGet(IdRowValue));
		}
		public bool IsDefault() {
			RCRowValueRecord defaultStruct = new RCRowValueRecord(null);
			if (this.ssSTRowValue != defaultStruct.ssSTRowValue) return false;
			return true;
		}
	} // RCRowValueRecord

	/// <summary>
	/// Structure <code>RCEntityDetailsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityDetailsRecord: ISerializable, ITypedRecord<RCEntityDetailsRecord> {
		internal static readonly GlobalObjectKey IdEntityDetails = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WzSkoDYQ5Obp+dWI4FjWAA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityDetails")]
		public STEntityDetailsStructure ssSTEntityDetails;


		public static implicit operator STEntityDetailsStructure(RCEntityDetailsRecord r) {
			return r.ssSTEntityDetails;
		}

		public static implicit operator RCEntityDetailsRecord(STEntityDetailsStructure r) {
			RCEntityDetailsRecord res = new RCEntityDetailsRecord(null);
			res.ssSTEntityDetails = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityDetailsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityDetails = new STEntityDetailsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityDetails.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityDetails.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityDetailsRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityDetailsRecord a, RCEntityDetailsRecord b) {
			if (a.ssSTEntityDetails != b.ssSTEntityDetails) return false;
			return true;
		}

		public static bool operator != (RCEntityDetailsRecord a, RCEntityDetailsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityDetailsRecord)) return false;
			return (this == (RCEntityDetailsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityDetails.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityDetailsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityDetails = new STEntityDetailsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityDetails", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityDetails' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityDetails = (STEntityDetailsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityDetails.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityDetails.InternalRecursiveSave();
		}


		public RCEntityDetailsRecord Duplicate() {
			RCEntityDetailsRecord t;
			t.ssSTEntityDetails = (STEntityDetailsStructure) this.ssSTEntityDetails.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityDetails.ToXml(this, recordElem, "EntityDetails", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entitydetails") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityDetails")) variable.Value = ssSTEntityDetails; else variable.Optimized = true;
				variable.SetFieldName("entitydetails");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityDetails) {
				return ssSTEntityDetails;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityDetails.FillFromOther((IRecord) other.AttributeGet(IdEntityDetails));
		}
		public bool IsDefault() {
			RCEntityDetailsRecord defaultStruct = new RCEntityDetailsRecord(null);
			if (this.ssSTEntityDetails != defaultStruct.ssSTEntityDetails) return false;
			return true;
		}
	} // RCEntityDetailsRecord

	/// <summary>
	/// Structure <code>RCEntityAttributeDetailsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCEntityAttributeDetailsRecord: ISerializable, ITypedRecord<RCEntityAttributeDetailsRecord> {
		internal static readonly GlobalObjectKey IdEntityAttributeDetails = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MfJzl8Wn4QRoZDONQfop7g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EntityAttributeDetails")]
		public STEntityAttributeDetailsStructure ssSTEntityAttributeDetails;


		public static implicit operator STEntityAttributeDetailsStructure(RCEntityAttributeDetailsRecord r) {
			return r.ssSTEntityAttributeDetails;
		}

		public static implicit operator RCEntityAttributeDetailsRecord(STEntityAttributeDetailsStructure r) {
			RCEntityAttributeDetailsRecord res = new RCEntityAttributeDetailsRecord(null);
			res.ssSTEntityAttributeDetails = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCEntityAttributeDetailsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTEntityAttributeDetails = new STEntityAttributeDetailsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTEntityAttributeDetails.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTEntityAttributeDetails.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCEntityAttributeDetailsRecord r) {
			this = r;
		}


		public static bool operator == (RCEntityAttributeDetailsRecord a, RCEntityAttributeDetailsRecord b) {
			if (a.ssSTEntityAttributeDetails != b.ssSTEntityAttributeDetails) return false;
			return true;
		}

		public static bool operator != (RCEntityAttributeDetailsRecord a, RCEntityAttributeDetailsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCEntityAttributeDetailsRecord)) return false;
			return (this == (RCEntityAttributeDetailsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTEntityAttributeDetails.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCEntityAttributeDetailsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTEntityAttributeDetails = new STEntityAttributeDetailsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTEntityAttributeDetails", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTEntityAttributeDetails' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTEntityAttributeDetails = (STEntityAttributeDetailsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTEntityAttributeDetails.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTEntityAttributeDetails.InternalRecursiveSave();
		}


		public RCEntityAttributeDetailsRecord Duplicate() {
			RCEntityAttributeDetailsRecord t;
			t.ssSTEntityAttributeDetails = (STEntityAttributeDetailsStructure) this.ssSTEntityAttributeDetails.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTEntityAttributeDetails.ToXml(this, recordElem, "EntityAttributeDetails", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "entityattributedetails") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EntityAttributeDetails")) variable.Value = ssSTEntityAttributeDetails; else variable.Optimized = true;
				variable.SetFieldName("entityattributedetails");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEntityAttributeDetails) {
				return ssSTEntityAttributeDetails;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTEntityAttributeDetails.FillFromOther((IRecord) other.AttributeGet(IdEntityAttributeDetails));
		}
		public bool IsDefault() {
			RCEntityAttributeDetailsRecord defaultStruct = new RCEntityAttributeDetailsRecord(null);
			if (this.ssSTEntityAttributeDetails != defaultStruct.ssSTEntityAttributeDetails) return false;
			return true;
		}
	} // RCEntityAttributeDetailsRecord

	/// <summary>
	/// Structure <code>RCTypeRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTypeRecord: ISerializable, ITypedRecord<RCTypeRecord> {
		internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sDNnulAVgv0DCTXmZQWiKw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Type")]
		public STTypeStructure ssSTType;


		public static implicit operator STTypeStructure(RCTypeRecord r) {
			return r.ssSTType;
		}

		public static implicit operator RCTypeRecord(STTypeStructure r) {
			RCTypeRecord res = new RCTypeRecord(null);
			res.ssSTType = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTypeRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTType = new STTypeStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTType.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTType.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTypeRecord r) {
			this = r;
		}


		public static bool operator == (RCTypeRecord a, RCTypeRecord b) {
			if (a.ssSTType != b.ssSTType) return false;
			return true;
		}

		public static bool operator != (RCTypeRecord a, RCTypeRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTypeRecord)) return false;
			return (this == (RCTypeRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTType.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTypeRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTType = new STTypeStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTType", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTType' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTType = (STTypeStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTType.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTType.InternalRecursiveSave();
		}


		public RCTypeRecord Duplicate() {
			RCTypeRecord t;
			t.ssSTType = (STTypeStructure) this.ssSTType.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTType.ToXml(this, recordElem, "Type", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "type") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssSTType; else variable.Optimized = true;
				variable.SetFieldName("type");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdType) {
				return ssSTType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTType.FillFromOther((IRecord) other.AttributeGet(IdType));
		}
		public bool IsDefault() {
			RCTypeRecord defaultStruct = new RCTypeRecord(null);
			if (this.ssSTType != defaultStruct.ssSTType) return false;
			return true;
		}
	} // RCTypeRecord
}

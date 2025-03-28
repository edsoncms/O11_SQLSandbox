using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssSQLCMD {

	/// <summary>
	/// Structure <code>STColumnStructure</code> that represents the Service Studio structure
	///  <code>Column</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STColumnStructure: ISerializable, ITypedRecord<STColumnStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAlias = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*CBaYM16lVk+IG7fBSpBMhg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Alias")]
		public string ssAlias;


		public BitArray OptimizedAttributes;

		public STColumnStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAlias = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAlias = r.ReadText(index++, "Column.Alias", "");
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
		public void ReadIM(STColumnStructure r) {
			this = r;
		}


		public static bool operator == (STColumnStructure a, STColumnStructure b) {
			if (a.ssAlias != b.ssAlias) return false;
			return true;
		}

		public static bool operator != (STColumnStructure a, STColumnStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STColumnStructure)) return false;
			return (this == (STColumnStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAlias.GetHashCode()
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

		public STColumnStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAlias = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssAlias", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAlias' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAlias = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STColumnStructure Duplicate() {
			STColumnStructure t;
			t.ssAlias = this.ssAlias;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Alias")) VarValue.AppendAttribute(recordElem, "Alias", ssAlias, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Alias");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "alias") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Alias")) variable.Value = ssAlias; else variable.Optimized = true;
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
			if (key == IdAlias) {
				return ssAlias;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAlias = (string) other.AttributeGet(IdAlias);
		}
		public bool IsDefault() {
			STColumnStructure defaultStruct = new STColumnStructure(null);
			if (this.ssAlias != defaultStruct.ssAlias) return false;
			return true;
		}
	} // STColumnStructure

	/// <summary>
	/// Structure <code>STRowStructure</code> that represents the Service Studio structure <code>Row</code>
	///  <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STRowStructure: ISerializable, ITypedRecord<STRowStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdValues = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*Su6bCc5lhUaK8OSZdkx0Zw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Values")]
		public RLRowValueRecordList ssValues;


		public BitArray OptimizedAttributes;

		public STRowStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssValues = new RLRowValueRecordList();
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
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
		public void ReadIM(STRowStructure r) {
			this = r;
		}


		public static bool operator == (STRowStructure a, STRowStructure b) {
			if (a.ssValues != b.ssValues) return false;
			return true;
		}

		public static bool operator != (STRowStructure a, STRowStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STRowStructure)) return false;
			return (this == (STRowStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssValues.GetHashCode()
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

		public STRowStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssValues = new RLRowValueRecordList();
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssValues", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssValues' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssValues = (RLRowValueRecordList) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssValues.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssValues.InternalRecursiveSave();
		}


		public STRowStructure Duplicate() {
			STRowStructure t;
			t.ssValues = (RLRowValueRecordList) this.ssValues.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				ssValues.ToXml(this, recordElem, "Values", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "values") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Values")) variable.Value = ssValues; else variable.Optimized = true;
				variable.SetFieldName("values");
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
			if (key == IdValues) {
				return ssValues;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssValues = new RLRowValueRecordList();
			ssValues.FillFromOther((IOSList) other.AttributeGet(IdValues));
		}
		public bool IsDefault() {
			STRowStructure defaultStruct = new STRowStructure(null);
			if (this.ssValues != null && this.ssValues.Length != 0) return false;
			return true;
		}
	} // STRowStructure

	/// <summary>
	/// Structure <code>STRowValueStructure</code> that represents the Service Studio structure
	///  <code>RowValue</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STRowValueStructure: ISerializable, ITypedRecord<STRowValueStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdColumnName = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*9VgRqSDBBUSgaKXpz47tqw");
		internal static readonly GlobalObjectKey IdIsNull = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*QnEUNa0KMU6BTA5dqD4KTg");
		internal static readonly GlobalObjectKey IdTextValue = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*7Ly3o2AaPEKooCVZlRVLVA");
		internal static readonly GlobalObjectKey IdIsDateTime = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*0RAsInEPUU2c14ZZPInzkg");
		internal static readonly GlobalObjectKey IdDateTimeValue = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*wROovPRTnUyX5_OsxoAicQ");
		internal static readonly GlobalObjectKey IdIsBinary = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*2p_Hu_Zzw0+5R6ESwnfzqg");
		internal static readonly GlobalObjectKey IdBinaryValue = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*UnWdbkvYtUCkBvPLkgVMcA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("ColumnName")]
		public string ssColumnName;

		[System.Xml.Serialization.XmlElement("IsNull")]
		public bool ssIsNull;

		[System.Xml.Serialization.XmlElement("TextValue")]
		public string ssTextValue;

		[System.Xml.Serialization.XmlElement("IsDateTime")]
		public bool ssIsDateTime;

		[System.Xml.Serialization.XmlElement("DateTimeValue")]
		public DateTime ssDateTimeValue;

		[System.Xml.Serialization.XmlElement("IsBinary")]
		public bool ssIsBinary;

		[System.Xml.Serialization.XmlElement("BinaryValue")]
		public byte[] ssBinaryValue;


		public BitArray OptimizedAttributes;

		public STRowValueStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssColumnName = "";
			ssIsNull = false;
			ssTextValue = "";
			ssIsDateTime = false;
			ssDateTimeValue = new DateTime(1900, 1, 1, 0, 0, 0);
			ssIsBinary = false;
			ssBinaryValue = new byte[] {};
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssColumnName = r.ReadText(index++, "RowValue.ColumnName", "");
			ssIsNull = r.ReadBoolean(index++, "RowValue.IsNull", false);
			ssTextValue = r.ReadText(index++, "RowValue.TextValue", "");
			ssIsDateTime = r.ReadBoolean(index++, "RowValue.IsDateTime", false);
			ssDateTimeValue = r.ReadDateTime(index++, "RowValue.DateTimeValue", new DateTime(1900, 1, 1, 0, 0, 0));
			ssIsBinary = r.ReadBoolean(index++, "RowValue.IsBinary", false);
			ssBinaryValue = r.ReadBinaryData(index++, "RowValue.BinaryValue", new byte[] {});
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
		public void ReadIM(STRowValueStructure r) {
			this = r;
		}


		public static bool operator == (STRowValueStructure a, STRowValueStructure b) {
			if (a.ssColumnName != b.ssColumnName) return false;
			if (a.ssIsNull != b.ssIsNull) return false;
			if (a.ssTextValue != b.ssTextValue) return false;
			if (a.ssIsDateTime != b.ssIsDateTime) return false;
			if (a.ssDateTimeValue != b.ssDateTimeValue) return false;
			if (a.ssIsBinary != b.ssIsBinary) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssBinaryValue, b.ssBinaryValue)) return false;
			return true;
		}

		public static bool operator != (STRowValueStructure a, STRowValueStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STRowValueStructure)) return false;
			return (this == (STRowValueStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssColumnName.GetHashCode()
				^ ssIsNull.GetHashCode()
				^ ssTextValue.GetHashCode()
				^ ssIsDateTime.GetHashCode()
				^ ssDateTimeValue.GetHashCode()
				^ ssIsBinary.GetHashCode()
				^ ssBinaryValue.GetHashCode()
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

		public STRowValueStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssColumnName = "";
			ssIsNull = false;
			ssTextValue = "";
			ssIsDateTime = false;
			ssDateTimeValue = new DateTime(1900, 1, 1, 0, 0, 0);
			ssIsBinary = false;
			ssBinaryValue = new byte[] {};
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssColumnName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssColumnName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssColumnName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssIsNull", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsNull' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsNull = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTextValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTextValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTextValue = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssIsDateTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsDateTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsDateTime = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssDateTimeValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDateTimeValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDateTimeValue = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssIsBinary", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsBinary' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsBinary = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssBinaryValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssBinaryValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssBinaryValue = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STRowValueStructure Duplicate() {
			STRowValueStructure t;
			t.ssColumnName = this.ssColumnName;
			t.ssIsNull = this.ssIsNull;
			t.ssTextValue = this.ssTextValue;
			t.ssIsDateTime = this.ssIsDateTime;
			t.ssDateTimeValue = this.ssDateTimeValue;
			t.ssIsBinary = this.ssIsBinary;
			if (this.ssBinaryValue != null) {
				t.ssBinaryValue = (byte[]) this.ssBinaryValue.Clone();
			} else {
				t.ssBinaryValue = null;
			}
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ColumnName")) VarValue.AppendAttribute(recordElem, "ColumnName", ssColumnName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "ColumnName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsNull")) VarValue.AppendAttribute(recordElem, "IsNull", ssIsNull, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsNull");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TextValue")) VarValue.AppendAttribute(recordElem, "TextValue", ssTextValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "TextValue");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsDateTime")) VarValue.AppendAttribute(recordElem, "IsDateTime", ssIsDateTime, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsDateTime");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DateTimeValue")) VarValue.AppendAttribute(recordElem, "DateTimeValue", ssDateTimeValue, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "DateTimeValue");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsBinary")) VarValue.AppendAttribute(recordElem, "IsBinary", ssIsBinary, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsBinary");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".BinaryValue")) VarValue.AppendAttribute(recordElem, "BinaryValue", ssBinaryValue, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "BinaryValue");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "columnname") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ColumnName")) variable.Value = ssColumnName; else variable.Optimized = true;
			} else if (head == "isnull") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsNull")) variable.Value = ssIsNull; else variable.Optimized = true;
			} else if (head == "textvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TextValue")) variable.Value = ssTextValue; else variable.Optimized = true;
			} else if (head == "isdatetime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsDateTime")) variable.Value = ssIsDateTime; else variable.Optimized = true;
			} else if (head == "datetimevalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DateTimeValue")) variable.Value = ssDateTimeValue; else variable.Optimized = true;
			} else if (head == "isbinary") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsBinary")) variable.Value = ssIsBinary; else variable.Optimized = true;
			} else if (head == "binaryvalue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".BinaryValue")) variable.Value = ssBinaryValue; else variable.Optimized = true;
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
			if (key == IdColumnName) {
				return ssColumnName;
			} else if (key == IdIsNull) {
				return ssIsNull;
			} else if (key == IdTextValue) {
				return ssTextValue;
			} else if (key == IdIsDateTime) {
				return ssIsDateTime;
			} else if (key == IdDateTimeValue) {
				return ssDateTimeValue;
			} else if (key == IdIsBinary) {
				return ssIsBinary;
			} else if (key == IdBinaryValue) {
				return ssBinaryValue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssColumnName = (string) other.AttributeGet(IdColumnName);
			ssIsNull = (bool) other.AttributeGet(IdIsNull);
			ssTextValue = (string) other.AttributeGet(IdTextValue);
			ssIsDateTime = (bool) other.AttributeGet(IdIsDateTime);
			ssDateTimeValue = (DateTime) other.AttributeGet(IdDateTimeValue);
			ssIsBinary = (bool) other.AttributeGet(IdIsBinary);
			ssBinaryValue = (byte[]) other.AttributeGet(IdBinaryValue);
		}
		public bool IsDefault() {
			STRowValueStructure defaultStruct = new STRowValueStructure(null);
			if (this.ssColumnName != defaultStruct.ssColumnName) return false;
			if (this.ssIsNull != defaultStruct.ssIsNull) return false;
			if (this.ssTextValue != defaultStruct.ssTextValue) return false;
			if (this.ssIsDateTime != defaultStruct.ssIsDateTime) return false;
			if (this.ssDateTimeValue != defaultStruct.ssDateTimeValue) return false;
			if (this.ssIsBinary != defaultStruct.ssIsBinary) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssBinaryValue, defaultStruct.ssBinaryValue)) return false;
			return true;
		}
	} // STRowValueStructure

	/// <summary>
	/// Structure <code>STEntityDetailsStructure</code> that represents the Service Studio structure
	///  <code>EntityDetails</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STEntityDetailsStructure: ISerializable, ITypedRecord<STEntityDetailsStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*izgmn4YUhEKyAaW3lSKUog");
		internal static readonly GlobalObjectKey IdPhysicalTableName = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*OTbu8nutUEGvZvq52WEM9A");
		internal static readonly GlobalObjectKey IdLogicalConnection = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*eTHJrg1RFUu+V4UjLAJvHA");
		internal static readonly GlobalObjectKey IdAttributes = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*4vZW1K_m3UmxV7a4vpL5Rg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("PhysicalTableName")]
		public string ssPhysicalTableName;

		[System.Xml.Serialization.XmlElement("LogicalConnection")]
		public string ssLogicalConnection;

		[System.Xml.Serialization.XmlElement("Attributes")]
		public RLEntityAttributeDetailsRecordList ssAttributes;


		public BitArray OptimizedAttributes;

		public STEntityDetailsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssPhysicalTableName = "";
			ssLogicalConnection = "";
			ssAttributes = new RLEntityAttributeDetailsRecordList();
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssName = r.ReadText(index++, "EntityDetails.Name", "");
			ssPhysicalTableName = r.ReadText(index++, "EntityDetails.PhysicalTableName", "");
			ssLogicalConnection = r.ReadText(index++, "EntityDetails.LogicalConnection", "");
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
		public void ReadIM(STEntityDetailsStructure r) {
			this = r;
		}


		public static bool operator == (STEntityDetailsStructure a, STEntityDetailsStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssPhysicalTableName != b.ssPhysicalTableName) return false;
			if (a.ssLogicalConnection != b.ssLogicalConnection) return false;
			if (a.ssAttributes != b.ssAttributes) return false;
			return true;
		}

		public static bool operator != (STEntityDetailsStructure a, STEntityDetailsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STEntityDetailsStructure)) return false;
			return (this == (STEntityDetailsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssPhysicalTableName.GetHashCode()
				^ ssLogicalConnection.GetHashCode()
				^ ssAttributes.GetHashCode()
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

		public STEntityDetailsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssPhysicalTableName = "";
			ssLogicalConnection = "";
			ssAttributes = new RLEntityAttributeDetailsRecordList();
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssPhysicalTableName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssPhysicalTableName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssPhysicalTableName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssLogicalConnection", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssLogicalConnection' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssLogicalConnection = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAttributes", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAttributes' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAttributes = (RLEntityAttributeDetailsRecordList) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssAttributes.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssAttributes.InternalRecursiveSave();
		}


		public STEntityDetailsStructure Duplicate() {
			STEntityDetailsStructure t;
			t.ssName = this.ssName;
			t.ssPhysicalTableName = this.ssPhysicalTableName;
			t.ssLogicalConnection = this.ssLogicalConnection;
			t.ssAttributes = (RLEntityAttributeDetailsRecordList) this.ssAttributes.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PhysicalTableName")) VarValue.AppendAttribute(recordElem, "PhysicalTableName", ssPhysicalTableName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "PhysicalTableName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".LogicalConnection")) VarValue.AppendAttribute(recordElem, "LogicalConnection", ssLogicalConnection, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "LogicalConnection");
				ssAttributes.ToXml(this, recordElem, "Attributes", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "physicaltablename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PhysicalTableName")) variable.Value = ssPhysicalTableName; else variable.Optimized = true;
			} else if (head == "logicalconnection") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".LogicalConnection")) variable.Value = ssLogicalConnection; else variable.Optimized = true;
			} else if (head == "attributes") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Attributes")) variable.Value = ssAttributes; else variable.Optimized = true;
				variable.SetFieldName("attributes");
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
			if (key == IdName) {
				return ssName;
			} else if (key == IdPhysicalTableName) {
				return ssPhysicalTableName;
			} else if (key == IdLogicalConnection) {
				return ssLogicalConnection;
			} else if (key == IdAttributes) {
				return ssAttributes;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssPhysicalTableName = (string) other.AttributeGet(IdPhysicalTableName);
			ssLogicalConnection = (string) other.AttributeGet(IdLogicalConnection);
			ssAttributes = new RLEntityAttributeDetailsRecordList();
			ssAttributes.FillFromOther((IOSList) other.AttributeGet(IdAttributes));
		}
		public bool IsDefault() {
			STEntityDetailsStructure defaultStruct = new STEntityDetailsStructure(null);
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssPhysicalTableName != defaultStruct.ssPhysicalTableName) return false;
			if (this.ssLogicalConnection != defaultStruct.ssLogicalConnection) return false;
			if (this.ssAttributes != null && this.ssAttributes.Length != 0) return false;
			return true;
		}
	} // STEntityDetailsStructure

	/// <summary>
	/// Structure <code>STEntityAttributeDetailsStructure</code> that represents the Service Studio
	///  structure <code>EntityAttributeDetails</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STEntityAttributeDetailsStructure: ISerializable, ITypedRecord<STEntityAttributeDetailsStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*dF9ldkDdOEet0pVP7RSTKw");
		internal static readonly GlobalObjectKey IdType = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*3Et_85aa00GQzkcGoi_H2A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("Type")]
		public string ssType;


		public BitArray OptimizedAttributes;

		public STEntityAttributeDetailsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssType = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssName = r.ReadText(index++, "EntityAttributeDetails.Name", "");
			ssType = r.ReadText(index++, "EntityAttributeDetails.Type", "");
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
		public void ReadIM(STEntityAttributeDetailsStructure r) {
			this = r;
		}


		public static bool operator == (STEntityAttributeDetailsStructure a, STEntityAttributeDetailsStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssType != b.ssType) return false;
			return true;
		}

		public static bool operator != (STEntityAttributeDetailsStructure a, STEntityAttributeDetailsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STEntityAttributeDetailsStructure)) return false;
			return (this == (STEntityAttributeDetailsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssType.GetHashCode()
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

		public STEntityAttributeDetailsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssType = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssType", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssType' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssType = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STEntityAttributeDetailsStructure Duplicate() {
			STEntityAttributeDetailsStructure t;
			t.ssName = this.ssName;
			t.ssType = this.ssType;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Type")) VarValue.AppendAttribute(recordElem, "Type", ssType, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Type");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "type") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Type")) variable.Value = ssType; else variable.Optimized = true;
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
			if (key == IdName) {
				return ssName;
			} else if (key == IdType) {
				return ssType;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssType = (string) other.AttributeGet(IdType);
		}
		public bool IsDefault() {
			STEntityAttributeDetailsStructure defaultStruct = new STEntityAttributeDetailsStructure(null);
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssType != defaultStruct.ssType) return false;
			return true;
		}
	} // STEntityAttributeDetailsStructure

	/// <summary>
	/// Structure <code>STTypeStructure</code> that represents the Service Studio structure
	///  <code>Type</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STTypeStructure: ISerializable, ITypedRecord<STTypeStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*QdJq0B4tfECJ9M3hKEXOsg");
		internal static readonly GlobalObjectKey IdIsValidForSelectRole = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*IjP99gxaAkqPXsuWVIx0lQ");
		internal static readonly GlobalObjectKey IdIsValidForDMLRole = GlobalObjectKey.Parse("flaCnwNE6UqUlpRVoEClpA*Ug9bETKlSESLmD5UBPx8kQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("IsValidForSelectRole")]
		public bool ssIsValidForSelectRole;

		[System.Xml.Serialization.XmlElement("IsValidForDMLRole")]
		public bool ssIsValidForDMLRole;


		public BitArray OptimizedAttributes;

		public STTypeStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssName = "";
			ssIsValidForSelectRole = false;
			ssIsValidForDMLRole = false;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssName = r.ReadText(index++, "Type.Name", "");
			ssIsValidForSelectRole = r.ReadBoolean(index++, "Type.IsValidForSelectRole", false);
			ssIsValidForDMLRole = r.ReadBoolean(index++, "Type.IsValidForDMLRole", false);
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
		public void ReadIM(STTypeStructure r) {
			this = r;
		}


		public static bool operator == (STTypeStructure a, STTypeStructure b) {
			if (a.ssName != b.ssName) return false;
			if (a.ssIsValidForSelectRole != b.ssIsValidForSelectRole) return false;
			if (a.ssIsValidForDMLRole != b.ssIsValidForDMLRole) return false;
			return true;
		}

		public static bool operator != (STTypeStructure a, STTypeStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTypeStructure)) return false;
			return (this == (STTypeStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssName.GetHashCode()
				^ ssIsValidForSelectRole.GetHashCode()
				^ ssIsValidForDMLRole.GetHashCode()
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

		public STTypeStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssName = "";
			ssIsValidForSelectRole = false;
			ssIsValidForDMLRole = false;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssIsValidForSelectRole", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsValidForSelectRole' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsValidForSelectRole = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssIsValidForDMLRole", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssIsValidForDMLRole' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssIsValidForDMLRole = (bool) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STTypeStructure Duplicate() {
			STTypeStructure t;
			t.ssName = this.ssName;
			t.ssIsValidForSelectRole = this.ssIsValidForSelectRole;
			t.ssIsValidForDMLRole = this.ssIsValidForDMLRole;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsValidForSelectRole")) VarValue.AppendAttribute(recordElem, "IsValidForSelectRole", ssIsValidForSelectRole, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsValidForSelectRole");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".IsValidForDMLRole")) VarValue.AppendAttribute(recordElem, "IsValidForDMLRole", ssIsValidForDMLRole, detailLevel, TypeKind.Boolean); else VarValue.AppendOptimizedAttribute(recordElem, "IsValidForDMLRole");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "isvalidforselectrole") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsValidForSelectRole")) variable.Value = ssIsValidForSelectRole; else variable.Optimized = true;
			} else if (head == "isvalidfordmlrole") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".IsValidForDMLRole")) variable.Value = ssIsValidForDMLRole; else variable.Optimized = true;
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
			if (key == IdName) {
				return ssName;
			} else if (key == IdIsValidForSelectRole) {
				return ssIsValidForSelectRole;
			} else if (key == IdIsValidForDMLRole) {
				return ssIsValidForDMLRole;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssName = (string) other.AttributeGet(IdName);
			ssIsValidForSelectRole = (bool) other.AttributeGet(IdIsValidForSelectRole);
			ssIsValidForDMLRole = (bool) other.AttributeGet(IdIsValidForDMLRole);
		}
		public bool IsDefault() {
			STTypeStructure defaultStruct = new STTypeStructure(null);
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssIsValidForSelectRole != defaultStruct.ssIsValidForSelectRole) return false;
			if (this.ssIsValidForDMLRole != defaultStruct.ssIsValidForDMLRole) return false;
			return true;
		}
	} // STTypeStructure

} // OutSystems.NssSQLCMD

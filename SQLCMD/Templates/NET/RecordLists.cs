using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssSQLCMD {

	/// <summary>
	/// RecordList type <code>RLColumnRecordList</code> that represents a record list of
	///  <code>Column</code>
	/// </summary>
	[Serializable()]
	public partial class RLColumnRecordList: GenericRecordList<RCColumnRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCColumnRecord GetElementDefaultValue() {
			return new RCColumnRecord("");
		}

		public T[] ToArray<T>(Func<RCColumnRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLColumnRecordList recordlist, Func<RCColumnRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLColumnRecordList(RCColumnRecord[] array) {
			RLColumnRecordList result = new RLColumnRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLColumnRecordList ToList<T>(T[] array, Func <T, RCColumnRecord> converter) {
			RLColumnRecordList result = new RLColumnRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLColumnRecordList FromRestList<T>(RestList<T> restList, Func <T, RCColumnRecord> converter) {
			RLColumnRecordList result = new RLColumnRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLColumnRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLColumnRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLColumnRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLColumnRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCColumnRecord> NewList() {
			return new RLColumnRecordList();
		}


	} // RLColumnRecordList

	/// <summary>
	/// RecordList type <code>RLRowRecordList</code> that represents a record list of <code>Row</code>
	/// </summary>
	[Serializable()]
	public partial class RLRowRecordList: GenericRecordList<RCRowRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCRowRecord GetElementDefaultValue() {
			return new RCRowRecord("");
		}

		public T[] ToArray<T>(Func<RCRowRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRowRecordList recordlist, Func<RCRowRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLRowRecordList(RCRowRecord[] array) {
			RLRowRecordList result = new RLRowRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLRowRecordList ToList<T>(T[] array, Func <T, RCRowRecord> converter) {
			RLRowRecordList result = new RLRowRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLRowRecordList FromRestList<T>(RestList<T> restList, Func <T, RCRowRecord> converter) {
			RLRowRecordList result = new RLRowRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLRowRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRowRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRowRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRowRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCRowRecord> NewList() {
			return new RLRowRecordList();
		}


	} // RLRowRecordList

	/// <summary>
	/// RecordList type <code>RLRowValueRecordList</code> that represents a record list of
	///  <code>RowValue</code>
	/// </summary>
	[Serializable()]
	public partial class RLRowValueRecordList: GenericRecordList<RCRowValueRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCRowValueRecord GetElementDefaultValue() {
			return new RCRowValueRecord("");
		}

		public T[] ToArray<T>(Func<RCRowValueRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLRowValueRecordList recordlist, Func<RCRowValueRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLRowValueRecordList(RCRowValueRecord[] array) {
			RLRowValueRecordList result = new RLRowValueRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLRowValueRecordList ToList<T>(T[] array, Func <T, RCRowValueRecord> converter) {
			RLRowValueRecordList result = new RLRowValueRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLRowValueRecordList FromRestList<T>(RestList<T> restList, Func <T, RCRowValueRecord> converter) {
			RLRowValueRecordList result = new RLRowValueRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLRowValueRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRowValueRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLRowValueRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLRowValueRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCRowValueRecord> NewList() {
			return new RLRowValueRecordList();
		}


	} // RLRowValueRecordList

	/// <summary>
	/// RecordList type <code>RLEntityDetailsRecordList</code> that represents a record list of
	///  <code>EntityDetails</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityDetailsRecordList: GenericRecordList<RCEntityDetailsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityDetailsRecord GetElementDefaultValue() {
			return new RCEntityDetailsRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityDetailsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityDetailsRecordList recordlist, Func<RCEntityDetailsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityDetailsRecordList(RCEntityDetailsRecord[] array) {
			RLEntityDetailsRecordList result = new RLEntityDetailsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityDetailsRecordList ToList<T>(T[] array, Func <T, RCEntityDetailsRecord> converter) {
			RLEntityDetailsRecordList result = new RLEntityDetailsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityDetailsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityDetailsRecord> converter) {
			RLEntityDetailsRecordList result = new RLEntityDetailsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityDetailsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDetailsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityDetailsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityDetailsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityDetailsRecord> NewList() {
			return new RLEntityDetailsRecordList();
		}


	} // RLEntityDetailsRecordList

	/// <summary>
	/// RecordList type <code>RLEntityAttributeDetailsRecordList</code> that represents a record list of
	///  <code>EntityAttributeDetails</code>
	/// </summary>
	[Serializable()]
	public partial class RLEntityAttributeDetailsRecordList: GenericRecordList<RCEntityAttributeDetailsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCEntityAttributeDetailsRecord GetElementDefaultValue() {
			return new RCEntityAttributeDetailsRecord("");
		}

		public T[] ToArray<T>(Func<RCEntityAttributeDetailsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLEntityAttributeDetailsRecordList recordlist, Func<RCEntityAttributeDetailsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLEntityAttributeDetailsRecordList(RCEntityAttributeDetailsRecord[] array) {
			RLEntityAttributeDetailsRecordList result = new RLEntityAttributeDetailsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLEntityAttributeDetailsRecordList ToList<T>(T[] array, Func <T, RCEntityAttributeDetailsRecord> converter) {
			RLEntityAttributeDetailsRecordList result = new RLEntityAttributeDetailsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLEntityAttributeDetailsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCEntityAttributeDetailsRecord> converter) {
			RLEntityAttributeDetailsRecordList result = new RLEntityAttributeDetailsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLEntityAttributeDetailsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityAttributeDetailsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLEntityAttributeDetailsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLEntityAttributeDetailsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCEntityAttributeDetailsRecord> NewList() {
			return new RLEntityAttributeDetailsRecordList();
		}


	} // RLEntityAttributeDetailsRecordList

	/// <summary>
	/// RecordList type <code>RLTypeRecordList</code> that represents a record list of <code>Type</code>
	/// </summary>
	[Serializable()]
	public partial class RLTypeRecordList: GenericRecordList<RCTypeRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTypeRecord GetElementDefaultValue() {
			return new RCTypeRecord("");
		}

		public T[] ToArray<T>(Func<RCTypeRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTypeRecordList recordlist, Func<RCTypeRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTypeRecordList(RCTypeRecord[] array) {
			RLTypeRecordList result = new RLTypeRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTypeRecordList ToList<T>(T[] array, Func <T, RCTypeRecord> converter) {
			RLTypeRecordList result = new RLTypeRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTypeRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTypeRecord> converter) {
			RLTypeRecordList result = new RLTypeRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTypeRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTypeRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTypeRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTypeRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTypeRecord> NewList() {
			return new RLTypeRecordList();
		}


	} // RLTypeRecordList
}

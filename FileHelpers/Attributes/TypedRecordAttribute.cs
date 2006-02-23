#region "  � Copyright 2005 to Marcos Meli - http://www.marcosmeli.com.ar" 

// Errors, suggestions, contributions, send a mail to: marcosdotnet[at]yahoo.com.ar.

#endregion

using System;
using System.ComponentModel;

namespace FileHelpers
{
	/// <summary>Base class for the record types..</summary>
	/// <remarks>See the <a href="attributes.html">Complete Attributes List</a> for more clear info and examples of each one.</remarks>
	/// <seealso href="attributes.html">Attributes List</seealso>
	/// <seealso href="quick_start.html">Quick Start Guide</seealso>
	/// <seealso href="examples.html">Examples of Use</seealso>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class TypedRecordAttribute : Attribute
	{
		#region "  Constructors  "

		/// <summary>Abstract class, see inheritors.</summary>
		protected TypedRecordAttribute() : this(String.Empty)
		{
		}

		/// <summary>Abstract class, see inheritors.</summary>
		protected TypedRecordAttribute(string description)
		{
			Description = description;
		}

		#endregion

		#region "  Description  "

		private string mDescription;

		/// <summary>
		/// The description of the Record Type.
		/// </summary>
		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; }
		}

		#endregion
	}
}
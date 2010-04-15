using System;
using System.Collections.Generic;
using System.Text;

namespace TotalTech.CMS.Controls {
	/// <summary>
	/// This is an Event Arugments class that uses generics to be flexible enough to accept two of any kind of object as its arguments.
	/// </summary>
	/// <typeparam name="T">A user definded argument type</typeparam>
	/// <typeparam name="U">A user definded argument type</typeparam>
	public sealed class GenericEventArgs<T, U> : EventArgs {
		T _Value;
		U _Identifier;

		/// <summary>
		/// This is an Event Arugments class that uses generics to be flexible enough to accept two of any kind of object as its arguments.
		/// </summary>
		/// <param name="Value">The value being passed</param>
		/// <param name="Identifier">An identifier to describe the value (or optionally another value)</param>
		public GenericEventArgs(T Value, U Identifier) {
			_Value = Value;
			_Identifier = Identifier;
		}

		/// <summary>
		/// The value being passed
		/// </summary>
		public T Value {
			get { return _Value; }
			set { _Value = value; }
		}

		/// <summary>
		/// An identifier to describe the value (or optionally another value)
		/// </summary>
		public U Identifier {
			get { return _Identifier; }
			set { _Identifier = value; }
		}
	}
}

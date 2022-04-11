﻿using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CommunityToolkit.Maui.Extensions;

namespace CommunityToolkit.Maui.Converters;

/// <summary>
/// Converts true to false and false to true. Simple as that!
/// </summary>
public class InvertedBoolConverter : BaseConverter<bool, bool>
{
	/// <summary>
	/// Converts a <see cref="bool"/> to its inverse value.
	/// </summary>
	/// <param name="value">The value to convert.</param>
	/// <param name="culture">The culture to use in the converter. This is not implemented.</param>
	/// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
	public override bool ConvertFrom(bool value, CultureInfo? culture = null) => !value;

	/// <summary>
	/// Converts a <see cref="bool"/> to its inverse value.
	/// </summary>
	/// <param name="value">The value to convert.</param>
	/// <param name="culture">The culture to use in the converter. This is not implemented.</param>
	/// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
	public override bool ConvertBackTo(bool value, CultureInfo? culture = null) => !value;
}
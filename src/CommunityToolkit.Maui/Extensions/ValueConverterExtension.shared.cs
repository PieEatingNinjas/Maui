﻿using CommunityToolkit.Maui.Converters;

namespace CommunityToolkit.Maui.Extensions;

/// <inheritdoc />
public abstract class ValueConverterExtension : IMarkupExtension<ICommunityToolkitValueConverter>
{
	/// <inheritdoc />
	public ICommunityToolkitValueConverter ProvideValue(IServiceProvider serviceProvider)
		=> (ICommunityToolkitValueConverter)this;

	object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
		=> ((IMarkupExtension<ICommunityToolkitValueConverter>)this).ProvideValue(serviceProvider);
}
﻿namespace CommunityToolkit.Maui.Sample.ViewModels.Converters;

public class EqualConverterViewModel : BaseViewModel
{
	string inputValue = string.Empty;

	public string InputValue
	{
		get => inputValue;
		set => SetProperty(ref inputValue, value);
	}
}
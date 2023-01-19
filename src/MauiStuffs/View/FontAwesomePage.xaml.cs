using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls;
using System;

namespace MauiStuffs.View;

public partial class FontAwesomePage : ContentPage
{
	int count = 0;

	public FontAwesomePage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


using Syncfusion.Maui.DataGrid;

namespace DataGridMAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Style style = new Style(typeof(DataGridCell));
        style.Setters.Add(new Setter() { Property = DataGridCell.TextColorProperty, Value = new Binding("Freight", BindingMode.TwoWay, new StyleConverter()) });
        dataGrid.Columns[2].CellStyle = style;
    }
}


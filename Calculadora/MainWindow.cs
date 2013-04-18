using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBsumaClicked (object sender, EventArgs e)
	{
		int resultado;
		int numero1;
		int numero2;
		numero1= int.Parse (this.EntradaNumero1.Text);
		numero2=int.Parse (this.EntradaNumero2.Text);
		resultado= numero1+numero2;
		Resultado.Text=resultado.ToString();
		//throw new System.NotImplementedException ();

	}

	protected void OnBrestaClicked (object sender, EventArgs e)
	{
		int resultado;
		int numero1;
		int numero2;
		numero1= int.Parse (this.EntradaNumero1.Text);
		numero2=int.Parse (this.EntradaNumero2.Text);
		resultado= numero1-numero2;
		Resultado.Text=resultado.ToString();
		//throw new System.NotImplementedException ();

	}

	protected void OnBmultiplicarClicked (object sender, EventArgs e)
	{
		int resultado;
		int numero1;
		int numero2;
		numero1= int.Parse (this.EntradaNumero1.Text);
		numero2=int.Parse (this.EntradaNumero2.Text);
		resultado= numero1*numero2;
		Resultado.Text=resultado.ToString();
		//throw new System.NotImplementedException ();
	}

	protected void OnBdivisionClicked (object sender, EventArgs e)
	{
		int resultado;
		int numero1;
		int numero2;
		numero1= int.Parse (this.EntradaNumero1.Text);
		numero2=int.Parse (this.EntradaNumero2.Text);
		resultado= numero1/numero2;
		Resultado.Text=resultado.ToString();
		//throw new System.NotImplementedException ();
	}
}
